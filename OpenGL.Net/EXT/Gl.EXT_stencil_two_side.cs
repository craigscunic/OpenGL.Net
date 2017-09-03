
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
		/// [GL] Value of GL_STENCIL_TEST_TWO_SIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public const int STENCIL_TEST_TWO_SIDE_EXT = 0x8910;

		/// <summary>
		/// [GL] Value of GL_ACTIVE_STENCIL_FACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public const int ACTIVE_STENCIL_FACE_EXT = 0x8911;

		/// <summary>
		/// [GL] glActiveStencilFaceEXT: Binding for glActiveStencilFaceEXT.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:StencilFaceDirection"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public static void ActiveStencilFaceEXT(StencilFaceDirection face)
		{
			Debug.Assert(Delegates.pglActiveStencilFaceEXT != null, "pglActiveStencilFaceEXT not implemented");
			Delegates.pglActiveStencilFaceEXT((Int32)face);
			LogCommand("glActiveStencilFaceEXT", null, face			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_stencil_two_side")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glActiveStencilFaceEXT(Int32 face);

			[RequiredByFeature("GL_EXT_stencil_two_side")]
			[ThreadStatic]
			internal static glActiveStencilFaceEXT pglActiveStencilFaceEXT;

		}
	}

}
