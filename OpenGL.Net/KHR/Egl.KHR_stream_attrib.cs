
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
		/// [EGL] Value of EGL_CONSUMER_LATENCY_USEC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int CONSUMER_LATENCY_USEC_KHR = 0x3210;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_KHR = 0x3214;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_CREATED_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_CREATED_KHR = 0x3215;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_STATE_CONNECTING_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_CONNECTING_KHR = 0x3216;

		/// <summary>
		/// [EGL] eglCreateStreamAttribKHR: Binding for eglCreateStreamAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static IntPtr CreateStreamAttribKHR(IntPtr dpy, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamAttribKHR != null, "peglCreateStreamAttribKHR not implemented");
					retValue = Delegates.peglCreateStreamAttribKHR(dpy, p_attrib_list);
					LogCommand("eglCreateStreamAttribKHR", retValue, dpy, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglSetStreamAttribKHR: Binding for eglSetStreamAttribKHR.
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
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool SetStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSetStreamAttribKHR != null, "peglSetStreamAttribKHR not implemented");
			retValue = Delegates.peglSetStreamAttribKHR(dpy, stream, attribute, value);
			LogCommand("eglSetStreamAttribKHR", retValue, dpy, stream, attribute, value			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryStreamAttribKHR: Binding for eglQueryStreamAttribKHR.
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
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool QueryStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamAttribKHR != null, "peglQueryStreamAttribKHR not implemented");
					retValue = Delegates.peglQueryStreamAttribKHR(dpy, stream, attribute, p_value);
					LogCommand("eglQueryStreamAttribKHR", retValue, dpy, stream, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglStreamConsumerAcquireAttribKHR: Binding for eglStreamConsumerAcquireAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool StreamConsumerAcquireAttribKHR(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerAcquireAttribKHR != null, "peglStreamConsumerAcquireAttribKHR not implemented");
					retValue = Delegates.peglStreamConsumerAcquireAttribKHR(dpy, stream, p_attrib_list);
					LogCommand("eglStreamConsumerAcquireAttribKHR", retValue, dpy, stream, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglStreamConsumerReleaseAttribKHR: Binding for eglStreamConsumerReleaseAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool StreamConsumerReleaseAttribKHR(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerReleaseAttribKHR != null, "peglStreamConsumerReleaseAttribKHR not implemented");
					retValue = Delegates.peglStreamConsumerReleaseAttribKHR(dpy, stream, p_attrib_list);
					LogCommand("eglStreamConsumerReleaseAttribKHR", retValue, dpy, stream, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamAttribKHR(IntPtr dpy, IntPtr* attrib_list);

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			internal static eglCreateStreamAttribKHR peglCreateStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSetStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value);

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			internal static eglSetStreamAttribKHR peglSetStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr* value);

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			internal static eglQueryStreamAttribKHR peglQueryStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerAcquireAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			internal static eglStreamConsumerAcquireAttribKHR peglStreamConsumerAcquireAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerReleaseAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			internal static eglStreamConsumerReleaseAttribKHR peglStreamConsumerReleaseAttribKHR;

		}
	}

}
