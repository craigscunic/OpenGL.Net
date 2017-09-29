
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = 0x2050;

		/// <summary>
		/// [WGL] Value of WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = 0x2051;

		/// <summary>
		/// [WGL] Value of WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = 0x2052;

		/// <summary>
		/// [WGL] Value of WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = 0x2053;

		/// <summary>
		/// [WGL] wglGetDigitalVideoParametersI3D: Binding for wglGetDigitalVideoParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public static bool GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglGetDigitalVideoParametersI3D != null, "pwglGetDigitalVideoParametersI3D not implemented");
					retValue = Delegates.pwglGetDigitalVideoParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglGetDigitalVideoParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSetDigitalVideoParametersI3D: Binding for wglSetDigitalVideoParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public static bool SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglSetDigitalVideoParametersI3D != null, "pwglSetDigitalVideoParametersI3D not implemented");
					retValue = Delegates.pwglSetDigitalVideoParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglSetDigitalVideoParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_digital_video_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_I3D_digital_video_control")]
			internal static wglGetDigitalVideoParametersI3D pwglGetDigitalVideoParametersI3D;

			[RequiredByFeature("WGL_I3D_digital_video_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_I3D_digital_video_control")]
			internal static wglSetDigitalVideoParametersI3D pwglSetDigitalVideoParametersI3D;

		}
	}

}
