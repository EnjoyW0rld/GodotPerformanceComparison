using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Line shape for 2D collisions. It works like a 2D plane and will not allow any physics body to go to the negative side. Not recommended for rigid bodies, and usually not recommended for static bodies either because it forces checks against it on every frame.</para>
    /// </summary>
    public partial class LineShape2D : Shape2D
    {
        /// <summary>
        /// <para>The line's normal.</para>
        /// </summary>
        public Vector2 Normal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormal(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The line's distance from the origin.</para>
        /// </summary>
        public float D
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetD();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetD(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "LineShape2D";

        public LineShape2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_LineShape2D_Ctor(this);
        }

        internal LineShape2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal");

        [GodotMethod("set_normal")]
        [Obsolete("SetNormal is deprecated. Use the Normal property instead.")]
        public void SetNormal(Vector2 normal)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref normal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal");

        [GodotMethod("get_normal")]
        [Obsolete("GetNormal is deprecated. Use the Normal property instead.")]
        public Vector2 GetNormal()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_d");

        [GodotMethod("set_d")]
        [Obsolete("SetD is deprecated. Use the D property instead.")]
        public void SetD(float d)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), d);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_d");

        [GodotMethod("get_d")]
        [Obsolete("GetD is deprecated. Use the D property instead.")]
        public float GetD()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
