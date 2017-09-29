
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
		/// [GL] Value of GL_DRAW_PIXELS_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int DRAW_PIXELS_APPLE = 0x8A0A;

		/// <summary>
		/// [GL] Value of GL_FENCE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int FENCE_APPLE = 0x8A0B;

		/// <summary>
		/// [GL] glGenFencesAPPLE: Binding for glGenFencesAPPLE.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void GenFencesAPPLE(UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesAPPLE != null, "pglGenFencesAPPLE not implemented");
					Delegates.pglGenFencesAPPLE((Int32)fences.Length, p_fences);
					LogCommand("glGenFencesAPPLE", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenFencesAPPLE: Binding for glGenFencesAPPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public static UInt32 GenFencesAPPLE()
		{
			UInt32[] retValue = new UInt32[1];
			GenFencesAPPLE(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] glDeleteFencesAPPLE: Binding for glDeleteFencesAPPLE.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void DeleteFencesAPPLE(params UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesAPPLE != null, "pglDeleteFencesAPPLE not implemented");
					Delegates.pglDeleteFencesAPPLE((Int32)fences.Length, p_fences);
					LogCommand("glDeleteFencesAPPLE", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSetFenceAPPLE: Binding for glSetFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void SetFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglSetFenceAPPLE != null, "pglSetFenceAPPLE not implemented");
			Delegates.pglSetFenceAPPLE(fence);
			LogCommand("glSetFenceAPPLE", null, fence			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsFenceAPPLE: Binding for glIsFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool IsFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceAPPLE != null, "pglIsFenceAPPLE not implemented");
			retValue = Delegates.pglIsFenceAPPLE(fence);
			LogCommand("glIsFenceAPPLE", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glTestFenceAPPLE: Binding for glTestFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceAPPLE != null, "pglTestFenceAPPLE not implemented");
			retValue = Delegates.pglTestFenceAPPLE(fence);
			LogCommand("glTestFenceAPPLE", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glFinishFenceAPPLE: Binding for glFinishFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceAPPLE != null, "pglFinishFenceAPPLE not implemented");
			Delegates.pglFinishFenceAPPLE(fence);
			LogCommand("glFinishFenceAPPLE", null, fence			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTestObjectAPPLE: Binding for glTestObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestObjectAPPLE(Int32 @object, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestObjectAPPLE != null, "pglTestObjectAPPLE not implemented");
			retValue = Delegates.pglTestObjectAPPLE(@object, name);
			LogCommand("glTestObjectAPPLE", retValue, @object, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glFinishObjectAPPLE: Binding for glFinishObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishObjectAPPLE(Int32 @object, Int32 name)
		{
			Debug.Assert(Delegates.pglFinishObjectAPPLE != null, "pglFinishObjectAPPLE not implemented");
			Delegates.pglFinishObjectAPPLE(@object, name);
			LogCommand("glFinishObjectAPPLE", null, @object, name			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFencesAPPLE(Int32 n, UInt32* fences);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glGenFencesAPPLE pglGenFencesAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFencesAPPLE(Int32 n, UInt32* fences);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glDeleteFencesAPPLE pglDeleteFencesAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSetFenceAPPLE(UInt32 fence);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glSetFenceAPPLE pglSetFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFenceAPPLE(UInt32 fence);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glIsFenceAPPLE pglIsFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestFenceAPPLE(UInt32 fence);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glTestFenceAPPLE pglTestFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishFenceAPPLE(UInt32 fence);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glFinishFenceAPPLE pglFinishFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestObjectAPPLE(Int32 @object, UInt32 name);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glTestObjectAPPLE pglTestObjectAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishObjectAPPLE(Int32 @object, Int32 name);

			[RequiredByFeature("GL_APPLE_fence")]
			[ThreadStatic]
			internal static glFinishObjectAPPLE pglFinishObjectAPPLE;

		}
	}

}
