
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
		/// [GL] Value of GL_COVERAGE_COMPONENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_COMPONENT_NV = 0x8ED0;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_COMPONENT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_COMPONENT4_NV = 0x8ED1;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_ATTACHMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_ATTACHMENT_NV = 0x8ED2;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_BUFFERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_BUFFERS_NV = 0x8ED3;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_SAMPLES_NV = 0x8ED4;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_ALL_FRAGMENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_EDGE_FRAGMENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_AUTOMATIC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_AUTOMATIC_NV = 0x8ED7;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_BUFFER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COVERAGE_BUFFER_BIT_NV = 0x00008000;

		/// <summary>
		/// [GL] glCoverageMaskNV: Binding for glCoverageMaskNV.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public static void CoverageMaskNV(bool mask)
		{
			Debug.Assert(Delegates.pglCoverageMaskNV != null, "pglCoverageMaskNV not implemented");
			Delegates.pglCoverageMaskNV(mask);
			LogCommand("glCoverageMaskNV", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glCoverageOperationNV: Binding for glCoverageOperationNV.
		/// </summary>
		/// <param name="operation">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public static void CoverageOpNV(Int32 operation)
		{
			Debug.Assert(Delegates.pglCoverageOperationNV != null, "pglCoverageOperationNV not implemented");
			Delegates.pglCoverageOperationNV(operation);
			LogCommand("glCoverageOperationNV", null, operation			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCoverageMaskNV(bool mask);

			[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
			[ThreadStatic]
			internal static glCoverageMaskNV pglCoverageMaskNV;

			[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCoverageOperationNV(Int32 operation);

			[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
			[ThreadStatic]
			internal static glCoverageOperationNV pglCoverageOperationNV;

		}
	}

}
