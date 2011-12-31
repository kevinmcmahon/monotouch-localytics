using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libLocalytics-fat.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true)]
