
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] wglEnableFrameLockI3D: Binding for wglEnableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool EnableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnableFrameLockI3D != null, "pwglEnableFrameLockI3D not implemented");
			retValue = Delegates.pwglEnableFrameLockI3D();
			LogCommand("wglEnableFrameLockI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDisableFrameLockI3D: Binding for wglDisableFrameLockI3D.
		/// </summary>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool DisableFrameLockI3D()
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDisableFrameLockI3D != null, "pwglDisableFrameLockI3D not implemented");
			retValue = Delegates.pwglDisableFrameLockI3D();
			LogCommand("wglDisableFrameLockI3D", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglIsEnabledFrameLockI3D: Binding for wglIsEnabledFrameLockI3D.
		/// </summary>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool IsEnabledFrameLockI3D([Out] bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglIsEnabledFrameLockI3D != null, "pwglIsEnabledFrameLockI3D not implemented");
					retValue = Delegates.pwglIsEnabledFrameLockI3D(p_pFlag);
					LogCommand("wglIsEnabledFrameLockI3D", retValue, pFlag					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryFrameLockMasterI3D: Binding for wglQueryFrameLockMasterI3D.
		/// </summary>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_swap_frame_lock")]
		public static bool QueryFrameLockMasterI3D(bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglQueryFrameLockMasterI3D != null, "pwglQueryFrameLockMasterI3D not implemented");
					retValue = Delegates.pwglQueryFrameLockMasterI3D(p_pFlag);
					LogCommand("wglQueryFrameLockMasterI3D", retValue, pFlag					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglEnableFrameLockI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			internal static wglEnableFrameLockI3D pwglEnableFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglDisableFrameLockI3D();

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			internal static wglDisableFrameLockI3D pwglDisableFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledFrameLockI3D(bool* pFlag);

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			internal static wglIsEnabledFrameLockI3D pwglIsEnabledFrameLockI3D;

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryFrameLockMasterI3D(bool* pFlag);

			[RequiredByFeature("WGL_I3D_swap_frame_lock")]
			internal static wglQueryFrameLockMasterI3D pwglQueryFrameLockMasterI3D;

		}
	}

}
