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

public class KwargsList : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<Kwargs>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal KwargsList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KwargsList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(KwargsList obj) {
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

  ~KwargsList() {
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
          SoapySDRPINVOKE.delete_KwargsList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public KwargsList(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Kwargs element in c) {
      this.Add(element);
    }
  }

  public KwargsList(global::System.Collections.Generic.IEnumerable<Kwargs> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Kwargs element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Kwargs this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < (int)size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(Kwargs[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Kwargs[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Kwargs[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public Kwargs[] ToArray() {
    Kwargs[] array = new Kwargs[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<Kwargs> global::System.Collections.Generic.IEnumerable<Kwargs>.GetEnumerator() {
    return new KwargsListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new KwargsListEnumerator(this);
  }

  public KwargsListEnumerator GetEnumerator() {
    return new KwargsListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class KwargsListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Kwargs>
  {
    private KwargsList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public KwargsListEnumerator(KwargsList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Kwargs Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Kwargs)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    SoapySDRPINVOKE.KwargsList_Clear(swigCPtr);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(Kwargs x) {
    SoapySDRPINVOKE.KwargsList_Add(swigCPtr, Kwargs.getCPtr(x));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = SoapySDRPINVOKE.KwargsList_size(swigCPtr);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = SoapySDRPINVOKE.KwargsList_capacity(swigCPtr);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    SoapySDRPINVOKE.KwargsList_reserve(swigCPtr, n);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public KwargsList() : this(SoapySDRPINVOKE.new_KwargsList__SWIG_0(), true) {
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public KwargsList(KwargsList other) : this(SoapySDRPINVOKE.new_KwargsList__SWIG_1(KwargsList.getCPtr(other)), true) {
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public KwargsList(int capacity) : this(SoapySDRPINVOKE.new_KwargsList__SWIG_2(capacity), true) {
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  private Kwargs getitemcopy(int index) {
    Kwargs ret = new Kwargs(SoapySDRPINVOKE.KwargsList_getitemcopy(swigCPtr, index), true);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Kwargs getitem(int index) {
    Kwargs ret = new Kwargs(SoapySDRPINVOKE.KwargsList_getitem(swigCPtr, index), false);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Kwargs val) {
    SoapySDRPINVOKE.KwargsList_setitem(swigCPtr, index, Kwargs.getCPtr(val));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(KwargsList values) {
    SoapySDRPINVOKE.KwargsList_AddRange(swigCPtr, KwargsList.getCPtr(values));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public KwargsList GetRange(int index, int count) {
    global::System.IntPtr cPtr = SoapySDRPINVOKE.KwargsList_GetRange(swigCPtr, index, count);
    KwargsList ret = (cPtr == global::System.IntPtr.Zero) ? null : new KwargsList(cPtr, true);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Kwargs x) {
    SoapySDRPINVOKE.KwargsList_Insert(swigCPtr, index, Kwargs.getCPtr(x));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, KwargsList values) {
    SoapySDRPINVOKE.KwargsList_InsertRange(swigCPtr, index, KwargsList.getCPtr(values));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    SoapySDRPINVOKE.KwargsList_RemoveAt(swigCPtr, index);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    SoapySDRPINVOKE.KwargsList_RemoveRange(swigCPtr, index, count);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public static KwargsList Repeat(Kwargs value, int count) {
    global::System.IntPtr cPtr = SoapySDRPINVOKE.KwargsList_Repeat(Kwargs.getCPtr(value), count);
    KwargsList ret = (cPtr == global::System.IntPtr.Zero) ? null : new KwargsList(cPtr, true);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    SoapySDRPINVOKE.KwargsList_Reverse__SWIG_0(swigCPtr);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    SoapySDRPINVOKE.KwargsList_Reverse__SWIG_1(swigCPtr, index, count);
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, KwargsList values) {
    SoapySDRPINVOKE.KwargsList_SetRange(swigCPtr, index, KwargsList.getCPtr(values));
    if (SoapySDRPINVOKE.SWIGPendingException.Pending) throw SoapySDRPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
