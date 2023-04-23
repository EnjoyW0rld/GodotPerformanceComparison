using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Height map shape resource, which can be added to a <see cref="Godot.PhysicsBody"/> or <see cref="Godot.Area"/>.</para>
    /// </summary>
    public partial class HeightMapShape : Shape
    {
        /// <summary>
        /// <para>Number of vertices in the width of the height map. Changing this will resize the <see cref="Godot.HeightMapShape.MapData"/>.</para>
        /// </summary>
        public int MapWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMapWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMapWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of vertices in the depth of the height map. Changing this will resize the <see cref="Godot.HeightMapShape.MapData"/>.</para>
        /// </summary>
        public int MapDepth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMapDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMapDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Height map data, pool array must be of <see cref="Godot.HeightMapShape.MapWidth"/> * <see cref="Godot.HeightMapShape.MapDepth"/> size.</para>
        /// </summary>
        public float[] MapData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMapData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMapData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "HeightMapShape";

        public HeightMapShape() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HeightMapShape_Ctor(this);
        }

        internal HeightMapShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_map_width");

        [GodotMethod("set_map_width")]
        [Obsolete("SetMapWidth is deprecated. Use the MapWidth property instead.")]
        public void SetMapWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_map_width");

        [GodotMethod("get_map_width")]
        [Obsolete("GetMapWidth is deprecated. Use the MapWidth property instead.")]
        public int GetMapWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_map_depth");

        [GodotMethod("set_map_depth")]
        [Obsolete("SetMapDepth is deprecated. Use the MapDepth property instead.")]
        public void SetMapDepth(int height)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_map_depth");

        [GodotMethod("get_map_depth")]
        [Obsolete("GetMapDepth is deprecated. Use the MapDepth property instead.")]
        public int GetMapDepth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_map_data");

        [GodotMethod("set_map_data")]
        [Obsolete("SetMapData is deprecated. Use the MapData property instead.")]
        public void SetMapData(float[] data)
        {
            NativeCalls.godot_icall_1_452(method_bind_4, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_map_data");

        [GodotMethod("get_map_data")]
        [Obsolete("GetMapData is deprecated. Use the MapData property instead.")]
        public float[] GetMapData()
        {
            return NativeCalls.godot_icall_0_356(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
