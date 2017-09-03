
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
		/// [EGL] eglQueryNativeDisplayNV: Binding for eglQueryNativeDisplayNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="display_id">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static bool QueryNativeDisplayNV(IntPtr dpy, IntPtr[] display_id)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_display_id = display_id)
				{
					Debug.Assert(Delegates.peglQueryNativeDisplayNV != null, "peglQueryNativeDisplayNV not implemented");
					retValue = Delegates.peglQueryNativeDisplayNV(dpy, p_display_id);
					LogCommand("eglQueryNativeDisplayNV", retValue, dpy, display_id					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryNativeWindowNV: Binding for eglQueryNativeWindowNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="window">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static bool QueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr[] window)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_window = window)
				{
					Debug.Assert(Delegates.peglQueryNativeWindowNV != null, "peglQueryNativeWindowNV not implemented");
					retValue = Delegates.peglQueryNativeWindowNV(dpy, surf, p_window);
					LogCommand("eglQueryNativeWindowNV", retValue, dpy, surf, window					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryNativePixmapNV: Binding for eglQueryNativePixmapNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_native_query")]
		public static bool QueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr[] pixmap)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_pixmap = pixmap)
				{
					Debug.Assert(Delegates.peglQueryNativePixmapNV != null, "peglQueryNativePixmapNV not implemented");
					retValue = Delegates.peglQueryNativePixmapNV(dpy, surf, p_pixmap);
					LogCommand("eglQueryNativePixmapNV", retValue, dpy, surf, pixmap					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_native_query")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryNativeDisplayNV(IntPtr dpy, IntPtr* display_id);

			[RequiredByFeature("EGL_NV_native_query")]
			internal static eglQueryNativeDisplayNV peglQueryNativeDisplayNV;

			[RequiredByFeature("EGL_NV_native_query")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr* window);

			[RequiredByFeature("EGL_NV_native_query")]
			internal static eglQueryNativeWindowNV peglQueryNativeWindowNV;

			[RequiredByFeature("EGL_NV_native_query")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglQueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr* pixmap);

			[RequiredByFeature("EGL_NV_native_query")]
			internal static eglQueryNativePixmapNV peglQueryNativePixmapNV;

		}
	}

}
