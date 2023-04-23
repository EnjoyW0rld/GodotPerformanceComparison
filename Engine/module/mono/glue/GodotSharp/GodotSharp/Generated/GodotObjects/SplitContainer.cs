using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Container for splitting two <see cref="Godot.Control"/>s vertically or horizontally, with a grabber that allows adjusting the split offset or ratio.</para>
    /// </summary>
    public abstract partial class SplitContainer : Container
    {
        public enum DraggerVisibilityEnum
        {
            /// <summary>
            /// <para>The split dragger is visible when the cursor hovers it.</para>
            /// </summary>
            Visible = 0,
            /// <summary>
            /// <para>The split dragger is never visible.</para>
            /// </summary>
            Hidden = 1,
            /// <summary>
            /// <para>The split dragger is never visible and its space collapsed.</para>
            /// </summary>
            HiddenCollapsed = 2
        }

        /// <summary>
        /// <para>The initial offset of the splitting between the two <see cref="Godot.Control"/>s, with <c>0</c> being at the end of the first <see cref="Godot.Control"/>.</para>
        /// </summary>
        public int SplitOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSplitOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSplitOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the area of the first <see cref="Godot.Control"/> will be collapsed and the dragger will be disabled.</para>
        /// </summary>
        public bool Collapsed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCollapsed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollapsed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Determines the dragger's visibility. See <see cref="Godot.SplitContainer.DraggerVisibilityEnum"/> for details.</para>
        /// </summary>
        public SplitContainer.DraggerVisibilityEnum DraggerVisibility
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDraggerVisibility();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDraggerVisibility(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SplitContainer";

        internal SplitContainer() {}

        internal SplitContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_split_offset");

        [GodotMethod("set_split_offset")]
        [Obsolete("SetSplitOffset is deprecated. Use the SplitOffset property instead.")]
        public void SetSplitOffset(int offset)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_split_offset");

        [GodotMethod("get_split_offset")]
        [Obsolete("GetSplitOffset is deprecated. Use the SplitOffset property instead.")]
        public int GetSplitOffset()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clamp_split_offset");

        /// <summary>
        /// <para>Clamps the <see cref="Godot.SplitContainer.SplitOffset"/> value to not go outside the currently possible minimal and maximum values.</para>
        /// </summary>
        [GodotMethod("clamp_split_offset")]
        public void ClampSplitOffset()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collapsed");

        [GodotMethod("set_collapsed")]
        [Obsolete("SetCollapsed is deprecated. Use the Collapsed property instead.")]
        public void SetCollapsed(bool collapsed)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), collapsed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_collapsed");

        [GodotMethod("is_collapsed")]
        [Obsolete("IsCollapsed is deprecated. Use the Collapsed property instead.")]
        public bool IsCollapsed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_dragger_visibility");

        [GodotMethod("set_dragger_visibility")]
        [Obsolete("SetDraggerVisibility is deprecated. Use the DraggerVisibility property instead.")]
        public void SetDraggerVisibility(SplitContainer.DraggerVisibilityEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_dragger_visibility");

        [GodotMethod("get_dragger_visibility")]
        [Obsolete("GetDraggerVisibility is deprecated. Use the DraggerVisibility property instead.")]
        public SplitContainer.DraggerVisibilityEnum GetDraggerVisibility()
        {
            return (SplitContainer.DraggerVisibilityEnum)NativeCalls.godot_icall_0_879(method_bind_6, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
