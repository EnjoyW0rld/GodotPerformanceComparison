using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>CollisionObject2D is the base class for 2D physics objects. It can hold any number of 2D collision <see cref="Godot.Shape2D"/>s. Each shape must be assigned to a shape owner. The CollisionObject2D can have any number of shape owners. Shape owners are not nodes and do not appear in the editor, but are accessible through code using the <c>shape_owner_*</c> methods.</para>
    /// <para>Note: Only collisions between objects within the same canvas (<see cref="Godot.Viewport"/> canvas or <see cref="Godot.CanvasLayer"/>) are supported. The behavior of collisions between objects in different canvases is undefined.</para>
    /// </summary>
    public abstract partial class CollisionObject2D : Node2D
    {
        /// <summary>
        /// <para>The physics layers this CollisionObject2D is in. Collision objects can exist in one or more of 32 different layers. See also <see cref="Godot.CollisionObject2D.CollisionMask"/>.</para>
        /// <para>Note: A contact is detected if object A is in any of the layers that object B scans, or object B is in any layers that object A scans. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>The physics layers this CollisionObject2D scans. Collision objects can scan one or more of 32 different layers. See also <see cref="Godot.CollisionObject2D.CollisionLayer"/>.</para>
        /// <para>Note: A contact is detected if object A is in any of the layers that object B scans, or object B is in any layers that object A scans. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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

        /// <summary>
        /// <para>If <c>true</c>, this object is pickable. A pickable object can detect the mouse pointer entering/leaving, and if the mouse is inside it, report input events. Requires at least one <see cref="Godot.CollisionObject2D.CollisionLayer"/> bit to be set.</para>
        /// </summary>
        public bool InputPickable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsPickable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPickable(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CollisionObject2D";

        internal CollisionObject2D() {}

        internal CollisionObject2D(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Accepts unhandled <see cref="Godot.InputEvent"/>s. Requires <see cref="Godot.CollisionObject2D.InputPickable"/> to be <c>true</c>. <c>shape_idx</c> is the child index of the clicked <see cref="Godot.Shape2D"/>. Connect to the <c>input_event</c> signal to easily pick up these events.</para>
        /// </summary>
        [GodotMethod("_input_event")]
        public virtual void _InputEvent(Object viewport, InputEvent @event, int shapeIdx)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// <para>Returns the object's <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("get_rid")]
        public RID GetRid()
        {
            return new RID(NativeCalls.godot_icall_0_254(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer");

        [GodotMethod("set_collision_layer")]
        [Obsolete("SetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public void SetCollisionLayer(uint layer)
        {
            NativeCalls.godot_icall_1_187(method_bind_1, Object.GetPtr(this), layer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer");

        [GodotMethod("get_collision_layer")]
        [Obsolete("GetCollisionLayer is deprecated. Use the CollisionLayer property instead.")]
        public uint GetCollisionLayer()
        {
            return NativeCalls.godot_icall_0_188(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_3, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// <para>If <c>value</c> is <c>true</c>, sets the specified <c>bit</c> in the <see cref="Godot.CollisionObject2D.CollisionLayer"/>.</para>
        /// <para>If <c>value</c> is <c>false</c>, clears the specified <c>bit</c> in the <see cref="Godot.CollisionObject2D.CollisionLayer"/>.</para>
        /// </summary>
        [GodotMethod("set_collision_layer_bit")]
        public void SetCollisionLayerBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_5, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// <para>Returns whether or not the specified <c>bit</c> of the <see cref="Godot.CollisionObject2D.CollisionLayer"/> is set.</para>
        /// </summary>
        [GodotMethod("get_collision_layer_bit")]
        public bool GetCollisionLayerBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_6, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>If <c>value</c> is <c>true</c>, sets the specified <c>bit</c> in the <see cref="Godot.CollisionObject2D.CollisionMask"/>.</para>
        /// <para>If <c>value</c> is <c>false</c>, clears the specified <c>bit</c> in the <see cref="Godot.CollisionObject2D.CollisionMask"/>.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_7, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns whether or not the specified <c>bit</c> of the <see cref="Godot.CollisionObject2D.CollisionMask"/> is set.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_8, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pickable");

        [GodotMethod("set_pickable")]
        [Obsolete("SetPickable is deprecated. Use the InputPickable property instead.")]
        public void SetPickable(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_pickable");

        [GodotMethod("is_pickable")]
        [Obsolete("IsPickable is deprecated. Use the InputPickable property instead.")]
        public bool IsPickable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_shape_owner");

        /// <summary>
        /// <para>Creates a new shape owner for the given object. Returns <c>owner_id</c> of the new owner for future reference.</para>
        /// </summary>
        [GodotMethod("create_shape_owner")]
        public uint CreateShapeOwner(Object owner)
        {
            return NativeCalls.godot_icall_1_286(method_bind_11, Object.GetPtr(this), Object.GetPtr(owner));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_shape_owner");

        /// <summary>
        /// <para>Removes the given shape owner.</para>
        /// </summary>
        [GodotMethod("remove_shape_owner")]
        public void RemoveShapeOwner(uint ownerId)
        {
            NativeCalls.godot_icall_1_187(method_bind_12, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape_owners");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of <c>owner_id</c> identifiers. You can use these ids in other methods that take <c>owner_id</c> as an argument.</para>
        /// </summary>
        [GodotMethod("get_shape_owners")]
        public Godot.Collections.Array GetShapeOwners()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_13, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_set_transform");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Transform2D"/> of the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_set_transform")]
        public void ShapeOwnerSetTransform(uint ownerId, Transform2D transform)
        {
            NativeCalls.godot_icall_2_297(method_bind_14, Object.GetPtr(this), ownerId, ref transform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_get_transform");

        /// <summary>
        /// <para>Returns the shape owner's <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        [GodotMethod("shape_owner_get_transform")]
        public Transform2D ShapeOwnerGetTransform(uint ownerId)
        {
            NativeCalls.godot_icall_1_298(method_bind_15, Object.GetPtr(this), ownerId, out Transform2D argRet); return (Transform2D)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_get_owner");

        /// <summary>
        /// <para>Returns the parent object of the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_get_owner")]
        public Object ShapeOwnerGetOwner(uint ownerId)
        {
            return NativeCalls.godot_icall_1_289(method_bind_16, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_set_disabled");

        /// <summary>
        /// <para>If <c>true</c>, disables the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_set_disabled")]
        public void ShapeOwnerSetDisabled(uint ownerId, bool disabled)
        {
            NativeCalls.godot_icall_2_290(method_bind_17, Object.GetPtr(this), ownerId, disabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shape_owner_disabled");

        /// <summary>
        /// <para>If <c>true</c>, the shape owner and its shapes are disabled.</para>
        /// </summary>
        [GodotMethod("is_shape_owner_disabled")]
        public bool IsShapeOwnerDisabled(uint ownerId)
        {
            return NativeCalls.godot_icall_1_291(method_bind_18, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_set_one_way_collision");

        /// <summary>
        /// <para>If <c>enable</c> is <c>true</c>, collisions for the shape owner originating from this <see cref="Godot.CollisionObject2D"/> will not be reported to collided with <see cref="Godot.CollisionObject2D"/>s.</para>
        /// </summary>
        [GodotMethod("shape_owner_set_one_way_collision")]
        public void ShapeOwnerSetOneWayCollision(uint ownerId, bool enable)
        {
            NativeCalls.godot_icall_2_290(method_bind_19, Object.GetPtr(this), ownerId, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shape_owner_one_way_collision_enabled");

        /// <summary>
        /// <para>Returns <c>true</c> if collisions for the shape owner originating from this <see cref="Godot.CollisionObject2D"/> will not be reported to collided with <see cref="Godot.CollisionObject2D"/>s.</para>
        /// </summary>
        [GodotMethod("is_shape_owner_one_way_collision_enabled")]
        public bool IsShapeOwnerOneWayCollisionEnabled(uint ownerId)
        {
            return NativeCalls.godot_icall_1_291(method_bind_20, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_set_one_way_collision_margin");

        /// <summary>
        /// <para>Sets the <c>one_way_collision_margin</c> of the shape owner identified by given <c>owner_id</c> to <c>margin</c> pixels.</para>
        /// </summary>
        [GodotMethod("shape_owner_set_one_way_collision_margin")]
        public void ShapeOwnerSetOneWayCollisionMargin(uint ownerId, float margin)
        {
            NativeCalls.godot_icall_2_299(method_bind_21, Object.GetPtr(this), ownerId, margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shape_owner_one_way_collision_margin");

        /// <summary>
        /// <para>Returns the <c>one_way_collision_margin</c> of the shape owner identified by given <c>owner_id</c>.</para>
        /// </summary>
        [GodotMethod("get_shape_owner_one_way_collision_margin")]
        public float GetShapeOwnerOneWayCollisionMargin(uint ownerId)
        {
            return NativeCalls.godot_icall_1_300(method_bind_22, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_add_shape");

        /// <summary>
        /// <para>Adds a <see cref="Godot.Shape2D"/> to the shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_add_shape")]
        public void ShapeOwnerAddShape(uint ownerId, Shape2D shape)
        {
            NativeCalls.godot_icall_2_292(method_bind_23, Object.GetPtr(this), ownerId, Object.GetPtr(shape));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_get_shape_count");

        /// <summary>
        /// <para>Returns the number of shapes the given shape owner contains.</para>
        /// </summary>
        [GodotMethod("shape_owner_get_shape_count")]
        public int ShapeOwnerGetShapeCount(uint ownerId)
        {
            return NativeCalls.godot_icall_1_293(method_bind_24, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_get_shape");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Shape2D"/> with the given id from the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_get_shape")]
        public Shape2D ShapeOwnerGetShape(uint ownerId, int shapeId)
        {
            return NativeCalls.godot_icall_2_301(method_bind_25, Object.GetPtr(this), ownerId, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_get_shape_index");

        /// <summary>
        /// <para>Returns the child index of the <see cref="Godot.Shape2D"/> with the given id from the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_get_shape_index")]
        public int ShapeOwnerGetShapeIndex(uint ownerId, int shapeId)
        {
            return NativeCalls.godot_icall_2_295(method_bind_26, Object.GetPtr(this), ownerId, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_remove_shape");

        /// <summary>
        /// <para>Removes a shape from the given shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_remove_shape")]
        public void ShapeOwnerRemoveShape(uint ownerId, int shapeId)
        {
            NativeCalls.godot_icall_2_296(method_bind_27, Object.GetPtr(this), ownerId, shapeId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_owner_clear_shapes");

        /// <summary>
        /// <para>Removes all shapes from the shape owner.</para>
        /// </summary>
        [GodotMethod("shape_owner_clear_shapes")]
        public void ShapeOwnerClearShapes(uint ownerId)
        {
            NativeCalls.godot_icall_1_187(method_bind_28, Object.GetPtr(this), ownerId);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "shape_find_owner");

        /// <summary>
        /// <para>Returns the <c>owner_id</c> of the given shape.</para>
        /// </summary>
        [GodotMethod("shape_find_owner")]
        public uint ShapeFindOwner(int shapeIndex)
        {
            return NativeCalls.godot_icall_1_154(method_bind_29, Object.GetPtr(this), shapeIndex);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
