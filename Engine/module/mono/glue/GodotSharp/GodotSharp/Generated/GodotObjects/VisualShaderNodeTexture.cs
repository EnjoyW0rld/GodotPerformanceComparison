using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Performs a lookup operation on the provided texture, with support for multiple texture sources to choose from.</para>
    /// </summary>
    public partial class VisualShaderNodeTexture : VisualShaderNode
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
            Normalmap = 2
        }

        public enum SourceEnum
        {
            /// <summary>
            /// <para>Use the texture given as an argument for this function.</para>
            /// </summary>
            Texture = 0,
            /// <summary>
            /// <para>Use the current viewport's texture as the source.</para>
            /// </summary>
            Screen = 1,
            /// <summary>
            /// <para>Use the texture from this shader's texture built-in (e.g. a texture of a <see cref="Godot.Sprite"/>).</para>
            /// </summary>
            Source2dTexture = 2,
            /// <summary>
            /// <para>Use the texture from this shader's normal map built-in.</para>
            /// </summary>
            Source2dNormal = 3,
            /// <summary>
            /// <para>Use the depth texture available for this shader.</para>
            /// </summary>
            Depth = 4,
            /// <summary>
            /// <para>Use the texture provided in the input port for this function.</para>
            /// </summary>
            Port = 5
        }

        /// <summary>
        /// <para>Determines the source for the lookup. See <see cref="Godot.VisualShaderNodeTexture.SourceEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeTexture.SourceEnum Source
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSource();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSource(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The source texture, if needed for the selected <see cref="Godot.VisualShaderNodeTexture.Source"/>.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the type of the texture if <see cref="Godot.VisualShaderNodeTexture.Source"/> is set to <see cref="Godot.VisualShaderNodeTexture.SourceEnum.Texture"/>. See <see cref="Godot.VisualShaderNodeTexture.TextureTypeEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeTexture.TextureTypeEnum TextureType
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

        private const string nativeName = "VisualShaderNodeTexture";

        public VisualShaderNodeTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeTexture_Ctor(this);
        }

        internal VisualShaderNodeTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_source");

        [GodotMethod("set_source")]
        [Obsolete("SetSource is deprecated. Use the Source property instead.")]
        public void SetSource(VisualShaderNodeTexture.SourceEnum value)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_source");

        [GodotMethod("get_source")]
        [Obsolete("GetSource is deprecated. Use the Source property instead.")]
        public VisualShaderNodeTexture.SourceEnum GetSource()
        {
            return (VisualShaderNodeTexture.SourceEnum)NativeCalls.godot_icall_0_1140(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture value)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(value));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_type");

        [GodotMethod("set_texture_type")]
        [Obsolete("SetTextureType is deprecated. Use the TextureType property instead.")]
        public void SetTextureType(VisualShaderNodeTexture.TextureTypeEnum value)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_type");

        [GodotMethod("get_texture_type")]
        [Obsolete("GetTextureType is deprecated. Use the TextureType property instead.")]
        public VisualShaderNodeTexture.TextureTypeEnum GetTextureType()
        {
            return (VisualShaderNodeTexture.TextureTypeEnum)NativeCalls.godot_icall_0_1141(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
