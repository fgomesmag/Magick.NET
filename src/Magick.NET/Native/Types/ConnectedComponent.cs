// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick;

public partial class ConnectedComponent
{
    [SuppressUnmanagedCodeSecurity]
    private static unsafe class NativeMethods
    {
        #if PLATFORM_x64 || PLATFORM_AnyCPU
        public static class X64
        {
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ConnectedComponent_DisposeList(IntPtr list);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetArea(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetCentroid(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetColor(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetHeight(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetId(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetInstance(IntPtr list, UIntPtr index);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetWidth(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetX(IntPtr instance);
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetY(IntPtr instance);
        }
        #endif
        #if PLATFORM_arm64 || PLATFORM_AnyCPU
        public static class ARM64
        {
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ConnectedComponent_DisposeList(IntPtr list);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetArea(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetCentroid(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetColor(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetHeight(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetId(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetInstance(IntPtr list, UIntPtr index);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetWidth(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetX(IntPtr instance);
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetY(IntPtr instance);
        }
        #endif
        #if PLATFORM_x86 || PLATFORM_AnyCPU
        public static class X86
        {
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern void ConnectedComponent_DisposeList(IntPtr list);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetArea(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetCentroid(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetColor(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetHeight(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetId(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetInstance(IntPtr list, UIntPtr index);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr ConnectedComponent_GetWidth(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetX(IntPtr instance);
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ConnectedComponent_GetY(IntPtr instance);
        }
        #endif
    }
    private unsafe static partial class NativeConnectedComponent
    {
        static NativeConnectedComponent() { Environment.Initialize(); }
        public static void DisposeList(IntPtr list)
        {
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            NativeMethods.X64.ConnectedComponent_DisposeList(list);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            NativeMethods.ARM64.ConnectedComponent_DisposeList(list);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            NativeMethods.X86.ConnectedComponent_DisposeList(list);
            #endif
        }
        public static int GetArea(IntPtr instance)
        {
            UIntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetArea(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetArea(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetArea(instance);
            #endif
            return (int)result;
        }
        public static PointInfo GetCentroid(IntPtr instance)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetCentroid(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetCentroid(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetCentroid(instance);
            #endif
            return PointInfo.CreateInstance(result);
        }
        public static IMagickColor<QuantumType>? GetColor(IntPtr instance)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetColor(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetColor(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetColor(instance);
            #endif
            return MagickColor.CreateInstance(result);
        }
        public static int GetHeight(IntPtr instance)
        {
            UIntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetHeight(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetHeight(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetHeight(instance);
            #endif
            return (int)result;
        }
        public static int GetId(IntPtr instance)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetId(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetId(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetId(instance);
            #endif
            return (int)result;
        }
        public static IntPtr GetInstance(IntPtr list, int index)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetInstance(list, (UIntPtr)index);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetInstance(list, (UIntPtr)index);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetInstance(list, (UIntPtr)index);
            #endif
            return result;
        }
        public static int GetWidth(IntPtr instance)
        {
            UIntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetWidth(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetWidth(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetWidth(instance);
            #endif
            return (int)result;
        }
        public static int GetX(IntPtr instance)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetX(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetX(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetX(instance);
            #endif
            return (int)result;
        }
        public static int GetY(IntPtr instance)
        {
            IntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.ConnectedComponent_GetY(instance);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.ConnectedComponent_GetY(instance);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.ConnectedComponent_GetY(instance);
            #endif
            return (int)result;
        }
    }
}
