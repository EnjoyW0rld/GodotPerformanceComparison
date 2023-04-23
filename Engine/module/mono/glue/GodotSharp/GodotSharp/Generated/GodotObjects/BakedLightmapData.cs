using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class BakedLightmapData : Resource
    {
        public AABB Bounds
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBounds();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBounds(value);
            }
#pragma warning restore CS0618
        }

        public Transform CellSpaceTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellSpaceTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellSpaceTransform(value);
            }
#pragma warning restore CS0618
        }

        public int CellSubdiv
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCellSubdiv();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCellSubdiv(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global energy multiplier for baked and dynamic capture objects. This can be changed at run-time without having to bake lightmaps again.</para>
        /// <para>To adjust only the energy of indirect lighting (without affecting direct lighting or emissive materials), adjust <see cref="Godot.BakedLightmap.BounceIndirectEnergy"/> and bake lightmaps again.</para>
        /// </summary>
        public float Energy
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnergy();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnergy(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls whether dynamic capture objects receive environment lighting or not.</para>
        /// </summary>
        public bool Interior
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInterior();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInterior(value);
            }
#pragma warning restore CS0618
        }

        public byte[] Octree
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOctree();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOctree(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array UserData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetUserData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetUserData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BakedLightmapData";

        public BakedLightmapData() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BakedLightmapData_Ctor(this);
        }

        internal BakedLightmapData(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_user_data");

        [Obsolete("_SetUserData is deprecated. Use the UserData property instead.")]
        internal void _SetUserData(Godot.Collections.Array data)
        {
            NativeCalls.godot_icall_1_92(method_bind_0, Object.GetPtr(this), data.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_user_data");

        [Obsolete("_GetUserData is deprecated. Use the UserData property instead.")]
        internal Godot.Collections.Array _GetUserData()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bounds");

        [GodotMethod("set_bounds")]
        [Obsolete("SetBounds is deprecated. Use the Bounds property instead.")]
        public void SetBounds(AABB bounds)
        {
            NativeCalls.godot_icall_1_157(method_bind_2, Object.GetPtr(this), ref bounds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bounds");

        [GodotMethod("get_bounds")]
        [Obsolete("GetBounds is deprecated. Use the Bounds property instead.")]
        public AABB GetBounds()
        {
            NativeCalls.godot_icall_0_158(method_bind_3, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_space_transform");

        [GodotMethod("set_cell_space_transform")]
        [Obsolete("SetCellSpaceTransform is deprecated. Use the CellSpaceTransform property instead.")]
        public void SetCellSpaceTransform(Transform xform)
        {
            NativeCalls.godot_icall_1_202(method_bind_4, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_space_transform");

        [GodotMethod("get_cell_space_transform")]
        [Obsolete("GetCellSpaceTransform is deprecated. Use the CellSpaceTransform property instead.")]
        public Transform GetCellSpaceTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_5, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cell_subdiv");

        [GodotMethod("set_cell_subdiv")]
        [Obsolete("SetCellSubdiv is deprecated. Use the CellSubdiv property instead.")]
        public void SetCellSubdiv(int cellSubdiv)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), cellSubdiv);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cell_subdiv");

        [GodotMethod("get_cell_subdiv")]
        [Obsolete("GetCellSubdiv is deprecated. Use the CellSubdiv property instead.")]
        public int GetCellSubdiv()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_octree");

        [GodotMethod("set_octree")]
        [Obsolete("SetOctree is deprecated. Use the Octree property instead.")]
        public void SetOctree(byte[] octree)
        {
            NativeCalls.godot_icall_1_183(method_bind_8, Object.GetPtr(this), octree);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_octree");

        [GodotMethod("get_octree")]
        [Obsolete("GetOctree is deprecated. Use the Octree property instead.")]
        public byte[] GetOctree()
        {
            return NativeCalls.godot_icall_0_2(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_energy");

        [GodotMethod("set_energy")]
        [Obsolete("SetEnergy is deprecated. Use the Energy property instead.")]
        public void SetEnergy(float energy)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), energy);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_energy");

        [GodotMethod("get_energy")]
        [Obsolete("GetEnergy is deprecated. Use the Energy property instead.")]
        public float GetEnergy()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_interior");

        [GodotMethod("set_interior")]
        [Obsolete("SetInterior is deprecated. Use the Interior property instead.")]
        public void SetInterior(bool interior)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), interior);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_interior");

        [GodotMethod("is_interior")]
        [Obsolete("IsInterior is deprecated. Use the Interior property instead.")]
        public bool IsInterior()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_user");

        [GodotMethod("add_user")]
        public void AddUser(NodePath path, Resource lightmap, int lightmapSlice, Rect2 lightmapUvRect, int instance)
        {
            NativeCalls.godot_icall_5_203(method_bind_14, Object.GetPtr(this), NodePath.GetPtr(path), Object.GetPtr(lightmap), lightmapSlice, ref lightmapUvRect, instance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_user_count");

        [GodotMethod("get_user_count")]
        public int GetUserCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_user_path");

        [GodotMethod("get_user_path")]
        public NodePath GetUserPath(int userIdx)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_16, Object.GetPtr(this), userIdx));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_user_lightmap");

        [GodotMethod("get_user_lightmap")]
        public Resource GetUserLightmap(int userIdx)
        {
            return NativeCalls.godot_icall_1_204(method_bind_17, Object.GetPtr(this), userIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_users");

        [GodotMethod("clear_users")]
        public void ClearUsers()
        {
            NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_data");

        [GodotMethod("clear_data")]
        public void ClearData()
        {
            NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
