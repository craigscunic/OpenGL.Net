
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
		/// [EGL] Value of EGL_CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public const int CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR = 0x321E;

		/// <summary>
		/// [EGL] eglStreamConsumerGLTextureExternalKHR: Binding for eglStreamConsumerGLTextureExternalKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerGLTextureExternalKHR != null, "peglStreamConsumerGLTextureExternalKHR not implemented");
			retValue = Delegates.peglStreamConsumerGLTextureExternalKHR(dpy, stream);
			LogCommand("eglStreamConsumerGLTextureExternalKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglStreamConsumerAcquireKHR: Binding for eglStreamConsumerAcquireKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerAcquireKHR != null, "peglStreamConsumerAcquireKHR not implemented");
			retValue = Delegates.peglStreamConsumerAcquireKHR(dpy, stream);
			LogCommand("eglStreamConsumerAcquireKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglStreamConsumerReleaseKHR: Binding for eglStreamConsumerReleaseKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerReleaseKHR != null, "peglStreamConsumerReleaseKHR not implemented");
			retValue = Delegates.peglStreamConsumerReleaseKHR(dpy, stream);
			LogCommand("eglStreamConsumerReleaseKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerGLTextureExternalKHR peglStreamConsumerGLTextureExternalKHR;

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerAcquireKHR peglStreamConsumerAcquireKHR;

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerReleaseKHR peglStreamConsumerReleaseKHR;

		}
	}

}
