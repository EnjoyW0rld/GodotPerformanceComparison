using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Arranges child controls in a way to preserve their aspect ratio automatically whenever the container is resized. Solves the problem where the container size is dynamic and the contents' size needs to adjust accordingly without losing proportions.</para>
    /// </summary>
    public partial class AspectRatioContainer : Container
    {
        public enum AlignMode
        {
            /// <summary>
            /// <para>Aligns child controls with the beginning (left or top) of the container.</para>
            /// </summary>
            Begin = 0,
            /// <summary>
            /// <para>Aligns child controls with the center of the container.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Aligns child controls with the end (right or bottom) of the container.</para>
            /// </summary>
            End = 2
        }

        public enum StretchModeEnum
        {
            /// <summary>
            /// <para>The height of child controls is automatically adjusted based on the width of the container.</para>
            /// </summary>
            WidthControlsHeight = 0,
            /// <summary>
            /// <para>The width of child controls is automatically adjusted based on the height of the container.</para>
            /// </summary>
            HeightControlsWidth = 1,
            /// <summary>
            /// <para>The bounding rectangle of child controls is automatically adjusted to fit inside the container while keeping the aspect ratio.</para>
            /// </summary>
            Fit = 2,
            /// <summary>
            /// <para>The width and height of child controls is automatically adjusted to make their bounding rectangle cover the entire area of the container while keeping the aspect ratio.</para>
            /// <para>When the bounding rectangle of child controls exceed the container's size and <see cref="Godot.Control.RectClipContent"/> is enabled, this allows to show only the container's area restricted by its own bounding rectangle.</para>
            /// </summary>
            Cover = 3
        }

        /// <summary>
        /// <para>The aspect ratio to enforce on child controls. This is the width divided by the height. The ratio depends on the <see cref="Godot.AspectRatioContainer.StretchMode"/>.</para>
        /// </summary>
        public float Ratio
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The stretch mode used to align child controls.</para>
        /// </summary>
        public AspectRatioContainer.StretchModeEnum StretchMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the horizontal relative position of child controls.</para>
        /// </summary>
        public AspectRatioContainer.AlignMode AlignmentHorizontal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlignmentHorizontal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlignmentHorizontal(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Specifies the vertical relative position of child controls.</para>
        /// </summary>
        public AspectRatioContainer.AlignMode AlignmentVertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlignmentVertical();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlignmentVertical(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AspectRatioContainer";

        public AspectRatioContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AspectRatioContainer_Ctor(this);
        }

        internal AspectRatioContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ratio");

        [GodotMethod("set_ratio")]
        [Obsolete("SetRatio is deprecated. Use the Ratio property instead.")]
        public void SetRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ratio");

        [GodotMethod("get_ratio")]
        [Obsolete("GetRatio is deprecated. Use the Ratio property instead.")]
        public float GetRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_mode");

        [GodotMethod("set_stretch_mode")]
        [Obsolete("SetStretchMode is deprecated. Use the StretchMode property instead.")]
        public void SetStretchMode(AspectRatioContainer.StretchModeEnum stretchMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)stretchMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_mode");

        [GodotMethod("get_stretch_mode")]
        [Obsolete("GetStretchMode is deprecated. Use the StretchMode property instead.")]
        public AspectRatioContainer.StretchModeEnum GetStretchMode()
        {
            return (AspectRatioContainer.StretchModeEnum)NativeCalls.godot_icall_0_159(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alignment_horizontal");

        [GodotMethod("set_alignment_horizontal")]
        [Obsolete("SetAlignmentHorizontal is deprecated. Use the AlignmentHorizontal property instead.")]
        public void SetAlignmentHorizontal(AspectRatioContainer.AlignMode alignmentHorizontal)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)alignmentHorizontal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alignment_horizontal");

        [GodotMethod("get_alignment_horizontal")]
        [Obsolete("GetAlignmentHorizontal is deprecated. Use the AlignmentHorizontal property instead.")]
        public AspectRatioContainer.AlignMode GetAlignmentHorizontal()
        {
            return (AspectRatioContainer.AlignMode)NativeCalls.godot_icall_0_160(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alignment_vertical");

        [GodotMethod("set_alignment_vertical")]
        [Obsolete("SetAlignmentVertical is deprecated. Use the AlignmentVertical property instead.")]
        public void SetAlignmentVertical(AspectRatioContainer.AlignMode alignmentVertical)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)alignmentVertical);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alignment_vertical");

        [GodotMethod("get_alignment_vertical")]
        [Obsolete("GetAlignmentVertical is deprecated. Use the AlignmentVertical property instead.")]
        public AspectRatioContainer.AlignMode GetAlignmentVertical()
        {
            return (AspectRatioContainer.AlignMode)NativeCalls.godot_icall_0_160(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
