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

public class XsFilterProfileArray : XsFilterProfileArrayImpl {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal XsFilterProfileArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xsensdeviceapiPINVOKE.XsFilterProfileArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsFilterProfileArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsFilterProfileArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsFilterProfileArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public XsFilterProfileArray(uint sz, XsFilterProfile src) : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_0(sz, XsFilterProfile.getCPtr(src)), true) {
  }

  public XsFilterProfileArray(uint sz) : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_1(sz), true) {
  }

  public XsFilterProfileArray() : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_2(), true) {
  }

  public XsFilterProfileArray(XsFilterProfileArray other) : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_3(XsFilterProfileArray.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsFilterProfileArray(XsFilterProfile arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_4(XsFilterProfile.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsFilterProfileArray(XsFilterProfile arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsFilterProfileArray__SWIG_5(XsFilterProfile.getCPtr(arg0), sz), true) {
  }

}

}
