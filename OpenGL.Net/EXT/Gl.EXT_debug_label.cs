
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
		/// [GL] Value of GL_PROGRAM_PIPELINE_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public const int PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;

		/// <summary>
		/// [GL] Value of GL_BUFFER_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public const int BUFFER_OBJECT_EXT = 0x9151;

		/// <summary>
		/// [GL] Value of GL_QUERY_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int QUERY_OBJECT_EXT = 0x9153;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int VERTEX_ARRAY_OBJECT_EXT = 0x9154;

		/// <summary>
		/// [GL] glLabelObjectEXT: Binding for glLabelObjectEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="object">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public static void LabelObjectEXT(Int32 type, UInt32 @object, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglLabelObjectEXT != null, "pglLabelObjectEXT not implemented");
			Delegates.pglLabelObjectEXT(type, @object, length, label);
			LogCommand("glLabelObjectEXT", null, type, @object, length, label			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetObjectLabelEXT: Binding for glGetObjectLabelEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="object">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		public static void GetObjectLabelEXT(Int32 type, UInt32 @object, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetObjectLabelEXT != null, "pglGetObjectLabelEXT not implemented");
					Delegates.pglGetObjectLabelEXT(type, @object, bufSize, p_length, label);
					LogCommand("glGetObjectLabelEXT", null, type, @object, bufSize, length, label					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glLabelObjectEXT(Int32 type, UInt32 @object, Int32 length, String label);

			[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glLabelObjectEXT pglLabelObjectEXT;

			[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
			#if !NETCORE && !NETSTANDARD1_4
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetObjectLabelEXT(Int32 type, UInt32 @object, Int32 bufSize, Int32* length, [Out] StringBuilder label);

			[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetObjectLabelEXT pglGetObjectLabelEXT;

		}
	}

}
