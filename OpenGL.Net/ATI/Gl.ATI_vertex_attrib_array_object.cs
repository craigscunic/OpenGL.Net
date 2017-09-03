
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
		/// [GL] glVertexAttribArrayObjectATI: Binding for glVertexAttribArrayObjectATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexAttribType"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
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
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void VertexAttribArrayObjectATI(UInt32 index, Int32 size, VertexAttribType type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglVertexAttribArrayObjectATI != null, "pglVertexAttribArrayObjectATI not implemented");
			Delegates.pglVertexAttribArrayObjectATI(index, size, (Int32)type, normalized, stride, buffer, offset);
			LogCommand("glVertexAttribArrayObjectATI", null, index, size, type, normalized, stride, buffer, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVertexAttribArrayObjectfvATI: Binding for glGetVertexAttribArrayObjectfvATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void GetVertexAttribArrayObjectATI(UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribArrayObjectfvATI != null, "pglGetVertexAttribArrayObjectfvATI not implemented");
					Delegates.pglGetVertexAttribArrayObjectfvATI(index, pname, p_params);
					LogCommand("glGetVertexAttribArrayObjectfvATI", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVertexAttribArrayObjectivATI: Binding for glGetVertexAttribArrayObjectivATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void GetVertexAttribArrayObjectATI(UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribArrayObjectivATI != null, "pglGetVertexAttribArrayObjectivATI not implemented");
					Delegates.pglGetVertexAttribArrayObjectivATI(index, pname, p_params);
					LogCommand("glGetVertexAttribArrayObjectivATI", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glVertexAttribArrayObjectATI pglVertexAttribArrayObjectATI;

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribArrayObjectfvATI(UInt32 index, Int32 pname, float* @params);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectfvATI pglGetVertexAttribArrayObjectfvATI;

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribArrayObjectivATI(UInt32 index, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectivATI pglGetVertexAttribArrayObjectivATI;

		}
	}

}
