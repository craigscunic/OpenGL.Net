
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
		/// [WGL] Value of WGL_DRAW_TO_PBUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int DRAW_TO_PBUFFER_ARB = 0x202D;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_PIXELS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_PIXELS_ARB = 0x202E;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_WIDTH_ARB = 0x202F;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_HEIGHT_ARB = 0x2030;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_LARGEST_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_LARGEST_ARB = 0x2033;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_WIDTH_ARB = 0x2034;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_HEIGHT_ARB = 0x2035;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_LOST_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public const int PBUFFER_LOST_ARB = 0x2036;

		/// <summary>
		/// [WGL] wglCreatePbufferARB: Binding for wglCreatePbufferARB.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iWidth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iHeight">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglCreatePbufferARB != null, "pwglCreatePbufferARB not implemented");
					retValue = Delegates.pwglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, p_piAttribList);
					LogCommand("wglCreatePbufferARB", retValue, hDC, iPixelFormat, iWidth, iHeight, piAttribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetPbufferDCARB: Binding for wglGetPbufferDCARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static IntPtr GetPbufferDCARB(IntPtr hPbuffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetPbufferDCARB != null, "pwglGetPbufferDCARB not implemented");
			retValue = Delegates.pwglGetPbufferDCARB(hPbuffer);
			LogCommand("wglGetPbufferDCARB", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleasePbufferDCARB: Binding for wglReleasePbufferDCARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC)
		{
			int retValue;

			Debug.Assert(Delegates.pwglReleasePbufferDCARB != null, "pwglReleasePbufferDCARB not implemented");
			retValue = Delegates.pwglReleasePbufferDCARB(hPbuffer, hDC);
			LogCommand("wglReleasePbufferDCARB", retValue, hPbuffer, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDestroyPbufferARB: Binding for wglDestroyPbufferARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static bool DestroyPbufferARB(IntPtr hPbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyPbufferARB != null, "pwglDestroyPbufferARB not implemented");
			retValue = Delegates.pwglDestroyPbufferARB(hPbuffer);
			LogCommand("wglDestroyPbufferARB", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryPbufferARB: Binding for wglQueryPbufferARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static bool QueryPbufferARB(IntPtr hPbuffer, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryPbufferARB != null, "pwglQueryPbufferARB not implemented");
					retValue = Delegates.pwglQueryPbufferARB(hPbuffer, iAttribute, p_piValue);
					LogCommand("wglQueryPbufferARB", retValue, hPbuffer, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			internal static wglCreatePbufferARB pwglCreatePbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			internal static wglGetPbufferDCARB pwglGetPbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			internal static wglReleasePbufferDCARB pwglReleasePbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDestroyPbufferARB(IntPtr hPbuffer);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			internal static wglDestroyPbufferARB pwglDestroyPbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			internal static wglQueryPbufferARB pwglQueryPbufferARB;

		}
	}

}
