
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

using Khronos;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_NO_STREAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int NO_STREAM_KHR = 0;

		/// <summary>
		/// [EGL] Value of EGL_PRODUCER_FRAME_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int PRODUCER_FRAME_KHR = 0x3212;

		/// <summary>
		/// [EGL] Value of EGL_CONSUMER_FRAME_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int CONSUMER_FRAME_KHR = 0x3213;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_EMPTY_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_EMPTY_KHR = 0x3217;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_NEW_FRAME_AVAILABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_NEW_FRAME_AVAILABLE_KHR = 0x3218;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_OLD_FRAME_AVAILABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_OLD_FRAME_AVAILABLE_KHR = 0x3219;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_DISCONNECTED_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_DISCONNECTED_KHR = 0x321A;

		/// <summary>
		/// [EGL] Value of EGL_BAD_STREAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int BAD_STREAM_KHR = 0x321B;

		/// <summary>
		/// [EGL] Value of EGL_BAD_STATE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int BAD_STATE_KHR = 0x321C;

		/// <summary>
		/// [EGL] eglCreateStreamKHR: Binding for eglCreateStreamKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static IntPtr CreateStreamKHR(IntPtr dpy, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamKHR != null, "peglCreateStreamKHR not implemented");
					retValue = Delegates.peglCreateStreamKHR(dpy, p_attrib_list);
					LogCommand("eglCreateStreamKHR", retValue, dpy, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglDestroyStreamKHR: Binding for eglDestroyStreamKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool DestroyStreamKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroyStreamKHR != null, "peglDestroyStreamKHR not implemented");
			retValue = Delegates.peglDestroyStreamKHR(dpy, stream);
			LogCommand("eglDestroyStreamKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglStreamAttribKHR: Binding for eglStreamAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool StreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamAttribKHR != null, "peglStreamAttribKHR not implemented");
			retValue = Delegates.peglStreamAttribKHR(dpy, stream, attribute, value);
			LogCommand("eglStreamAttribKHR", retValue, dpy, stream, attribute, value			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryStreamKHR: Binding for eglQueryStreamKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool QueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamKHR != null, "peglQueryStreamKHR not implemented");
					retValue = Delegates.peglQueryStreamKHR(dpy, stream, attribute, p_value);
					LogCommand("eglQueryStreamKHR", retValue, dpy, stream, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryStreamu64KHR: Binding for eglQueryStreamu64KHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool QueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64[] value)
		{
			bool retValue;

			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamu64KHR != null, "peglQueryStreamu64KHR not implemented");
					retValue = Delegates.peglQueryStreamu64KHR(dpy, stream, attribute, p_value);
					LogCommand("eglQueryStreamu64KHR", retValue, dpy, stream, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamKHR(IntPtr dpy, int* attrib_list);

			[RequiredByFeature("EGL_KHR_stream")]
			internal static eglCreateStreamKHR peglCreateStreamKHR;

			[RequiredByFeature("EGL_KHR_stream")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroyStreamKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream")]
			internal static eglDestroyStreamKHR peglDestroyStreamKHR;

			[RequiredByFeature("EGL_KHR_stream")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value);

			[RequiredByFeature("EGL_KHR_stream")]
			internal static eglStreamAttribKHR peglStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int* value);

			[RequiredByFeature("EGL_KHR_stream")]
			internal static eglQueryStreamKHR peglQueryStreamKHR;

			[RequiredByFeature("EGL_KHR_stream")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamu64KHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			[RequiredByFeature("EGL_KHR_stream")]
			internal static eglQueryStreamu64KHR peglQueryStreamu64KHR;

		}
	}

}
