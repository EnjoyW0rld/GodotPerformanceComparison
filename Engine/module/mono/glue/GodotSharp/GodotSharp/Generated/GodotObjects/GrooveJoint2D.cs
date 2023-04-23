using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Groove constraint for 2D physics. This is useful for making a body "slide" through a segment placed in another.</para>
    /// </summary>
    public partial class GrooveJoint2D : Joint2D
    {
        /// <summary>
        /// <para>The groove's length. The groove is from the joint's origin towards <see cref="Godot.GrooveJoint2D.Length"/> along the joint's local Y axis.</para>
        /// </summary>
        public float Length
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLength();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLength(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The body B's initial anchor position defined by the joint's origin and a local offset <see cref="Godot.GrooveJoint2D.InitialOffset"/> along the joint's Y axis (along the groove).</para>
        /// </summary>
        public float InitialOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInitialOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInitialOffset(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GrooveJoint2D";

        public GrooveJoint2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GrooveJoint2D_Ctor(this);
        }

        internal GrooveJoint2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_length");

        [GodotMethod("set_length")]
        [Obsolete("SetLength is deprecated. Use the Length property instead.")]
        public void SetLength(float length)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), length);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_length");

        [GodotMethod("get_length")]
        [Obsolete("GetLength is deprecated. Use the Length property instead.")]
        public float GetLength()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_initial_offset");

        [GodotMethod("set_initial_offset")]
        [Obsolete("SetInitialOffset is deprecated. Use the InitialOffset property instead.")]
        public void SetInitialOffset(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_initial_offset");

        [GodotMethod("get_initial_offset")]
        [Obsolete("GetInitialOffset is deprecated. Use the InitialOffset property instead.")]
        public float GetInitialOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
