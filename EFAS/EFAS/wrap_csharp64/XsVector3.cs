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

public class XsVector3 : XsVector {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal XsVector3(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xsensdeviceapiPINVOKE.XsVector3_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsVector3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsVector3() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsVector3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public XsVector3() : this(xsensdeviceapiPINVOKE.new_XsVector3__SWIG_0(), true) {
  }

  public XsVector3(XsVector3 other) : this(xsensdeviceapiPINVOKE.new_XsVector3__SWIG_1(XsVector3.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVector3(XsVector other) : this(xsensdeviceapiPINVOKE.new_XsVector3__SWIG_2(XsVector.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVector3(double x, double y, double z) : this(xsensdeviceapiPINVOKE.new_XsVector3__SWIG_3(x, y, z), true) {
  }

  public static XsVector3 zero3() {
    XsVector3 ret = new XsVector3(xsensdeviceapiPINVOKE.XsVector3_zero3(), false);
    return ret;
  }

}

}