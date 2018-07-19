//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XDA {

public class XsDeviceRef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceRef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDeviceRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceRef() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDeviceRef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsDeviceRef() : this(xsensdeviceapiPINVOKE.new_XsDeviceRef__SWIG_0(), true) {
  }

  public XsDeviceRef(SWIGTYPE_p_XsDevice device) : this(xsensdeviceapiPINVOKE.new_XsDeviceRef__SWIG_1(SWIGTYPE_p_XsDevice.getCPtr(device)), true) {
  }

  public XsDeviceRef(XsDeviceRef deviceRef) : this(xsensdeviceapiPINVOKE.new_XsDeviceRef__SWIG_2(XsDeviceRef.getCPtr(deviceRef)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_XsDevice __deref__() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsDeviceRef___deref__(swigCPtr);
    SWIGTYPE_p_XsDevice ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_XsDevice(cPtr, false);
    return ret;
  }

  public void addRef() {
    xsensdeviceapiPINVOKE.XsDeviceRef_addRef(swigCPtr);
  }

  public void removeRef() {
    xsensdeviceapiPINVOKE.XsDeviceRef_removeRef(swigCPtr);
  }

}

}
