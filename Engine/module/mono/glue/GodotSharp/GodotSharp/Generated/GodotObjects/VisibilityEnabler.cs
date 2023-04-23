using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The VisibilityEnabler will disable <see cref="Godot.RigidBody"/> and <see cref="Godot.AnimationPlayer"/> nodes when they are not visible. It will only affect other nodes within the same scene as the VisibilityEnabler itself.</para>
    /// <para>If you just want to receive notifications, use <see cref="Godot.VisibilityNotifier"/> instead.</para>
    /// <para>Note: VisibilityEnabler uses an approximate heuristic for performance reasons. It doesn't take walls and other occlusion into account (unless you are using <see cref="Godot.Portal"/>s). The heuristic is an implementation detail and may change in future versions. If you need precise visibility checking, use another method such as adding an <see cref="Godot.Area"/> node as a child of a <see cref="Godot.Camera"/> node and/or <c>Vector3.dot</c>.</para>
    /// <para>Note: VisibilityEnabler will not affect nodes added after scene initialization.</para>
    /// </summary>
    public partial class VisibilityEnabler : VisibilityNotifier
    {
        public enum Enabler
        {
            /// <summary>
            /// <para>This enabler will pause <see cref="Godot.AnimationPlayer"/> nodes.</para>
            /// </summary>
            PauseAnimations = 0,
            /// <summary>
            /// <para>This enabler will freeze <see cref="Godot.RigidBody"/> nodes.</para>
            /// </summary>
            FreezeBodies = 1,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisibilityEnabler.Enabler"/> enum.</para>
            /// </summary>
            Max = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.AnimationPlayer"/> nodes will be paused.</para>
        /// </summary>
        public bool PauseAnimations
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler.Enabler)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler.Enabler)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.RigidBody"/> nodes will be paused.</para>
        /// </summary>
        public bool FreezeBodies
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler.Enabler)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler.Enabler)1, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisibilityEnabler";

        public VisibilityEnabler() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisibilityEnabler_Ctor(this);
        }

        internal VisibilityEnabler(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabler");

        /// <summary>
        /// <para>Sets active state of the enabler identified by given <see cref="Godot.VisibilityEnabler.Enabler"/> constant.</para>
        /// </summary>
        [GodotMethod("set_enabler")]
        [Obsolete("SetEnabler is deprecated. Use the FreezeBodies property instead.")]
        public void SetEnabler(VisibilityEnabler.Enabler enabler, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_0, Object.GetPtr(this), (int)enabler, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_enabler_enabled");

        /// <summary>
        /// <para>Returns whether the enabler identified by given <see cref="Godot.VisibilityEnabler.Enabler"/> constant is active.</para>
        /// </summary>
        [GodotMethod("is_enabler_enabled")]
        [Obsolete("IsEnablerEnabled is deprecated. Use the FreezeBodies property instead.")]
        public bool IsEnablerEnabled(VisibilityEnabler.Enabler enabler)
        {
            return NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), (int)enabler);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
