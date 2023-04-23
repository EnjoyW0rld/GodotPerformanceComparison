using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>CenterContainer keeps children controls centered. This container keeps all children to their minimum size, in the center.</para>
    /// </summary>
    public partial class CenterContainer : Container
    {
        /// <summary>
        /// <para>If <c>true</c>, centers children relative to the <see cref="Godot.CenterContainer"/>'s top left corner.</para>
        /// </summary>
        public bool UseTopLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingTopLeft();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseTopLeft(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CenterContainer";

        public CenterContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CenterContainer_Ctor(this);
        }

        internal CenterContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_top_left");

        [GodotMethod("set_use_top_left")]
        [Obsolete("SetUseTopLeft is deprecated. Use the UseTopLeft property instead.")]
        public void SetUseTopLeft(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_top_left");

        [GodotMethod("is_using_top_left")]
        [Obsolete("IsUsingTopLeft is deprecated. Use the UseTopLeft property instead.")]
        public bool IsUsingTopLeft()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
