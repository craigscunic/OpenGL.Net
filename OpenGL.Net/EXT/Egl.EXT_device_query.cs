
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_NO_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int NO_DEVICE_EXT = 0;

		/// <summary>
		/// [EGL] Value of EGL_BAD_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int BAD_DEVICE_EXT = 0x322B;

		/// <summary>
		/// [EGL] Value of EGL_DEVICE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public const int DEVICE_EXT = 0x322C;

		/// <summary>
		/// [EGL] eglQueryDeviceAttribEXT: Binding for eglQueryDeviceAttribEXT.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public static bool QueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDeviceAttribEXT != null, "peglQueryDeviceAttribEXT not implemented");
					retValue = Delegates.peglQueryDeviceAttribEXT(device, attribute, p_value);
					LogCommand("eglQueryDeviceAttribEXT", retValue, device, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryDeviceStringEXT: Binding for eglQueryDeviceStringEXT.
		/// </summary>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		public static string QueryDeviceStringEXT(IntPtr device, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryDeviceStringEXT != null, "peglQueryDeviceStringEXT not implemented");
			retValue = Delegates.peglQueryDeviceStringEXT(device, name);
			LogCommand("eglQueryDeviceStringEXT", Marshal.PtrToStringAnsi(retValue), device, name			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// [EGL] eglQueryDisplayAttribEXT: Binding for eglQueryDisplayAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_query")]
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool QueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryDisplayAttribEXT != null, "peglQueryDisplayAttribEXT not implemented");
					retValue = Delegates.peglQueryDisplayAttribEXT(dpy, attribute, p_value);
					LogCommand("eglQueryDisplayAttribEXT", retValue, dpy, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			internal static eglQueryDeviceAttribEXT peglQueryDeviceAttribEXT;

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			internal static eglQueryDeviceStringEXT peglQueryDeviceStringEXT;

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[RequiredByFeature("EGL_NV_stream_metadata", EntryPoint = "eglQueryDisplayAttribNV")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_query")]
			[RequiredByFeature("EGL_NV_stream_metadata", EntryPoint = "eglQueryDisplayAttribNV")]
			internal static eglQueryDisplayAttribEXT peglQueryDisplayAttribEXT;

		}
	}

}
