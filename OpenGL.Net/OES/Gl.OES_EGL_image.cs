
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] glEGLImageTargetTexture2DOES: Binding for glEGLImageTargetTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetTexture2DOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetTexture2DOES != null, "pglEGLImageTargetTexture2DOES not implemented");
			Delegates.pglEGLImageTargetTexture2DOES(target, image);
			LogCommand("glEGLImageTargetTexture2DOES", null, target, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glEGLImageTargetRenderbufferStorageOES: Binding for glEGLImageTargetRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetRenderbufferStorageOES != null, "pglEGLImageTargetRenderbufferStorageOES not implemented");
			Delegates.pglEGLImageTargetRenderbufferStorageOES(target, image);
			LogCommand("glEGLImageTargetRenderbufferStorageOES", null, target, image			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEGLImageTargetTexture2DOES(Int32 target, IntPtr image);

			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glEGLImageTargetTexture2DOES pglEGLImageTargetTexture2DOES;

			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image);

			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glEGLImageTargetRenderbufferStorageOES pglEGLImageTargetRenderbufferStorageOES;

		}
	}

}
