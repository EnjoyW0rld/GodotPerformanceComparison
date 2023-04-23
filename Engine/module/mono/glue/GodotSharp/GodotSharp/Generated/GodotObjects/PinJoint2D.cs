using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Pin Joint for 2D rigid bodies. It pins two bodies (rigid or static) together.</para>
    /// </summary>
    public partial class PinJoint2D : Joint2D
    {
        /// <summary>
        /// <para>The higher this value, the more the bond to the pinned partner can flex.</para>
        /// </summary>
        public float Softness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSoftness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSoftness(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PinJoint2D";

        public PinJoint2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PinJoint2D_Ctor(this);
        }

        internal PinJoint2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_softness");

        [GodotMethod("set_softness")]
        [Obsolete("SetSoftness is deprecated. Use the Softness property instead.")]
        public void SetSoftness(float softness)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), softness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_softness");

        [GodotMethod("get_softness")]
        [Obsolete("GetSoftness is deprecated. Use the Softness property instead.")]
        public float GetSoftness()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
