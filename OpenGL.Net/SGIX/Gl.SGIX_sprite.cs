
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
		/// [GL] Value of GL_SPRITE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_SGIX = 0x8148;

		/// <summary>
		/// [GL] Value of GL_SPRITE_MODE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_MODE_SGIX = 0x8149;

		/// <summary>
		/// [GL] Value of GL_SPRITE_AXIS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_AXIS_SGIX = 0x814A;

		/// <summary>
		/// [GL] Value of GL_SPRITE_TRANSLATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_TRANSLATION_SGIX = 0x814B;

		/// <summary>
		/// [GL] Value of GL_SPRITE_AXIAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_AXIAL_SGIX = 0x814C;

		/// <summary>
		/// [GL] Value of GL_SPRITE_OBJECT_ALIGNED_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;

		/// <summary>
		/// [GL] Value of GL_SPRITE_EYE_ALIGNED_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_EYE_ALIGNED_SGIX = 0x814E;

		/// <summary>
		/// [GL] glSpriteParameterfSGIX: Binding for glSpriteParameterfSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglSpriteParameterfSGIX != null, "pglSpriteParameterfSGIX not implemented");
			Delegates.pglSpriteParameterfSGIX(pname, param);
			LogCommand("glSpriteParameterfSGIX", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSpriteParameterfvSGIX: Binding for glSpriteParameterfvSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglSpriteParameterfvSGIX != null, "pglSpriteParameterfvSGIX not implemented");
					Delegates.pglSpriteParameterfvSGIX(pname, p_params);
					LogCommand("glSpriteParameterfvSGIX", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSpriteParameteriSGIX: Binding for glSpriteParameteriSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglSpriteParameteriSGIX != null, "pglSpriteParameteriSGIX not implemented");
			Delegates.pglSpriteParameteriSGIX(pname, param);
			LogCommand("glSpriteParameteriSGIX", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSpriteParameterivSGIX: Binding for glSpriteParameterivSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglSpriteParameterivSGIX != null, "pglSpriteParameterivSGIX not implemented");
					Delegates.pglSpriteParameterivSGIX(pname, p_params);
					LogCommand("glSpriteParameterivSGIX", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_sprite")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSpriteParameterfSGIX(Int32 pname, float param);

			[RequiredByFeature("GL_SGIX_sprite")]
			[ThreadStatic]
			internal static glSpriteParameterfSGIX pglSpriteParameterfSGIX;

			[RequiredByFeature("GL_SGIX_sprite")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glSpriteParameterfvSGIX(Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_sprite")]
			[ThreadStatic]
			internal static glSpriteParameterfvSGIX pglSpriteParameterfvSGIX;

			[RequiredByFeature("GL_SGIX_sprite")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSpriteParameteriSGIX(Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_sprite")]
			[ThreadStatic]
			internal static glSpriteParameteriSGIX pglSpriteParameteriSGIX;

			[RequiredByFeature("GL_SGIX_sprite")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glSpriteParameterivSGIX(Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_sprite")]
			[ThreadStatic]
			internal static glSpriteParameterivSGIX pglSpriteParameterivSGIX;

		}
	}

}
