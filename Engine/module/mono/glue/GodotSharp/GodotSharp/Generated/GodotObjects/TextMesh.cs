using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Generate an <see cref="Godot.PrimitiveMesh"/> from the text.</para>
    /// <para>TextMesh can be generated only when using dynamic fonts with vector glyph contours. Bitmap fonts (including bitmap data in the TrueType/OpenType containers, like color emoji fonts) are not supported.</para>
    /// <para>The UV layout is arranged in 4 horizontal strips, top to bottom: 40% of the height for the front face, 40% for the back face, 10% for the outer edges and 10% for the inner edges.</para>
    /// </summary>
    public partial class TextMesh : PrimitiveMesh
    {
        public enum Align
        {
            /// <summary>
            /// <para>Align rows to the left (default).</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Align rows centered.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Align rows to the right.</para>
            /// </summary>
            Right = 2
        }

        /// <summary>
        /// <para>The text to generate mesh from.</para>
        /// </summary>
        public string Text
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetText();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetText(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Font"/> used for the <see cref="Godot.TextMesh"/>'s text.</para>
        /// </summary>
        public Font Font
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFont();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFont(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the text's horizontal alignment. Supports left, center and right. Set it to one of the <see cref="Godot.TextMesh.Align"/> constants.</para>
        /// </summary>
        public TextMesh.Align HorizontalAlignment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHorizontalAlignment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHorizontalAlignment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, all the text displays as UPPERCASE.</para>
        /// </summary>
        public bool Uppercase
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUppercase();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUppercase(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of one pixel's width on the text to scale it in 3D.</para>
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
        /// <para>Step (in pixels) used to approximate Bézier curves.</para>
        /// </summary>
        public float CurveStep
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCurveStep();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCurveStep(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Depths of the mesh, if set to <c>0.0</c> only front surface, is generated, and UV layout is changed to use full texture for the front face only.</para>
        /// </summary>
        public float Depth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepth(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "TextMesh";

        public TextMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextMesh_Ctor(this);
        }

        internal TextMesh(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_horizontal_alignment");

        [GodotMethod("set_horizontal_alignment")]
        [Obsolete("SetHorizontalAlignment is deprecated. Use the HorizontalAlignment property instead.")]
        public void SetHorizontalAlignment(TextMesh.Align alignment)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)alignment);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_horizontal_alignment");

        [GodotMethod("get_horizontal_alignment")]
        [Obsolete("GetHorizontalAlignment is deprecated. Use the HorizontalAlignment property instead.")]
        public TextMesh.Align GetHorizontalAlignment()
        {
            return (TextMesh.Align)NativeCalls.godot_icall_0_923(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_text");

        [GodotMethod("set_text")]
        [Obsolete("SetText is deprecated. Use the Text property instead.")]
        public void SetText(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_text");

        [GodotMethod("get_text")]
        [Obsolete("GetText is deprecated. Use the Text property instead.")]
        public string GetText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_font");

        [GodotMethod("set_font")]
        [Obsolete("SetFont is deprecated. Use the Font property instead.")]
        public void SetFont(Font font)
        {
            NativeCalls.godot_icall_1_24(method_bind_4, Object.GetPtr(this), Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font");

        [GodotMethod("get_font")]
        [Obsolete("GetFont is deprecated. Use the Font property instead.")]
        public Font GetFont()
        {
            return NativeCalls.godot_icall_0_322(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth");

        [GodotMethod("set_depth")]
        [Obsolete("SetDepth is deprecated. Use the Depth property instead.")]
        public void SetDepth(float depth)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        [GodotMethod("get_depth")]
        [Obsolete("GetDepth is deprecated. Use the Depth property instead.")]
        public float GetDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pixel_size");

        [GodotMethod("set_pixel_size")]
        [Obsolete("SetPixelSize is deprecated. Use the PixelSize property instead.")]
        public void SetPixelSize(float pixelSize)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), pixelSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pixel_size");

        [GodotMethod("get_pixel_size")]
        [Obsolete("GetPixelSize is deprecated. Use the PixelSize property instead.")]
        public float GetPixelSize()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_curve_step");

        [GodotMethod("set_curve_step")]
        [Obsolete("SetCurveStep is deprecated. Use the CurveStep property instead.")]
        public void SetCurveStep(float curveStep)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), curveStep);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_curve_step");

        [GodotMethod("get_curve_step")]
        [Obsolete("GetCurveStep is deprecated. Use the CurveStep property instead.")]
        public float GetCurveStep()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_uppercase");

        [GodotMethod("set_uppercase")]
        [Obsolete("SetUppercase is deprecated. Use the Uppercase property instead.")]
        public void SetUppercase(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_uppercase");

        [GodotMethod("is_uppercase")]
        [Obsolete("IsUppercase is deprecated. Use the Uppercase property instead.")]
        public bool IsUppercase()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
