namespace EFAS
{
    partial class Startup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch {
                // Tried doing GUI operations while program was closing. 
                // Program should be closed now.
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.XSensFinder = new System.ComponentModel.BackgroundWorker();
            this.DataCollector = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sensor_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sensor_address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sensor_baud = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.gauge_ori_z = new System.Windows.Forms.AGauge();
            this.gauge_ori_y = new System.Windows.Forms.AGauge();
            this.gauge_ori_x = new System.Windows.Forms.AGauge();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ori_z = new System.Windows.Forms.Label();
            this.ori_y = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ori_x = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gyr_z = new System.Windows.Forms.Label();
            this.gyr_y = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gyr_x = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.acc_z = new System.Windows.Forms.Label();
            this.acc_y = new System.Windows.Forms.Label();
            this.acc_x = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.acc_threshold = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diagbox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.FallChecker = new System.ComponentModel.BackgroundWorker();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GPS_Checker = new System.ComponentModel.BackgroundWorker();
            this.label28 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.calibration_progressbar = new System.Windows.Forms.ProgressBar();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.CalibrationWaiter = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.ManualRecorder = new System.ComponentModel.BackgroundWorker();
            this.AnalyseFileDiaglog = new System.Windows.Forms.OpenFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.label51 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.label76 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.aGauge6 = new System.Windows.Forms.AGauge();
            this.aGauge3 = new System.Windows.Forms.AGauge();
            this.aGauge4 = new System.Windows.Forms.AGauge();
            this.aGauge5 = new System.Windows.Forms.AGauge();
            this.label97 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label62 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.AnalyseFileWorker = new System.ComponentModel.BackgroundWorker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.GPSWaiter = new System.ComponentModel.BackgroundWorker();
            this.button15 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_threshold)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(283, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Searching for XSens Sensor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elderly Fall Alert System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 539);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(867, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Searching";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::EFAS.Properties.Resources.Mti_g_700;
            this.pictureBox6.Location = new System.Drawing.Point(578, 75);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(191, 156);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EFAS.Properties.Resources.Mti_g_700;
            this.pictureBox5.Location = new System.Drawing.Point(220, 75);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(191, 153);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(441, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 28);
            this.button7.TabIndex = 9;
            this.button7.Text = "No Sensor Mode";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EFAS.Properties.Resources.Spinner_1_6s_200px;
            this.pictureBox2.Location = new System.Drawing.Point(418, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // XSensFinder
            // 
            this.XSensFinder.WorkerSupportsCancellation = true;
            this.XSensFinder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.XSensFinder_DoWork);
            // 
            // DataCollector
            // 
            this.DataCollector.WorkerSupportsCancellation = true;
            this.DataCollector.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataCollector_DoWork);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(81, 53);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(66, 20);
            this.status.TabIndex = 8;
            this.status.Text = "Loading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sensor ID:";
            // 
            // sensor_id
            // 
            this.sensor_id.AutoSize = true;
            this.sensor_id.Location = new System.Drawing.Point(113, 25);
            this.sensor_id.Name = "sensor_id";
            this.sensor_id.Size = new System.Drawing.Size(81, 20);
            this.sensor_id.TabIndex = 8;
            this.sensor_id.Text = "Sensor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address:";
            // 
            // sensor_address
            // 
            this.sensor_address.AutoSize = true;
            this.sensor_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor_address.Location = new System.Drawing.Point(114, 76);
            this.sensor_address.Name = "sensor_address";
            this.sensor_address.Size = new System.Drawing.Size(93, 15);
            this.sensor_address.TabIndex = 8;
            this.sensor_address.Text = "Sensor Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud Rate:";
            // 
            // sensor_baud
            // 
            this.sensor_baud.AutoSize = true;
            this.sensor_baud.Location = new System.Drawing.Point(113, 51);
            this.sensor_baud.Name = "sensor_baud";
            this.sensor_baud.Size = new System.Drawing.Size(141, 20);
            this.sensor_baud.TabIndex = 8;
            this.sensor_baud.Text = "Sensor Baud Rate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 539);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EFAS.Properties.Resources.icons8_Falling_Man_100px__2_;
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(837, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 35);
            this.button6.TabIndex = 3;
            this.button6.Text = "Manual Record";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(671, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Analyse Recording";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(299, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fall Detection (Off)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 481);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox9.Location = new System.Drawing.Point(359, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(584, 161);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Fall Detection Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(70, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Body Direction:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(192, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(192, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(46, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Total Acceleration:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.gauge_ori_z);
            this.groupBox7.Controls.Add(this.gauge_ori_y);
            this.groupBox7.Controls.Add(this.gauge_ori_x);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.ori_z);
            this.groupBox7.Controls.Add(this.ori_y);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.ori_x);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(9, 170);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(937, 272);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Orientation";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(466, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Right";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(365, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 20);
            this.label34.TabIndex = 0;
            this.label34.Text = "Down";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(137, 57);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 20);
            this.label36.TabIndex = 0;
            this.label36.Text = "Roll R";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(689, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(189, 35);
            this.button11.TabIndex = 3;
            this.button11.Text = "Orientation Reset";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(10, 57);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 20);
            this.label35.TabIndex = 0;
            this.label35.Text = "Roll L";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(259, 57);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "Up";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(589, 57);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 20);
            this.label31.TabIndex = 0;
            this.label31.Text = "Left";
            // 
            // gauge_ori_z
            // 
            this.gauge_ori_z.BackColor = System.Drawing.Color.White;
            this.gauge_ori_z.BaseArcColor = System.Drawing.Color.Gray;
            this.gauge_ori_z.BaseArcRadius = 80;
            this.gauge_ori_z.BaseArcStart = 90;
            this.gauge_ori_z.BaseArcSweep = 360;
            this.gauge_ori_z.BaseArcWidth = 1;
            this.gauge_ori_z.Center = new System.Drawing.Point(105, 100);
            this.gauge_ori_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_ori_z.Location = new System.Drawing.Point(443, 62);
            this.gauge_ori_z.MaxValue = 180F;
            this.gauge_ori_z.MinValue = -180F;
            this.gauge_ori_z.Name = "gauge_ori_z";
            this.gauge_ori_z.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gauge_ori_z.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gauge_ori_z.NeedleRadius = 80;
            this.gauge_ori_z.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gauge_ori_z.NeedleWidth = 2;
            this.gauge_ori_z.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gauge_ori_z.ScaleLinesInterInnerRadius = 73;
            this.gauge_ori_z.ScaleLinesInterOuterRadius = 80;
            this.gauge_ori_z.ScaleLinesInterWidth = 3;
            this.gauge_ori_z.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gauge_ori_z.ScaleLinesMajorInnerRadius = 70;
            this.gauge_ori_z.ScaleLinesMajorOuterRadius = 80;
            this.gauge_ori_z.ScaleLinesMajorStepValue = 30F;
            this.gauge_ori_z.ScaleLinesMajorWidth = 1;
            this.gauge_ori_z.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gauge_ori_z.ScaleLinesMinorInnerRadius = 75;
            this.gauge_ori_z.ScaleLinesMinorOuterRadius = 80;
            this.gauge_ori_z.ScaleLinesMinorTicks = 0;
            this.gauge_ori_z.ScaleLinesMinorWidth = 2;
            this.gauge_ori_z.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gauge_ori_z.ScaleNumbersFormat = "#°";
            this.gauge_ori_z.ScaleNumbersRadius = 90;
            this.gauge_ori_z.ScaleNumbersRotation = 0;
            this.gauge_ori_z.ScaleNumbersStartScaleLine = 2;
            this.gauge_ori_z.ScaleNumbersStepScaleLines = 1;
            this.gauge_ori_z.Size = new System.Drawing.Size(211, 205);
            this.gauge_ori_z.TabIndex = 3;
            this.gauge_ori_z.Text = "gauge_ori_x";
            this.gauge_ori_z.Value = 0F;
            // 
            // gauge_ori_y
            // 
            this.gauge_ori_y.BackColor = System.Drawing.Color.White;
            this.gauge_ori_y.BaseArcColor = System.Drawing.Color.Gray;
            this.gauge_ori_y.BaseArcRadius = 80;
            this.gauge_ori_y.BaseArcStart = 90;
            this.gauge_ori_y.BaseArcSweep = 360;
            this.gauge_ori_y.BaseArcWidth = 1;
            this.gauge_ori_y.Center = new System.Drawing.Point(105, 100);
            this.gauge_ori_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_ori_y.Location = new System.Drawing.Point(226, 62);
            this.gauge_ori_y.MaxValue = 180F;
            this.gauge_ori_y.MinValue = -180F;
            this.gauge_ori_y.Name = "gauge_ori_y";
            this.gauge_ori_y.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gauge_ori_y.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gauge_ori_y.NeedleRadius = 80;
            this.gauge_ori_y.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gauge_ori_y.NeedleWidth = 2;
            this.gauge_ori_y.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gauge_ori_y.ScaleLinesInterInnerRadius = 73;
            this.gauge_ori_y.ScaleLinesInterOuterRadius = 80;
            this.gauge_ori_y.ScaleLinesInterWidth = 3;
            this.gauge_ori_y.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gauge_ori_y.ScaleLinesMajorInnerRadius = 70;
            this.gauge_ori_y.ScaleLinesMajorOuterRadius = 80;
            this.gauge_ori_y.ScaleLinesMajorStepValue = 30F;
            this.gauge_ori_y.ScaleLinesMajorWidth = 1;
            this.gauge_ori_y.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gauge_ori_y.ScaleLinesMinorInnerRadius = 75;
            this.gauge_ori_y.ScaleLinesMinorOuterRadius = 80;
            this.gauge_ori_y.ScaleLinesMinorTicks = 0;
            this.gauge_ori_y.ScaleLinesMinorWidth = 2;
            this.gauge_ori_y.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gauge_ori_y.ScaleNumbersFormat = "#°";
            this.gauge_ori_y.ScaleNumbersRadius = 90;
            this.gauge_ori_y.ScaleNumbersRotation = 0;
            this.gauge_ori_y.ScaleNumbersStartScaleLine = 2;
            this.gauge_ori_y.ScaleNumbersStepScaleLines = 1;
            this.gauge_ori_y.Size = new System.Drawing.Size(211, 205);
            this.gauge_ori_y.TabIndex = 3;
            this.gauge_ori_y.Text = "gauge_ori_x";
            this.gauge_ori_y.Value = 0F;
            // 
            // gauge_ori_x
            // 
            this.gauge_ori_x.BackColor = System.Drawing.Color.White;
            this.gauge_ori_x.BaseArcColor = System.Drawing.Color.Gray;
            this.gauge_ori_x.BaseArcRadius = 80;
            this.gauge_ori_x.BaseArcStart = 90;
            this.gauge_ori_x.BaseArcSweep = 360;
            this.gauge_ori_x.BaseArcWidth = 1;
            this.gauge_ori_x.Center = new System.Drawing.Point(105, 100);
            this.gauge_ori_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_ori_x.Location = new System.Drawing.Point(6, 62);
            this.gauge_ori_x.MaxValue = 180F;
            this.gauge_ori_x.MinValue = -180F;
            this.gauge_ori_x.Name = "gauge_ori_x";
            this.gauge_ori_x.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.gauge_ori_x.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gauge_ori_x.NeedleRadius = 80;
            this.gauge_ori_x.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gauge_ori_x.NeedleWidth = 2;
            this.gauge_ori_x.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gauge_ori_x.ScaleLinesInterInnerRadius = 73;
            this.gauge_ori_x.ScaleLinesInterOuterRadius = 80;
            this.gauge_ori_x.ScaleLinesInterWidth = 3;
            this.gauge_ori_x.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gauge_ori_x.ScaleLinesMajorInnerRadius = 70;
            this.gauge_ori_x.ScaleLinesMajorOuterRadius = 80;
            this.gauge_ori_x.ScaleLinesMajorStepValue = 30F;
            this.gauge_ori_x.ScaleLinesMajorWidth = 1;
            this.gauge_ori_x.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gauge_ori_x.ScaleLinesMinorInnerRadius = 75;
            this.gauge_ori_x.ScaleLinesMinorOuterRadius = 80;
            this.gauge_ori_x.ScaleLinesMinorTicks = 0;
            this.gauge_ori_x.ScaleLinesMinorWidth = 2;
            this.gauge_ori_x.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gauge_ori_x.ScaleNumbersFormat = "#°";
            this.gauge_ori_x.ScaleNumbersRadius = 90;
            this.gauge_ori_x.ScaleNumbersRotation = 0;
            this.gauge_ori_x.ScaleNumbersStartScaleLine = 2;
            this.gauge_ori_x.ScaleNumbersStepScaleLines = 1;
            this.gauge_ori_x.Size = new System.Drawing.Size(211, 205);
            this.gauge_ori_x.TabIndex = 3;
            this.gauge_ori_x.Text = "gauge_ori_x";
            this.gauge_ori_x.Value = 0F;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(500, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Z:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(283, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Y:";
            // 
            // ori_z
            // 
            this.ori_z.AutoSize = true;
            this.ori_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ori_z.Location = new System.Drawing.Point(533, 29);
            this.ori_z.Name = "ori_z";
            this.ori_z.Size = new System.Drawing.Size(30, 25);
            this.ori_z.TabIndex = 0;
            this.ori_z.Text = "...";
            // 
            // ori_y
            // 
            this.ori_y.AutoSize = true;
            this.ori_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ori_y.Location = new System.Drawing.Point(318, 29);
            this.ori_y.Name = "ori_y";
            this.ori_y.Size = new System.Drawing.Size(30, 25);
            this.ori_y.TabIndex = 0;
            this.ori_y.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(65, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "X:";
            // 
            // ori_x
            // 
            this.ori_x.AutoSize = true;
            this.ori_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ori_x.Location = new System.Drawing.Point(99, 29);
            this.ori_x.Name = "ori_x";
            this.ori_x.Size = new System.Drawing.Size(30, 25);
            this.ori_x.TabIndex = 0;
            this.ori_x.Text = "...";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.gyr_z);
            this.groupBox6.Controls.Add(this.gyr_y);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.gyr_x);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(9, 88);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 76);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gyroscope";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Z:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Y:";
            // 
            // gyr_z
            // 
            this.gyr_z.AutoSize = true;
            this.gyr_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyr_z.Location = new System.Drawing.Point(259, 29);
            this.gyr_z.Name = "gyr_z";
            this.gyr_z.Size = new System.Drawing.Size(30, 25);
            this.gyr_z.TabIndex = 0;
            this.gyr_z.Text = "...";
            // 
            // gyr_y
            // 
            this.gyr_y.AutoSize = true;
            this.gyr_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyr_y.Location = new System.Drawing.Point(155, 29);
            this.gyr_y.Name = "gyr_y";
            this.gyr_y.Size = new System.Drawing.Size(30, 25);
            this.gyr_y.TabIndex = 0;
            this.gyr_y.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "X:";
            // 
            // gyr_x
            // 
            this.gyr_x.AutoSize = true;
            this.gyr_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyr_x.Location = new System.Drawing.Point(53, 29);
            this.gyr_x.Name = "gyr_x";
            this.gyr_x.Size = new System.Drawing.Size(30, 25);
            this.gyr_x.TabIndex = 0;
            this.gyr_x.Text = "...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.acc_z);
            this.groupBox5.Controls.Add(this.acc_y);
            this.groupBox5.Controls.Add(this.acc_x);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 76);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Accelerometer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(226, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Z:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Y:";
            // 
            // acc_z
            // 
            this.acc_z.AutoSize = true;
            this.acc_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_z.Location = new System.Drawing.Point(263, 29);
            this.acc_z.Name = "acc_z";
            this.acc_z.Size = new System.Drawing.Size(30, 25);
            this.acc_z.TabIndex = 0;
            this.acc_z.Text = "...";
            // 
            // acc_y
            // 
            this.acc_y.AutoSize = true;
            this.acc_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_y.Location = new System.Drawing.Point(159, 29);
            this.acc_y.Name = "acc_y";
            this.acc_y.Size = new System.Drawing.Size(30, 25);
            this.acc_y.TabIndex = 0;
            this.acc_y.Text = "...";
            // 
            // acc_x
            // 
            this.acc_x.AutoSize = true;
            this.acc_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_x.Location = new System.Drawing.Point(57, 29);
            this.acc_x.Name = "acc_x";
            this.acc_x.Size = new System.Drawing.Size(30, 25);
            this.acc_x.TabIndex = 0;
            this.acc_x.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "X:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(680, 80);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 20);
            this.label37.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 448);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.acc_threshold);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thresholds";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(134, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "m/s2";
            // 
            // acc_threshold
            // 
            this.acc_threshold.Location = new System.Drawing.Point(23, 67);
            this.acc_threshold.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acc_threshold.Name = "acc_threshold";
            this.acc_threshold.Size = new System.Drawing.Size(109, 26);
            this.acc_threshold.TabIndex = 0;
            this.acc_threshold.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(32, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Total Acceleration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(212, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(22, 40);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(203, 24);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "Auto Start Fall Detection";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(22, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(165, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Trigger Alert on Fall";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(22, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Record Falls to File (Path: /falls/)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(212, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 239);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alert";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "http://127.0.0.1/fall_found.php";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(22, 172);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(99, 24);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "HTTP Get";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(22, 142);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 24);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Text File (/alert_text_files/)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(22, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Test Alert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(22, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(175, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Diagnostic Log Entry";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(22, 82);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(222, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Sound (/trigger_sound.wav)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.diagbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(952, 448);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Diagnostics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Controls.Add(this.label53);
            this.groupBox10.Location = new System.Drawing.Point(3, 109);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(651, 94);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Live Packet Estimations";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(21, 25);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(109, 20);
            this.label52.TabIndex = 8;
            this.label52.Text = "Body Position:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(136, 25);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(21, 20);
            this.label53.TabIndex = 8;
            this.label53.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sensor_baud);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sensor_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.sensor_address);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connected Sensor";
            // 
            // diagbox
            // 
            this.diagbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagbox.Location = new System.Drawing.Point(3, 209);
            this.diagbox.MaxLength = 999999999;
            this.diagbox.Multiline = true;
            this.diagbox.Name = "diagbox";
            this.diagbox.ReadOnly = true;
            this.diagbox.Size = new System.Drawing.Size(946, 236);
            this.diagbox.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(92, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Latitude:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(79, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Longitude:";
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude.Location = new System.Drawing.Point(169, 30);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(21, 20);
            this.latitude.TabIndex = 0;
            this.latitude.Text = "...";
            // 
            // longitude
            // 
            this.longitude.AutoSize = true;
            this.longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitude.Location = new System.Drawing.Point(169, 3);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(21, 20);
            this.longitude.TabIndex = 0;
            this.longitude.Text = "...";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(884, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FallChecker
            // 
            this.FallChecker.WorkerSupportsCancellation = true;
            this.FallChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FallChecker_DoWork);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 29);
            this.label27.TabIndex = 8;
            this.label27.Text = "0";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(78, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(286, 29);
            this.label30.TabIndex = 8;
            this.label30.Text = "Searching for GPS";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.longitude);
            this.panel3.Controls.Add(this.latitude);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Location = new System.Drawing.Point(618, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 85);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EFAS.Properties.Resources.icons8_Satellite_104px_1;
            this.pictureBox3.Location = new System.Drawing.Point(6, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // GPS_Checker
            // 
            this.GPS_Checker.WorkerSupportsCancellation = true;
            this.GPS_Checker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GPS_Checker_DoWork);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Location = new System.Drawing.Point(-5, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(1000, 3);
            this.label28.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.calibration_progressbar);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 539);
            this.panel4.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(459, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 33);
            this.button8.TabIndex = 2;
            this.button8.Text = "Skip";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // calibration_progressbar
            // 
            this.calibration_progressbar.Location = new System.Drawing.Point(211, 167);
            this.calibration_progressbar.Maximum = 20;
            this.calibration_progressbar.Name = "calibration_progressbar";
            this.calibration_progressbar.Size = new System.Drawing.Size(573, 29);
            this.calibration_progressbar.Step = 1;
            this.calibration_progressbar.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(223, 214);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(548, 20);
            this.label40.TabIndex = 0;
            this.label40.Text = "During the next 20 seconds, Active Heading Stabilization (AHS) will calibrate.";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(373, 105);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(248, 37);
            this.label39.TabIndex = 0;
            this.label39.Text = "Please Hold Still";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(301, 42);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(392, 37);
            this.label38.TabIndex = 0;
            this.label38.Text = "Sensor is being Calibrated";
            // 
            // CalibrationWaiter
            // 
            this.CalibrationWaiter.WorkerSupportsCancellation = true;
            this.CalibrationWaiter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CalibrationWaiter_DoWork);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.groupBox8);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.label42);
            this.panel5.Controls.Add(this.label41);
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(986, 539);
            this.panel5.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(358, 90);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.label49);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.label48);
            this.groupBox8.Controls.Add(this.label47);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(386, 193);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(214, 199);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(92, 179);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(116, 20);
            this.label50.TabIndex = 8;
            this.label50.Text = "Future Feature";
            this.label50.Visible = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(92, 147);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(21, 20);
            this.label46.TabIndex = 8;
            this.label46.Text = "...";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(92, 115);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(21, 20);
            this.label44.TabIndex = 8;
            this.label44.Text = "...";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(10, 179);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(76, 20);
            this.label49.TabIndex = 8;
            this.label49.Text = "Est. Size:";
            this.label49.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(10, 147);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(76, 20);
            this.label45.TabIndex = 8;
            this.label45.Text = "Seconds:";
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(7, 61);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(200, 36);
            this.label48.TabIndex = 8;
            this.label48.Text = "Idle";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(71, 33);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(73, 25);
            this.label47.TabIndex = 8;
            this.label47.Text = "Status";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(16, 115);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(70, 20);
            this.label43.TabIndex = 8;
            this.label43.Text = "Packets:";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(411, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 33);
            this.button10.TabIndex = 2;
            this.button10.Text = "Start Recording";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(837, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 33);
            this.button9.TabIndex = 2;
            this.button9.Text = "Go Back";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(174, 93);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(178, 25);
            this.label42.TabIndex = 8;
            this.label42.Text = "Recording Name:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label41.Location = new System.Drawing.Point(355, 30);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(276, 37);
            this.label41.TabIndex = 8;
            this.label41.Text = "Manual Recording";
            // 
            // ManualRecorder
            // 
            this.ManualRecorder.WorkerSupportsCancellation = true;
            this.ManualRecorder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ManualRecorder_DoWork);
            // 
            // AnalyseFileDiaglog
            // 
            this.AnalyseFileDiaglog.FileName = "openFileDialog1";
            this.AnalyseFileDiaglog.Filter = "EFAS Data File|*.efas";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox11);
            this.panel6.Controls.Add(this.checkBox10);
            this.panel6.Controls.Add(this.checkBox7);
            this.panel6.Controls.Add(this.groupBox13);
            this.panel6.Controls.Add(this.groupBox12);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Controls.Add(this.button13);
            this.panel6.Controls.Add(this.label62);
            this.panel6.Controls.Add(this.label69);
            this.panel6.Location = new System.Drawing.Point(0, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(986, 539);
            this.panel6.TabIndex = 14;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.numericUpDown1);
            this.groupBox11.Location = new System.Drawing.Point(738, 66);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(231, 100);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Threshold";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(145, 59);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(43, 20);
            this.label57.TabIndex = 13;
            this.label57.Text = "m/s2";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(43, 29);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(136, 20);
            this.label58.TabIndex = 15;
            this.label58.Text = "Total Acceleration";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 60);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(459, 139);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(76, 17);
            this.checkBox10.TabIndex = 19;
            this.checkBox10.Text = "Live Mode";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(349, 139);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(90, 17);
            this.checkBox7.TabIndex = 19;
            this.checkBox7.Text = "Pause on Fall";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.progressBar1);
            this.groupBox13.Controls.Add(this.button14);
            this.groupBox13.Controls.Add(this.tabControl2);
            this.groupBox13.Location = new System.Drawing.Point(19, 172);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(950, 354);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(837, 33);
            this.progressBar1.TabIndex = 12;
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(852, 16);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 33);
            this.button14.TabIndex = 11;
            this.button14.Text = "Resume";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(9, 54);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(931, 294);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox9);
            this.tabPage4.Controls.Add(this.label80);
            this.tabPage4.Controls.Add(this.label77);
            this.tabPage4.Controls.Add(this.label71);
            this.tabPage4.Controls.Add(this.label79);
            this.tabPage4.Controls.Add(this.checkBox8);
            this.tabPage4.Controls.Add(this.label75);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.label61);
            this.tabPage4.Controls.Add(this.label73);
            this.tabPage4.Controls.Add(this.label72);
            this.tabPage4.Controls.Add(this.label60);
            this.tabPage4.Controls.Add(this.label84);
            this.tabPage4.Controls.Add(this.label83);
            this.tabPage4.Controls.Add(this.label70);
            this.tabPage4.Controls.Add(this.label56);
            this.tabPage4.Controls.Add(this.aGauge2);
            this.tabPage4.Controls.Add(this.label51);
            this.tabPage4.Controls.Add(this.label78);
            this.tabPage4.Controls.Add(this.label55);
            this.tabPage4.Controls.Add(this.aGauge1);
            this.tabPage4.Controls.Add(this.label76);
            this.tabPage4.Controls.Add(this.label82);
            this.tabPage4.Controls.Add(this.label59);
            this.tabPage4.Controls.Add(this.label81);
            this.tabPage4.Controls.Add(this.label74);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(923, 268);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Information";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoCheck = false;
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(223, 109);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(169, 241);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(47, 20);
            this.label80.TabIndex = 8;
            this.label80.Text = "Time:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(168, 215);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(48, 20);
            this.label77.TabIndex = 8;
            this.label77.Text = "Date:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(727, 32);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(168, 20);
            this.label71.TabIndex = 8;
            this.label71.Text = "Maximum Acceleration";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(219, 241);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(21, 20);
            this.label79.TabIndex = 8;
            this.label79.Text = "...";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoCheck = false;
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(223, 79);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(219, 215);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(21, 20);
            this.label75.TabIndex = 8;
            this.label75.Text = "...";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(108, 190);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(108, 20);
            this.label54.TabIndex = 8;
            this.label54.Text = "Fall Detected:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(107, 163);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(109, 20);
            this.label61.TabIndex = 8;
            this.label61.Text = "Body Position:";
            // 
            // label73
            // 
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(542, 197);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(53, 20);
            this.label73.TabIndex = 8;
            this.label73.Text = "...";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(508, 32);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(115, 20);
            this.label72.TabIndex = 8;
            this.label72.Text = "Maximum Pitch";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(118, 135);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(98, 20);
            this.label60.TabIndex = 8;
            this.label60.Text = "Fall Position:";
            // 
            // label84
            // 
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(527, 225);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(86, 20);
            this.label84.TabIndex = 8;
            this.label84.Text = "degrees";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(781, 220);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(58, 20);
            this.label83.TabIndex = 8;
            this.label83.Text = "m/s2";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(781, 197);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(58, 20);
            this.label70.TabIndex = 8;
            this.label70.Text = "...";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(219, 190);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(21, 20);
            this.label56.TabIndex = 8;
            this.label56.Text = "...";
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.White;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(105, 100);
            this.aGauge2.Location = new System.Drawing.Point(464, 60);
            this.aGauge2.MaxValue = 90F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(215, 180);
            this.aGauge2.TabIndex = 13;
            this.aGauge2.Text = "aGauge1";
            this.aGauge2.Value = 0F;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(219, 163);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(21, 20);
            this.label51.TabIndex = 8;
            this.label51.Text = "...";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(47, 101);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(169, 25);
            this.label78.TabIndex = 8;
            this.label78.Text = "Position Trigger:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(219, 135);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(21, 20);
            this.label55.TabIndex = 8;
            this.label55.Text = "...";
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.White;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(105, 100);
            this.aGauge1.Location = new System.Drawing.Point(704, 60);
            this.aGauge1.MaxValue = 200F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(215, 180);
            this.aGauge1.TabIndex = 13;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(5, 70);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(211, 25);
            this.label76.TabIndex = 8;
            this.label76.Text = "Acceleration Trigger:";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(99, 10);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(118, 25);
            this.label82.TabIndex = 8;
            this.label82.Text = "Total Falls:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(218, 40);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(42, 25);
            this.label59.TabIndex = 8;
            this.label59.Text = "0/0";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(217, 10);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(24, 25);
            this.label81.TabIndex = 8;
            this.label81.Text = "0";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(113, 40);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(104, 25);
            this.label74.TabIndex = 8;
            this.label74.Text = "Progress:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label85);
            this.tabPage5.Controls.Add(this.label86);
            this.tabPage5.Controls.Add(this.label87);
            this.tabPage5.Controls.Add(this.label88);
            this.tabPage5.Controls.Add(this.label89);
            this.tabPage5.Controls.Add(this.label90);
            this.tabPage5.Controls.Add(this.aGauge6);
            this.tabPage5.Controls.Add(this.aGauge3);
            this.tabPage5.Controls.Add(this.aGauge4);
            this.tabPage5.Controls.Add(this.aGauge5);
            this.tabPage5.Controls.Add(this.label97);
            this.tabPage5.Controls.Add(this.label91);
            this.tabPage5.Controls.Add(this.label92);
            this.tabPage5.Controls.Add(this.label98);
            this.tabPage5.Controls.Add(this.label93);
            this.tabPage5.Controls.Add(this.label94);
            this.tabPage5.Controls.Add(this.label95);
            this.tabPage5.Controls.Add(this.label96);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(923, 268);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Gauges";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(482, 40);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(47, 20);
            this.label85.TabIndex = 4;
            this.label85.Text = "Right";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(381, 40);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(50, 20);
            this.label86.TabIndex = 5;
            this.label86.Text = "Down";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(153, 40);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(52, 20);
            this.label87.TabIndex = 6;
            this.label87.Text = "Roll R";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(26, 40);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(49, 20);
            this.label88.TabIndex = 7;
            this.label88.Text = "Roll L";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(275, 40);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(30, 20);
            this.label89.TabIndex = 8;
            this.label89.Text = "Up";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(605, 40);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(37, 20);
            this.label90.TabIndex = 9;
            this.label90.Text = "Left";
            // 
            // aGauge6
            // 
            this.aGauge6.BackColor = System.Drawing.Color.White;
            this.aGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge6.BaseArcRadius = 80;
            this.aGauge6.BaseArcStart = 135;
            this.aGauge6.BaseArcSweep = 270;
            this.aGauge6.BaseArcWidth = 1;
            this.aGauge6.Center = new System.Drawing.Point(105, 100);
            this.aGauge6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge6.Location = new System.Drawing.Point(682, 45);
            this.aGauge6.MaxValue = 200F;
            this.aGauge6.MinValue = 0F;
            this.aGauge6.Name = "aGauge6";
            this.aGauge6.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge6.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge6.NeedleRadius = 80;
            this.aGauge6.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge6.NeedleWidth = 2;
            this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleLinesInterInnerRadius = 73;
            this.aGauge6.ScaleLinesInterOuterRadius = 80;
            this.aGauge6.ScaleLinesInterWidth = 3;
            this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleLinesMajorInnerRadius = 70;
            this.aGauge6.ScaleLinesMajorOuterRadius = 80;
            this.aGauge6.ScaleLinesMajorStepValue = 25F;
            this.aGauge6.ScaleLinesMajorWidth = 1;
            this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge6.ScaleLinesMinorInnerRadius = 75;
            this.aGauge6.ScaleLinesMinorOuterRadius = 80;
            this.aGauge6.ScaleLinesMinorTicks = 0;
            this.aGauge6.ScaleLinesMinorWidth = 2;
            this.aGauge6.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge6.ScaleNumbersFormat = "";
            this.aGauge6.ScaleNumbersRadius = 90;
            this.aGauge6.ScaleNumbersRotation = 0;
            this.aGauge6.ScaleNumbersStartScaleLine = 2;
            this.aGauge6.ScaleNumbersStepScaleLines = 1;
            this.aGauge6.Size = new System.Drawing.Size(211, 205);
            this.aGauge6.TabIndex = 16;
            this.aGauge6.Text = "gauge_ori_x";
            this.aGauge6.Value = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.White;
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 90;
            this.aGauge3.BaseArcSweep = 360;
            this.aGauge3.BaseArcWidth = 1;
            this.aGauge3.Center = new System.Drawing.Point(105, 100);
            this.aGauge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge3.Location = new System.Drawing.Point(459, 45);
            this.aGauge3.MaxValue = 180F;
            this.aGauge3.MinValue = -180F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 3;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 70;
            this.aGauge3.ScaleLinesMajorOuterRadius = 80;
            this.aGauge3.ScaleLinesMajorStepValue = 30F;
            this.aGauge3.ScaleLinesMajorWidth = 1;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorTicks = 0;
            this.aGauge3.ScaleLinesMinorWidth = 2;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = "#°";
            this.aGauge3.ScaleNumbersRadius = 90;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 2;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(211, 205);
            this.aGauge3.TabIndex = 16;
            this.aGauge3.Text = "gauge_ori_x";
            this.aGauge3.Value = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.White;
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 80;
            this.aGauge4.BaseArcStart = 90;
            this.aGauge4.BaseArcSweep = 360;
            this.aGauge4.BaseArcWidth = 1;
            this.aGauge4.Center = new System.Drawing.Point(105, 100);
            this.aGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge4.Location = new System.Drawing.Point(242, 45);
            this.aGauge4.MaxValue = 180F;
            this.aGauge4.MinValue = -180F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleRadius = 80;
            this.aGauge4.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesInterInnerRadius = 73;
            this.aGauge4.ScaleLinesInterOuterRadius = 80;
            this.aGauge4.ScaleLinesInterWidth = 3;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 70;
            this.aGauge4.ScaleLinesMajorOuterRadius = 80;
            this.aGauge4.ScaleLinesMajorStepValue = 30F;
            this.aGauge4.ScaleLinesMajorWidth = 1;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 75;
            this.aGauge4.ScaleLinesMinorOuterRadius = 80;
            this.aGauge4.ScaleLinesMinorTicks = 0;
            this.aGauge4.ScaleLinesMinorWidth = 2;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = "#°";
            this.aGauge4.ScaleNumbersRadius = 90;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 2;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Size = new System.Drawing.Size(211, 205);
            this.aGauge4.TabIndex = 17;
            this.aGauge4.Text = "gauge_ori_x";
            this.aGauge4.Value = 0F;
            // 
            // aGauge5
            // 
            this.aGauge5.BackColor = System.Drawing.Color.White;
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 80;
            this.aGauge5.BaseArcStart = 90;
            this.aGauge5.BaseArcSweep = 360;
            this.aGauge5.BaseArcWidth = 1;
            this.aGauge5.Center = new System.Drawing.Point(105, 100);
            this.aGauge5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge5.Location = new System.Drawing.Point(22, 45);
            this.aGauge5.MaxValue = 180F;
            this.aGauge5.MinValue = -180F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge5.NeedleRadius = 80;
            this.aGauge5.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesInterInnerRadius = 73;
            this.aGauge5.ScaleLinesInterOuterRadius = 80;
            this.aGauge5.ScaleLinesInterWidth = 3;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 70;
            this.aGauge5.ScaleLinesMajorOuterRadius = 80;
            this.aGauge5.ScaleLinesMajorStepValue = 30F;
            this.aGauge5.ScaleLinesMajorWidth = 1;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 75;
            this.aGauge5.ScaleLinesMinorOuterRadius = 80;
            this.aGauge5.ScaleLinesMinorTicks = 0;
            this.aGauge5.ScaleLinesMinorWidth = 2;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = "#°";
            this.aGauge5.ScaleNumbersRadius = 90;
            this.aGauge5.ScaleNumbersRotation = 0;
            this.aGauge5.ScaleNumbersStartScaleLine = 2;
            this.aGauge5.ScaleNumbersStepScaleLines = 1;
            this.aGauge5.Size = new System.Drawing.Size(211, 205);
            this.aGauge5.TabIndex = 18;
            this.aGauge5.Text = "aGauge5";
            this.aGauge5.Value = 0F;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(736, 12);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(54, 25);
            this.label97.TabIndex = 10;
            this.label97.Text = "Acc:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(516, 12);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(31, 25);
            this.label91.TabIndex = 10;
            this.label91.Text = "Z:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(299, 12);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(33, 25);
            this.label92.TabIndex = 11;
            this.label92.Text = "Y:";
            // 
            // label98
            // 
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(793, 11);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(78, 25);
            this.label98.TabIndex = 12;
            this.label98.Text = "...";
            // 
            // label93
            // 
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(549, 12);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(93, 25);
            this.label93.TabIndex = 12;
            this.label93.Text = "...";
            // 
            // label94
            // 
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(334, 12);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(87, 25);
            this.label94.TabIndex = 13;
            this.label94.Text = "...";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(81, 12);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(32, 25);
            this.label95.TabIndex = 14;
            this.label95.Text = "X:";
            // 
            // label96
            // 
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(115, 12);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(75, 25);
            this.label96.TabIndex = 15;
            this.label96.Text = "...";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label64);
            this.groupBox12.Controls.Add(this.label63);
            this.groupBox12.Controls.Add(this.label66);
            this.groupBox12.Controls.Add(this.label68);
            this.groupBox12.Controls.Add(this.label67);
            this.groupBox12.Controls.Add(this.label65);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(19, 15);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(203, 146);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "File Statistics";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(94, 41);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(21, 20);
            this.label64.TabIndex = 8;
            this.label64.Text = "...";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(23, 41);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(70, 20);
            this.label63.TabIndex = 8;
            this.label63.Text = "Packets:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(94, 69);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(21, 20);
            this.label66.TabIndex = 8;
            this.label66.Text = "...";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(94, 99);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(21, 20);
            this.label68.TabIndex = 8;
            this.label68.Text = "...";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(49, 99);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(44, 20);
            this.label67.TabIndex = 8;
            this.label67.Text = "Size:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(17, 69);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(76, 20);
            this.label65.TabIndex = 8;
            this.label65.Text = "Seconds:";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(358, 83);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(164, 33);
            this.button12.TabIndex = 11;
            this.button12.Text = "Run Analysis";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(671, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 33);
            this.button13.TabIndex = 12;
            this.button13.Text = "Close File";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label62.Location = new System.Drawing.Point(342, 15);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(196, 37);
            this.label62.TabIndex = 14;
            this.label62.Text = "File Analysis";
            // 
            // label69
            // 
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(262, 56);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(356, 20);
            this.label69.TabIndex = 8;
            this.label69.Text = "Filename";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalyseFileWorker
            // 
            this.AnalyseFileWorker.WorkerSupportsCancellation = true;
            this.AnalyseFileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AnalyseFileWorker_DoWork);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.label99);
            this.panel7.Controls.Add(this.label100);
            this.panel7.Location = new System.Drawing.Point(0, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(986, 539);
            this.panel7.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EFAS.Properties.Resources.icons8_Satellite_104px_2;
            this.pictureBox4.Location = new System.Drawing.Point(418, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 143);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label99
            // 
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(60, 226);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(867, 25);
            this.label99.TabIndex = 10;
            this.label99.Text = "Searching";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label100.Location = new System.Drawing.Point(352, 35);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(282, 37);
            this.label100.TabIndex = 11;
            this.label100.Text = "Obtaining GPS Fix";
            // 
            // GPSWaiter
            // 
            this.GPSWaiter.WorkerSupportsCancellation = true;
            this.GPSWaiter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GPSWaiter_DoWork);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(19, 202);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(167, 42);
            this.button15.TabIndex = 3;
            this.button15.Text = "Save Settings";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 386);
            this.Name = "Startup";
            this.Text = "EFAS - Loading";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Startup_FormClosed);
            this.Load += new System.EventHandler(this.Startup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc_threshold)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker XSensFinder;
        private System.ComponentModel.BackgroundWorker DataCollector;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sensor_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sensor_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sensor_baud;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label acc_z;
        private System.Windows.Forms.Label acc_y;
        private System.Windows.Forms.Label acc_x;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown acc_threshold;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label ori_z;
        private System.Windows.Forms.Label ori_y;
        private System.Windows.Forms.Label ori_x;
        private System.Windows.Forms.Label gyr_z;
        private System.Windows.Forms.Label gyr_y;
        private System.Windows.Forms.Label gyr_x;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.AGauge gauge_ori_x;
        private System.Windows.Forms.AGauge gauge_ori_z;
        private System.Windows.Forms.AGauge gauge_ori_y;
        private System.Windows.Forms.TextBox diagbox;
        private System.ComponentModel.BackgroundWorker FallChecker;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker GPS_Checker;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar calibration_progressbar;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.ComponentModel.BackgroundWorker CalibrationWaiter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.ComponentModel.BackgroundWorker ManualRecorder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.OpenFileDialog AnalyseFileDiaglog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.Label label72;
        private System.ComponentModel.BackgroundWorker AnalyseFileWorker;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.AGauge aGauge3;
        private System.Windows.Forms.AGauge aGauge4;
        private System.Windows.Forms.AGauge aGauge5;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.AGauge aGauge6;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.ComponentModel.BackgroundWorker GPSWaiter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Button button15;
    }
}

