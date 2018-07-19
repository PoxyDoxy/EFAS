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

public class XsMessageArrayImpl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsMessageArrayImpl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMessageArrayImpl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMessageArrayImpl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsMessageArrayImpl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsMessageArrayImpl(uint count, XsMessage src) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_0(count, XsMessage.getCPtr(src)), true) {
  }

  public XsMessageArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_1(count), true) {
  }

  public XsMessageArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_2(), true) {
  }

  public XsMessageArrayImpl(XsMessageArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_3(XsMessageArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsMessageArrayImpl(XsMessage arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_4(XsMessage.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsMessageArrayImpl(XsMessage arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_5(XsMessage.getCPtr(arg0), sz), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsMessageArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public XsMessage value(uint index) {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_value(swigCPtr, index), true);
    return ret;
  }

  public XsMessage first() {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_first(swigCPtr), true);
    return ret;
  }

  public XsMessage last() {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_last(swigCPtr), true);
    return ret;
  }

  public XsMessage at(uint index) {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_at__SWIG_0(swigCPtr, index), false);
    return ret;
  }

  public void insert(XsMessage item, uint index) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_insert__SWIG_0(swigCPtr, XsMessage.getCPtr(item), index);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert(XsMessage items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_insert__SWIG_1(swigCPtr, XsMessage.getCPtr(items), index, count);
  }

  public void push_back(XsMessage item) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_push_back(swigCPtr, XsMessage.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(XsMessage item) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_push_front(swigCPtr, XsMessage.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, XsMessage src) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_assign(swigCPtr, count, XsMessage.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsMessageArrayImpl other) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_append(swigCPtr, XsMessageArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsMessageArrayImpl other) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_swap(swigCPtr, XsMessageArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int find(XsMessage needle) {
    int ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_find(swigCPtr, XsMessage.getCPtr(needle));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_removeDuplicates(swigCPtr);
  }

  public void removeDuplicatesPredicate(SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int predicate) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_removeDuplicatesPredicate(swigCPtr, SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int.getCPtr(predicate));
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_sort(swigCPtr);
  }

  public void reverse() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_reverse(swigCPtr);
  }

}

}