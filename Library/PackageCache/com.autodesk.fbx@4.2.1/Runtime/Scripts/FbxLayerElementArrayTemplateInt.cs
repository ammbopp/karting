#if UNITY_EDITOR || FBXSDK_RUNTIME
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxLayerElementArrayTemplateInt : FbxLayerElementArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementArrayTemplateInt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativeMethods.FbxLayerElementArrayTemplateInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementArrayTemplateInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementArrayTemplateInt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativeMethods.delete_FbxLayerElementArrayTemplateInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  private int GetAtUnchecked(int pIndex) {
    int ret = NativeMethods.FbxLayerElementArrayTemplateInt_GetAtUnchecked(swigCPtr, pIndex);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

   public int GetAt(int pIndex) { 
      if (pIndex < 0 || pIndex >= GetCount()) { 
        throw new System.ArgumentOutOfRangeException("pIndex");
      }
      return GetAtUnchecked(pIndex);
    }

  public FbxLayerElementArrayTemplateInt() : this(NativeMethods.new_FbxLayerElementArrayTemplateInt(), true) {
  }

}

}

#endif // UNITY_EDITOR || FBXSDK_RUNTIME