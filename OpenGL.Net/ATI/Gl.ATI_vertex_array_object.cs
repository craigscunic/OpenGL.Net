
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
		/// [GL] Value of GL_STATIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int STATIC_ATI = 0x8760;

		/// <summary>
		/// [GL] Value of GL_DYNAMIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int DYNAMIC_ATI = 0x8761;

		/// <summary>
		/// [GL] Value of GL_PRESERVE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int PRESERVE_ATI = 0x8762;

		/// <summary>
		/// [GL] Value of GL_DISCARD_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int DISCARD_ATI = 0x8763;

		/// <summary>
		/// [GL] Value of GL_OBJECT_BUFFER_SIZE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int OBJECT_BUFFER_SIZE_ATI = 0x8764;

		/// <summary>
		/// [GL] Value of GL_OBJECT_BUFFER_USAGE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int OBJECT_BUFFER_USAGE_ATI = 0x8765;

		/// <summary>
		/// [GL] Value of GL_ARRAY_OBJECT_BUFFER_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int ARRAY_OBJECT_BUFFER_ATI = 0x8766;

		/// <summary>
		/// [GL] Value of GL_ARRAY_OBJECT_OFFSET_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int ARRAY_OBJECT_OFFSET_ATI = 0x8767;

		/// <summary>
		/// [GL] glNewObjectBufferATI: Binding for glNewObjectBufferATI.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static UInt32 NewObjectBufferATI(Int32 size, IntPtr pointer, Int32 usage)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglNewObjectBufferATI != null, "pglNewObjectBufferATI not implemented");
			retValue = Delegates.pglNewObjectBufferATI(size, pointer, usage);
			LogCommand("glNewObjectBufferATI", retValue, size, pointer, usage			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glNewObjectBufferATI: Binding for glNewObjectBufferATI.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static UInt32 NewObjectBufferATI(Int32 size, Object pointer, Int32 usage)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				return (NewObjectBufferATI(size, pin_pointer.AddrOfPinnedObject(), usage));
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// [GL] glIsObjectBufferATI: Binding for glIsObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static bool IsObjectBufferATI(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsObjectBufferATI != null, "pglIsObjectBufferATI not implemented");
			retValue = Delegates.pglIsObjectBufferATI(buffer);
			LogCommand("glIsObjectBufferATI", retValue, buffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glUpdateObjectBufferATI: Binding for glUpdateObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="preserve">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Int32 preserve)
		{
			Debug.Assert(Delegates.pglUpdateObjectBufferATI != null, "pglUpdateObjectBufferATI not implemented");
			Delegates.pglUpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
			LogCommand("glUpdateObjectBufferATI", null, buffer, offset, size, pointer, preserve			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glUpdateObjectBufferATI: Binding for glUpdateObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="preserve">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, Object pointer, Int32 preserve)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				UpdateObjectBufferATI(buffer, offset, size, pin_pointer.AddrOfPinnedObject(), preserve);
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// [GL] glGetObjectBufferfvATI: Binding for glGetObjectBufferfvATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetObjectBufferATI(UInt32 buffer, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectBufferfvATI != null, "pglGetObjectBufferfvATI not implemented");
					Delegates.pglGetObjectBufferfvATI(buffer, pname, p_params);
					LogCommand("glGetObjectBufferfvATI", null, buffer, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetObjectBufferivATI: Binding for glGetObjectBufferivATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetObjectBufferATI(UInt32 buffer, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectBufferivATI != null, "pglGetObjectBufferivATI not implemented");
					Delegates.pglGetObjectBufferivATI(buffer, pname, p_params);
					LogCommand("glGetObjectBufferivATI", null, buffer, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFreeObjectBufferATI: Binding for glFreeObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void FreeObjectBufferATI(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglFreeObjectBufferATI != null, "pglFreeObjectBufferATI not implemented");
			Delegates.pglFreeObjectBufferATI(buffer);
			LogCommand("glFreeObjectBufferATI", null, buffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glArrayObjectATI: Binding for glArrayObjectATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void ArrayObjectATI(EnableCap array, Int32 size, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglArrayObjectATI != null, "pglArrayObjectATI not implemented");
			Delegates.pglArrayObjectATI((Int32)array, size, type, stride, buffer, offset);
			LogCommand("glArrayObjectATI", null, array, size, type, stride, buffer, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetArrayObjectfvATI: Binding for glGetArrayObjectfvATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetArrayObjectATI(EnableCap array, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetArrayObjectfvATI != null, "pglGetArrayObjectfvATI not implemented");
					Delegates.pglGetArrayObjectfvATI((Int32)array, pname, p_params);
					LogCommand("glGetArrayObjectfvATI", null, array, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetArrayObjectivATI: Binding for glGetArrayObjectivATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetArrayObjectATI(EnableCap array, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetArrayObjectivATI != null, "pglGetArrayObjectivATI not implemented");
					Delegates.pglGetArrayObjectivATI((Int32)array, pname, p_params);
					LogCommand("glGetArrayObjectivATI", null, array, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVariantArrayObjectATI: Binding for glVariantArrayObjectATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void VariantArrayObjectATI(UInt32 id, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglVariantArrayObjectATI != null, "pglVariantArrayObjectATI not implemented");
			Delegates.pglVariantArrayObjectATI(id, type, stride, buffer, offset);
			LogCommand("glVariantArrayObjectATI", null, id, type, stride, buffer, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVariantArrayObjectfvATI: Binding for glGetVariantArrayObjectfvATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetVariantArrayObjectATI(UInt32 id, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVariantArrayObjectfvATI != null, "pglGetVariantArrayObjectfvATI not implemented");
					Delegates.pglGetVariantArrayObjectfvATI(id, pname, p_params);
					LogCommand("glGetVariantArrayObjectfvATI", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVariantArrayObjectivATI: Binding for glGetVariantArrayObjectivATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetVariantArrayObjectATI(UInt32 id, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVariantArrayObjectivATI != null, "pglGetVariantArrayObjectivATI not implemented");
					Delegates.pglGetVariantArrayObjectivATI(id, pname, p_params);
					LogCommand("glGetVariantArrayObjectivATI", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glNewObjectBufferATI(Int32 size, IntPtr pointer, Int32 usage);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glNewObjectBufferATI pglNewObjectBufferATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsObjectBufferATI(UInt32 buffer);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glIsObjectBufferATI pglIsObjectBufferATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Int32 preserve);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glUpdateObjectBufferATI pglUpdateObjectBufferATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectBufferfvATI(UInt32 buffer, Int32 pname, float* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetObjectBufferfvATI pglGetObjectBufferfvATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectBufferivATI(UInt32 buffer, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetObjectBufferivATI pglGetObjectBufferivATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFreeObjectBufferATI(UInt32 buffer);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glFreeObjectBufferATI pglFreeObjectBufferATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glArrayObjectATI(Int32 array, Int32 size, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glArrayObjectATI pglArrayObjectATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetArrayObjectfvATI(Int32 array, Int32 pname, float* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetArrayObjectfvATI pglGetArrayObjectfvATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetArrayObjectivATI(Int32 array, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetArrayObjectivATI pglGetArrayObjectivATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVariantArrayObjectATI(UInt32 id, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glVariantArrayObjectATI pglVariantArrayObjectATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantArrayObjectfvATI(UInt32 id, Int32 pname, float* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetVariantArrayObjectfvATI pglGetVariantArrayObjectfvATI;

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantArrayObjectivATI(UInt32 id, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ATI_vertex_array_object")]
			[ThreadStatic]
			internal static glGetVariantArrayObjectivATI pglGetVariantArrayObjectivATI;

		}
	}

}
