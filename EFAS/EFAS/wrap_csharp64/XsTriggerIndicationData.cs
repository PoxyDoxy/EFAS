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

public class XsTriggerIndicationData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsTriggerIndicationData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsTriggerIndicationData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsTriggerIndicationData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsTriggerIndicationData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public byte m_line {
    set {
      xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_line_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_line_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_polarity {
    set {
      xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_polarity_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_polarity_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_timestamp {
    set {
      xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_timestamp_set(swigCPtr, value);
    } 
    get {
      uint ret = xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_timestamp_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_frameNumber {
    set {
      xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_frameNumber_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsTriggerIndicationData_m_frameNumber_get(swigCPtr);
      return ret;
    } 
  }

  public XsTriggerIndicationData(byte line, byte polarity, uint timestamp, ushort frameNumber) : this(xsensdeviceapiPINVOKE.new_XsTriggerIndicationData__SWIG_0(line, polarity, timestamp, frameNumber), true) {
  }

  public XsTriggerIndicationData(byte line, byte polarity, uint timestamp) : this(xsensdeviceapiPINVOKE.new_XsTriggerIndicationData__SWIG_1(line, polarity, timestamp), true) {
  }

  public XsTriggerIndicationData(byte line, byte polarity) : this(xsensdeviceapiPINVOKE.new_XsTriggerIndicationData__SWIG_2(line, polarity), true) {
  }

  public XsTriggerIndicationData(byte line) : this(xsensdeviceapiPINVOKE.new_XsTriggerIndicationData__SWIG_3(line), true) {
  }

  public XsTriggerIndicationData() : this(xsensdeviceapiPINVOKE.new_XsTriggerIndicationData__SWIG_4(), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsTriggerIndicationData_clear(swigCPtr);
  }

  public bool valid() {
    bool ret = xsensdeviceapiPINVOKE.XsTriggerIndicationData_valid(swigCPtr);
    return ret;
  }

}

}
