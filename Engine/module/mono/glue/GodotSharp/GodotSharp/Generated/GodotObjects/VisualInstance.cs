using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.VisualInstance"/> is used to connect a resource to a visual representation. All visual 3D nodes inherit from the <see cref="Godot.VisualInstance"/>. In general, you should not access the <see cref="Godot.VisualInstance"/> properties directly as they are accessed and managed by the nodes that inherit from <see cref="Godot.VisualInstance"/>. <see cref="Godot.VisualInstance"/> is the node representation of the <see cref="Godot.VisualServer"/> instance.</para>
    /// </summary>
    public abstract partial class VisualInstance : CullInstance
    {
        /// <summary>
        /// <para>The render layer(s) this <see cref="Godot.VisualInstance"/> is drawn on.</para>
        /// <para>This object will only be visible for <see cref="Godot.Camera"/>s whose cull mask includes the render object this <see cref="Godot.VisualInstance"/> is set to.</para>
        /// </summary>
        public uint Layers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLayerMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLayerMask(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The sorting offset used by this <see cref="Godot.VisualInstance"/>. Adjusting it to a higher value will make the <see cref="Godot.VisualInstance"/> reliably draw on top of other <see cref="Godot.VisualInstance"/>s that are otherwise positioned at the same spot.</para>
        /// </summary>
        public float SortingOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSortingOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSortingOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the object is sorted based on the <see cref="Godot.AABB"/> center. Sorted based on the global position otherwise.</para>
        /// <para>The <see cref="Godot.AABB"/> center based sorting is generally more accurate for 3D models. The position based sorting instead allows to better control the drawing order when working with <see cref="Godot.Particles"/> and <see cref="Godot.CPUParticles"/>.</para>
        /// </summary>
        public bool SortingUseAabbCenter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSortingUseAabbCenter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSortingUseAabbCenter(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualInstance";

        internal VisualInstance() {}

        internal VisualInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base");

        /// <summary>
        /// <para>Sets the resource that is instantiated by this <see cref="Godot.VisualInstance"/>, which changes how the engine handles the <see cref="Godot.VisualInstance"/> under the hood. Equivalent to <see cref="Godot.VisualServer.InstanceSetBase"/>.</para>
        /// </summary>
        [GodotMethod("set_base")]
        public void SetBase(RID @base)
        {
            NativeCalls.godot_icall_1_285(method_bind_0, Object.GetPtr(this), RID.GetPtr(@base));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base");

        /// <summary>
        /// <para>Returns the RID of the resource associated with this <see cref="Godot.VisualInstance"/>. For example, if the Node is a <see cref="Godot.MeshInstance"/>, this will return the RID of the associated <see cref="Godot.Mesh"/>.</para>
        /// </summary>
        [GodotMethod("get_base")]
        public RID GetBase()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance");

        /// <summary>
        /// <para>Returns the RID of this instance. This RID is the same as the RID returned by <see cref="Godot.VisualServer.InstanceCreate"/>. This RID is needed if you want to call <see cref="Godot.VisualServer"/> functions directly on this <see cref="Godot.VisualInstance"/>.</para>
        /// </summary>
        [GodotMethod("get_instance")]
        public RID GetInstance()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_2, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer_mask");

        [GodotMethod("set_layer_mask")]
        [Obsolete("SetLayerMask is deprecated. Use the Layers property instead.")]
        public void SetLayerMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_3, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer_mask");

        [GodotMethod("get_layer_mask")]
        [Obsolete("GetLayerMask is deprecated. Use the Layers property instead.")]
        public uint GetLayerMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_layer_mask_bit");

        /// <summary>
        /// <para>Enables a particular layer in <see cref="Godot.VisualInstance.Layers"/>.</para>
        /// </summary>
        [GodotMethod("set_layer_mask_bit")]
        public void SetLayerMaskBit(int layer, bool enabled)
        {
            NativeCalls.godot_icall_2_23(method_bind_5, Object.GetPtr(this), layer, enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_layer_mask_bit");

        /// <summary>
        /// <para>Returns <c>true</c> when the specified layer is enabled in <see cref="Godot.VisualInstance.Layers"/> and <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("get_layer_mask_bit")]
        public bool GetLayerMaskBit(int layer)
        {
            return NativeCalls.godot_icall_1_35(method_bind_6, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transformed_aabb");

        /// <summary>
        /// <para>Returns the transformed <see cref="Godot.AABB"/> (also known as the bounding box) for this <see cref="Godot.VisualInstance"/>.</para>
        /// <para>Transformed in this case means the <see cref="Godot.AABB"/> plus the position, rotation, and scale of the <see cref="Godot.Spatial"/>'s <see cref="Godot.Transform"/>. See also <see cref="Godot.VisualInstance.GetAabb"/>.</para>
        /// </summary>
        [GodotMethod("get_transformed_aabb")]
        public AABB GetTransformedAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_7, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sorting_offset");

        [GodotMethod("set_sorting_offset")]
        [Obsolete("SetSortingOffset is deprecated. Use the SortingOffset property instead.")]
        public void SetSortingOffset(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sorting_offset");

        [GodotMethod("get_sorting_offset")]
        [Obsolete("GetSortingOffset is deprecated. Use the SortingOffset property instead.")]
        public float GetSortingOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sorting_use_aabb_center");

        [GodotMethod("set_sorting_use_aabb_center")]
        [Obsolete("SetSortingUseAabbCenter is deprecated. Use the SortingUseAabbCenter property instead.")]
        public void SetSortingUseAabbCenter(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sorting_use_aabb_center");

        [GodotMethod("is_sorting_use_aabb_center")]
        [Obsolete("IsSortingUseAabbCenter is deprecated. Use the SortingUseAabbCenter property instead.")]
        public bool IsSortingUseAabbCenter()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_aabb");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AABB"/> (also known as the bounding box) for this <see cref="Godot.VisualInstance"/>. See also <see cref="Godot.VisualInstance.GetTransformedAabb"/>.</para>
        /// </summary>
        [GodotMethod("get_aabb")]
        public AABB GetAabb()
        {
            NativeCalls.godot_icall_0_158(method_bind_12, Object.GetPtr(this), out AABB argRet); return (AABB)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
