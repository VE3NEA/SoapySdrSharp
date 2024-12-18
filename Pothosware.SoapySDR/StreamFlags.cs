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

using System;

/// <summary>
/// Bitwise flags to be passed into or returned from streaming functions.
/// </summary>
[Flags]
public enum StreamFlags {
  /// <summary>No flags.</summary>
  None = 0,
  ///
/// <summary>
/// Indicate end of burst for transmit or receive. For write, end of burst if set by the caller. For read, end of burst is set by the driver.
/// </summary>
  EndBurst = (1 << 1),
  ///
/// <summary>
/// Indicates that the time stamp is valid. For write, the caller must set has time when <b>timeNs</b> is provided. For read, the driver sets has time when <b>timeNs</b> is provided.
/// </summary>
  HasTime = (1 << 2),
  ///
/// <summary>
/// Indicates that the stream terminated prematurely. This is the flag version of an overflow error that indicates an overflow with the end samples.
/// </summary>
  EndAbrupt = (1 << 3),
  ///
/// <summary>
/// Indicates transmit or receive only a single packet.
/// Applicable when the driver fragments samples into packets.
///
/// For write, the user sets this flag to only send a single packet.
/// For read, the user sets this flag to only receive a single packet.
/// </summary>
  OnePacket = (1 << 4),
  ///
/// <summary>
/// Indicate that this read call and the next results in a fragment.
/// Used when the implementation has an underlying packet interface.
///
/// The caller can use this indicator and the OnePacket flag
/// on subsequent read stream calls to re-align with packet boundaries.
/// </summary>
  MoreFragments = (1 << 5),
  ///
/// <summary>
/// Indicate that the stream should wait for an external trigger event.
/// This flag might be used with the <b>flags</b> argument in any of the
/// stream API calls. The trigger implementation is hardware-specific.
/// </summary>
  WaitTrigger = (1 << 6),
  /// <summary>A flag that can be used for SDR specific data.</summary>
  UserFlag0 = (1 << 16),
  /// <summary>A flag that can be used for SDR specific data.</summary>
  UserFlag1 = (1 << 17),
  /// <summary>A flag that can be used for SDR specific data.</summary>
  UserFlag2 = (1 << 18),
  /// <summary>A flag that can be used for SDR specific data.</summary>
  UserFlag3 = (1 << 19),
  /// <summary>A flag that can be used for SDR specific data.</summary>
  UserFlag4 = (1 << 20)
}

}
