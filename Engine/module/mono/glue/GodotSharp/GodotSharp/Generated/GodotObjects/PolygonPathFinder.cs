using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class PolygonPathFinder : Resource
    {
        public Godot.Collections.Dictionary Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "PolygonPathFinder";

        public PolygonPathFinder() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PolygonPathFinder_Ctor(this);
        }

        internal PolygonPathFinder(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "setup");

        [GodotMethod("setup")]
        public void Setup(Vector2[] points, int[] connections)
        {
            NativeCalls.godot_icall_2_795(method_bind_0, Object.GetPtr(this), points, connections);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_path");

        [GodotMethod("find_path")]
        public Vector2[] FindPath(Vector2 from, Vector2 to)
        {
            return NativeCalls.godot_icall_2_796(method_bind_1, Object.GetPtr(this), ref from, ref to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_intersections");

        [GodotMethod("get_intersections")]
        public Vector2[] GetIntersections(Vector2 from, Vector2 to)
        {
            return NativeCalls.godot_icall_2_796(method_bind_2, Object.GetPtr(this), ref from, ref to);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_closest_point");

        [GodotMethod("get_closest_point")]
        public Vector2 GetClosestPoint(Vector2 point)
        {
            NativeCalls.godot_icall_1_47(method_bind_3, Object.GetPtr(this), ref point, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_point_inside");

        [GodotMethod("is_point_inside")]
        public bool IsPointInside(Vector2 point)
        {
            return NativeCalls.godot_icall_1_181(method_bind_4, Object.GetPtr(this), ref point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_point_penalty");

        [GodotMethod("set_point_penalty")]
        public void SetPointPenalty(int idx, float penalty)
        {
            NativeCalls.godot_icall_2_34(method_bind_5, Object.GetPtr(this), idx, penalty);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_point_penalty");

        [GodotMethod("get_point_penalty")]
        public float GetPointPenalty(int idx)
        {
            return NativeCalls.godot_icall_1_12(method_bind_6, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounds");

        [GodotMethod("get_bounds")]
        public Rect2 GetBounds()
        {
            NativeCalls.godot_icall_0_163(method_bind_7, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary arg0)
        {
            NativeCalls.godot_icall_1_213(method_bind_8, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_9, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
