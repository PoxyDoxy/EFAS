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

public enum XsPortLinesOptions {
  XPLO_Invalid = 0,
  XPLO_RTS_Set = (1 << 0),
  XPLO_RTS_Clear = (1 << 1),
  XPLO_RTS_Ignore = (1 << 2),
  XPLO_DTR_Set = (1 << 3),
  XPLO_DTR_Clear = (1 << 4),
  XPLO_DTR_Ignore = (1 << 5),
  XPLO_All_Set = XPLO_RTS_Set|XPLO_DTR_Set,
  XPLO_All_Clear = XPLO_RTS_Clear|XPLO_DTR_Clear,
  XPLO_All_Ignore = XPLO_RTS_Ignore|XPLO_DTR_Ignore,
  XPLO_RtsCtsFlowControl = (1 << 6)
}

}
