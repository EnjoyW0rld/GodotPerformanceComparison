using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translated to <c>texture(cubemap, vec3)</c> in the shader language. Returns a color vector and alpha channel as scalar.</para>
    /// </summary>
    public partial class VisualShaderNodeCubeMap : VisualShaderNode
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
            /// <para>Use the <see cref="Godot.CubeMap"/> set via <see cref="Godot.VisualShaderNodeCubeMap.CubeMap"/>. If this is set to <see cref="Godot.VisualShaderNodeCubeMap.Source"/>, the <c>samplerCube</c> port is ignored.</para>
            /// </summary>
            Texture = 0,
            /// <summary>
            /// <para>Use the <see cref="Godot.CubeMap"/> sampler reference passed via the <c>samplerCube</c> port. If this is set to <see cref="Godot.VisualShaderNodeCubeMap.Source"/>, the <see cref="Godot.VisualShaderNodeCubeMap.CubeMap"/> texture is ignored.</para>
            /// </summary>
            Port = 1
        }

        /// <summary>
        /// <para>Defines which source should be used for the sampling. See <see cref="Godot.VisualShaderNodeCubeMap.SourceEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeCubeMap.SourceEnum Source
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
        /// <para>The <see cref="Godot.CubeMap"/> texture to sample when using <see cref="Godot.VisualShaderNodeCubeMap.SourceEnum.Texture"/> as <see cref="Godot.VisualShaderNodeCubeMap.Source"/>.</para>
        /// </summary>
        public CubeMap CubeMap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCubeMap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCubeMap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Defines the type of data provided by the source texture. See <see cref="Godot.VisualShaderNodeCubeMap.TextureTypeEnum"/> for options.</para>
        /// </summary>
        public VisualShaderNodeCubeMap.TextureTypeEnum TextureType
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

        private const string nativeName = "VisualShaderNodeCubeMap";

        public VisualShaderNodeCubeMap() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeCubeMap_Ctor(this);
        }

        internal VisualShaderNodeCubeMap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_source");

        [GodotMethod("set_source")]
        [Obsolete("SetSource is deprecated. Use the Source property instead.")]
        public void SetSource(VisualShaderNodeCubeMap.SourceEnum value)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_source");

        [GodotMethod("get_source")]
        [Obsolete("GetSource is deprecated. Use the Source property instead.")]
        public VisualShaderNodeCubeMap.SourceEnum GetSource()
        {
            return (VisualShaderNodeCubeMap.SourceEnum)NativeCalls.godot_icall_0_1132(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cube_map");

        [GodotMethod("set_cube_map")]
        [Obsolete("SetCubeMap is deprecated. Use the CubeMap property instead.")]
        public void SetCubeMap(CubeMap value)
        {
            NativeCalls.godot_icall_1_24(method_bind_2, Object.GetPtr(this), Object.GetPtr(value));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cube_map");

        [GodotMethod("get_cube_map")]
        [Obsolete("GetCubeMap is deprecated. Use the CubeMap property instead.")]
        public CubeMap GetCubeMap()
        {
            return NativeCalls.godot_icall_0_1133(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture_type");

        [GodotMethod("set_texture_type")]
        [Obsolete("SetTextureType is deprecated. Use the TextureType property instead.")]
        public void SetTextureType(VisualShaderNodeCubeMap.TextureTypeEnum value)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture_type");

        [GodotMethod("get_texture_type")]
        [Obsolete("GetTextureType is deprecated. Use the TextureType property instead.")]
        public VisualShaderNodeCubeMap.TextureTypeEnum GetTextureType()
        {
            return (VisualShaderNodeCubeMap.TextureTypeEnum)NativeCalls.godot_icall_0_1134(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
