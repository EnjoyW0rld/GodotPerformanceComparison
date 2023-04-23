using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class allows you to define a custom shader program that can be used by a <see cref="Godot.ShaderMaterial"/>. Shaders allow you to write your own custom behavior for rendering objects or updating particle information. For a detailed explanation and usage, please see the tutorials linked below.</para>
    /// </summary>
    public partial class Shader : Resource
    {
        public enum Mode
        {
            /// <summary>
            /// <para>Mode used to draw all 3D objects.</para>
            /// </summary>
            Spatial = 0,
            /// <summary>
            /// <para>Mode used to draw all 2D objects.</para>
            /// </summary>
            CanvasItem = 1,
            /// <summary>
            /// <para>Mode used to calculate particle information on a per-particle basis. Not used for drawing.</para>
            /// </summary>
            Particles = 2
        }

        /// <summary>
        /// <para>Returns the shader's code as the user has written it, not the full generated code used internally.</para>
        /// </summary>
        public string Code
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Returns the shader's custom defines. Custom defines can be used in Godot to add GLSL preprocessor directives (e.g: extensions) required for the shader logic.</para>
        /// <para>Note: Custom defines are not validated by the Godot shader parser, so care should be taken when using them.</para>
        /// </summary>
        public string CustomDefines
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomDefines();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomDefines(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Shader";

        public Shader() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Shader_Ctor(this);
        }

        internal Shader(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mode");

        /// <summary>
        /// <para>Returns the shader mode for the shader, either <see cref="Godot.Shader.Mode.CanvasItem"/>, <see cref="Godot.Shader.Mode.Spatial"/> or <see cref="Godot.Shader.Mode.Particles"/>.</para>
        /// </summary>
        [GodotMethod("get_mode")]
        public Shader.Mode GetMode()
        {
            return (Shader.Mode)NativeCalls.godot_icall_0_851(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_code");

        [GodotMethod("set_code")]
        [Obsolete("SetCode is deprecated. Use the Code property instead.")]
        public void SetCode(string code)
        {
            NativeCalls.godot_icall_1_54(method_bind_1, Object.GetPtr(this), code);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_code");

        [GodotMethod("get_code")]
        [Obsolete("GetCode is deprecated. Use the Code property instead.")]
        public string GetCode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_texture_param");

        /// <summary>
        /// <para>Sets the default texture to be used with a texture uniform. The default is used if a texture is not set in the <see cref="Godot.ShaderMaterial"/>.</para>
        /// <para>Note: <c>param</c> must match the name of the uniform in the code exactly.</para>
        /// </summary>
        [GodotMethod("set_default_texture_param")]
        public void SetDefaultTextureParam(string param, Texture texture)
        {
            NativeCalls.godot_icall_2_114(method_bind_3, Object.GetPtr(this), param, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_texture_param");

        /// <summary>
        /// <para>Returns the texture that is set as default for the specified parameter.</para>
        /// <para>Note: <c>param</c> must match the name of the uniform in the code exactly.</para>
        /// </summary>
        [GodotMethod("get_default_texture_param")]
        public Texture GetDefaultTextureParam(string param)
        {
            return NativeCalls.godot_icall_1_852(method_bind_4, Object.GetPtr(this), param);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_defines");

        [GodotMethod("set_custom_defines")]
        [Obsolete("SetCustomDefines is deprecated. Use the CustomDefines property instead.")]
        public void SetCustomDefines(string customDefines)
        {
            NativeCalls.godot_icall_1_54(method_bind_5, Object.GetPtr(this), customDefines);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_defines");

        [GodotMethod("get_custom_defines")]
        [Obsolete("GetCustomDefines is deprecated. Use the CustomDefines property instead.")]
        public string GetCustomDefines()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_param");

        /// <summary>
        /// <para>Returns <c>true</c> if the shader has this param defined as a uniform in its code.</para>
        /// <para>Note: <c>param</c> must match the name of the uniform in the code exactly.</para>
        /// </summary>
        [GodotMethod("has_param")]
        public bool HasParam(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_7, Object.GetPtr(this), name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
