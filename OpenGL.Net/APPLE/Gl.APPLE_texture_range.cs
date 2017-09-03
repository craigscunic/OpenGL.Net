
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
		/// [GL] Value of GL_TEXTURE_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_POINTER_APPLE = 0x85B8;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_STORAGE_HINT_APPLE = 0x85BC;

		/// <summary>
		/// [GL] Value of GL_STORAGE_PRIVATE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int STORAGE_PRIVATE_APPLE = 0x85BD;

		/// <summary>
		/// [GL] glTextureRangeAPPLE: Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void TextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTextureRangeAPPLE != null, "pglTextureRangeAPPLE not implemented");
			Delegates.pglTextureRangeAPPLE(target, length, pointer);
			LogCommand("glTextureRangeAPPLE", null, target, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTextureRangeAPPLE: Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void TextureRangeAPPLE(Int32 target, Int32 length, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TextureRangeAPPLE(target, length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// [GL] glGetTexParameterPointervAPPLE: Binding for glGetTexParameterPointervAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void GetTexParameterPointerAPPLE(Int32 target, Int32 pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTexParameterPointervAPPLE != null, "pglGetTexParameterPointervAPPLE not implemented");
					Delegates.pglGetTexParameterPointervAPPLE(target, pname, p_params);
					LogCommand("glGetTexParameterPointervAPPLE", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetTexParameterPointervAPPLE: Binding for glGetTexParameterPointervAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public static void GetTexParameterPointerAPPLE(Int32 target, Int32 pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetTexParameterPointerAPPLE(target, pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_texture_range")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTextureRangeAPPLE(Int32 target, Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_texture_range")]
			[ThreadStatic]
			internal static glTextureRangeAPPLE pglTextureRangeAPPLE;

			[RequiredByFeature("GL_APPLE_texture_range")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexParameterPointervAPPLE(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_APPLE_texture_range")]
			[ThreadStatic]
			internal static glGetTexParameterPointervAPPLE pglGetTexParameterPointervAPPLE;

		}
	}

}
