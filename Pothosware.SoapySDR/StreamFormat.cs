//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pothosware.SoapySDR {


/// <summary>A set of string constants corresponding to different sample types.</summary>
public class StreamFormat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StreamFormat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StreamFormat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(StreamFormat obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~StreamFormat() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SoapySDRPINVOKE.delete_StreamFormat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  /// <summary>Complex double-precision floating-point samples.</summary>
  public static string ComplexFloat64 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexFloat64_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex single-precision floating-point samples.</summary>
  public static string ComplexFloat32 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexFloat32_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex signed 32-bit integer samples.</summary>
  public static string ComplexInt32 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexInt32_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex unsigned 32-bit integer samples.</summary>
  public static string ComplexUInt32 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexUInt32_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex signed 16-bit integer samples.</summary>
  public static string ComplexInt16 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexInt16_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex unsigned 16-bit integer samples.</summary>
  public static string ComplexUInt16 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexUInt16_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  
/// <summary>Packed complex signed 12-bit integer samples.
///
/// This stream format can only be used with the non-generic stream API, as there is no native C# representation for this type.
/// </summary>
  public static string ComplexInt12 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexInt12_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  
/// <summary>Packed complex unsigned 12-bit integer samples.
///
/// This stream format can only be used with the non-generic stream API, as there is no native C# representation for this type.
/// </summary>
  public static string ComplexUInt12 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexUInt12_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex signed 8-bit integer samples.</summary>
  public static string ComplexInt8 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexInt8_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  /// <summary>Complex unsigned 8-bit integer samples.</summary>
  public static string ComplexUInt8 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexUInt8_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  
/// <summary>Packed complex signed 4-bit integer samples.
///
/// This stream format can only be used with the non-generic stream API, as there is no native C# representation for this type.
/// </summary>
  public static string ComplexInt4 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexInt4_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  
/// <summary>Packed complex unsigned 4-bit integer samples.
///
/// This stream format can only be used with the non-generic stream API, as there is no native C# representation for this type.
/// </summary>
  public static string ComplexUInt4 {
    get {
      string ret = SoapySDRPINVOKE.StreamFormat_ComplexUInt4_get();
      if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  
/// <summary>
/// Return the size of the given sample type, coming out to twice the size of the primitive type.
///
/// This value is intended to be used when allocating unmanaged memory to be used for streaming.
/// </summary>
public static uint FormatToSize(string format) {
    uint ret = SoapySDRPINVOKE.StreamFormat_FormatToSize(format);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}