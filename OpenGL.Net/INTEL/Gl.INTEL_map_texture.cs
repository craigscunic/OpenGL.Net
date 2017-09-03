
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
		/// [GL] Value of GL_TEXTURE_MEMORY_LAYOUT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEFAULT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_DEFAULT_INTEL = 0;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_LINEAR_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_LINEAR_INTEL = 1;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_LINEAR_CPU_CACHED_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;

		/// <summary>
		/// [GL] glSyncTextureINTEL: Binding for glSyncTextureINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static void SyncTextureINTEL(UInt32 texture)
		{
			Debug.Assert(Delegates.pglSyncTextureINTEL != null, "pglSyncTextureINTEL not implemented");
			Delegates.pglSyncTextureINTEL(texture);
			LogCommand("glSyncTextureINTEL", null, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glUnmapTexture2DINTEL: Binding for glUnmapTexture2DINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static void UnmapTexture2DINTEL(UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglUnmapTexture2DINTEL != null, "pglUnmapTexture2DINTEL not implemented");
			Delegates.pglUnmapTexture2DINTEL(texture, level);
			LogCommand("glUnmapTexture2DINTEL", null, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMapTexture2DINTEL: Binding for glMapTexture2DINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="layout">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static IntPtr MapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32[] stride, Int32[] layout)
		{
			IntPtr retValue;

			unsafe {
				fixed (Int32* p_stride = stride)
				fixed (Int32* p_layout = layout)
				{
					Debug.Assert(Delegates.pglMapTexture2DINTEL != null, "pglMapTexture2DINTEL not implemented");
					retValue = Delegates.pglMapTexture2DINTEL(texture, level, access, p_stride, p_layout);
					LogCommand("glMapTexture2DINTEL", retValue, texture, level, access, stride, layout					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_INTEL_map_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSyncTextureINTEL(UInt32 texture);

			[RequiredByFeature("GL_INTEL_map_texture")]
			[ThreadStatic]
			internal static glSyncTextureINTEL pglSyncTextureINTEL;

			[RequiredByFeature("GL_INTEL_map_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);

			[RequiredByFeature("GL_INTEL_map_texture")]
			[ThreadStatic]
			internal static glUnmapTexture2DINTEL pglUnmapTexture2DINTEL;

			[RequiredByFeature("GL_INTEL_map_texture")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32* stride, Int32* layout);

			[RequiredByFeature("GL_INTEL_map_texture")]
			[ThreadStatic]
			internal static glMapTexture2DINTEL pglMapTexture2DINTEL;

		}
	}

}
