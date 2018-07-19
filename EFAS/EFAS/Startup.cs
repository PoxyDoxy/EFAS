using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Xsens;
using XDA;
using System.Threading;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.Threading.Tasks;

namespace EFAS
{
    public partial class Startup : Form
    {
        // Begin Setting up API Calls and Callbacks
        private MyXda _xda;
        private XsDevice _measuringDevice = null;
        private MyMtCallback _myMtCallback = null;
        private ConnectedMtData _connectedData = new ConnectedMtData();

        public Startup()
        {
            // Form Initialisation
            InitializeComponent();
            _xda = new MyXda();
        }

        public static class Variables {
            // A public class that stores variables for use throughout the entire program.

            // Environment
            public static bool connected_to_sensor = false;
            public static bool fall_detection = false;

            // Sensor Data
            public static double latest_gpsfetch = 0; // Store when Long+Lat was last fetched. 
            public static bool gps_fix_old = false; // Is the GPS Fix Older than 10 seconds?
            public static int latest_fixtype = 0; // Most recent Fix Type
            public static decimal latest_longitude = 0; // Most recent Longitude
            public static decimal latest_latitude = 0; // Most recent Latitude
            public static int satellites = 0; // Amount of Satellites Found

            // Calibration Timer Page
            public static bool skip_timer = false; // Skip Button causes the 20s Timer to skip to the end. 

            // CapturedData is 12 seconds worth of Live data.
            public static List<string[]> CapturedData = new List<string[]>();
            public static double last_fall_time = 0;

            // ManualRecord Variables
            public static bool manual_recording = false; // Data Processor Stop Signal
            public static bool manual_recording_collection = false; // Data Collector Stop Signal
            public static List<string[]> manual_recorded_data = new List<string[]>(); // Collected Data

            // File to Analyse
            public static string opened_file = "";
            public static List<string[]> opened_data = new List<string[]>();
            public static bool fall_analysis_paused = false;
        }

        public static void DeviceStateChange(XsConnectivityState change) {
            // Trigger when the sensor is unplugged.
            if (change == XsConnectivityState.XCS_Disconnected)
            {
                MessageBox.Show("The Sensor has been disconnected.\nThis program will now close.");
                Application.Exit();
            }
        }

        private void SetLabel(string text_to_set) {
            // Sets the Text Label (and window title) at the top left of the program.
            this.Invoke(new MethodInvoker(delegate () { this.Text = "EFAS - " + text_to_set; status.Text = text_to_set; }));
        }

        private void Startup_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When the program is closing, ensures the device is disconnected cleanly.
            if (_measuringDevice != null)
                _measuringDevice.clearCallbackHandlers();
            if (_myMtCallback != null)
                _myMtCallback.Dispose();

            _xda.Dispose();
            _xda = null;
        }

        public decimal DeltaDecimal(decimal num1, decimal num2)
        {
            // Convert Each Number to Positive. Return Difference as Positive. 
            return Math.Abs(Math.Abs(num1) - Math.Abs(num2));
        }

        private decimal CalculateRotateDiff(decimal num1, decimal num2) {
            // This Calculates the Difference Between Two Numbers, when they rotate from 180 to -180.
            // Used when calculating Gyroscope Number Differences. 
            // For example, the difference between -170 and +170 is 20 

            // Calculate Neg/Pos Difference
            bool numsdiff = false;
            if (num1 >= 0 & num2 < 0) { numsdiff = true; }
            if (num1 < 0 & num2 >= 0) { numsdiff = true; }

            // If Numbers are Different (Pos and Neg)
            if (numsdiff)
            {
                // Find which side is closest to eachother (Round past 180, or back through 0).
                decimal test1 = 0;
                decimal test2 = 0;

                test1 = DeltaDecimal(0, num1) + DeltaDecimal(0, num2);

                test2 = DeltaDecimal(180, num1) + DeltaDecimal(180, num2);

                if (test1 < test2)
                {
                    // Test 1 is the shorter path. It passes through 0. 
                    return test1;
                }
                else if (test2 < test1)
                {
                    // Test 2 is the shorter path. It passes through 180.
                    return test2;
                }
                else if (test1 == test2) {
                    // They are equal to eachother. Each side is the same distance. 
                    return test1;
                }
            }
            else
            {
                // Numbers are not different, simple Delta Calculation
                return DeltaDecimal(num1, num2);
            }

            // This point should never be reached. 
            MessageBox.Show("An error has occured while calculating the difference of numbers.");
            return 0;
        }

        private decimal orientation_compensation(decimal reference, decimal input)
        {
            // Take the input and calculate the result after subtracting the reference from the input.
            // For example, if your reference is 180 and you turn to 0, it will say that you have turned to 180.
            // For example, if your reference is -50 and turn to +10, it will say that you have turned to +60.
            // This ensures that if you are walking in a direction, it will correctly state your fall direction.
            /* 
             * If the same, return input
             * If both positive
             *     -If input is behind reference
             *     -Else reference is behind input 
             * If both negative
             *     -If input is behind reference
             *     -Else reference is behind input 
             * If one negative one positive
             *     -If input is behind reference
             *     -Else reference is behind input
            */

            // If the same, return 0
            if (reference == input) {
                return 0;
            }

            // If both positive
            if (reference >= 0 & input >= 0)
            {
                // If input is behind reference
                if (input > reference)
                {
                    // Stays in the positive
                    return CalculateRotateDiff(reference, input);
                }
                else {
                    // Goes in the negative
                    return CalculateRotateDiff(reference, input) * -1;
                }
            }

            // If both negative
            if (reference <= 0 & input <= 0)
            {
                // If input is behind reference
                if (input < reference)
                {
                    // Stays in the negative
                    return CalculateRotateDiff(reference, input) * -1;
                }
                else
                {
                    // Goes in the positive
                    return CalculateRotateDiff(reference, input);
                }
            }

            // If one negative one positive
            if (reference <= 0 & input >= 0) {
                // Reference is negative, pushes the input up (positive)
                // Input is positive
                decimal numberdiff = CalculateRotateDiff(0, reference);
                if (input + numberdiff > 180)
                {
                    // Number is pushed into the negative range
                    decimal overhang = (input + numberdiff) - 180;
                    return (-180) + overhang;
                }
                else {
                    return input + numberdiff;
                }
            }

            // If one negative one positive
            if (reference >= 0 & input <= 0)
            {
                // Reference is positive, pushes the input down (negative)
                // Input is negative
                decimal numberdiff = CalculateRotateDiff(0, reference);
                if (input - numberdiff < -180)
                {
                    // Number is pushed into the negative range
                    decimal overhang = (input - numberdiff) + 180;
                    return 180 + overhang;
                }
                else
                {
                    return (input - numberdiff);
                }
            }

            return 0;
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            // Fetch Program Settings
            if (File.Exists("EFAS.settings"))
            {
                // Get Settings from File
                string[] settings_array = DeSerializeObject<string[]>("EFAS.settings");
                LoadSettings(settings_array);
            } else {
                // Create File (using GUI defaults)
                SaveSettings();
            }

            // Bring Main Panel to the Front
            panel1.BringToFront();

            // Hide Labels when Not Connected
            label5.Hide();
            label2.Hide();
            label7.Hide();
            sensor_id.Hide();
            sensor_baud.Hide();
            sensor_address.Hide();

            // Check Folder/File Permissions for Write Access

            // Check to see if the required folders exists. 
            if (!System.IO.Directory.Exists("falls"))
            {
                // If not, create it.
                try
                {
                    System.IO.Directory.CreateDirectory("falls");
                }
                catch {
                    MessageBox.Show("Could not create the ./falls/ folder.\nPlease check folder permissions and reopen this program.");
                }
            }

            if (!System.IO.Directory.Exists("alert_text_files"))
            {
                // If not, create it.
                try
                {
                    System.IO.Directory.CreateDirectory("alert_text_files");
                }
                catch
                {
                    MessageBox.Show("Could not create the ./alert_text_files/ folder.\nPlease check folder permissions and reopen this program.");
                }
            }

            if (!System.IO.Directory.Exists("manual_recordings"))
            {
                // If not, create it.
                try
                {
                    System.IO.Directory.CreateDirectory("manual_recordings");
                }
                catch
                {
                    MessageBox.Show("Could not create the ./manual_recordings/ folder.\nPlease check folder permissions and reopen this program.");
                }
            }

            // Run startup Scan to detect XSens Sensor
            SetLabel("Starting Up");
            XSensFinder.RunWorkerAsync();
        }

