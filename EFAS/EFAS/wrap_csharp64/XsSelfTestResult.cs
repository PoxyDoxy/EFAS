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

public class XsSelfTestResult : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSelfTestResult(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsSelfTestResult obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSelfTestResult() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsSelfTestResult(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ushort m_flags {
    set {
      xsensdeviceapiPINVOKE.XsSelfTestResult_m_flags_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsSelfTestResult_m_flags_get(swigCPtr);
      return ret;
    } 
  }

  public static XsSelfTestResult create(ushort resultFlags) {
    XsSelfTestResult ret = new XsSelfTestResult(xsensdeviceapiPINVOKE.XsSelfTestResult_create(resultFlags), true);
    return ret;
  }

  public bool accX() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_accX(swigCPtr);
    return ret;
  }

  public bool accY() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_accY(swigCPtr);
    return ret;
  }

  public bool accZ() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_accZ(swigCPtr);
    return ret;
  }

  public bool gyrX() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_gyrX(swigCPtr);
    return ret;
  }

  public bool gyrY() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_gyrY(swigCPtr);
    return ret;
  }

  public bool gyrZ() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_gyrZ(swigCPtr);
    return ret;
  }

  public bool magX() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_magX(swigCPtr);
    return ret;
  }

  public bool magY() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_magY(swigCPtr);
    return ret;
  }

  public bool magZ() {
    bool ret = xsensdeviceapiPINVOKE.XsSelfTestResult_magZ(swigCPtr);
    return ret;
  }

  public XsSelfTestResult() : this(xsensdeviceapiPINVOKE.new_XsSelfTestResult(), true) {
  }

}

}