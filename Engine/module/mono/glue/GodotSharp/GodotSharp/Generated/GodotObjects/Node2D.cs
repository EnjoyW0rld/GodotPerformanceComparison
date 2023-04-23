using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A 2D game object, with a transform (position, rotation, and scale). All 2D nodes, including physics objects and sprites, inherit from Node2D. Use Node2D as a parent node to move, scale and rotate children in a 2D project. Also gives control of the node's render order.</para>
    /// </summary>
    public partial class Node2D : CanvasItem
    {
        /// <summary>
        /// <para>Position, relative to the node's parent.</para>
        /// </summary>
        public Vector2 Position
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Rotation in radians, relative to the node's parent.</para>
        /// </summary>
        public float Rotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Rotation in degrees, relative to the node's parent.</para>
        /// </summary>
        public float RotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's scale. Unscaled value: <c>(1, 1)</c>.</para>
        /// <para>Note: Negative X scales in 2D are not decomposable from the transformation matrix. Due to the way scale is represented with transformation matrices in Godot, negative scales on the X axis will be changed to negative scales on the Y axis and a rotation of 180 degrees when decomposed.</para>
        /// </summary>
        public Vector2 Scale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Local <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        public Transform2D Transform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global position.</para>
        /// </summary>
        public Vector2 GlobalPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global rotation in radians.</para>
        /// </summary>
        public float GlobalRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global rotation in degrees.</para>
        /// </summary>
        public float GlobalRotationDegrees
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global scale.</para>
        /// </summary>
        public Vector2 GlobalScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Global <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        public Transform2D GlobalTransform
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalTransform();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalTransform(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Z index. Controls the order in which the nodes render. A node with a higher Z index will display in front of others. Must be between <see cref="Godot.VisualServer.CanvasItemZMin"/> and <see cref="Godot.VisualServer.CanvasItemZMax"/> (inclusive).</para>
        /// </summary>
        public int ZIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetZIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the node's Z index is relative to its parent's Z index. If this node's Z index is 2 and its parent's effective Z index is 3, then this node's effective Z index will be 2 + 3 = 5.</para>
        /// </summary>
        public bool ZAsRelative
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsZRelative();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetZAsRelative(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Node2D";

        public Node2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Node2D_Ctor(this);
        }

        internal Node2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_position");

        [GodotMethod("set_position")]
        [Obsolete("SetPosition is deprecated. Use the Position property instead.")]
        public void SetPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation");

        [GodotMethod("set_rotation")]
        [Obsolete("SetRotation is deprecated. Use the Rotation property instead.")]
        public void SetRotation(float radians)
        {
            NativeCalls.godot_icall_1_15(method_bind_1, Object.GetPtr(this), radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation_degrees");

        [GodotMethod("set_rotation_degrees")]
        [Obsolete("SetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public void SetRotationDegrees(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scale");

        [GodotMethod("set_scale")]
        [Obsolete("SetScale is deprecated. Use the Scale property instead.")]
        public void SetScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_3, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the Position property instead.")]
        public Vector2 GetPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_4, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation");

        [GodotMethod("get_rotation")]
        [Obsolete("GetRotation is deprecated. Use the Rotation property instead.")]
        public float GetRotation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation_degrees");

        [GodotMethod("get_rotation_degrees")]
        [Obsolete("GetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public float GetRotationDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scale");

        [GodotMethod("get_scale")]
        [Obsolete("GetScale is deprecated. Use the Scale property instead.")]
        public Vector2 GetScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate");

        /// <summary>
        /// <para>Applies a rotation to the node, in radians, starting from its current rotation.</para>
        /// </summary>
        [GodotMethod("rotate")]
        public void Rotate(float radians)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_local_x");

        /// <summary>
        /// <para>Applies a local translation on the node's X axis based on the <see cref="Godot.Node._Process"/>'s <c>delta</c>. If <c>scaled</c> is <c>false</c>, normalizes the movement.</para>
        /// </summary>
        [GodotMethod("move_local_x")]
        public void MoveLocalX(float delta, bool scaled = false)
        {
            NativeCalls.godot_icall_2_133(method_bind_9, Object.GetPtr(this), delta, scaled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "move_local_y");

        /// <summary>
        /// <para>Applies a local translation on the node's Y axis based on the <see cref="Godot.Node._Process"/>'s <c>delta</c>. If <c>scaled</c> is <c>false</c>, normalizes the movement.</para>
        /// </summary>
        [GodotMethod("move_local_y")]
        public void MoveLocalY(float delta, bool scaled = false)
        {
            NativeCalls.godot_icall_2_133(method_bind_10, Object.GetPtr(this), delta, scaled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "translate");

        /// <summary>
        /// <para>Translates the node by the given <c>offset</c> in local coordinates.</para>
        /// </summary>
        [GodotMethod("translate")]
        public void Translate(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_11, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_translate");

        /// <summary>
        /// <para>Adds the <c>offset</c> vector to the node's global position.</para>
        /// </summary>
        [GodotMethod("global_translate")]
        public void GlobalTranslate(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_12, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "apply_scale");

        /// <summary>
        /// <para>Multiplies the current scale by the <c>ratio</c> vector.</para>
        /// </summary>
        [GodotMethod("apply_scale")]
        public void ApplyScale(Vector2 ratio)
        {
            NativeCalls.godot_icall_1_57(method_bind_13, Object.GetPtr(this), ref ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_position");

        [GodotMethod("set_global_position")]
        [Obsolete("SetGlobalPosition is deprecated. Use the GlobalPosition property instead.")]
        public void SetGlobalPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_14, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_position");

        [GodotMethod("get_global_position")]
        [Obsolete("GetGlobalPosition is deprecated. Use the GlobalPosition property instead.")]
        public Vector2 GetGlobalPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_15, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_rotation");

        [GodotMethod("set_global_rotation")]
        [Obsolete("SetGlobalRotation is deprecated. Use the GlobalRotation property instead.")]
        public void SetGlobalRotation(float radians)
        {
            NativeCalls.godot_icall_1_15(method_bind_16, Object.GetPtr(this), radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_rotation");

        [GodotMethod("get_global_rotation")]
        [Obsolete("GetGlobalRotation is deprecated. Use the GlobalRotation property instead.")]
        public float GetGlobalRotation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_rotation_degrees");

        [GodotMethod("set_global_rotation_degrees")]
        [Obsolete("SetGlobalRotationDegrees is deprecated. Use the GlobalRotationDegrees property instead.")]
        public void SetGlobalRotationDegrees(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_18, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_rotation_degrees");

        [GodotMethod("get_global_rotation_degrees")]
        [Obsolete("GetGlobalRotationDegrees is deprecated. Use the GlobalRotationDegrees property instead.")]
        public float GetGlobalRotationDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_scale");

        [GodotMethod("set_global_scale")]
        [Obsolete("SetGlobalScale is deprecated. Use the GlobalScale property instead.")]
        public void SetGlobalScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_20, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_scale");

        [GodotMethod("get_global_scale")]
        [Obsolete("GetGlobalScale is deprecated. Use the GlobalScale property instead.")]
        public Vector2 GetGlobalScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_21, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the Transform property instead.")]
        public void SetTransform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_220(method_bind_22, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_transform");

        [GodotMethod("set_global_transform")]
        [Obsolete("SetGlobalTransform is deprecated. Use the GlobalTransform property instead.")]
        public void SetGlobalTransform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_220(method_bind_23, Object.GetPtr(this), ref xform);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "look_at");

        /// <summary>
        /// <para>Rotates the node so it points towards the <c>point</c>, which is expected to use global coordinates.</para>
        /// </summary>
        [GodotMethod("look_at")]
        public void LookAt(Vector2 point)
        {
            NativeCalls.godot_icall_1_57(method_bind_24, Object.GetPtr(this), ref point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_angle_to");

        /// <summary>
        /// <para>Returns the angle between the node and the <c>point</c> in radians.</para>
        /// <para><a href="https://raw.githubusercontent.com/godotengine/godot-docs/master/img/node2d_get_angle_to.png">Illustration of the returned angle.</a></para>
        /// </summary>
        [GodotMethod("get_angle_to")]
        public float GetAngleTo(Vector2 point)
        {
            return NativeCalls.godot_icall_1_350(method_bind_25, Object.GetPtr(this), ref point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "to_local");

        /// <summary>
        /// <para>Transforms the provided global position into a position in local coordinate space. The output will be local relative to the <see cref="Godot.Node2D"/> it is called on. e.g. It is appropriate for determining the positions of child nodes, but it is not appropriate for determining its own position relative to its parent.</para>
        /// </summary>
        [GodotMethod("to_local")]
        public Vector2 ToLocal(Vector2 globalPoint)
        {
            NativeCalls.godot_icall_1_47(method_bind_26, Object.GetPtr(this), ref globalPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "to_global");

        /// <summary>
        /// <para>Transforms the provided local position into a position in global coordinate space. The input is expected to be local relative to the <see cref="Godot.Node2D"/> it is called on. e.g. Applying this method to the positions of child nodes will correctly transform their positions into the global coordinate space, but applying it to a node's own position will give an incorrect result, as it will incorporate the node's own transformation into its global position.</para>
        /// </summary>
        [GodotMethod("to_global")]
        public Vector2 ToGlobal(Vector2 localPoint)
        {
            NativeCalls.godot_icall_1_47(method_bind_27, Object.GetPtr(this), ref localPoint, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_z_index");

        [GodotMethod("set_z_index")]
        [Obsolete("SetZIndex is deprecated. Use the ZIndex property instead.")]
        public void SetZIndex(int zIndex)
        {
            NativeCalls.godot_icall_1_4(method_bind_28, Object.GetPtr(this), zIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_z_index");

        [GodotMethod("get_z_index")]
        [Obsolete("GetZIndex is deprecated. Use the ZIndex property instead.")]
        public int GetZIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_z_as_relative");

        [GodotMethod("set_z_as_relative")]
        [Obsolete("SetZAsRelative is deprecated. Use the ZAsRelative property instead.")]
        public void SetZAsRelative(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_30, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_z_relative");

        [GodotMethod("is_z_relative")]
        [Obsolete("IsZRelative is deprecated. Use the ZAsRelative property instead.")]
        public bool IsZRelative()
        {
            return NativeCalls.godot_icall_0_7(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_relative_transform_to_parent");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Transform2D"/> relative to this node's parent.</para>
        /// </summary>
        [GodotMethod("get_relative_transform_to_parent")]
        public Transform2D GetRelativeTransformToParent(Node parent)
        {
            NativeCalls.godot_icall_1_688(method_bind_32, Object.GetPtr(this), Object.GetPtr(parent), out Transform2D argRet); return (Transform2D)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
