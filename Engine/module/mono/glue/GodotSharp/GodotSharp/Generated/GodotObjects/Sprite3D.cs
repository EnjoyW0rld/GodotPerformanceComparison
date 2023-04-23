using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node that displays a 2D texture in a 3D environment. The texture displayed can be a region from a larger atlas texture, or a frame from a sprite sheet animation.</para>
    /// </summary>
    public partial class Sprite3D : SpriteBase3D
    {
        /// <summary>
        /// <para><see cref="Godot.Texture"/> object to draw. If <see cref="Godot.GeometryInstance.MaterialOverride"/> is used, this will be overridden. The size information is still used.</para>
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
        /// <para>The number of columns in the sprite sheet.</para>
        /// </summary>
        public int Hframes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHframes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHframes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of rows in the sprite sheet.</para>
        /// </summary>
        public int Vframes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVframes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVframes(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Current frame to display from sprite sheet. <see cref="Godot.Sprite3D.Hframes"/> or <see cref="Godot.Sprite3D.Vframes"/> must be greater than 1.</para>
        /// </summary>
        public int Frame
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrame();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrame(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Coordinates of the frame to display from sprite sheet. This is as an alias for the <see cref="Godot.Sprite3D.Frame"/> property. <see cref="Godot.Sprite3D.Hframes"/> or <see cref="Godot.Sprite3D.Vframes"/> must be greater than 1.</para>
        /// </summary>
        public Vector2 FrameCoords
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameCoords();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameCoords(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture will be cut from a larger atlas texture. See <see cref="Godot.Sprite3D.RegionRect"/>.</para>
        /// </summary>
        public bool RegionEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsRegion();
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
        /// <para>The region of the atlas texture to display. <see cref="Godot.Sprite3D.RegionEnabled"/> must be <c>true</c>.</para>
        /// </summary>
        public Rect2 RegionRect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRegionRect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRegionRect(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Sprite3D";

        public Sprite3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Sprite3D_Ctor(this);
        }

        internal Sprite3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region");

        [GodotMethod("set_region")]
        [Obsolete("SetRegion is deprecated. Use the RegionEnabled property instead.")]
        public void SetRegion(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_2, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_region");

        [GodotMethod("is_region")]
        [Obsolete("IsRegion is deprecated. Use the RegionEnabled property instead.")]
        public bool IsRegion()
        {
            return NativeCalls.godot_icall_0_7(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_region_rect");

        [GodotMethod("set_region_rect")]
        [Obsolete("SetRegionRect is deprecated. Use the RegionRect property instead.")]
        public void SetRegionRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_4, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_region_rect");

        [GodotMethod("get_region_rect")]
        [Obsolete("GetRegionRect is deprecated. Use the RegionRect property instead.")]
        public Rect2 GetRegionRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_5, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame");

        [GodotMethod("set_frame")]
        [Obsolete("SetFrame is deprecated. Use the Frame property instead.")]
        public void SetFrame(int frame)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), frame);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame");

        [GodotMethod("get_frame")]
        [Obsolete("GetFrame is deprecated. Use the Frame property instead.")]
        public int GetFrame()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame_coords");

        [GodotMethod("set_frame_coords")]
        [Obsolete("SetFrameCoords is deprecated. Use the FrameCoords property instead.")]
        public void SetFrameCoords(Vector2 coords)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref coords);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_coords");

        [GodotMethod("get_frame_coords")]
        [Obsolete("GetFrameCoords is deprecated. Use the FrameCoords property instead.")]
        public Vector2 GetFrameCoords()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vframes");

        [GodotMethod("set_vframes")]
        [Obsolete("SetVframes is deprecated. Use the Vframes property instead.")]
        public void SetVframes(int vframes)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), vframes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_vframes");

        [GodotMethod("get_vframes")]
        [Obsolete("GetVframes is deprecated. Use the Vframes property instead.")]
        public int GetVframes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_hframes");

        [GodotMethod("set_hframes")]
        [Obsolete("SetHframes is deprecated. Use the Hframes property instead.")]
        public void SetHframes(int hframes)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), hframes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_hframes");

        [GodotMethod("get_hframes")]
        [Obsolete("GetHframes is deprecated. Use the Hframes property instead.")]
        public int GetHframes()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
