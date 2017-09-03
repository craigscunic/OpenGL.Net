
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_ACCESS_READ_ONLY_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_READ_ONLY_NV = 0x00000000;

		/// <summary>
		/// [WGL] Value of WGL_ACCESS_READ_WRITE_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_READ_WRITE_NV = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_ACCESS_WRITE_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_WRITE_DISCARD_NV = 0x00000002;

		/// <summary>
		/// [WGL] wglDXSetResourceShareHandleNV: Binding for wglDXSetResourceShareHandleNV.
		/// </summary>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="shareHandle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXSetResourceShareHandleNV != null, "pwglDXSetResourceShareHandleNV not implemented");
			retValue = Delegates.pwglDXSetResourceShareHandleNV(dxObject, shareHandle);
			LogCommand("wglDXSetResourceShareHandleNV", retValue, dxObject, shareHandle			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXOpenDeviceNV: Binding for wglDXOpenDeviceNV.
		/// </summary>
		/// <param name="dxDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXOpenDeviceNV(IntPtr dxDevice)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXOpenDeviceNV != null, "pwglDXOpenDeviceNV not implemented");
			retValue = Delegates.pwglDXOpenDeviceNV(dxDevice);
			LogCommand("wglDXOpenDeviceNV", retValue, dxDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXCloseDeviceNV: Binding for wglDXCloseDeviceNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXCloseDeviceNV(IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXCloseDeviceNV != null, "pwglDXCloseDeviceNV not implemented");
			retValue = Delegates.pwglDXCloseDeviceNV(hDevice);
			LogCommand("wglDXCloseDeviceNV", retValue, hDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXRegisterObjectNV: Binding for wglDXRegisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXRegisterObjectNV != null, "pwglDXRegisterObjectNV not implemented");
			retValue = Delegates.pwglDXRegisterObjectNV(hDevice, dxObject, name, type, access);
			LogCommand("wglDXRegisterObjectNV", retValue, hDevice, dxObject, name, type, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXUnregisterObjectNV: Binding for wglDXUnregisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXUnregisterObjectNV != null, "pwglDXUnregisterObjectNV not implemented");
			retValue = Delegates.pwglDXUnregisterObjectNV(hDevice, hObject);
			LogCommand("wglDXUnregisterObjectNV", retValue, hDevice, hObject			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXObjectAccessNV: Binding for wglDXObjectAccessNV.
		/// </summary>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXObjectNV(IntPtr hObject, Int32 access)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXObjectAccessNV != null, "pwglDXObjectAccessNV not implemented");
			retValue = Delegates.pwglDXObjectAccessNV(hObject, access);
			LogCommand("wglDXObjectAccessNV", retValue, hObject, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXLockObjectsNV: Binding for wglDXLockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXLockObjectNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXLockObjectsNV != null, "pwglDXLockObjectsNV not implemented");
					retValue = Delegates.pwglDXLockObjectsNV(hDevice, count, p_hObjects);
					LogCommand("wglDXLockObjectsNV", retValue, hDevice, count, hObjects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDXUnlockObjectsNV: Binding for wglDXUnlockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXUnlockObjectsNV != null, "pwglDXUnlockObjectsNV not implemented");
					retValue = Delegates.pwglDXUnlockObjectsNV(hDevice, count, p_hObjects);
					LogCommand("wglDXUnlockObjectsNV", retValue, hDevice, count, hObjects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXSetResourceShareHandleNV pwglDXSetResourceShareHandleNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglDXOpenDeviceNV(IntPtr dxDevice);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXOpenDeviceNV pwglDXOpenDeviceNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXCloseDeviceNV(IntPtr hDevice);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXCloseDeviceNV pwglDXCloseDeviceNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglDXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXRegisterObjectNV pwglDXRegisterObjectNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXUnregisterObjectNV pwglDXUnregisterObjectNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXObjectAccessNV(IntPtr hObject, Int32 access);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXObjectAccessNV pwglDXObjectAccessNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXLockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXLockObjectsNV pwglDXLockObjectsNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[RequiredByFeature("WGL_NV_DX_interop")]
			internal static wglDXUnlockObjectsNV pwglDXUnlockObjectsNV;

		}
	}

}
