
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
		/// [GL] Value of GL_TEXTURE_BINDING_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_NV = 0x8E55;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLER_RENDERBUFFER_NV = 0x8E56;

		/// <summary>
		/// [GL] Value of GL_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;

		/// <summary>
		/// [GL] glSampleMaskIndexedNV: Binding for glSampleMaskIndexedNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void SampleMaskIndexedNV(UInt32 index, UInt32 mask)
		{
			Debug.Assert(Delegates.pglSampleMaskIndexedNV != null, "pglSampleMaskIndexedNV not implemented");
			Delegates.pglSampleMaskIndexedNV(index, mask);
			LogCommand("glSampleMaskIndexedNV", null, index, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexRenderbufferNV: Binding for glTexRenderbufferNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void TexRenderbufferNV(TextureTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglTexRenderbufferNV != null, "pglTexRenderbufferNV not implemented");
			Delegates.pglTexRenderbufferNV((Int32)target, renderbuffer);
			LogCommand("glTexRenderbufferNV", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_explicit_multisample")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSampleMaskIndexedNV(UInt32 index, UInt32 mask);

			[RequiredByFeature("GL_NV_explicit_multisample")]
			[ThreadStatic]
			internal static glSampleMaskIndexedNV pglSampleMaskIndexedNV;

			[RequiredByFeature("GL_NV_explicit_multisample")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexRenderbufferNV(Int32 target, UInt32 renderbuffer);

			[RequiredByFeature("GL_NV_explicit_multisample")]
			[ThreadStatic]
			internal static glTexRenderbufferNV pglTexRenderbufferNV;

		}
	}

}
