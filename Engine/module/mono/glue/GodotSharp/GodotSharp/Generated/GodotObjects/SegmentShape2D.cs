using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Segment shape for 2D collisions. Consists of two points, <c>a</c> and <c>b</c>.</para>
    /// </summary>
    public partial class SegmentShape2D : Shape2D
    {
        /// <summary>
        /// <para>The segment's first point position.</para>
        /// </summary>
        public Vector2 A
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetA();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetA(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The segment's second point position.</para>
        /// </summary>
        public Vector2 B
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetB();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetB(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "SegmentShape2D";

        public SegmentShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SegmentShape2D_Ctor(this);
        }

        internal SegmentShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_a");

        [GodotMethod("set_a")]
        [Obsolete("SetA is deprecated. Use the A property instead.")]
        public void SetA(Vector2 a)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref a);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_a");

        [GodotMethod("get_a")]
        [Obsolete("GetA is deprecated. Use the A property instead.")]
        public Vector2 GetA()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_b");

        [GodotMethod("set_b")]
        [Obsolete("SetB is deprecated. Use the B property instead.")]
        public void SetB(Vector2 b)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref b);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_b");

        [GodotMethod("get_b")]
        [Obsolete("GetB is deprecated. Use the B property instead.")]
        public Vector2 GetB()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
