# OpenGL.Net

[![Build Status](https://travis-ci.org/luca-piccioni/OpenGL.Net.svg?branch=master)](https://travis-ci.org/luca-piccioni/OpenGL.Net)

Modern OpenGL binding for C#.

Generated from the lastest official XML specification, OpenGL.Net provides:
- Strongly typed enumerants: we like strongly-typed enumerations and flags. 
- Function pointer wrappers, with unsafe and strongly-typed arguments: because the garbage collector we're required to pin
  managed objects in order to use the OpenGL entry points; OpenGL.Net functions already fix the arguments for you. Of course
  the unmanaged pointer capability is reserved for those situation that you'll face.
- OpenGL entry points overloading.
- Automatic entry points aliasing management: many OpenGL commands were introduced in extensions, which were promoted from ARB
  or in core specification; if the semantic of these commands didn't change, they can be called equivalently. When the OpenGL
  specification assert a command equivalency, the corresponding OpenGL.Net function will fallback to equivalent commands in
  case the current host does not implement the specific core function.
- Fully documented OpenGL entry points with the official manual pages (GL2 and GL4 repositories): having a nice and complete
  documentation integrated with your IDE will be of great help.
- Integrated entry points call logging: every OpenGL call could be logged for debugging. Additionally every OpenGL command is
  checked for errors, to catch a soon as possible OpenGL errors.

Currently implemented API are:
- [OpenGL 4.5](https://www.opengl.org/registry/), including compatibility profile
- [OpenGL ES 3.2](https://www.khronos.org/registry/gles/), including OpenGL ES 1.0
- WGL, GLX 1.4 and [EGL (Native Platform Interface) 1.5](https://www.khronos.org/registry/egl/) as platform APIs.

# Instructions

In order to use OpenGL.Net you only need to link the library; Then it is just to write code.
Due the current state of the project, it is advisable to clone the repository and work directly with the library, since this method offers more flexible solution.

### Clone the repository

Follow the command below to clone and build the repository.

    git clone https://github.com/luca-piccioni/OpenGL.Net.git
    cd OpenGL.Net
    msbuild /p:Configuration=Release OpenGL.Net.sln`

The executable will be located at `OpenGL.Net/OpenGL.Net/bin/Release/OpenGL.Net.dll`.

### NuGet

Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run the following command:

    Install-Package OpenGL.Net

or just download the [nuget binary package](https://www.nuget.org/packages/OpenGL.Net/)

# Using the Forms control

OpenGL.Net comes with a *System.Windows.Forms* control that allow to draw using OpenGL.Net without much hassle. You need to just design the control instance in you application, and handle the relevant events to manage the drawing operations.

```C#
private void RenderControl_ContextCreated(object sender, GlControlEventArgs e)
{
	// Here you can allocate resources or initialize state
    Gl.MatrixMode(MatrixMode.Projection);
    Gl.LoadIdentity();
    Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

    Gl.MatrixMode(MatrixMode.Modelview);
    Gl.LoadIdentity();
}

private void RenderControl_Render(object sender, GlControlEventArgs e)
{
    Control senderControl = (Control)sender;

	Gl.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height);
	Gl.Clear(ClearBufferMask.ColorBufferBit);

	Gl.Begin(PrimitiveType.Triangles);
	Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.0f, 0.0f);
	Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.5f, 1.0f);
	Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(1.0f, 0.0f);
	Gl.End();
}

private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
{
    // Here you can dispose resources allocated in RenderControl_ContextCreated
}
```