        private void XSensFinder_DoWork(object sender, DoWorkEventArgs e)
        {
            SetLabel("Searching for XSens Sensor");
            this.Invoke(new MethodInvoker(delegate () { label9.Text = "Scanning for devices..."; }));

            // This gives the user 5 seconds to be able to press "No Sensor" if they want.
            Thread.Sleep(5000);

            if (XSensFinder.CancellationPending) {
                return;
            }

            while (!Variables.connected_to_sensor)
            {
                if (XSensFinder.CancellationPending)
                {
                    return;
                }

                // Begin the process of scanning for, and connecting to the XSens Sensor.
                _xda.reset();
                _xda.scanPorts();
                if (_xda._DetectedDevices.Count > 0)
                {
                    this.Invoke(new MethodInvoker(delegate () { label9.Text = string.Format("Found {0} device(s)\n", _xda._DetectedDevices.Count); }));
                    XsPortInfo portInfo = _xda._DetectedDevices[0];
                    if (portInfo.deviceId().isMtMk4() || portInfo.deviceId().isFmt_X000() || portInfo.deviceId().isMt9c() || portInfo.deviceId().isLegacyMtig())
                    {
                        if (XSensFinder.CancellationPending)
                        {
                            return;
                        }
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Opening port...\n"; }));
                        if (!_xda.openPort(portInfo))
                        {
                            this.Invoke(new MethodInvoker(delegate () { label9.Text = "Could not open port. Aborting."; }));
                            return;
                        }

                        MasterInfo ai = new MasterInfo(portInfo.deviceId());
                        ai.ComPort = portInfo.portName();
                        ai.BaudRate = portInfo.baudrate();

                        _measuringDevice = _xda.getDevice(ai.DeviceId);
                        ai.ProductCode = new XsString(_measuringDevice.productCode());

                        // Print information about detected MTi / MTx / MTmk4 device
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Found Sensor"; }));
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            // Set Values for connected Device
                            sensor_id.Text = _measuringDevice.deviceId().toXsString().toString();
                            sensor_baud.Text = ai.BaudRate.ToString();
                            sensor_address.Text = ai.ComPort.toString();

                            // Show Labels to User
                            label5.Show();
                            label2.Show();
                            label7.Show();
                            sensor_id.Show();
                            sensor_baud.Show();
                            sensor_address.Show();
                        }));
                        //string.Format("Found a device with id: {0} @ port: {1}, baudrate: {2}\n", _measuringDevice.deviceId().toXsString().toString(), ai.ComPort.toString(), ai.BaudRate);

                        // Create and attach callback handler to device
                        _myMtCallback = new MyMtCallback();
                        _measuringDevice.addCallbackHandler(_myMtCallback);

                        // Set Filter Profile
                        // 1 = General
                        // 2 = GeneralNoBaro
                        // 3 = GeneralMag
                        // 4 = Automotive
                        // 9 = HighPerformanceEDR
                        // I have chosen 4 (Automotive) as it counters Yaw Drift the best. 
                        _measuringDevice.setXdaFilterProfile(4);
                        _measuringDevice.setOnboardFilterProfile(4);

                        // Enables AHS (Active Heading Stabilisation)
                        _measuringDevice.setDeviceOptionFlags(XsDeviceOptionFlag.XDOF_EnableMagAidedVru, XsDeviceOptionFlag.XDOF_None);
                        // Perform No Rotation Update of 20 seconds. 
                        _measuringDevice.setNoRotation(20);

                        ConnectedMtData mtwData = new ConnectedMtData();

                        // connect signals
                        _myMtCallback.DataAvailable += new EventHandler<DataAvailableArgs>(_callbackHandler_DataAvailable);

                        // Put the device in configuration mode
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Putting device into configuration mode...\n"; }));
                        if (!_measuringDevice.gotoConfig()) // Put the device into configuration mode before configuring the device
                        {
                            this.Invoke(new MethodInvoker(delegate () { label9.Text = "Could not put device into configuration mode. Aborting."; }));
                            return;
                        }

                        // Configure the device. Note the differences between MTix and MTmk4
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Configuring the device...\n"; }));
                        if (_measuringDevice.deviceId().isMt9c() || _measuringDevice.deviceId().isLegacyMtig())
                        {
                            XsOutputMode outputMode = XsOutputMode.XOM_Orientation; // output orientation data
                            XsOutputSettings outputSettings = XsOutputSettings.XOS_OrientationMode_Quaternion; // output orientation data as quaternion
                            XsDeviceMode deviceMode = new XsDeviceMode(100); // make a device mode with update rate: 100 Hz
                            deviceMode.setModeFlag(outputMode);
                            deviceMode.setSettingsFlag(outputSettings);

                            // set the device configuration
                            if (!_measuringDevice.setDeviceMode(deviceMode))
                            {
                                this.Invoke(new MethodInvoker(delegate () { label9.Text = "Could not configure MTix device. Aborting."; }));
                                return;
                            }
                        }
                        else if (_measuringDevice.deviceId().isMtMk4() || _measuringDevice.deviceId().isFmt_X000())
                        {
                            XsOutputConfigurationArray configArray = new XsOutputConfigurationArray();
                            if (_measuringDevice.deviceId().isImu())
                            {
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_PacketCounter, 0));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_SampleTimeFine, 0));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_Quaternion, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaV, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaQ, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_MagneticField, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_StatusWord, 0));

                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_LatLon, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GpsAge, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GnssPvtData, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GnssSatInfo, 4));
                            }
                            else
                            {
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_PacketCounter, 0));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_SampleTimeFine, 0));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_Quaternion, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaV, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaQ, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_MagneticField, 1000));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_StatusWord, 0));

                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_LatLon, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GpsAge, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GnssPvtData, 4));
                                configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_GnssSatInfo, 4));
                            }
                            if (!_measuringDevice.setOutputConfiguration(configArray))
                            {
                                this.Invoke(new MethodInvoker(delegate () { label9.Text = "Could not configure MTmk4 device. Aborting."; }));
                                return;
                            }
                        }
                        else
                        {
                            this.Invoke(new MethodInvoker(delegate () { label9.Text = "Unknown device while configuring. Aborting."; }));
                            return;
                        }

                        // Put the device in measurement mode
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Putting device into measurement mode...\n"; }));
                        if (!_measuringDevice.gotoMeasurement())
                        {
                            this.Invoke(new MethodInvoker(delegate () { label9.Text = "Could not put device into measurement mode. Aborting."; }));
                            return;
                        }

                        // Wait for Device Object to Initalise
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Device Connected!"; }));

                        Variables.connected_to_sensor = true;
                        SetLabel("Connected");
                    }
                    else
                    {
                        this.Invoke(new MethodInvoker(delegate () { label9.Text = "Your device is not compatible with this version."; }));
                    }
                }
                else
                {
                    // No Device Found, Wait 1 Second, Try Again. 
                    Thread.Sleep(1000);
                }
            }

            if (Variables.connected_to_sensor) {
                // Show Calibration Wait Panel
                this.Invoke(new MethodInvoker(delegate () { CalibrationWaiter.RunWorkerAsync(); panel4.BringToFront(); }));
            }   
        }

        void _callbackHandler_DataAvailable(object sender, DataAvailableArgs e)
        {
            // This handles the data as it goes from the Device to the API.
            // If you want to collect extra readings from the sensor, it must be added here as well as the API!
            if (InvokeRequired)
            {
                // Update UI, make sure this happens on the UI thread
                BeginInvoke(new Action(delegate { _callbackHandler_DataAvailable(sender, e); }));
            }
            else
            {
                if (e.Packet.containsOrientation()) {                
                    // Connect (Orientation Euler angles).
                    XsEuler oriEuler = e.Packet.orientationEuler();
                    _connectedData._orientation = oriEuler;
                }

                if (e.Packet.containsCalibratedData()) {
                    // Connect (Calibration Data)
                    XsCalibratedData calData = e.Packet.calibratedData();
                    _connectedData._calibratedData = calData;
                }

                if (e.Packet.containsRawGnssPvtData()) {
                    // Connect (Raw GNSS Data)
                    XsRawGnssPvtData rawgnssdata = e.Packet.rawGnssPvtData();
                    _connectedData._rawgnssdata = rawgnssdata;
                }

                if (e.Packet.containsRawGnssSatInfo()) {
                    // Connect (Raw GNSS Sat Info)
                    XsRawGnssSatInfo rawgnssinfo = e.Packet.rawGnssSatInfo();
                    _connectedData._rawgnssinfo = rawgnssinfo;
                }

                if (e.Packet.containsRawGpsTimeUtc()) {
                    // Connect (Raw GPS Time)
                    XsRawGpsTimeUtc rawgpstimeutc = e.Packet.rawGpsTimeUtc();
                    _connectedData._gpstime = rawgpstimeutc;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the about form.
            Form AboutForm = new About();
            AboutForm.ShowDialog();
        }

        private void ToggleFallDetection() {
            // Function -> Toggle Fall Detection On/Off
            if (button2.Text == "Enable")
            {
                // Set Image to Red. 
                pictureBox1.Image = Properties.Resources.icons8_Falling_Man_100px;

                // Enable Fall Detection
                Variables.fall_detection = true;

                // Set Button Text
                button2.Text = "Disable";

                // Set Label
                label6.Text = "Fall Detection (On)";
            }
            else
            {
                // Set Image to Black. 
                pictureBox1.Image = Properties.Resources.icons8_Falling_Man_100px__2_;

                // Disable Fall Detection
                Variables.fall_detection = false;

                // Set Button Text
                button2.Text = "Enable";

                // Set Label
                label6.Text = "Fall Detection (Off)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button -> Toggle Fall Detection On/Off
            ToggleFallDetection();
        }

        private double GetTime() {
            // Gets the Time as UTC Epoch (seconds since 1970).
            // Change this if you want to use a different time zone.
            DateTime baseDate = new DateTime(1970, 1, 1);
            TimeSpan diff = DateTime.Now - baseDate;
            return diff.TotalMilliseconds;
        }

        private void DataCollector_DoWork(object sender, DoWorkEventArgs e)
        {
            // Reset Orientation Alignment on Startup (Orientation XYZ back to 0).
            _measuringDevice.resetOrientation(XsResetMethod.XRM_Alignment);

            FallChecker.RunWorkerAsync();
            GPS_Checker.RunWorkerAsync();

            // Loop and Collect Data from the Connected Sensor
            while (!DataCollector.CancellationPending)
            {
                // Check to see if the Sensor has been disconnected.
                int collected_count = 0;
                string[] data_to_collect = new string[13];

                // This is the layout of the data located in the array, as well as the .efas Files. 
                // [0] Time
                // [1] Acc X
                // [2] Acc Y
                // [3] Acc Z
                // [4] Gyro X
                // [5] Gyro Y
                // [6] Gyro Z
                // [7] Ori X
                // [8] Ori Y
                // [9] Ori Z
                // [10] GPS Long
                // [11] GPS Lat
                // [12] GPS Fix Old

                data_to_collect[0] = GetTime().ToString();

                data_to_collect[10] = Variables.latest_longitude.ToString();
                data_to_collect[11] = Variables.latest_latitude.ToString();
                data_to_collect[12] = Variables.gps_fix_old.ToString();

                // GNSS
                if (_connectedData._rawgnssdata != null)
                {
                    if (_connectedData._rawgnssdata.m_year != 0)
                    {
                        // Store Fix Type
                        Variables.latest_fixtype = _connectedData._rawgnssdata.m_fixType;

                        // Process Latitude and Longitude. 
                        int temp_lat = _connectedData._rawgnssdata.m_lat;
                        int temp_lon = _connectedData._rawgnssdata.m_lon;
                        if (_connectedData._rawgnssdata.m_fixType != 0) {
                            if (temp_lat != 0 && temp_lon != 0) {
                                // Convert Lat and Lon to Decimal, because the XSens API stores them as Integers instead of Decimals (No idea why).
                                decimal lat = Convert.ToDecimal(temp_lat) / 10000000; // Inserts a Decimal Place 7 digits forward
                                decimal lon = Convert.ToDecimal(temp_lon) / 10000000; // Inserts a Decimal Place 7 digits forward

                                // Save Lon and Lat for use. 
                                Variables.latest_latitude = lat;
                                Variables.latest_longitude = lon;
                                Variables.latest_gpsfetch = GetTime();
                            }
                        }
                    }
                }

                // GNSS
                if (_connectedData._rawgnssinfo != null)
                {
                    // Store amount of Satellites
                    Variables.satellites = _connectedData._rawgnssinfo.m_numSvs;
                }

                // GPS Time - Currently don't need this.
                /*if (_connectedData._gpstime != null) {
                    if (_connectedData._gpstime.m_year != 0)
                    {
                        DiagBoxAdd("GPS Time: " + _connectedData._gpstime);
                    }
                }*/

                // Grab Orientation Data
                Decimal orix = 0;
                Decimal oriy = 0;
                Decimal oriz = 0;

                if (_connectedData._orientation != null)
                {                    
                    // Collect Data
                    orix = Convert.ToDecimal(Math.Round(_connectedData._orientation.x(), 2));
                    oriy = Convert.ToDecimal(Math.Round(_connectedData._orientation.y(), 2));
                    oriz = Convert.ToDecimal(Math.Round(_connectedData._orientation.z(), 2));

                    // Append Data to Payload
                    data_to_collect[7] = orix.ToString();
                    data_to_collect[8] = oriy.ToString();
                    data_to_collect[9] = oriz.ToString();

                    collected_count += 1;
                }

                // Grab Accelerometer Data
                Decimal accx = 0;
                Decimal accy = 0;
                Decimal accz = 0;

                Decimal gyrx = 0;
                Decimal gyry = 0;
                Decimal gyrz = 0;

                if (_connectedData._calibratedData != null)
                {
                    // Collect Data
                    accx = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_acc.value(0), 2));
                    accy = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_acc.value(1), 2));
                    accz = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_acc.value(2), 2));

                    // Append Data to Payload
                    data_to_collect[1] = accx.ToString();
                    data_to_collect[2] = accy.ToString();
                    data_to_collect[3] = accz.ToString();

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        // Set Text Labels
                        acc_x.Text = accx.ToString();
                        acc_z.Text = accz.ToString();
                        acc_y.Text = accy.ToString();
                    }));

                    // Collect Data
                    gyrx = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_gyr.value(0), 2));
                    gyry = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_gyr.value(1), 2));
                    gyrz = Convert.ToDecimal(Math.Round(_connectedData._calibratedData.m_gyr.value(2), 2));

                    // Append Data to Payload
                    data_to_collect[4] = gyrx.ToString();
                    data_to_collect[5] = gyry.ToString();
                    data_to_collect[6] = gyrz.ToString();

                    collected_count += 1;
                }

                // If Both Sets of Data Collected.
                if (collected_count == 2) {
                    // Only Store payload if the GPS is not Zero.
                    if ((Variables.latest_longitude != 0) && (Variables.latest_latitude != 0)) {

                        // Set GUI Labels
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            // Set Text Labels
                            ori_x.Text = orix.ToString();
                            ori_y.Text = oriy.ToString();
                            ori_z.Text = oriz.ToString();

                            // Set Gauges
                            gauge_ori_x.Value = Convert.ToInt32(orix);
                            gauge_ori_y.Value = Convert.ToInt32(oriy);
                            gauge_ori_z.Value = Convert.ToInt32(oriz);

                            // Set Text Labels
                            gyr_x.Text = gyrx.ToString();
                            gyr_y.Text = gyry.ToString();
                            gyr_z.Text = gyrz.ToString();

                            this.Update();
                        }));                        

                        // Store Payload
                        Variables.CapturedData.Add(data_to_collect);

                        // Diagnostics - Show Body Position
                        this.Invoke(new MethodInvoker(delegate { label53.Text = ConvertBodyPositionToText(CalculateBodyPosition(Convert.ToDecimal(data_to_collect[7]), Convert.ToDecimal(data_to_collect[8]), Convert.ToDecimal(data_to_collect[9]))); }));

                        if (Variables.manual_recording_collection) {
                            // Also store the data in the manual recording as well.
                            Variables.manual_recorded_data.Add(data_to_collect);
                        }
                    }
                }

                // 12 Second Buffer - anything older than 12 seconds is trimmed off.
                try
                {
                    double comparecurrenttime = GetTime() - 12000;
                    if (Convert.ToDouble(Variables.CapturedData.First()[0]) < comparecurrenttime)
                    {
                        // Trim List to 12 seconds maximum.
                        Variables.CapturedData.RemoveAt(0);
                    }
                } catch { }

                // Prevents GUI Lockup. 1ms.
                Thread.Sleep(1);
            }
        }

        private void FallChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Loop and Check for Falls every half a second.
            // Falls can only happen once per second.
            while (!FallChecker.CancellationPending)
            {
                if (Variables.fall_detection)
                {
                    // Loop in the event that fall check fails
                    bool completed = false;
                    while (!completed) {
                        try
                        {
                            FallCheck();
                            completed = true;
                        } catch {
                            // Failed, loop will try again.
                        }
                    }
                }
                Thread.Sleep(500);
            }
        }

        private bool FallCheck() {
            // Checks for Live Falls

            /* Check for Fall using Three Stages of Threshold Triggers
             * 
             * Stage 1
             * Use the Accelerometer Threshold to check against forces applied on all axis, added together. 
             * 
             * Stage 2
             * Use the Orientation Yaw axis to determine if the body is horizontal (facing upwards or downwards), using the Tilt Point Threshold. 
             * 
             * Stage 3
             * Use the extra information to determine which side the body is on. 
             * 
             */

            // Store copy of time when started
            double start_time = GetTime();

            // Storage for Chosen Data
            List<string[]> DataToProcess = new List<string[]>();

            // Store Copy of Current List Locally to work with
            List<string[]> LocalCopyCapturedData = new List<string[]>();
            LocalCopyCapturedData.Capacity = Variables.CapturedData.Capacity;
            LocalCopyCapturedData = Variables.CapturedData;        

            // Time is based on 9 seconds from the Last Entry.
            double comparecurrenttime = 0;
            comparecurrenttime = Convert.ToDouble(LocalCopyCapturedData.LastOrDefault()[0]) - 9000;

            // Process collected Data
            List<string[]> templist = new List<string[]>(); // Create a new List
            templist.Capacity = LocalCopyCapturedData.Capacity; // Set the new Lists Capacity the same as the source list.
            templist = LocalCopyCapturedData.ToList(); // Copy the data from the source list into the new list

            foreach (string[] dataentry in templist)
            {
                if (Convert.ToDouble(dataentry[0]) >= comparecurrenttime)
                {
                    // Within 9 Seconds. Add to Processing. 
                    DataToProcess.Add(dataentry);
                }
            }

            // Categorise Data Into Time Based Sections
            List<string[]> Data_Before = new List<string[]>();
            List<string[]> Data_During = new List<string[]>();
            List<string[]> Data_After = new List<string[]>();

            // Time to compare against
            double comparetime = 0;
            comparetime = Convert.ToDouble(LocalCopyCapturedData.LastOrDefault()[0]);

            // Before (9000ms - 5000ms)
            double time_before1 = comparetime - 9000;
            double time_before2 = comparetime - 5000;
            foreach (string[] dataentry in DataToProcess.ToList())
            {
                double storedtime = Convert.ToDouble(dataentry[0]);
                if (storedtime <= time_before2 && storedtime >= time_before1)
                {
                    // In Range, add to list. 
                    Data_Before.Add(dataentry);
                }
            }

            // During (5000ms - 4000ms)
            double time_during1 = comparetime - 4999;
            double time_during2 = comparetime - 4000;
            foreach (string[] dataentry in DataToProcess.ToList())
            {
                double storedtime = Convert.ToDouble(dataentry[0]);
                if (storedtime <= time_during2 && storedtime >= time_during1)
                {
                    // In Range, add to list. 
                    Data_During.Add(dataentry);
                }
            }

            // After (4000ms - 0ms)
            double time_after1 = comparetime - 3999;
            double time_after2 = comparetime - 0;
            foreach (string[] dataentry in DataToProcess.ToList())
            {
                double storedtime = Convert.ToDouble(dataentry[0]);
                if (storedtime <= time_after2 && storedtime >= time_after1)
                {
                    // In Range, add to list.
                    Data_After.Add(dataentry);
                }
            }

            // Calculate Avg for each Axis. 
            double acc_x_avg = 0;
            double acc_y_avg = 0;
            double acc_z_avg = 0;

            double acc_x_temp = 0;
            double acc_y_temp = 0;
            double acc_z_temp = 0;

            foreach (string[] dataentry in Data_During.ToList())
            {
                acc_x_temp += Convert.ToDouble(dataentry[1]);
                acc_y_temp += Convert.ToDouble(dataentry[2]);
                acc_z_temp += Convert.ToDouble(dataentry[3]);
            }

            int datacount = Data_During.Count();

            acc_x_avg = acc_x_temp / datacount;
            acc_y_avg = acc_y_temp / datacount;
            acc_z_avg = acc_z_temp / datacount;

            // Stage 1. Go through each packet, determine total delta accross all axis (XYZ). 
            int acc_triggers = 0;
            foreach (string[] dataentry in Data_During.ToList())
            {
                // Calculate XYZ Delta

                double acc_x = Convert.ToDouble(dataentry[1]);
                double acc_y = Convert.ToDouble(dataentry[2]);
                double acc_z = Convert.ToDouble(dataentry[3]);

                double acc_x_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_x), Convert.ToDecimal(acc_x_avg)));
                double acc_y_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_y), Convert.ToDecimal(acc_y_avg)));
                double acc_z_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_z), Convert.ToDecimal(acc_z_avg)));

                double acc_x_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_x), 0));
                double acc_y_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_y), 0));
                double acc_z_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_z), 0));

                double totalacc = acc_x_zero + acc_y_zero + acc_z_zero;
                double totaldelta = acc_x_delta + acc_y_delta + acc_z_delta;
                double totaldelta_rounded = Math.Round(totaldelta, 2);

                // Store Total Acceleration
                this.Invoke(new MethodInvoker(delegate
                {
                    label21.Text = totaldelta_rounded.ToString() + " m/s2";

                    if (totaldelta >= Convert.ToDouble(numericUpDown1.Value))
                    {
                        acc_triggers += 1;
                    }
                }));
            }

            // Zero the starting direction from the prefall.
            if (Data_Before.Count() == 0) {
                return false;
            }
            decimal ori_z_start = Convert.ToDecimal(Data_Before.First()[9]);

            // Stage 2. Check Body Orientation.
            // Body Position After Fall

            int positions_fallen = 0;
            int latest_body_position = 100;
            int latest_fall_position = 100;

            foreach (string[] dataentry in Data_After.ToList())
            {
                // Body Position Combinations

                // Zero the starting direction from the prefall based on the before-fall direction.
                decimal adjusted_ori_z = orientation_compensation(ori_z_start, Convert.ToDecimal(dataentry[9]));

                int bodyposition = CalculateBodyPosition(Convert.ToDecimal(dataentry[7]), Convert.ToDecimal(dataentry[8]), adjusted_ori_z);
                latest_body_position = bodyposition;

                this.Invoke(new MethodInvoker(delegate
                {
                    label20.Text = ConvertBodyPositionToText(bodyposition);
                }));

                if (ConvertBodyPositionToBool(bodyposition))
                {
                    positions_fallen++;
                    latest_fall_position = bodyposition;
                }
            }

            if (latest_fall_position == 100)
            {
                latest_fall_position = latest_body_position;
            }

            if (acc_triggers >= 1)
            {
                if (positions_fallen >= 1)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        // Live Fall Detected!

                        // If "record falls to file"
                        if (checkBox1.Checked) {
                            // Record fall to File

                            // Check to see if /falls/ folder exists. 
                            string foldername = "falls";

                            if (!System.IO.Directory.Exists(foldername))
                            {
                                // If not, create it.
                                System.IO.Directory.CreateDirectory(foldername);
                            }

                            // Set File Name to store results in.
                            string filename = "fall-" + Math.Round(start_time, 0);

                            // Add File Extension
                            filename += ".efas";

                            // Write contents to file.
                            SerializeObject(DataToProcess, foldername + System.IO.Path.DirectorySeparatorChar + filename);
                        }

                        // If "trigger alert on fall"
                        if (checkBox2.Checked)
                        {
                            // If last fall hasn't happened yet, set it.
                            bool trigger_approved = false;

                            if (Variables.last_fall_time == 0) {
                                Variables.last_fall_time = start_time;
                                trigger_approved = true;
                            }

                            // If the last fall happened over 1 second ago, make an alert
                            if (Variables.last_fall_time < start_time - 1000)
                            {
                                Variables.last_fall_time = start_time;
                                trigger_approved = true;
                            }

                            if (trigger_approved) {
                                // Make an Alert (Async)
                                new Task(() => { TriggerAlert(true, Variables.latest_longitude.ToString(), Variables.latest_latitude.ToString(), Variables.gps_fix_old, GetTime().ToString(), ConvertBodyPositionToText(latest_fall_position)); }).Start();
                                //TriggerAlert(true, Variables.latest_longitude.ToString(), Variables.latest_latitude.ToString(), Variables.gps_fix_old, GetTime().ToString(), ConvertBodyPositionToText(latest_fall_position));
                            }
                        }
                    }));
                }
            }

            return false;
        }

        private int CalculateBodyPosition(decimal X, decimal Y, decimal Z) {
            // Calculates the Body Position
            // Use the value returned (1-15) to calculate:
            // -> ConvertBodyPositionToText
            // -> ConvertBodyPositionToBool

            decimal range = 45; // Split the 360 degree circle into 8 x 45 degree parts (4 sections, each 90 degrees)

            // Because of "Pitch Flip", determing other axis when facing Up/Down is difficult. 
            if (InRange(Y, range, 90)) { return 1; }
            if (InRange(Y, range, -90)) { return 2; }

            // All the other values don't suffer from pitch flip, so we can determine extra information.
            if (InRange(X, range, -90) && InRange(Y, range, 0) && InRange(Z, range, 0)) { return 3; }
            if (InRange(X, range, -90) && InRange(Y, range, 0) && InRange(Z, range, 90)) { return 4; }
            if (InRange(X, range, -90) && InRange(Y, range, 0) && InRange(Z, range, -90)) { return 5; }
            if (InRange(X, range, -90) && InRange(Y, range, 0) && InRange(Z, range, 180)) { return 6; }

            if (InRange(X, range, 90) && InRange(Y, range, 0) && InRange(Z, range, 0)) { return 7; }
            if (InRange(X, range, 90) && InRange(Y, range, 0) && InRange(Z, range, 90)) { return 8; }
            if (InRange(X, range, 90) && InRange(Y, range, 0) && InRange(Z, range, -90)) { return 9; }
            if (InRange(X, range, 90) && InRange(Y, range, 0) && InRange(Z, range, 180)) { return 10; }

            if (InRange(X, range, 0) && InRange(Y, range, 0) && InRange(Z, range, 0)) { return 11; }
            if (InRange(X, range, 0) && InRange(Y, range, 0) && InRange(Z, range, 90)) { return 12; }
            if (InRange(X, range, 0) && InRange(Y, range, 0) && InRange(Z, range, -90)) { return 13; }
            if (InRange(X, range, 0) && InRange(Y, range, 0) && InRange(Z, range, 180)) { return 14; }

            if (InRange(X, range, 180) && InRange(Y, range, 0) && InRange(Z, range, 0)) { return 15; }
            if (InRange(X, range, 180) && InRange(Y, range, 0) && InRange(Z, range, 90)) { return 15; }
            if (InRange(X, range, 180) && InRange(Y, range, 0) && InRange(Z, range, -90)) { return 15; }
            if (InRange(X, range, 180) && InRange(Y, range, 0) && InRange(Z, range, 180)) { return 15; }

            return 0;
        }

        private string ConvertBodyPositionToText(int position) {
            // Converts Position Result into Text.
            if (position == 1) { return "Fallen, Face Down"; }
            if (position == 2) { return "Fallen, Face Up"; }

            if (position == 3) { return "Fallen, Left Side, Facing Front"; }
            if (position == 4) { return "Fallen, Left Side, Facing Left"; }
            if (position == 5) { return "Fallen, Left Side, Facing Right"; }
            if (position == 6) { return "Fallen, Left Side, Facing Rear"; }

            if (position == 7) { return "Fallen, Right Side, Facing Front"; }
            if (position == 8) { return "Fallen, Right Side, Facing Left"; }
            if (position == 9) { return "Fallen, Right Side, Facing Right"; }
            if (position == 10) { return "Fallen, Right Side, Facing Rear"; }

            if (position == 11) { return "Upright, Facing Forward"; }
            if (position == 12) { return "Upright, Facing Left"; }
            if (position == 13) { return "Upright, Facing Right"; }
            if (position == 14) { return "Upright, Facing Rear"; }

            if (position == 15) { return "Upside Down"; }

            return "Calculating";
        }

        private bool ConvertBodyPositionToBool(int position) {
            // Return True if the position is a fallen position. 
            List<int> FallPositions = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            if (FallPositions.Contains(position)) { return true; } else { return false; }
        }

        private bool InRange(decimal item, decimal range, decimal position)
        {
            // If the item is in range of the position, it returns true.
            if (CalculateRotateDiff(item, position) <= range) { return true; } else { return false; }
            //if (item >= (position - range) && item <= (position + range)) { return true; } else { return false; }
        }

        private bool Between(decimal item, decimal bottom, decimal top) {
            // If the item is between the bottom and top values, it returns true.
            if (item >= bottom && item <= top) { return true; } else { return false; }
        }

        private void DiagBoxAdd(string message) {
            // Adds the Message to the Diagnostic Box
            this.Invoke(new MethodInvoker(delegate () {
                diagbox.Text = message + Environment.NewLine + diagbox.Text;
            }));
        }

        private void TriggerAlert(bool live, string longitude, string latitude, bool stalegps, string time, string fallposition) {
            // If Live is true, the alert is real, and to be considered important. 
            if (checkBox3.Checked)
            {
                try
                {
                    // Play Sound
                    string soundfile = "trigger_sound.wav";
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundfile);
                    player.Play();
                }
                catch (Exception err)
                {
                    DiagBoxAdd("ALERT SOUND ERROR:" + err.Message);
                }
            }

            if (checkBox5.Checked) {
                // Log Fall via Diagnostics Log
                if (live)
                {
                    DiagBoxAdd("FALL DETECTED: Long:[" + longitude + "] Lat:[" + latitude + "] GpsOld:[" + stalegps + "] Time:[" + time + "] FallPosition:[" + fallposition + "]");
                } else {
                    DiagBoxAdd("FALL DETECTED [TEST]: Long:[133.7751321] Lat:[25.2744123] StaleGPS:[false] Time:[" + GetTime() + "] FallPosition:[Fallen, Right Side, Facing Left]");
                }
            }

            if (checkBox4.Checked) {
                // Log Fall via Text File
                try
                {
                    // Check if "/alert_text_files/" folder exists
                    string foldername = "alert_text_files";
                    if (!System.IO.Directory.Exists(foldername))
                    {
                        // If not, create it.
                        System.IO.Directory.CreateDirectory(foldername);
                    }

                    if (live)
                    {
                        System.IO.File.WriteAllText(@foldername + System.IO.Path.DirectorySeparatorChar + "fall_alert_" + time + ".txt", "FALL DETECTED: Long:[" + longitude + "] Lat:[" + latitude + "] StaleGPS:[" + stalegps + "] Time:[" + time + "] FallPosition:[" + fallposition + "]");
                    }
                    else
                    {
                        System.IO.File.WriteAllText(@foldername + System.IO.Path.DirectorySeparatorChar + "fall_alert_" + GetTime() + ".txt", "FALL DETECTED [TEST]: Long:[133.7751321] Lat:[25.2744123] StaleGPS:[false] Time:[" + GetTime() + "] FallPosition:[Fallen, Right Side, Facing Left]");
                    }
                }
                catch (Exception err) {
                    DiagBoxAdd("ALERT TEXT FILE ERROR:" + err.Message);
                }
            }

            if (checkBox6.Checked) {
                // Log Fall via HTTP Get
                try
                {
                    string weburl = textBox2.Text;
                    string html = string.Empty;
                    string url = weburl.Trim() + "?";

                    if (live)
                    {
                        url += "long=" + longitude;
                        url += "&lat=" + latitude;
                        url += "&stalegps=" + stalegps;
                        url += "&time=" + time;
                        url += "&fallposition=" + fallposition;
                        url += "&test=false";
                    }
                    else
                    {
                        url += "long=133.7751321";
                        url += "&lat=25.2744123";
                        url += "&stalegps=false";
                        url += "&time=" + GetTime();
                        url += "&fallposition=Fallen, Right Side, Facing Left";
                        url += "&test=true";
                    }

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.AutomaticDecompression = DecompressionMethods.GZip;

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        html = reader.ReadToEnd();
                    }

                    // Log the HTML Response to the Diagnostics Box
                    DiagBoxAdd(html);
                }
                catch (Exception err) {
                    DiagBoxAdd("WEBSITE ERROR: " + err.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Run Test Alert (Async)
            new Task(() => { TriggerAlert(false, null, null, false, null, null); }).Start();
            //TriggerAlert(false, null, null, false, null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // User does not want to use Sensor. 
            XSensFinder.CancelAsync();
            SetLabel("Idle (No Sensor Mode)");

            // Without a Sensor, data recording is not possible.
            button6.Visible = false;
            button2.Visible = false;
            button11.Enabled = false;

            // Show Main Panel
            panel2.BringToFront();
            label30.Text = "No Sensor Mode";
            panel3.Visible = true;
        }

        private void GPS_Checker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check for GPS Fix Type
            while (!GPS_Checker.CancellationPending) {
                string fixtypemessage = "";
                switch (Variables.latest_fixtype) {
                    case 0:
                        // No Fix
                        fixtypemessage = "No Fix";
                        break;
                    case 1:
                        // Read Reckoning Fix
                        fixtypemessage = "Read Reckoning Fix";
                        break;
                    case 2:
                        // 2D Fix
                        fixtypemessage = "2D Fix";
                        break;
                    case 3:
                        // 3D Fix
                        fixtypemessage = "3D Fix";
                        break;
                    case 4:
                        // GNSS + Dead Reckoning Fix
                        fixtypemessage = "GNSS + Dead Reckoning Fix";
                        break;
                    case 5:
                        // Time Only Fix
                        fixtypemessage = "Time Only Fix";
                        break;
                }
                this.Invoke(new MethodInvoker(delegate () { label30.Text = fixtypemessage; }));

                // Set Satellite Count
                this.Invoke(new MethodInvoker(delegate () { label27.Text = Variables.satellites.ToString(); }));

                // Check if Latest GPS Fetch is older than 10 seconds. 
                if (Variables.latest_gpsfetch < (GetTime() - 10000)) {
                    // The GPS Fix is Old, and should be taken into consideration when searching for the fallen person.
                    Variables.gps_fix_old = true;
                    this.Invoke(new MethodInvoker(delegate (){ pictureBox3.Image = Properties.Resources.icons8_Satellite_104px_1; }));
                } else {
                    // Gps Fix is up to date.
                    Variables.gps_fix_old = false;
                    this.Invoke(new MethodInvoker(delegate () { pictureBox3.Image = Properties.Resources.icons8_Satellite_104px_2; }));
                }

                this.Invoke(new MethodInvoker(delegate ()
                {
                    // Set Latitude and Longitude
                    latitude.Text = Variables.latest_latitude.ToString();
                    longitude.Text = Variables.latest_longitude.ToString();
                }));
                Thread.Sleep(500);
            }
        }

        private void CalibrationWaiter_DoWork(object sender, DoWorkEventArgs e)
        {
            // Wait for 20 Seconds while the sensor Calibrates
            for (int i = 1; i <= 20; i++) {
                if (Variables.skip_timer == true) {
                    break;
                }
                this.Invoke(new MethodInvoker(delegate (){ calibration_progressbar.Value = i; }));
                Thread.Sleep(1000);
            }

            // Sensor is now calibrated! 
            this.Invoke(new MethodInvoker(delegate {
                // Show GPS Waiter Panel
                GPSWaiter.RunWorkerAsync();
                this.Update();
            }));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Skips the 20s Sensor Calibration Page
            Variables.skip_timer = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Show the Manual Record Screen.

            // Disable Analyse Recording Button
            button4.Enabled = false;

            // Disable the Fall Detection Button
            button2.Enabled = false;

            // Disable Fall Detection Routine
            // Set Image to Black. 
            pictureBox1.Image = Properties.Resources.icons8_Falling_Man_100px__2_;

            // Disable Fall Detection
            Variables.fall_detection = false;

            // Set Button Text
            button2.Text = "Enable";

            // Set Label
            label6.Text = "Fall Detection (Off)";

            panel5.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "Start Recording")
            {
                // Disable the 'Go Back' Button. 
                button9.Enabled = false;

                // Start Recording Values into Array
                Variables.manual_recording = true;
                Variables.manual_recording_collection = true;

                // Update the Text Label
                button10.Text = "Stop";

                // Disable Editing of the File Name Input
                textBox1.Enabled = false;

                // Start Into BackGround Worker to show information. 
                ManualRecorder.RunWorkerAsync();

                // Set Text Label to inform of starting 4 second data collection.
                label48.Text = "Warming Up";
                button10.Enabled = false;

            } else if (button10.Text == "Stop") {

                // Stop Recording Values into Array
                Variables.manual_recording = false;

                // Let the ManualRecorder Background Worker finish
                button10.Enabled = false;
                button10.Text = "Stopping";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Close Manual Recording Panel
            button4.Enabled = true; // Enable Analyse Recording Button
            button2.Enabled = true; // Enable the Fall Detection Button            
            panel2.BringToFront(); // Go back from Manual Recording, show the main window. 
            this.Update(); // Update the GUI so it forces a redraw. 
        }

        private void ManualRecorder_DoWork(object sender, DoWorkEventArgs e)
        {
            // Manual Recorder Worker
            while (!ManualRecorder.CancellationPending)
            {
                // Check to see if /manual_recordings/ folder exists. 
                string foldername = "manual_recordings";
                if (!System.IO.Directory.Exists(foldername)) {
                    // If not, create it.
                    System.IO.Directory.CreateDirectory(foldername);
                }

                // Set File Name to store results in.
                string filename = "recording-" + Math.Round(GetTime(), 0);
                if (textBox1.Text != "")
                {
                    // Add Custom Label, if it was set.
                    filename += "-" + textBox1.Text;
                }

                // Add File Extension
                filename += ".efas";

                // Go through each entry until recording is to be stopped. 
                while (Variables.manual_recording) {

                    // Update and Show Statistics
                    this.Invoke(new MethodInvoker(delegate {
                        label44.Text = ConvertK(Variables.manual_recorded_data.Count()).ToString(); // Packet Count

                        if (Variables.manual_recorded_data.Count() != 0) {
                            double seconds_passed = Math.Round(((GetTime() - Convert.ToDouble(Variables.manual_recorded_data.First()[0])) / 1000), 0);
                            label46.Text = seconds_passed.ToString(); // Seconds Passed

                            if (seconds_passed >= 4) {
                                // Warmup has Finished
                                label48.Text = "Recording"; // Status Label
                                button10.Enabled = true; // Enable Stop Button;
                            }
                        }
                    }));
                    Thread.Sleep(1000);
                }

                // Recording has been told to stop. 
                // Collect the last 4 seconds of data, and then stop. 

                this.Invoke(new MethodInvoker(delegate {
                    // Status Label
                    label48.Text = "Cooling Down";
                }));

                int countdown = 4;
                while (countdown != 0) {
                    Thread.Sleep(1000); // Wait 1 second.

                    this.Invoke(new MethodInvoker(delegate
                    {
                        label44.Text = ConvertK(Variables.manual_recorded_data.Count()); // Packet Count
                        if (Variables.manual_recorded_data.Count() != 0)
                        {
                            double seconds_passed = Math.Round(((GetTime() - Convert.ToDouble(Variables.manual_recorded_data.First()[0])) / 1000), 0);
                            label46.Text = seconds_passed.ToString(); // Seconds Passed
                        }
                    }));
                               
                    countdown--; // Stop Counter by 1.
                }
                
                // Stops the Data collector
                Variables.manual_recording_collection = false;

                // Save results to the file.
                SerializeObject(Variables.manual_recorded_data, foldername + System.IO.Path.DirectorySeparatorChar + filename);

                // Empty the Manually Recorded Data
                Variables.manual_recorded_data.Clear();

                // This message box is disabled to avoid annoying popups.
                //MessageBox.Show("Recording Finished!\nFile saved under " + System.IO.Path.DirectorySeparatorChar + foldername + System.IO.Path.DirectorySeparatorChar + filename);

                this.Invoke(new MethodInvoker(delegate {
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button10.Text = "Start Recording";
                    label48.Text = "Stopped";
                    textBox1.Text = "";
                    textBox1.Enabled = true;
                }));
                break;
            }

        }

        // Writes the supplied Object (Array List) into the file specified.
        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex) { }
        }


        // Reades the supplied Object Type (Array List) from the file specified.
        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex) { }

            return objectOut;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Textbox filtering for the File Name (Manual Recording)
            Char pressedKey = e.KeyChar;
            // Allow Letters, Number, Backspace and a dash (negative sign).
            if (Char.IsLetter(pressedKey) || Char.IsDigit(pressedKey) || pressedKey == (char)Keys.Back || pressedKey == '-')
            {
                // Allow input.
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Manually Reset Orientation Alignment (Orientation XYZ back to 0).
            try
            {
                _measuringDevice.resetOrientation(XsResetMethod.XRM_Alignment);
            } catch { }
        }

        private string HumanReadableBytes(long filesize) {
            // Turn Bytes into Human Readable Value
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = filesize;
            int order = 0;
            while (len >= 1024 && order < (sizes.Length - 1))
            {
                order++;
                len /= 1024;
            }
            return Math.Round(len, 2) + " " + sizes[order];
        }

        public string ConvertK(long number)
        {
            // Convert Long Numbers into Smaller Human Readable ones (1k = 1000, 100k = 100'000)
            if (number >= 1000)
            {
                return number / 1000 + "k";
            }
            return number.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open File for Analysing
            AnalyseFileDiaglog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // Set Default Directory to the Programs Current Location
            DialogResult OpenFileResult = AnalyseFileDiaglog.ShowDialog(); // Ask for File to be Opened
            if (OpenFileResult == DialogResult.OK) {
                Variables.opened_file = AnalyseFileDiaglog.FileName; // File has been Selected

                // Preload Statistics
                label69.Text = Path.GetFileName(AnalyseFileDiaglog.FileName); // File Name Label

                // Open Stored File into List Array. 
                try
                {
                    Variables.opened_data = DeSerializeObject<List<string[]>>(AnalyseFileDiaglog.FileName);
                }
                catch (Exception err){
                    MessageBox.Show("The file could not be opened. Please Try again.\nThe Error is:\n" + err.Message);
                    return;
                }

                // Check if the content was loaded successfully. 
                if (Variables.opened_data == null) {
                    MessageBox.Show("The file could not be opened, or the contents were empty.");
                    return;
                }

                if (((Convert.ToDecimal(Variables.opened_data.Last()[0]) - Convert.ToDecimal(Variables.opened_data.First()[0])) / 1000) < 9) {
                    MessageBox.Show("Your Recording File is too Short! You need at least 9 seconds of content.");
                    return;
                }

                label64.Text = ConvertK(Variables.opened_data.Count()).ToString(); // Packets
                label66.Text = Math.Round(((Convert.ToDecimal(Variables.opened_data.Last()[0]) - Convert.ToDecimal(Variables.opened_data.First()[0])) / 1000), 0).ToString(); // Seconds
                label68.Text = HumanReadableBytes(new System.IO.FileInfo(AnalyseFileDiaglog.FileName).Length).ToString(); // File Size

                // Disable Background Events before showing Analysis Panel
                button6.Enabled = false; // Disable Manual Recording Button
                button2.Enabled = false; // Disable the Fall Detection Button

                // Disable Fall Detection Routine
                pictureBox1.Image = Properties.Resources.icons8_Falling_Man_100px__2_; // Set Image to Black. 
                Variables.fall_detection = false; // Disable Fall Detection
                button2.Text = "Enable"; // Set Button Text
                label6.Text = "Fall Detection (Off)"; // Set Label

                // Copy over Threshold
                numericUpDown1.Value = acc_threshold.Value;

                // Reset Values on Entry

                // Reset controls back to default
                label59.Text = "0/0";
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                label79.Text = "...";
                label55.Text = "...";
                label51.Text = "...";
                label56.Text = "...";
                label75.Text = "...";
                label73.Text = "...";
                label70.Text = "...";
                label81.Text = "0";
                aGauge1.Value = 0;
                aGauge2.Value = 0;
                progressBar1.Value = 0;

                label96.Text = "0";
                label94.Text = "0";
                label93.Text = "0";
                label98.Text = "0";
                aGauge5.Value = 0;
                aGauge4.Value = 0;
                aGauge3.Value = 0;
                aGauge6.Value = 0;

                // Show Analysis Panel
                panel6.BringToFront();
                this.Update();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Close File Analysis
            button6.Enabled = true; // Enable Manual Recording Button
            button2.Enabled = true; // Enable the Fall Detection Button
            panel2.BringToFront(); // Show the main window.
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "Run Analysis")
            {
                // Disable Resume Button until needed
                button14.Enabled = false;

                // Reset controls back to default
                label59.Text = "0/0";
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                label79.Text = "...";
                label55.Text = "...";
                label51.Text = "...";
                label56.Text = "...";
                label75.Text = "...";
                label73.Text = "...";
                label70.Text = "...";
                label81.Text = "0";
                aGauge1.Value = 0;
                aGauge2.Value = 0;
                progressBar1.Value = 0;

                label96.Text = "0";
                label94.Text = "0";
                label93.Text = "0";
                label98.Text = "0";
                aGauge5.Value = 0;
                aGauge4.Value = 0;
                aGauge3.Value = 0;
                aGauge6.Value = 0;

                // Disable the Close Button
                button13.Enabled = false;

                // Set Buttons Text
                button12.Text = "Stop";

                numericUpDown1.Enabled = false;

                // Run Analysis
                AnalyseFileWorker.RunWorkerAsync();
            }
            else if (button12.Text == "Stop") {
                // Stop the Worker
                AnalyseFileWorker.CancelAsync();
            }
        }

        private void AnalyseFileWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!AnalyseFileWorker.CancellationPending)
            {
                // Perform Analysis of File Data
                decimal total_run_time = Math.Round(((Convert.ToDecimal(Variables.opened_data.Last()[0]) - Convert.ToDecimal(Variables.opened_data.First()[0])) / 1000), 0);
                this.Invoke(new MethodInvoker(delegate { progressBar1.Maximum = Convert.ToInt32(total_run_time - 8); })); // Amount of Seconds Checkable (minus the first and last 4 seconds of padding data for orientation)

                decimal usable_time = total_run_time - 8;
                this.Invoke(new MethodInvoker(delegate { label59.Text = "0/" + usable_time; })); // Progress Count

                double starting_time = Convert.ToDouble(Variables.opened_data.First()[0]);
                double ending_time = Convert.ToDouble(Variables.opened_data.Last()[0]);

                int falls_found = 0;

                decimal current_position = 0;

                int positions_fallen = 0;

                int latest_body_position = 100;
                int latest_fall_position = 100;

                while (current_position <= usable_time)
                {
                    List<string[]> CurrentData = new List<string[]>();
                    foreach (string[] entry in Variables.opened_data)
                    {
                        // If in time range needed, add to CurrentData for processing
                        if (Convert.ToDouble(entry[0]) >= (starting_time + Convert.ToDouble(current_position * 1000)) && Convert.ToDouble(entry[0]) <= (starting_time + ((Convert.ToDouble(current_position * 1000) + 9000))))
                        {
                            CurrentData.Add(entry);
                        }
                    }

                    // Categorise Data Into Time Based Sections
                    List<string[]> Data_Before = new List<string[]>();
                    List<string[]> Data_During = new List<string[]>();
                    List<string[]> Data_After = new List<string[]>();

                    // Time to compare against
                    double comparetime = Convert.ToDouble(CurrentData.Last()[0]);

                    // Before (9000ms - 5000ms)
                    double time_before1 = comparetime - 9000;
                    double time_before2 = comparetime - 5000;
                    foreach (string[] dataentry in CurrentData.ToList())
                    {
                        double storedtime = Convert.ToDouble(dataentry[0]);
                        if (storedtime <= time_before2 && storedtime >= time_before1)
                        {
                            // In Range, add to list. 
                            Data_Before.Add(dataentry);
                        }
                    }

                    // During (5000ms - 4000ms)
                    double time_during1 = comparetime - 4999;
                    double time_during2 = comparetime - 4000;
                    foreach (string[] dataentry in CurrentData.ToList())
                    {
                        double storedtime = Convert.ToDouble(dataentry[0]);
                        if (storedtime <= time_during2 && storedtime >= time_during1)
                        {
                            // In Range, add to list. 
                            Data_During.Add(dataentry);
                        }
                    }

                    // After (4000ms - 0ms)
                    double time_after1 = comparetime - 3999;
                    double time_after2 = comparetime - 0;
                    foreach (string[] dataentry in CurrentData.ToList())
                    {
                        double storedtime = Convert.ToDouble(dataentry[0]);
                        if (storedtime <= time_after2 && storedtime >= time_after1)
                        {
                            // In Range, add to list.
                            Data_After.Add(dataentry);
                        }
                    }

                    // Calculate Avg for each Axis. 
                    double acc_x_avg = 0;
                    double acc_y_avg = 0;
                    double acc_z_avg = 0;

                    double acc_x_temp = 0;
                    double acc_y_temp = 0;
                    double acc_z_temp = 0;

                    foreach (string[] dataentry in Data_During.ToList())
                    {
                        acc_x_temp += Convert.ToDouble(dataentry[1]);
                        acc_y_temp += Convert.ToDouble(dataentry[2]);
                        acc_z_temp += Convert.ToDouble(dataentry[3]);
                    }

                    int datacount = Data_During.Count();

                    acc_x_avg = acc_x_temp / datacount;
                    acc_y_avg = acc_y_temp / datacount;
                    acc_z_avg = acc_z_temp / datacount;

                    // Stage 1. Go through each packet, determine total delta accross all axis (XYZ). 
                    int acc_triggers = 0;
                    double during_max_acc = 0;
                    foreach (string[] dataentry in Data_During.ToList())
                    {
                        double acc_x = Convert.ToDouble(dataentry[1]);
                        double acc_y = Convert.ToDouble(dataentry[2]);
                        double acc_z = Convert.ToDouble(dataentry[3]);

                        // Calculate XYZ Delta
                        double acc_x_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_x), Convert.ToDecimal(acc_x_avg)));
                        double acc_y_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_y), Convert.ToDecimal(acc_y_avg)));
                        double acc_z_delta = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_z), Convert.ToDecimal(acc_z_avg)));


                        double acc_x_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_x), 0));
                        double acc_y_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_y), 0));
                        double acc_z_zero = Convert.ToDouble(CalculateRotateDiff(Convert.ToDecimal(acc_z), 0));

                        double totalacc = acc_x_zero + acc_y_zero + acc_z_zero;
                        double totaldelta = acc_x_delta + acc_y_delta + acc_z_delta;
                        double totaldelta_rounded = Math.Round(totaldelta, 2);

                        this.Invoke(new MethodInvoker(delegate
                        {
                            // Ensures the maximum acceleration is shown during each second. 
                            if (totalacc > during_max_acc)
                            {
                                during_max_acc = totalacc;
                                label98.Text = totalacc.ToString();
                                aGauge6.Value = Convert.ToInt32(totalacc);
                            }                            
                        }));

                        // Store Acceleration
                        this.Invoke(new MethodInvoker(delegate
                        {
                            if (label70.Text == "...")
                            {
                                label70.Text = totaldelta_rounded.ToString();
                                aGauge1.Value = Convert.ToInt32(totaldelta_rounded);
                            }
                            if (Convert.ToDouble(label70.Text) < totaldelta_rounded)
                            {
                                label70.Text = totaldelta_rounded.ToString();
                                aGauge1.Value = Convert.ToInt32(totaldelta_rounded);
                            }

                            if (totaldelta >= Convert.ToDouble(numericUpDown1.Value))
                            {
                                acc_triggers += 1;
                            }
                        }));
                    }

                    // Zero the starting direction from the prefall.
                    decimal ori_z_start = Convert.ToDecimal(Data_Before.First()[9]);

                    // Stage 2. Check Body Orientation.
                    // Body Position After Fall

                    foreach (string[] dataentry in Data_After.ToList())
                    {
                        // Body Position Calculation

                        // Zero the starting direction from the prefall based on the before-fall direction.
                        decimal adjusted_ori_z = orientation_compensation(ori_z_start, Convert.ToDecimal(dataentry[9]));

                        int bodyposition = CalculateBodyPosition(Convert.ToDecimal(dataentry[7]), Convert.ToDecimal(dataentry[8]), adjusted_ori_z);
                        latest_body_position = bodyposition;
                        if (ConvertBodyPositionToBool(bodyposition))
                        {
                            positions_fallen++;
                            latest_fall_position = bodyposition;
                        }
                    }

                    // If the latest fall position is unset, set it.
                    if (latest_fall_position == 100)
                    {
                        latest_fall_position = latest_body_position;
                    }

                    // Set Orientation Trigger Checkboxes
                    this.Invoke(new MethodInvoker(delegate
                    {
                        label51.Text = ConvertBodyPositionToText(latest_body_position);
                        if (ConvertBodyPositionToBool(latest_body_position))
                        {
                            checkBox9.Checked = true;
                        }
                        else {
                            checkBox9.Checked = false;
                        }
                    }));

                    if (acc_triggers >= 1)
                    {
                        this.Invoke(new MethodInvoker(delegate { checkBox8.Checked = true; }));

                        if (positions_fallen >= 1)
                        {
                            falls_found++;
                            bool paused = false;
                            this.Invoke(new MethodInvoker(delegate
                            {
                                label55.Text = ConvertBodyPositionToText(latest_fall_position);
                                label81.Text = falls_found.ToString();
                                label56.Text = "Yes";

                                if (checkBox7.Checked)
                                {
                                    // Pause on fall detected.
                                    paused = true;
                                    button14.Enabled = true;
                                    Variables.fall_analysis_paused = true;
                                    button12.Enabled = false; // Disable Stop Button while Paused
                                }
                            }));

                            if (paused)
                            {
                                while (Variables.fall_analysis_paused)
                                {
                                    Thread.Sleep(500);
                                }
                            }
                        }
                    }
                    else
                    {
                        // No Fall Detected
                        this.Invoke(new MethodInvoker(delegate {
                            label56.Text = "No";
                            checkBox8.Checked = false;
                        }));
                            
                    }

                    // Set Current Position
                    this.Invoke(new MethodInvoker(delegate
                    {
                        progressBar1.Value = Convert.ToInt32(current_position);
                        label59.Text = current_position + "/" + usable_time;
                    }));

                    this.Invoke(new MethodInvoker(delegate
                    {
                        foreach (string[] dataentry in Data_During.ToList()) {
                            // Set Gauge Values
                            label96.Text = Convert.ToDecimal(dataentry[7]).ToString();
                            aGauge5.Value = Convert.ToInt32(Math.Round(Convert.ToDecimal(dataentry[7]), 2));

                            label94.Text = Convert.ToDecimal(dataentry[8]).ToString();
                            aGauge4.Value = Convert.ToInt32(Math.Round(Convert.ToDecimal(dataentry[8]), 2));

                            label93.Text = Convert.ToDecimal(dataentry[9]).ToString();
                            aGauge3.Value = Convert.ToInt32(Math.Round(Convert.ToDecimal(dataentry[9]), 2));

                            // Store Maximum Pitch
                            decimal ori_y = CalculateRotateDiff(Math.Round(Convert.ToDecimal(dataentry[8]), 2), 0);
                            if (label73.Text == "...")
                            {
                                label73.Text = ori_y.ToString();
                                aGauge2.Value = Convert.ToInt32(ori_y);
                            }
                            if (Convert.ToDecimal(label73.Text) < ori_y)
                            {
                                label73.Text = ori_y.ToString();
                                aGauge2.Value = Convert.ToInt32(ori_y);
                            }

                            // Set Date and Time
                            DateTime time = new DateTime(1970, 1, 1).AddMilliseconds(Convert.ToDouble(dataentry[0]));
                            label75.Text = time.Year + "/" + time.Month + "/" + time.Day;
                            label79.Text = time.Hour + ":" + time.Minute + ":" + time.Second;
                        }
                    }));

                    if (AnalyseFileWorker.CancellationPending) {
                        break;
                    }

                    // Go to Next Second for Processing
                    CurrentData.Clear();
                    current_position++;

                    // If Live Mode is enabled, wait 1 second between each second. 
                    bool doiwait = false;
                    this.Invoke(new MethodInvoker(delegate { doiwait = checkBox10.Checked; }));
                    if (doiwait)
                    {
                        Thread.Sleep(1000);
                    }
                }

                this.Invoke(new MethodInvoker(delegate {
                    // Disable the Close Button
                    button13.Enabled = true;

                    // Set Buttons Text
                    button12.Text = "Run Analysis";

                    numericUpDown1.Enabled = true;
                }));

                return;
            }
        }

        private void GPSWaiter_DoWork(object sender, DoWorkEventArgs e)
        {
            // Wait until the GPS Fix has been located
            this.Invoke(new MethodInvoker(delegate {
                panel7.BringToFront();
                panel3.Visible = true;
                this.Update();
            }));

            // Start Data Collector
            DataCollector.RunWorkerAsync();

            // Wait for GPS Fix
            while (Variables.latest_gpsfetch == 0) {
                Thread.Sleep(500);
            }

            // GPS Fix Locked
            this.Invoke(new MethodInvoker(delegate {
                // Reset Orientation Alignment on Startup (Orientation XYZ back to 0).
                _measuringDevice.resetOrientation(XsResetMethod.XRM_Alignment);

                // Show Main Panel
                panel2.BringToFront();

                // If AutoStart Fall Detection is enabled
                if (checkBox11.Checked) {
                    // Start Fall Detection
                    ToggleFallDetection();
                }
                
                this.Update();
            }));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Resume file analysis
            button14.Enabled = false;
            Variables.fall_analysis_paused = false;
            button12.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Save Settings Button
            SaveSettings();
        }

        private void SaveSettings() {
            this.Invoke(new MethodInvoker(delegate {
                button15.Enabled = false;
                button15.Text = "Saving...";
                // Save Settings
                string[] settings_array = new string[9];
                settings_array[0] = acc_threshold.Value.ToString(); // setting_acc_threshold
                settings_array[1] = checkBox11.Checked.ToString(); // setting_auto_start_fall_detection
                settings_array[2] = checkBox1.Checked.ToString(); // setting_record_falls_to_file
                settings_array[3] = checkBox2.Checked.ToString(); // setting_trigger_alerts_on_fall
                settings_array[4] = checkBox3.Checked.ToString(); // setting_trigger_sound
                settings_array[5] = checkBox5.Checked.ToString(); // setting_trigger_diagnostic_log
                settings_array[6] = checkBox4.Checked.ToString(); // setting_trigger_text_file
                settings_array[7] = checkBox6.Checked.ToString(); // setting_trigger_http_get
                settings_array[8] = textBox2.Text; // setting_trigger_http_url

                try
                {
                    SerializeObject(settings_array, "EFAS.settings");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Could not save settings!\nReason: " + err.Message);
                }

                button15.Text = "Save Settings";
                button15.Enabled = true;
            }));
        }

        public void LoadSettings(string[] settings_array)
        {
            this.Invoke(new MethodInvoker(delegate {
                try
                {
                    // Load Settings
                    acc_threshold.Value = Convert.ToInt32(settings_array[0]); // setting_acc_threshold
                    checkBox11.Checked = Convert.ToBoolean(settings_array[1]); // setting_auto_start_fall_detection
                    checkBox1.Checked = Convert.ToBoolean(settings_array[2]); // setting_record_falls_to_file
                    checkBox2.Checked = Convert.ToBoolean(settings_array[3]); // setting_trigger_alerts_on_fall
                    checkBox3.Checked = Convert.ToBoolean(settings_array[4]); // setting_trigger_sound
                    checkBox5.Checked = Convert.ToBoolean(settings_array[5]); // setting_trigger_diagnostic_log
                    checkBox4.Checked = Convert.ToBoolean(settings_array[6]); // setting_trigger_text_file
                    checkBox6.Checked = Convert.ToBoolean(settings_array[7]); // setting_trigger_http_get
                    textBox2.Text = settings_array[8]; // setting_trigger_http_url
                }
                catch (Exception err){
                    MessageBox.Show("Error: Could not load settings.\nReason: " + err.Message);
                }
            }));
            return;
        }
    }
}
