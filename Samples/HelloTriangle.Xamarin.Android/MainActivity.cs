﻿
// Copyright (C) 2016-2017 Luca Piccioni
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

using Android.App;
using Android.OS;
using Android.Content.PM;

using OpenGL;

namespace HelloTriangle.Xamarin
{
	[Activity(Label = "HelloTriangle.Xamarin", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden)]
	public class MainActivity : Activity
	{
		#region Rendering

		private void SurfaceView_ContextCreated(object sender, GlSurfaceViewEventArgs e)
		{
			Es2_ContextCreated();
		}

		private void SurfaceView_Render(object sender, GlSurfaceViewEventArgs e)
		{
			GLSurfaceView glSurfaceView = (GLSurfaceView)sender;

			Gl.Viewport(0, 0, glSurfaceView.Width, glSurfaceView.Height);
			Gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			Es2_Render();
		}

		private void SurfaceView_ContextDestroying(object sender, GlSurfaceViewEventArgs e)
		{
			Es2_ContextDestroying();
		}

		/// <summary>
		/// Vertex position array.
		/// </summary>
		private static readonly float[] _ArrayPosition = new float[] {
			0.0f, 0.0f,
			0.5f, 1.0f,
			1.0f, 0.0f
		};

		/// <summary>
		/// Vertex color array.
		/// </summary>
		private static readonly float[] _ArrayColor = new float[] {
			1.0f, 0.0f, 0.0f,
			0.0f, 1.0f, 0.0f,
			0.0f, 0.0f, 1.0f
		};

		#endregion

		#region Rendering (ES 1.0)

		private void Es1_ContextCreated()
		{
			// Here you can allocate resources or initialize state
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();
		}

		private void Es1_Render()
		{
			// Old school OpenGL 1.1
			// Setup & enable client states to specify vertex arrays, and use Gl.DrawArrays instead of Gl.Begin/End paradigm
			using (MemoryLock vertexArrayLock = new MemoryLock(_ArrayPosition)) 
			using (MemoryLock vertexColorLock = new MemoryLock(_ArrayColor))
			{
				// Note: the use of MemoryLock objects is necessary to pin vertex arrays since they can be reallocated by GC
				// at any time between the Gl.VertexPointer execution and the Gl.DrawArrays execution

				Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address);
				Gl.EnableClientState(EnableCap.VertexArray);

				Gl.ColorPointer(3, ColorPointerType.Float, 0, vertexColorLock.Address);
				Gl.EnableClientState(EnableCap.ColorArray);

				Gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
			}
		}

		private void Es1_ContextDestroying()
		{
			
		}

		#endregion

		#region Rendering (ES 2.0)

		private void Es2_ContextCreated()
		{
			// Vertex shader
			uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
			Gl.ShaderSource(vertexShader, _Es2_ShaderVertexSource);
			Gl.CompileShader(vertexShader);

			// Fragment shader
			uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
			Gl.ShaderSource(fragmentShader, _Es2_ShaderFragmentSource);
			Gl.CompileShader(fragmentShader);

			// Program
			_Es2_Program = Gl.CreateProgram();
			Gl.AttachShader(_Es2_Program, vertexShader);
			Gl.AttachShader(_Es2_Program, fragmentShader);
			Gl.LinkProgram(_Es2_Program);

			_Es2_Program_Location_uMVP = Gl.GetUniformLocation(_Es2_Program, "uMVP");
			_Es2_Program_Location_aPosition = Gl.GetAttribLocation(_Es2_Program, "aPosition");
			_Es2_Program_Location_aColor = Gl.GetAttribLocation(_Es2_Program, "aColor");
		}

		private void Es2_Render()
		{
			OrthoProjectionMatrix projectionMatrix = new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, 0.0f, 1.0f);

			Gl.UseProgram(_Es2_Program);

			using (MemoryLock arrayPosition = new MemoryLock(_ArrayPosition))
			using (MemoryLock arrayColor = new MemoryLock(_ArrayColor))
			{
				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aPosition, 2, VertexAttribType.Float, false, 0, arrayPosition.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aPosition);

				Gl.VertexAttribPointer((uint)_Es2_Program_Location_aColor, 3, VertexAttribType.Float, false, 0, arrayColor.Address);
				Gl.EnableVertexAttribArray((uint)_Es2_Program_Location_aColor);

				Gl.UniformMatrix4(_Es2_Program_Location_uMVP, 1, false, projectionMatrix.ToArray());

				Gl.DrawArrays(PrimitiveType.Triangles,  0, 3);
			}
		}

		private void Es2_ContextDestroying()
		{
			if (_Es2_Program != 0)
				Gl.DeleteProgram(_Es2_Program);
			_Es2_Program = 0;
		}

		private uint _Es2_Program;

		private int _Es2_Program_Location_aPosition;

		private int _Es2_Program_Location_aColor;

		private int _Es2_Program_Location_uMVP;

		private readonly string[] _Es2_ShaderVertexSource = new string[] {
			"uniform mat4 uMVP;\n",
			"attribute vec2 aPosition;\n",
			"attribute vec3 aColor;\n",
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_Position = uMVP * vec4(aPosition, 0.0, 1.0);\n",
			"	vColor = aColor;\n",
			"}\n"
		};

		private readonly string[] _Es2_ShaderFragmentSource = new string[] {
			"varying vec3 vColor;\n",
			"void main() {\n",
			"	gl_FragColor = vec4(vColor, 1.0);\n",
			"}\n"
		};

		#endregion

		#region Activity Overrides

		protected override void OnCreate(Bundle bundle)
		{
			// Base implementation
			base.OnCreate(bundle);

			// Surface view
			GLSurfaceView surfaceView = new GLSurfaceView(this);

			surfaceView.ContextCreated += SurfaceView_ContextCreated;
			surfaceView.Render += SurfaceView_Render;
			surfaceView.ContextDestroying += SurfaceView_ContextDestroying;
			
			SetContentView(surfaceView);
		}

		#endregion
	}
}

