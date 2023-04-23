using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Arranges child controls vertically or horizontally, and rearranges the controls automatically when their minimum size changes.</para>
    /// </summary>
    public abstract partial class BoxContainer : Container
    {
        public enum AlignMode
        {
            /// <summary>
            /// <para>Aligns children with the beginning of the container.</para>
            /// </summary>
            Begin = 0,
            /// <summary>
            /// <para>Aligns children with the center of the container.</para>
            /// </summary>
            Center = 1,
            /// <summary>
            /// <para>Aligns children with the end of the container.</para>
            /// </summary>
            End = 2
        }

        /// <summary>
        /// <para>The alignment of the container's children (must be one of <see cref="Godot.BoxContainer.AlignMode.Begin"/>, <see cref="Godot.BoxContainer.AlignMode.Center"/> or <see cref="Godot.BoxContainer.AlignMode.End"/>).</para>
        /// </summary>
        public BoxContainer.AlignMode Alignment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAlignment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAlignment(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BoxContainer";

        internal BoxContainer() {}

        internal BoxContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_spacer");

        /// <summary>
        /// <para>Adds a control to the box as a spacer. If <c>true</c>, <c>begin</c> will insert the spacer control in front of other children.</para>
        /// </summary>
        [GodotMethod("add_spacer")]
        public void AddSpacer(bool begin)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), begin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_alignment");

        [GodotMethod("get_alignment")]
        [Obsolete("GetAlignment is deprecated. Use the Alignment property instead.")]
        public BoxContainer.AlignMode GetAlignment()
        {
            return (BoxContainer.AlignMode)NativeCalls.godot_icall_0_222(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_alignment");

        [GodotMethod("set_alignment")]
        [Obsolete("SetAlignment is deprecated. Use the Alignment property instead.")]
        public void SetAlignment(BoxContainer.AlignMode alignment)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)alignment);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
