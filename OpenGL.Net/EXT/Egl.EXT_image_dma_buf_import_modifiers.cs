
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_FD_EXT = 0x3440;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_OFFSET_EXT = 0x3441;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_PITCH_EXT = 0x3442;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE0_MODIFIER_LO_EXT = 0x3443;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE0_MODIFIER_HI_EXT = 0x3444;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE1_MODIFIER_LO_EXT = 0x3445;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE1_MODIFIER_HI_EXT = 0x3446;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE2_MODIFIER_LO_EXT = 0x3447;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE2_MODIFIER_HI_EXT = 0x3448;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_MODIFIER_LO_EXT = 0x3449;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_MODIFIER_HI_EXT = 0x344A;

		/// <summary>
		/// [EGL] eglQueryDmaBufFormatsEXT: Binding for eglQueryDmaBufFormatsEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="max_formats">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="formats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="num_formats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public static bool QueryDmaBufFormatsEXT(IntPtr dpy, int max_formats, int[] formats, int[] num_formats)
		{
			bool retValue;

			unsafe {
				fixed (int* p_formats = formats)
				fixed (int* p_num_formats = num_formats)
				{
					Debug.Assert(Delegates.peglQueryDmaBufFormatsEXT != null, "peglQueryDmaBufFormatsEXT not implemented");
					retValue = Delegates.peglQueryDmaBufFormatsEXT(dpy, max_formats, p_formats, p_num_formats);
					LogCommand("eglQueryDmaBufFormatsEXT", retValue, dpy, max_formats, formats, num_formats					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryDmaBufModifiersEXT: Binding for eglQueryDmaBufModifiersEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="max_modifiers">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modifiers">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		/// <param name="external_only">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <param name="num_modifiers">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public static bool QueryDmaBufModifiersEXT(IntPtr dpy, int format, int max_modifiers, UInt64[] modifiers, bool[] external_only, int[] num_modifiers)
		{
			bool retValue;

			unsafe {
				fixed (UInt64* p_modifiers = modifiers)
				fixed (bool* p_external_only = external_only)
				fixed (int* p_num_modifiers = num_modifiers)
				{
					Debug.Assert(Delegates.peglQueryDmaBufModifiersEXT != null, "peglQueryDmaBufModifiersEXT not implemented");
					retValue = Delegates.peglQueryDmaBufModifiersEXT(dpy, format, max_modifiers, p_modifiers, p_external_only, p_num_modifiers);
					LogCommand("eglQueryDmaBufModifiersEXT", retValue, dpy, format, max_modifiers, modifiers, external_only, num_modifiers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDmaBufFormatsEXT(IntPtr dpy, int max_formats, int* formats, int* num_formats);

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			internal static eglQueryDmaBufFormatsEXT peglQueryDmaBufFormatsEXT;

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDmaBufModifiersEXT(IntPtr dpy, int format, int max_modifiers, UInt64* modifiers, bool* external_only, int* num_modifiers);

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			internal static eglQueryDmaBufModifiersEXT peglQueryDmaBufModifiersEXT;

		}
	}

}
