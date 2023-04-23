using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Editor facility that helps you draw a 2D polygon used as resource for <see cref="Godot.LightOccluder2D"/>.</para>
    /// </summary>
    public partial class OccluderPolygon2D : Resource
    {
        public enum CullModeEnum
        {
            /// <summary>
            /// <para>Culling is disabled. See <see cref="Godot.OccluderPolygon2D.CullMode"/>.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Culling is performed in the clockwise direction. See <see cref="Godot.OccluderPolygon2D.CullMode"/>.</para>
            /// </summary>
            Clockwise = 1,
            /// <summary>
            /// <para>Culling is performed in the counterclockwise direction. See <see cref="Godot.OccluderPolygon2D.CullMode"/>.</para>
            /// </summary>
            CounterClockwise = 2
        }

        /// <summary>
        /// <para>If <c>true</c>, closes the polygon. A closed OccluderPolygon2D occludes the light coming from any direction. An opened OccluderPolygon2D occludes the light only at its outline's direction.</para>
        /// </summary>
        public bool Closed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClosed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClosed(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The culling mode to use.</para>
        /// </summary>
        public OccluderPolygon2D.CullModeEnum CullMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCullMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCullMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>A <see cref="Godot.Vector2"/> array with the index for polygon's vertices positions.</para>
        /// <para>Note: The returned value is a copy of the underlying array, rather than a reference.</para>
        /// </summary>
        public Vector2[] Polygon
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPolygon();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPolygon(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "OccluderPolygon2D";

        public OccluderPolygon2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OccluderPolygon2D_Ctor(this);
        }

        internal OccluderPolygon2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_closed");

        [GodotMethod("set_closed")]
        [Obsolete("SetClosed is deprecated. Use the Closed property instead.")]
        public void SetClosed(bool closed)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), closed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_closed");

        [GodotMethod("is_closed")]
        [Obsolete("IsClosed is deprecated. Use the Closed property instead.")]
        public bool IsClosed()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cull_mode");

        [GodotMethod("set_cull_mode")]
        [Obsolete("SetCullMode is deprecated. Use the CullMode property instead.")]
        public void SetCullMode(OccluderPolygon2D.CullModeEnum cullMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)cullMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cull_mode");

        [GodotMethod("get_cull_mode")]
        [Obsolete("GetCullMode is deprecated. Use the CullMode property instead.")]
        public OccluderPolygon2D.CullModeEnum GetCullMode()
        {
            return (OccluderPolygon2D.CullModeEnum)NativeCalls.godot_icall_0_701(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_polygon");

        [GodotMethod("set_polygon")]
        [Obsolete("SetPolygon is deprecated. Use the Polygon property instead.")]
        public void SetPolygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_235(method_bind_4, Object.GetPtr(this), polygon);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_polygon");

        [GodotMethod("get_polygon")]
        [Obsolete("GetPolygon is deprecated. Use the Polygon property instead.")]
        public Vector2[] GetPolygon()
        {
            return NativeCalls.godot_icall_0_236(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
