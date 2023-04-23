using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node takes its parent <see cref="Godot.Path"/>, and returns the coordinates of a point within it, given a distance from the first vertex.</para>
    /// <para>It is useful for making other nodes follow a path, without coding the movement pattern. For that, the nodes must be children of this node. The descendant nodes will then move accordingly when setting an offset in this node.</para>
    /// </summary>
    public partial class PathFollow : Spatial
    {
        public enum RotationModeEnum
        {
            /// <summary>
            /// <para>Forbids the PathFollow to rotate.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Allows the PathFollow to rotate in the Y axis only.</para>
            /// </summary>
            Y = 1,
            /// <summary>
            /// <para>Allows the PathFollow to rotate in both the X, and Y axes.</para>
            /// </summary>
            Xy = 2,
            /// <summary>
            /// <para>Allows the PathFollow to rotate in any axis.</para>
            /// </summary>
            Xyz = 3,
            /// <summary>
            /// <para>Uses the up vector information in a <see cref="Godot.Curve3D"/> to enforce orientation. This rotation mode requires the <see cref="Godot.Path"/>'s <see cref="Godot.Curve3D.UpVectorEnabled"/> property to be set to <c>true</c>.</para>
            /// </summary>
            Oriented = 4
        }

        /// <summary>
        /// <para>The distance from the first vertex, measured in 3D units along the path. This sets this node's position to a point within the path.</para>
        /// </summary>
        public float Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance from the first vertex, considering 0.0 as the first vertex and 1.0 as the last. This is just another way of expressing the offset within the path, as the offset supplied is multiplied internally by the path's length.</para>
        /// </summary>
        public float UnitOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUnitOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUnitOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's offset along the curve.</para>
        /// </summary>
        public float HOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's offset perpendicular to the curve.</para>
        /// </summary>
        public float VOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Allows or forbids rotation on one or more axes, depending on the <see cref="Godot.PathFollow.RotationModeEnum"/> constants being used.</para>
        /// </summary>
        public PathFollow.RotationModeEnum RotationMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotationMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotationMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the position between two cached points is interpolated cubically, and linearly otherwise.</para>
        /// <para>The points along the <see cref="Godot.Curve3D"/> of the <see cref="Godot.Path"/> are precomputed before use, for faster calculations. The point at the requested offset is then calculated interpolating between two adjacent cached points. This may present a problem if the curve makes sharp turns, as the cached points may not follow the curve closely enough.</para>
        /// <para>There are two answers to this problem: either increase the number of cached points and increase memory consumption, or make a cubic interpolation between two points at the cost of (slightly) slower calculations.</para>
        /// </summary>
        public bool CubicInterp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCubicInterpolation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCubicInterpolation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, any offset outside the path's length will wrap around, instead of stopping at the ends. Use it for cyclic paths.</para>
        /// </summary>
        public bool Loop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoop(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PathFollow";

        public PathFollow() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PathFollow_Ctor(this);
        }

        internal PathFollow(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public float GetOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_offset");

        [GodotMethod("set_h_offset")]
        [Obsolete("SetHOffset is deprecated. Use the HOffset property instead.")]
        public void SetHOffset(float hOffset)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), hOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_offset");

        [GodotMethod("get_h_offset")]
        [Obsolete("GetHOffset is deprecated. Use the HOffset property instead.")]
        public float GetHOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_offset");

        [GodotMethod("set_v_offset")]
        [Obsolete("SetVOffset is deprecated. Use the VOffset property instead.")]
        public void SetVOffset(float vOffset)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), vOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_offset");

        [GodotMethod("get_v_offset")]
        [Obsolete("GetVOffset is deprecated. Use the VOffset property instead.")]
        public float GetVOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unit_offset");

        [GodotMethod("set_unit_offset")]
        [Obsolete("SetUnitOffset is deprecated. Use the UnitOffset property instead.")]
        public void SetUnitOffset(float unitOffset)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), unitOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unit_offset");

        [GodotMethod("get_unit_offset")]
        [Obsolete("GetUnitOffset is deprecated. Use the UnitOffset property instead.")]
        public float GetUnitOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation_mode");

        [GodotMethod("set_rotation_mode")]
        [Obsolete("SetRotationMode is deprecated. Use the RotationMode property instead.")]
        public void SetRotationMode(PathFollow.RotationModeEnum rotationMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), (int)rotationMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation_mode");

        [GodotMethod("get_rotation_mode")]
        [Obsolete("GetRotationMode is deprecated. Use the RotationMode property instead.")]
        public PathFollow.RotationModeEnum GetRotationMode()
        {
            return (PathFollow.RotationModeEnum)NativeCalls.godot_icall_0_728(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cubic_interpolation");

        [GodotMethod("set_cubic_interpolation")]
        [Obsolete("SetCubicInterpolation is deprecated. Use the CubicInterp property instead.")]
        public void SetCubicInterpolation(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cubic_interpolation");

        [GodotMethod("get_cubic_interpolation")]
        [Obsolete("GetCubicInterpolation is deprecated. Use the CubicInterp property instead.")]
        public bool GetCubicInterpolation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop");

        [GodotMethod("set_loop")]
        [Obsolete("SetLoop is deprecated. Use the Loop property instead.")]
        public void SetLoop(bool loop)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), loop);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_loop");

        [GodotMethod("has_loop")]
        [Obsolete("HasLoop is deprecated. Use the Loop property instead.")]
        public bool HasLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
