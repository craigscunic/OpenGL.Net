
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
		/// [WGL] wglSwapIntervalEXT: Binding for wglSwapIntervalEXT.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_swap_control")]
		public static bool SwapIntervalEXT(int interval)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSwapIntervalEXT != null, "pwglSwapIntervalEXT not implemented");
			retValue = Delegates.pwglSwapIntervalEXT(interval);
			LogCommand("wglSwapIntervalEXT", retValue, interval			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetSwapIntervalEXT: Binding for wglGetSwapIntervalEXT.
		/// </summary>
		[RequiredByFeature("WGL_EXT_swap_control")]
		public static int GetSwapIntervalEXT()
		{
			int retValue;

			Debug.Assert(Delegates.pwglGetSwapIntervalEXT != null, "pwglGetSwapIntervalEXT not implemented");
			retValue = Delegates.pwglGetSwapIntervalEXT();
			LogCommand("wglGetSwapIntervalEXT", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_swap_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglSwapIntervalEXT(int interval);

			[RequiredByFeature("WGL_EXT_swap_control")]
			internal static wglSwapIntervalEXT pwglSwapIntervalEXT;

			[RequiredByFeature("WGL_EXT_swap_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wglGetSwapIntervalEXT();

			[RequiredByFeature("WGL_EXT_swap_control")]
			internal static wglGetSwapIntervalEXT pwglGetSwapIntervalEXT;

		}
	}

}
