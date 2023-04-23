using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A <see cref="Godot.Container"/> node that holds a <see cref="Godot.Viewport"/>, automatically setting the viewport's size.</para>
    /// <para>Note: Changing a ViewportContainer's <see cref="Godot.Control.RectScale"/> will cause its contents to appear distorted. To change its visual size without causing distortion, adjust the node's margins instead (if it's not already in a container).</para>
    /// </summary>
    public partial class ViewportContainer : Container
    {
        /// <summary>
        /// <para>If <c>true</c>, the viewport will be scaled to the control's size.</para>
        /// </summary>
        public bool Stretch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsStretchEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretch(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Divides the viewport's effective resolution by this value while preserving its scale. This can be used to speed up rendering.</para>
        /// <para>For example, a 1280×720 viewport with <see cref="Godot.ViewportContainer.StretchShrink"/> set to <c>2</c> will be rendered at 640×360 while occupying the same size in the container.</para>
        /// <para>Note: <see cref="Godot.ViewportContainer.Stretch"/> must be <c>true</c> for this property to work.</para>
        /// </summary>
        public int StretchShrink
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchShrink();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchShrink(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ViewportContainer";

        public ViewportContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ViewportContainer_Ctor(this);
        }

        internal ViewportContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch");

        [GodotMethod("set_stretch")]
        [Obsolete("SetStretch is deprecated. Use the Stretch property instead.")]
        public void SetStretch(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_stretch_enabled");

        [GodotMethod("is_stretch_enabled")]
        [Obsolete("IsStretchEnabled is deprecated. Use the Stretch property instead.")]
        public bool IsStretchEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_shrink");

        [GodotMethod("set_stretch_shrink")]
        [Obsolete("SetStretchShrink is deprecated. Use the StretchShrink property instead.")]
        public void SetStretchShrink(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_shrink");

        [GodotMethod("get_stretch_shrink")]
        [Obsolete("GetStretchShrink is deprecated. Use the StretchShrink property instead.")]
        public int GetStretchShrink()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
