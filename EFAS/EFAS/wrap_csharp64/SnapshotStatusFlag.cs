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

public enum SnapshotStatusFlag {
  FSFL_ClipAccX = 0x0001,
  FSFL_ClipAccY = 0x0002,
  FSFL_ClipAccZ = 0x0004,
  FSFL_ClipAccMask = 0x0007,
  FSFL_ClipGyrX = 0x0008,
  FSFL_ClipGyrY = 0x0010,
  FSFL_ClipGyrZ = 0x0020,
  FSFL_ClipGyrMask = 0x0038,
  FSFL_ClipMagX = 0x0040,
  FSFL_ClipMagY = 0x0080,
  FSFL_ClipMagZ = 0x0100,
  FSFL_ClipMagMask = 0x01C0,
  FSFL_MagIsNew = 0x0200,
  FSFL_BaroIsNew = 0x0400,
  FSFL_RotationMask = 0x1800
}

}