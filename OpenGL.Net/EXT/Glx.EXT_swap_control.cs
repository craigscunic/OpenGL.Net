
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public const int SWAP_INTERVAL_EXT = 0x20F1;

		/// <summary>
		/// [GLX] Value of GLX_MAX_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public const int MAX_SWAP_INTERVAL_EXT = 0x20F2;

		/// <summary>
		/// [GLX] glXSwapIntervalEXT: Binding for glXSwapIntervalEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="interval">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_swap_control")]
		public static void SwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval)
		{
			Debug.Assert(Delegates.pglXSwapIntervalEXT != null, "pglXSwapIntervalEXT not implemented");
			Delegates.pglXSwapIntervalEXT(dpy, drawable, interval);
			LogCommand("glXSwapIntervalEXT", null, dpy, drawable, interval			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_EXT_swap_control")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);

			[RequiredByFeature("GLX_EXT_swap_control")]
			internal static glXSwapIntervalEXT pglXSwapIntervalEXT;

		}
	}

}
