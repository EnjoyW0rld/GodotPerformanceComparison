using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.Texture"/> resource that crops out one part of the <see cref="Godot.AtlasTexture.Atlas"/> texture, defined by <see cref="Godot.AtlasTexture.Region"/>. The main use case is cropping out textures from a texture atlas, which is a big texture file that packs multiple smaller textures. Consists of a <see cref="Godot.Texture"/> for the <see cref="Godot.AtlasTexture.Atlas"/>, a <see cref="Godot.AtlasTexture.Region"/> that defines the area of <see cref="Godot.AtlasTexture.Atlas"/> to use, and a <see cref="Godot.AtlasTexture.Margin"/> that defines the border width.</para>
    /// <para><see cref="Godot.AtlasTexture"/> cannot be used in an <see cref="Godot.AnimatedTexture"/>, cannot be tiled in nodes such as <see cref="Godot.TextureRect"/>, and does not work properly if used inside of other <see cref="Godot.AtlasTexture"/> resources. Multiple <see cref="Godot.AtlasTexture"/> resources can be used to crop multiple textures from the atlas. Using a texture atlas helps to optimize video memory costs and render calls compared to using multiple small files.</para>
    /// <para>Note: AtlasTextures don't support repetition. The <see cref="Godot.Texture.FlagsEnum.Repeat"/> and <see cref="Godot.Texture.FlagsEnum.MirroredRepeat"/> flags are ignored when using an AtlasTexture.</para>
    /// </summary>
    public partial class AtlasTexture : Texture
    {
        /// <summary>
        /// <para>The texture that contains the atlas. Can be any <see cref="Godot.Texture"/> subtype.</para>
        /// </summary>
        public Texture Atlas
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAtlas();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAtlas(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The AtlasTexture's used region.</para>
        /// </summary>
        public Rect2 Region
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRegion();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRegion(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The margin around the region. The <see cref="Godot.Rect2"/>'s <c>Rect2.size</c> parameter ("w" and "h" in the editor) resizes the texture so it fits within the margin.</para>
        /// </summary>
        public Rect2 Margin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, clips the area outside of the region to avoid bleeding of the surrounding texture pixels.</para>
        /// </summary>
        public bool FilterClip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasFilterClip();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFilterClip(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AtlasTexture";

        public AtlasTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AtlasTexture_Ctor(this);
        }

        internal AtlasTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_atlas");

        [GodotMethod("set_atlas")]
        [Obsolete("SetAtlas is deprecated. Use the Atlas property instead.")]
        public void SetAtlas(Texture atlas)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(atlas));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_atlas");

        [GodotMethod("get_atlas")]
        [Obsolete("GetAtlas is deprecated. Use the Atlas property instead.")]
        public Texture GetAtlas()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region");

        [GodotMethod("set_region")]
        [Obsolete("SetRegion is deprecated. Use the Region property instead.")]
        public void SetRegion(Rect2 region)
        {
            NativeCalls.godot_icall_1_162(method_bind_2, Object.GetPtr(this), ref region);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region");

        [GodotMethod("get_region")]
        [Obsolete("GetRegion is deprecated. Use the Region property instead.")]
        public Rect2 GetRegion()
        {
            NativeCalls.godot_icall_0_163(method_bind_3, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(Rect2 margin)
        {
            NativeCalls.godot_icall_1_162(method_bind_4, Object.GetPtr(this), ref margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public Rect2 GetMargin()
        {
            NativeCalls.godot_icall_0_163(method_bind_5, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_filter_clip");

        [GodotMethod("set_filter_clip")]
        [Obsolete("SetFilterClip is deprecated. Use the FilterClip property instead.")]
        public void SetFilterClip(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_filter_clip");

        [GodotMethod("has_filter_clip")]
        [Obsolete("HasFilterClip is deprecated. Use the FilterClip property instead.")]
        public bool HasFilterClip()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
