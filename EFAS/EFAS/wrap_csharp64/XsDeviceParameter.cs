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

public class XsDeviceParameter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceParameter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDeviceParameter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceParameter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDeviceParameter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsDeviceParameter(XsDeviceParameterIdentifier id) : this(xsensdeviceapiPINVOKE.new_XsDeviceParameter__SWIG_0((int)id), true) {
  }

  public XsDeviceParameter(XsDeviceParameterIdentifier id, int value) : this(xsensdeviceapiPINVOKE.new_XsDeviceParameter__SWIG_1((int)id, value), true) {
  }

  public XsDeviceParameterIdentifier id() {
    XsDeviceParameterIdentifier ret = (XsDeviceParameterIdentifier)xsensdeviceapiPINVOKE.XsDeviceParameter_id(swigCPtr);
    return ret;
  }

}

}
