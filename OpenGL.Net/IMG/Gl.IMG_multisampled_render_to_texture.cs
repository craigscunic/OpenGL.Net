
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
		/// [GL] Value of GL_RENDERBUFFER_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int RENDERBUFFER_SAMPLES_IMG = 0x9133;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;

		/// <summary>
		/// [GL] Value of GL_MAX_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int MAX_SAMPLES_IMG = 0x9135;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int TEXTURE_SAMPLES_IMG = 0x9136;

		/// <summary>
		/// [GL] glRenderbufferStorageMultisampleIMG: Binding for glRenderbufferStorageMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleIMG != null, "pglRenderbufferStorageMultisampleIMG not implemented");
			Delegates.pglRenderbufferStorageMultisampleIMG((Int32)target, samples, (Int32)internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleIMG", null, target, samples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFramebufferTexture2DMultisampleIMG: Binding for glFramebufferTexture2DMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleIMG != null, "pglFramebufferTexture2DMultisampleIMG not implemented");
			Delegates.pglFramebufferTexture2DMultisampleIMG((Int32)target, (Int32)attachment, (Int32)textarget, texture, level, samples);
			LogCommand("glFramebufferTexture2DMultisampleIMG", null, target, attachment, textarget, texture, level, samples			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glRenderbufferStorageMultisampleIMG(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleIMG pglRenderbufferStorageMultisampleIMG;

			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFramebufferTexture2DMultisampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glFramebufferTexture2DMultisampleIMG pglFramebufferTexture2DMultisampleIMG;

		}
	}

}
