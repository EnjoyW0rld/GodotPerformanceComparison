using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node that displays 2D texture information in a 3D environment.</para>
    /// </summary>
    public abstract partial class SpriteBase3D : GeometryInstance
    {
        public enum DrawFlags
        {
            /// <summary>
            /// <para>If set, the texture's transparency and the opacity are used to make those parts of the sprite invisible.</para>
            /// </summary>
            Transparent = 0,
            /// <summary>
            /// <para>If set, lights in the environment affect the sprite.</para>
            /// </summary>
            Shaded = 1,
            /// <summary>
            /// <para>If set, texture can be seen from the back as well, if not, it is invisible when looking at it from behind.</para>
            /// </summary>
            DoubleSided = 2,
            /// <summary>
            /// <para>Disables the depth test, so this object is drawn on top of all others. However, objects drawn after it in the draw order may cover it.</para>
            /// </summary>
            DisableDepthTest = 3,
            /// <summary>
            /// <para>Sprite is scaled by depth so that it always appears the same size on screen.</para>
            /// </summary>
            FixedSize = 4,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.SpriteBase3D.DrawFlags"/> enum.</para>
            /// </summary>
            Max = 5
        }

        public enum AlphaCutMode
        {
            Disabled = 0,
            Discard = 1,
            OpaquePrepass = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, texture will be centered.</para>
        /// </summary>
        public bool Centered
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCentered();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCentered(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's drawing offset.</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped horizontally.</para>
        /// </summary>
        public bool FlipH
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedH();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipH(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture is flipped vertically.</para>
        /// </summary>
        public bool FlipV
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFlippedV();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlipV(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A color value used to multiply the texture's colors. Can be used for mood-coloring or to simulate the color of light.</para>
        /// <para>Note: If a <see cref="Godot.GeometryInstance.MaterialOverride"/> is defined on the <see cref="Godot.SpriteBase3D"/>, the material override must be configured to take vertex colors into account for albedo. Otherwise, the color defined in <see cref="Godot.SpriteBase3D.Modulate"/> will be ignored. For a <see cref="Godot.SpatialMaterial"/>, <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> must be <c>true</c>. For a <see cref="Godot.ShaderMaterial"/>, <c>ALBEDO *= COLOR.rgb;</c> must be inserted in the shader's <c>fragment()</c> function.</para>
        /// </summary>
        public Color Modulate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetModulate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetModulate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The texture's visibility on a scale from <c>0</c> (fully invisible) to <c>1</c> (fully visible). <see cref="Godot.SpriteBase3D.Opacity"/> is a multiplier for the <see cref="Godot.SpriteBase3D.Modulate"/> color's alpha channel.</para>
        /// <para>Note: If a <see cref="Godot.GeometryInstance.MaterialOverride"/> is defined on the <see cref="Godot.SpriteBase3D"/>, the material override must be configured to take vertex colors into account for albedo. Otherwise, the opacity defined in <see cref="Godot.SpriteBase3D.Opacity"/> will be ignored. For a <see cref="Godot.SpatialMaterial"/>, <see cref="Godot.SpatialMaterial.VertexColorUseAsAlbedo"/> must be <c>true</c>. For a <see cref="Godot.ShaderMaterial"/>, <c>ALPHA *= COLOR.a;</c> must be inserted in the shader's <c>fragment()</c> function.</para>
        /// </summary>
        public float Opacity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOpacity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOpacity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of one pixel's width on the sprite to scale it in 3D.</para>
        /// </summary>
        public float PixelSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPixelSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPixelSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The direction in which the front of the texture faces.</para>
        /// </summary>
        public Vector3.Axis Axis
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAxis();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAxis(value);
            }
#pragma warning restore CS0618
        }

        public SpatialMaterial.BillboardMode Billboard
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBillboardMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBillboardMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the texture's transparency and the opacity are used to make those parts of the sprite invisible.</para>
        /// </summary>
        public bool Transparent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((SpriteBase3D.DrawFlags)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((SpriteBase3D.DrawFlags)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the <see cref="Godot.Light"/> in the <see cref="Godot.Environment"/> has effects on the sprite.</para>
        /// </summary>
        public bool Shaded
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((SpriteBase3D.DrawFlags)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((SpriteBase3D.DrawFlags)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, texture can be seen from the back as well, if <c>false</c>, it is invisible when looking at it from behind.</para>
        /// </summary>
        public bool DoubleSided
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((SpriteBase3D.DrawFlags)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((SpriteBase3D.DrawFlags)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, depth testing is disabled and the object will be drawn in render order.</para>
        /// </summary>
        public bool NoDepthTest
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((SpriteBase3D.DrawFlags)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((SpriteBase3D.DrawFlags)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the label is rendered at the same size regardless of distance.</para>
        /// </summary>
        public bool FixedSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawFlag((SpriteBase3D.DrawFlags)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawFlag((SpriteBase3D.DrawFlags)4, value);
            }
#pragma warning restore CS0618
        }

        public SpriteBase3D.AlphaCutMode AlphaCut
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlphaCutMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlphaCutMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the render priority for the sprite. Higher priority objects will be sorted in front of lower priority objects.</para>
        /// <para>Note: This only applies if <see cref="Godot.SpriteBase3D.AlphaCut"/> is set to <see cref="Godot.SpriteBase3D.AlphaCutMode.Disabled"/> (default value).</para>
        /// <para>Note: This only applies to sorting of transparent objects. This will not impact how transparent objects are sorted relative to opaque objects. This is because opaque objects are not sorted, while transparent objects are sorted from back to front (subject to priority).</para>
        /// </summary>
        public int RenderPriority
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRenderPriority();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRenderPriority(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SpriteBase3D";

        internal SpriteBase3D() {}

        internal SpriteBase3D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_centered");

        [GodotMethod("set_centered")]
        [Obsolete("SetCentered is deprecated. Use the Centered property instead.")]
        public void SetCentered(bool centered)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), centered);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_centered");

        [GodotMethod("is_centered")]
        [Obsolete("IsCentered is deprecated. Use the Centered property instead.")]
        public bool IsCentered()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_h");

        [GodotMethod("set_flip_h")]
        [Obsolete("SetFlipH is deprecated. Use the FlipH property instead.")]
        public void SetFlipH(bool flipH)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), flipH);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_h");

        [GodotMethod("is_flipped_h")]
        [Obsolete("IsFlippedH is deprecated. Use the FlipH property instead.")]
        public bool IsFlippedH()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flip_v");

        [GodotMethod("set_flip_v")]
        [Obsolete("SetFlipV is deprecated. Use the FlipV property instead.")]
        public void SetFlipV(bool flipV)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), flipV);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_flipped_v");

        [GodotMethod("is_flipped_v")]
        [Obsolete("IsFlippedV is deprecated. Use the FlipV property instead.")]
        public bool IsFlippedV()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_modulate");

        [GodotMethod("set_modulate")]
        [Obsolete("SetModulate is deprecated. Use the Modulate property instead.")]
        public void SetModulate(Color modulate)
        {
            NativeCalls.godot_icall_1_199(method_bind_8, Object.GetPtr(this), ref modulate);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modulate");

        [GodotMethod("get_modulate")]
        [Obsolete("GetModulate is deprecated. Use the Modulate property instead.")]
        public Color GetModulate()
        {
            NativeCalls.godot_icall_0_200(method_bind_9, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_opacity");

        [GodotMethod("set_opacity")]
        [Obsolete("SetOpacity is deprecated. Use the Opacity property instead.")]
        public void SetOpacity(float opacity)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), opacity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_opacity");

        [GodotMethod("get_opacity")]
        [Obsolete("GetOpacity is deprecated. Use the Opacity property instead.")]
        public float GetOpacity()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_render_priority");

        [GodotMethod("set_render_priority")]
        [Obsolete("SetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public void SetRenderPriority(int priority)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), priority);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_render_priority");

        [GodotMethod("get_render_priority")]
        [Obsolete("GetRenderPriority is deprecated. Use the RenderPriority property instead.")]
        public int GetRenderPriority()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pixel_size");

        [GodotMethod("set_pixel_size")]
        [Obsolete("SetPixelSize is deprecated. Use the PixelSize property instead.")]
        public void SetPixelSize(float pixelSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_14, Object.GetPtr(this), pixelSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pixel_size");

        [GodotMethod("get_pixel_size")]
        [Obsolete("GetPixelSize is deprecated. Use the PixelSize property instead.")]
        public float GetPixelSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_axis");

        [GodotMethod("set_axis")]
        [Obsolete("SetAxis is deprecated. Use the Axis property instead.")]
        public void SetAxis(Vector3.Axis axis)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), (int)axis);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_axis");

        [GodotMethod("get_axis")]
        [Obsolete("GetAxis is deprecated. Use the Axis property instead.")]
        public Vector3.Axis GetAxis()
        {
            return (Vector3.Axis)NativeCalls.godot_icall_0_880(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_flag");

        /// <summary>
        /// <para>If <c>true</c>, the specified flag will be enabled.</para>
        /// </summary>
        [GodotMethod("set_draw_flag")]
        [Obsolete("SetDrawFlag is deprecated. Use the FixedSize property instead.")]
        public void SetDrawFlag(SpriteBase3D.DrawFlags flag, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_18, Object.GetPtr(this), (int)flag, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_draw_flag");

        /// <summary>
        /// <para>Returns the value of the specified flag.</para>
        /// </summary>
        [GodotMethod("get_draw_flag")]
        [Obsolete("GetDrawFlag is deprecated. Use the FixedSize property instead.")]
        public bool GetDrawFlag(SpriteBase3D.DrawFlags flag)
        {
            return NativeCalls.godot_icall_1_35(method_bind_19, Object.GetPtr(this), (int)flag);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alpha_cut_mode");

        [GodotMethod("set_alpha_cut_mode")]
        [Obsolete("SetAlphaCutMode is deprecated. Use the AlphaCut property instead.")]
        public void SetAlphaCutMode(SpriteBase3D.AlphaCutMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_20, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alpha_cut_mode");

        [GodotMethod("get_alpha_cut_mode")]
        [Obsolete("GetAlphaCutMode is deprecated. Use the AlphaCut property instead.")]
        public SpriteBase3D.AlphaCutMode GetAlphaCutMode()
        {
            return (SpriteBase3D.AlphaCutMode)NativeCalls.godot_icall_0_881(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_billboard_mode");

        [GodotMethod("set_billboard_mode")]
        [Obsolete("SetBillboardMode is deprecated. Use the Billboard property instead.")]
        public void SetBillboardMode(SpatialMaterial.BillboardMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_22, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_billboard_mode");

        [GodotMethod("get_billboard_mode")]
        [Obsolete("GetBillboardMode is deprecated. Use the Billboard property instead.")]
        public SpatialMaterial.BillboardMode GetBillboardMode()
        {
            return (SpatialMaterial.BillboardMode)NativeCalls.godot_icall_0_578(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_item_rect");

        /// <summary>
        /// <para>Returns the rectangle representing this sprite.</para>
        /// </summary>
        [GodotMethod("get_item_rect")]
        public Rect2 GetItemRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_24, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate_triangle_mesh");

        [GodotMethod("generate_triangle_mesh")]
        public TriangleMesh GenerateTriangleMesh()
        {
            return NativeCalls.godot_icall_0_580(method_bind_25, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
