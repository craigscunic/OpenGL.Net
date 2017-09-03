
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_SUBSAMPLE_DISTANCE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		[RequiredByFeature("GL_AMD_sample_positions")]
		public const int SUBSAMPLE_DISTANCE_AMD = 0x883F;

		/// <summary>
		/// [GL] glSetMultisamplefvAMD: Binding for glSetMultisamplefvAMD.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="val">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_sample_positions")]
		public static void SetMultisampleAMD(Int32 pname, UInt32 index, float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					Debug.Assert(Delegates.pglSetMultisamplefvAMD != null, "pglSetMultisamplefvAMD not implemented");
					Delegates.pglSetMultisamplefvAMD(pname, index, p_val);
					LogCommand("glSetMultisamplefvAMD", null, pname, index, val					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_sample_positions")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glSetMultisamplefvAMD(Int32 pname, UInt32 index, float* val);

			[RequiredByFeature("GL_AMD_sample_positions")]
			[ThreadStatic]
			internal static glSetMultisamplefvAMD pglSetMultisamplefvAMD;

		}
	}

}
