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

public class XsMessageArray : XsMessageArrayImpl {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal XsMessageArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xsensdeviceapiPINVOKE.XsMessageArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMessageArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMessageArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsMessageArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public XsMessageArray(uint sz, XsMessage src) : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_0(sz, XsMessage.getCPtr(src)), true) {
  }

  public XsMessageArray(uint sz) : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_1(sz), true) {
  }

  public XsMessageArray() : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_2(), true) {
  }

  public XsMessageArray(XsMessageArray other) : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_3(XsMessageArray.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsMessageArray(XsMessage arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_4(XsMessage.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsMessageArray(XsMessage arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsMessageArray__SWIG_5(XsMessage.getCPtr(arg0), sz), true) {
  }

}

}