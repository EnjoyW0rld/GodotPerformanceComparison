using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The VisibilityEnabler2D will disable <see cref="Godot.RigidBody2D"/>, <see cref="Godot.AnimationPlayer"/>, and other nodes when they are not visible. It will only affect nodes with the same root node as the VisibilityEnabler2D, and the root node itself.</para>
    /// <para>If you just want to receive notifications, use <see cref="Godot.VisibilityNotifier2D"/> instead.</para>
    /// <para>Note: For performance reasons, VisibilityEnabler2D uses an approximate heuristic with precision determined by . If you need precise visibility checking, use another method such as adding an <see cref="Godot.Area2D"/> node as a child of a <see cref="Godot.Camera2D"/> node.</para>
    /// <para>Note: VisibilityEnabler2D will not affect nodes added after scene initialization.</para>
    /// </summary>
    public partial class VisibilityEnabler2D : VisibilityNotifier2D
    {
        public enum Enabler
        {
            /// <summary>
            /// <para>This enabler will pause <see cref="Godot.AnimationPlayer"/> nodes.</para>
            /// </summary>
            PauseAnimations = 0,
            /// <summary>
            /// <para>This enabler will freeze <see cref="Godot.RigidBody2D"/> nodes.</para>
            /// </summary>
            FreezeBodies = 1,
            /// <summary>
            /// <para>This enabler will stop <see cref="Godot.Particles2D"/> nodes.</para>
            /// </summary>
            PauseParticles = 2,
            /// <summary>
            /// <para>This enabler will stop the parent's <see cref="Godot.Node._Process"/> function.</para>
            /// </summary>
            ParentProcess = 3,
            /// <summary>
            /// <para>This enabler will stop the parent's <see cref="Godot.Node._PhysicsProcess"/> function.</para>
            /// </summary>
            ParentPhysicsProcess = 4,
            /// <summary>
            /// <para>This enabler will stop <see cref="Godot.AnimatedSprite"/> nodes animations.</para>
            /// </summary>
            PauseAnimatedSprites = 5,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisibilityEnabler2D.Enabler"/> enum.</para>
            /// </summary>
            Max = 6
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.AnimationPlayer"/> nodes will be paused.</para>
        /// </summary>
        public bool PauseAnimations
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.RigidBody2D"/> nodes will be paused.</para>
        /// </summary>
        public bool FreezeBodies
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.Particles2D"/> nodes will be paused.</para>
        /// </summary>
        public bool PauseParticles
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, <see cref="Godot.AnimatedSprite"/> nodes will be paused.</para>
        /// </summary>
        public bool PauseAnimatedSprites
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)5, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the parent's <see cref="Godot.Node._Process"/> will be stopped.</para>
        /// </summary>
        public bool ProcessParent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the parent's <see cref="Godot.Node._PhysicsProcess"/> will be stopped.</para>
        /// </summary>
        public bool PhysicsProcessParent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEnablerEnabled((VisibilityEnabler2D.Enabler)4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabler((VisibilityEnabler2D.Enabler)4, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisibilityEnabler2D";

        public VisibilityEnabler2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisibilityEnabler2D_Ctor(this);
        }

        internal VisibilityEnabler2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabler");

        /// <summary>
        /// <para>Sets active state of the enabler identified by given <see cref="Godot.VisibilityEnabler2D.Enabler"/> constant.</para>
        /// </summary>
        [GodotMethod("set_enabler")]
        [Obsolete("SetEnabler is deprecated. Use the PhysicsProcessParent property instead.")]
        public void SetEnabler(VisibilityEnabler2D.Enabler enabler, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_0, Object.GetPtr(this), (int)enabler, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_enabler_enabled");

        /// <summary>
        /// <para>Returns whether the enabler identified by given <see cref="Godot.VisibilityEnabler2D.Enabler"/> constant is active.</para>
        /// </summary>
        [GodotMethod("is_enabler_enabled")]
        [Obsolete("IsEnablerEnabled is deprecated. Use the PhysicsProcessParent property instead.")]
        public bool IsEnablerEnabled(VisibilityEnabler2D.Enabler enabler)
        {
            return NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), (int)enabler);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
