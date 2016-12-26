using System;
using ObjCRuntime;

[assembly: LinkWith ("DynamsoftBarcodeReader.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-lc++.1")]
