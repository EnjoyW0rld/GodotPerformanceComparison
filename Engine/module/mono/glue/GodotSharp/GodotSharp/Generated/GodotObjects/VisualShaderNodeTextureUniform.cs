using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Performs a lookup operation on the texture provided as a uniform for the shader.</para>
    /// </summary>
    public partial class VisualShaderNodeTextureUniform : VisualShaderNodeUniform
    {
        public enum TextureTypeEnum
        {
            /// <summary>
            /// <para>No hints are added to the uniform declaration.</para>
            /// </summary>
            Data = 0,
            /// <summary>
            /// <para>Adds <c>hint_albedo</c> as hint to the uniform declaration for proper sRGB to linear conversion.</para>
            /// </summary>
            Color = 1,
            /// <summary>
            /// <para>Adds <c>hint_normal</c> as hint to the uniform declaration, which internally converts the texture for proper usage as normal map.</para>
            /// </summary>
            Normalmap = 2,
            /// <summary>
            /// <para>Adds <c>hint_aniso</c> as hint to the uniform declaration to use for a flowmap.</para>
            /// </summary>
            Aniso = 3
        }

        public enum ColorDefaultEnum
        {
            /// <summary>
            /// <para>Defaults to white color.</para>
            /// </summary>
            White = 0,
            /// <summary>
            /// <para>Defaults to black color.</para>
            /// </summary>
            Black = 1
        }

        /// <summary>
        /// <para>Defines the type of data provided by the source texture. See <see cref="Godot.VisualShaderNodeTextureUniform.TextureTypeEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeTextureUniform.TextureTypeEnum TextureType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextureType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextureType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the default color if no texture is assigned to the uniform.</para>
        /// </summary>
        public VisualShaderNodeTextureUniform.ColorDefaultEnum ColorDefault
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColorDefault();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColorDefault(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeTextureUniform";

        public VisualShaderNodeTextureUniform() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTextureUniform_Ctor(this);
        }

        internal VisualShaderNodeTextureUniform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_type");

        [GodotMethod("set_texture_type")]
        [Obsolete("SetTextureType is deprecated. Use the TextureType property instead.")]
        public void SetTextureType(VisualShaderNodeTextureUniform.TextureTypeEnum type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_type");

        [GodotMethod("get_texture_type")]
        [Obsolete("GetTextureType is deprecated. Use the TextureType property instead.")]
        public VisualShaderNodeTextureUniform.TextureTypeEnum GetTextureType()
        {
            return (VisualShaderNodeTextureUniform.TextureTypeEnum)NativeCalls.godot_icall_0_1142(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color_default");

        [GodotMethod("set_color_default")]
        [Obsolete("SetColorDefault is deprecated. Use the ColorDefault property instead.")]
        public void SetColorDefault(VisualShaderNodeTextureUniform.ColorDefaultEnum type)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color_default");

        [GodotMethod("get_color_default")]
        [Obsolete("GetColorDefault is deprecated. Use the ColorDefault property instead.")]
        public VisualShaderNodeTextureUniform.ColorDefaultEnum GetColorDefault()
        {
            return (VisualShaderNodeTextureUniform.ColorDefaultEnum)NativeCalls.godot_icall_0_1143(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
