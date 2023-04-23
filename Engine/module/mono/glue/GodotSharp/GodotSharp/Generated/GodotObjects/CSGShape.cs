using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is the CSG base class that provides CSG operation support to the various CSG nodes in Godot.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public abstract partial class CSGShape : GeometryInstance
    {
        public enum OperationEnum
        {
            /// <summary>
            /// <para>Geometry of both primitives is merged, intersecting geometry is removed.</para>
            /// </summary>
            Union = 0,
            /// <summary>
            /// <para>Only intersecting geometry remains, the rest is removed.</para>
            /// </summary>
            Intersection = 1,
            /// <summary>
            /// <para>The second shape is subtracted from the first, leaving a dent with its shape.</para>
            /// </summary>
            Subtraction = 2
        }

        /// <summary>
        /// <para>The operation that is performed on this shape. This is ignored for the first CSG child node as the operation is between this node and the previous child of this nodes parent.</para>
        /// </summary>
        public CSGShape.OperationEnum Operation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOperation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOperation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Snap makes the mesh snap to a given distance so that the faces of two meshes can be perfectly aligned. A lower value results in greater precision but may be harder to adjust.</para>
        /// </summary>
        public float Snap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSnap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSnap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Calculate tangents for the CSG shape which allows the use of normal maps. This is only applied on the root shape, this setting is ignored on any child.</para>
        /// </summary>
        public bool CalculateTangents
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCalculatingTangents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCalculateTangents(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Adds a collision shape to the physics engine for our CSG shape. This will always act like a static body. Note that the collision shape is still active even if the CSG shape itself is hidden.</para>
        /// </summary>
        public bool UseCollision
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingCollision();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseCollision(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this area is in.</para>
        /// <para>Collidable objects can exist in any of 32 different layers. These layers work like a tagging system, and are not visual. A collidable can use these layers to select with which objects it can collide, using the collision_mask property.</para>
        /// <para>A contact is detected if object A is in any of the layers that object B scans, or object B is in any layer scanned by object A. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionLayer
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionLayer();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionLayer(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The physics layers this CSG shape scans for collisions. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
        /// </summary>
        public uint CollisionMask
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCollisionMask();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCollisionMask(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CSGShape";

        internal CSGShape() {}

        internal CSGShape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_root_shape");

        /// <summary>
        /// <para>Returns <c>true</c> if this is a root shape and is thus the object that is rendered.</para>
        /// </summary>
        [GodotMethod("is_root_shape")]
        public bool IsRootShape()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_operation");

        [GodotMethod("set_operation")]
        [Obsolete("SetOperation is deprecated. Use the Operation property instead.")]
        public void SetOperation(CSGShape.OperationEnum operation)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), (int)operation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_operation");

        [GodotMethod("get_operation")]
        [Obsolete("GetOperation is deprecated. Use the Operation property instead.")]
        public CSGShape.OperationEnum GetOperation()
        {
            return (CSGShape.OperationEnum)NativeCalls.godot_icall_0_241(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_snap");

        [GodotMethod("set_snap")]
        [Obsolete("SetSnap is deprecated. Use the Snap property instead.")]
        public void SetSnap(float snap)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), snap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_snap");

        [GodotMethod("get_snap")]
        [Obsolete("GetSnap is deprecated. Use the Snap property instead.")]
        public float GetSnap()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_collision");

        [GodotMethod("set_use_collision")]
        [Obsolete("SetUseCollision is deprecated. Use the UseCollision property instead.")]
        public void SetUseCollision(bool operation)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), operation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_collision");

        [GodotMethod("is_using_collision")]
        [Obsolete("IsUsingCollision is deprecated. Use the UseCollision property instead.")]
        public bool IsUsingCollision()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint layer)
        {
            NativeCalls.godot_icall_1_187(method_bind_7, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_9, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets individual bits on the collision mask. Use this if you only need to change one layer's value.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_11, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns an individual bit on the collision mask.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_12, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// <para>Sets individual bits on the layer mask. Use this if you only need to change one layer's value.</para>
        /// </summary>
        [GodotMethod("set_collision_layer_bit")]
        public void SetCollisionLayerBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_13, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// <para>Returns an individual bit on the collision mask.</para>
        /// </summary>
        [GodotMethod("get_collision_layer_bit")]
        public bool GetCollisionLayerBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_14, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_calculate_tangents");

        [GodotMethod("set_calculate_tangents")]
        [Obsolete("SetCalculateTangents is deprecated. Use the CalculateTangents property instead.")]
        public void SetCalculateTangents(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_calculating_tangents");

        [GodotMethod("is_calculating_tangents")]
        [Obsolete("IsCalculatingTangents is deprecated. Use the CalculateTangents property instead.")]
        public bool IsCalculatingTangents()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_meshes");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> with two elements, the first is the <see cref="Godot.Transform"/> of this node and the second is the root <see cref="Godot.Mesh"/> of this node. Only works when this node is the root shape.</para>
        /// </summary>
        [GodotMethod("get_meshes")]
        public Godot.Collections.Array GetMeshes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_17, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
