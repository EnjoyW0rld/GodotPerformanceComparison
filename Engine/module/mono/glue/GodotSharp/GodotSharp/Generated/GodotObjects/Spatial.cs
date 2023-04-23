using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Most basic 3D game object, with a 3D <see cref="Godot.Transform"/> and visibility settings. All other 3D game objects inherit from Spatial. Use <see cref="Godot.Spatial"/> as a parent node to move, scale, rotate and show/hide children in a 3D project.</para>
    /// <para>Affine operations (rotate, scale, translate) happen in parent's local coordinate system, unless the <see cref="Godot.Spatial"/> object is set as top-level. Affine operations in this coordinate system correspond to direct affine operations on the <see cref="Godot.Spatial"/>'s transform. The word local below refers to this coordinate system. The coordinate system that is attached to the <see cref="Godot.Spatial"/> object itself is referred to as object-local coordinate system.</para>
    /// <para>Note: Unless otherwise specified, all methods that have angle parameters must have angles specified as radians. To convert degrees to radians, use <c>@GDScript.deg2rad</c>.</para>
    /// </summary>
    public partial class Spatial : Node
    {
        /// <summary>
        /// <para>Spatial nodes receives this notification when their global transform changes. This means that either the current or a parent node changed its transform.</para>
        /// <para>In order for <see cref="Godot.Spatial.NotificationTransformChanged"/> to work, users first need to ask for it, with <see cref="Godot.Spatial.SetNotifyTransform"/>. The notification is also sent if the node is in the editor context and it has a valid gizmo.</para>
        /// </summary>
        public const int NotificationTransformChanged = 2000;
        /// <summary>
        /// <para>Spatial nodes receives this notification when they are registered to new <see cref="Godot.World"/> resource.</para>
        /// </summary>
        public const int NotificationEnterWorld = 41;
        /// <summary>
        /// <para>Spatial nodes receives this notification when they are unregistered from current <see cref="Godot.World"/> resource.</para>
        /// </summary>
        public const int NotificationExitWorld = 42;
        /// <summary>
        /// <para>Spatial nodes receives this notification when their visibility changes.</para>
        /// </summary>
        public const int NotificationVisibilityChanged = 43;
        /// <summary>
        /// <para>Spatial nodes receives this notification if the portal system gameplay monitor detects they have entered the gameplay area.</para>
        /// </summary>
        public const int NotificationEnterGameplay = 45;
        /// <summary>
        /// <para>Spatial nodes receives this notification if the portal system gameplay monitor detects they have exited the gameplay area.</para>
        /// </summary>
        public const int NotificationExitGameplay = 46;

        /// <summary>
        /// <para>Local translation of this node.</para>
        /// </summary>
        public Vector3 Translation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTranslation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTranslation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Rotation part of the local transformation in degrees, specified in terms of YXZ-Euler angles in the format (X angle, Y angle, Z angle).</para>
        /// </summary>
        public Vector3 RotationDegrees
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
        /// <para>Rotation part of the local transformation in radians, specified in terms of YXZ-Euler angles in the format (X angle, Y angle, Z angle).</para>
        /// <para>Note: In the mathematical sense, rotation is a matrix and not a vector. The three Euler angles, which are the three independent parameters of the Euler-angle parametrization of the rotation matrix, are stored in a <see cref="Godot.Vector3"/> data structure not because the rotation is a vector, but only because <see cref="Godot.Vector3"/> exists as a convenient data-structure to store 3 floating-point numbers. Therefore, applying affine operations on the rotation "vector" is not meaningful.</para>
        /// </summary>
        public Vector3 Rotation
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
        /// <para>Scale part of the local transformation.</para>
        /// <para>Note: Mixed negative scales in 3D are not decomposable from the transformation matrix. Due to the way scale is represented with transformation matrices in Godot, the scale values will either be all positive or all negative.</para>
        /// <para>Note: Not all nodes are visually scaled by the <see cref="Godot.Spatial.Scale"/> property. For example, <see cref="Godot.Light"/>s are not visually affected by <see cref="Godot.Spatial.Scale"/>.</para>
        /// </summary>
        public Vector3 Scale
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
        /// <para>World space (global) <see cref="Godot.Transform"/> of this node.</para>
        /// </summary>
        public Transform GlobalTransform
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
        /// <para>Global position of this node. This is equivalent to <c>global_transform.origin</c>.</para>
        /// </summary>
        public Vector3 GlobalTranslation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalTranslation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlobalTranslation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Rotation part of the global transformation in radians, specified in terms of YXZ-Euler angles in the format (X angle, Y angle, Z angle).</para>
        /// <para>Note: In the mathematical sense, rotation is a matrix and not a vector. The three Euler angles, which are the three independent parameters of the Euler-angle parametrization of the rotation matrix, are stored in a <see cref="Godot.Vector3"/> data structure not because the rotation is a vector, but only because <see cref="Godot.Vector3"/> exists as a convenient data-structure to store 3 floating-point numbers. Therefore, applying affine operations on the rotation "vector" is not meaningful.</para>
        /// </summary>
        public Vector3 GlobalRotation
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
        /// <para>Local space <see cref="Godot.Transform"/> of this node, with respect to the parent node.</para>
        /// </summary>
        public Transform Transform
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
        /// <para>If <c>true</c>, this node is drawn. The node is only visible if all of its antecedents are visible as well (in other words, <see cref="Godot.Spatial.IsVisibleInTree"/> must return <c>true</c>).</para>
        /// </summary>
        public bool Visible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisible(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.SpatialGizmo"/> for this node. Used for example in <see cref="Godot.EditorSpatialGizmo"/> as custom visualization and editing handles in Editor.</para>
        /// </summary>
        public SpatialGizmo Gizmo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGizmo();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGizmo(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Spatial";

        public Spatial() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Spatial_Ctor(this);
        }

        internal Spatial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_transform");

        [GodotMethod("set_transform")]
        [Obsolete("SetTransform is deprecated. Use the Transform property instead.")]
        public void SetTransform(Transform local)
        {
            NativeCalls.godot_icall_1_202(method_bind_0, Object.GetPtr(this), ref local);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_transform");

        [GodotMethod("get_transform")]
        [Obsolete("GetTransform is deprecated. Use the Transform property instead.")]
        public Transform GetTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_1, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_translation");

        [GodotMethod("set_translation")]
        [Obsolete("SetTranslation is deprecated. Use the Translation property instead.")]
        public void SetTranslation(Vector3 translation)
        {
            NativeCalls.godot_icall_1_148(method_bind_2, Object.GetPtr(this), ref translation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_translation");

        [GodotMethod("get_translation")]
        [Obsolete("GetTranslation is deprecated. Use the Translation property instead.")]
        public Vector3 GetTranslation()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation");

        [GodotMethod("set_rotation")]
        [Obsolete("SetRotation is deprecated. Use the Rotation property instead.")]
        public void SetRotation(Vector3 euler)
        {
            NativeCalls.godot_icall_1_148(method_bind_4, Object.GetPtr(this), ref euler);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation");

        [GodotMethod("get_rotation")]
        [Obsolete("GetRotation is deprecated. Use the Rotation property instead.")]
        public Vector3 GetRotation()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation_degrees");

        [GodotMethod("set_rotation_degrees")]
        [Obsolete("SetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public void SetRotationDegrees(Vector3 eulerDegrees)
        {
            NativeCalls.godot_icall_1_148(method_bind_6, Object.GetPtr(this), ref eulerDegrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation_degrees");

        [GodotMethod("get_rotation_degrees")]
        [Obsolete("GetRotationDegrees is deprecated. Use the RotationDegrees property instead.")]
        public Vector3 GetRotationDegrees()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scale");

        [GodotMethod("set_scale")]
        [Obsolete("SetScale is deprecated. Use the Scale property instead.")]
        public void SetScale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_8, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scale");

        [GodotMethod("get_scale")]
        [Obsolete("GetScale is deprecated. Use the Scale property instead.")]
        public Vector3 GetScale()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_transform");

        [GodotMethod("set_global_transform")]
        [Obsolete("SetGlobalTransform is deprecated. Use the GlobalTransform property instead.")]
        public void SetGlobalTransform(Transform global)
        {
            NativeCalls.godot_icall_1_202(method_bind_10, Object.GetPtr(this), ref global);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_transform");

        [GodotMethod("get_global_transform")]
        [Obsolete("GetGlobalTransform is deprecated. Use the GlobalTransform property instead.")]
        public Transform GetGlobalTransform()
        {
            NativeCalls.godot_icall_0_22(method_bind_11, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_translation");

        [GodotMethod("set_global_translation")]
        [Obsolete("SetGlobalTranslation is deprecated. Use the GlobalTranslation property instead.")]
        public void SetGlobalTranslation(Vector3 translation)
        {
            NativeCalls.godot_icall_1_148(method_bind_12, Object.GetPtr(this), ref translation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_translation");

        [GodotMethod("get_global_translation")]
        [Obsolete("GetGlobalTranslation is deprecated. Use the GlobalTranslation property instead.")]
        public Vector3 GetGlobalTranslation()
        {
            NativeCalls.godot_icall_0_8(method_bind_13, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_rotation");

        [GodotMethod("set_global_rotation")]
        [Obsolete("SetGlobalRotation is deprecated. Use the GlobalRotation property instead.")]
        public void SetGlobalRotation(Vector3 radians)
        {
            NativeCalls.godot_icall_1_148(method_bind_14, Object.GetPtr(this), ref radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_rotation");

        [GodotMethod("get_global_rotation")]
        [Obsolete("GetGlobalRotation is deprecated. Use the GlobalRotation property instead.")]
        public Vector3 GetGlobalRotation()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this), out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_transform_interpolated");

        /// <summary>
        /// <para>When using physics interpolation, there will be circumstances in which you want to know the interpolated (displayed) transform of a node rather than the standard transform (which may only be accurate to the most recent physics tick).</para>
        /// <para>This is particularly important for frame-based operations that take place in <see cref="Godot.Node._Process"/>, rather than <see cref="Godot.Node._PhysicsProcess"/>. Examples include <see cref="Godot.Camera"/>s focusing on a node, or finding where to fire lasers from on a frame rather than physics tick.</para>
        /// </summary>
        [GodotMethod("get_global_transform_interpolated")]
        public Transform GetGlobalTransformInterpolated()
        {
            NativeCalls.godot_icall_0_22(method_bind_16, Object.GetPtr(this), out Transform argRet); return (Transform)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_spatial");

        /// <summary>
        /// <para>Returns the parent <see cref="Godot.Spatial"/>, or an empty <see cref="Godot.Object"/> if no parent exists or parent is not of type <see cref="Godot.Spatial"/>.</para>
        /// </summary>
        [GodotMethod("get_parent_spatial")]
        public Spatial GetParentSpatial()
        {
            return NativeCalls.godot_icall_0_412(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_ignore_transform_notification");

        /// <summary>
        /// <para>Sets whether the node ignores notification that its transformation (global or local) changed.</para>
        /// </summary>
        [GodotMethod("set_ignore_transform_notification")]
        public void SetIgnoreTransformNotification(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_18, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_as_toplevel");

        /// <summary>
        /// <para>Makes the node ignore its parents transformations. Node transformations are only in global space.</para>
        /// </summary>
        [GodotMethod("set_as_toplevel")]
        public void SetAsToplevel(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_19, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_set_as_toplevel");

        /// <summary>
        /// <para>Returns whether this node is set as Toplevel, that is whether it ignores its parent nodes transformations.</para>
        /// </summary>
        [GodotMethod("is_set_as_toplevel")]
        public bool IsSetAsToplevel()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_disable_scale");

        /// <summary>
        /// <para>Sets whether the node uses a scale of <c>(1, 1, 1)</c> or its local transformation scale. Changes to the local transformation scale are preserved.</para>
        /// </summary>
        [GodotMethod("set_disable_scale")]
        public void SetDisableScale(bool disable)
        {
            NativeCalls.godot_icall_1_16(method_bind_21, Object.GetPtr(this), disable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_scale_disabled");

        /// <summary>
        /// <para>Returns whether this node uses a scale of <c>(1, 1, 1)</c> or its local transformation scale.</para>
        /// </summary>
        [GodotMethod("is_scale_disabled")]
        public bool IsScaleDisabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_world");

        /// <summary>
        /// <para>Returns the current <see cref="Godot.World"/> resource this <see cref="Godot.Spatial"/> node is registered to.</para>
        /// </summary>
        [GodotMethod("get_world")]
        public World GetWorld()
        {
            return NativeCalls.godot_icall_0_865(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_update_transform");

        /// <summary>
        /// <para>Forces the transform to update. Transform changes in physics are not instant for performance reasons. Transforms are accumulated and then set. Use this if you need an up-to-date transform when doing physics operations.</para>
        /// </summary>
        [GodotMethod("force_update_transform")]
        public void ForceUpdateTransform()
        {
            NativeCalls.godot_icall_0_3(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "update_gizmo");

        /// <summary>
        /// <para>Updates the <see cref="Godot.SpatialGizmo"/> of this node.</para>
        /// </summary>
        [GodotMethod("update_gizmo")]
        public void UpdateGizmo()
        {
            NativeCalls.godot_icall_0_3(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gizmo");

        [GodotMethod("set_gizmo")]
        [Obsolete("SetGizmo is deprecated. Use the Gizmo property instead.")]
        public void SetGizmo(SpatialGizmo gizmo)
        {
            NativeCalls.godot_icall_1_24(method_bind_26, Object.GetPtr(this), Object.GetPtr(gizmo));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gizmo");

        [GodotMethod("get_gizmo")]
        [Obsolete("GetGizmo is deprecated. Use the Gizmo property instead.")]
        public SpatialGizmo GetGizmo()
        {
            return NativeCalls.godot_icall_0_866(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visible");

        [GodotMethod("set_visible")]
        [Obsolete("SetVisible is deprecated. Use the Visible property instead.")]
        public void SetVisible(bool visible)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), visible);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible");

        [GodotMethod("is_visible")]
        [Obsolete("IsVisible is deprecated. Use the Visible property instead.")]
        public bool IsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible_in_tree");

        /// <summary>
        /// <para>Returns <c>true</c> if the node is present in the <see cref="Godot.SceneTree"/>, its <see cref="Godot.Spatial.Visible"/> property is <c>true</c> and all its antecedents are also visible. If any antecedent is hidden, this node will not be visible in the scene tree.</para>
        /// </summary>
        [GodotMethod("is_visible_in_tree")]
        public bool IsVisibleInTree()
        {
            return NativeCalls.godot_icall_0_7(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "show");

        /// <summary>
        /// <para>Enables rendering of this node. Changes <see cref="Godot.Spatial.Visible"/> to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("show")]
        public void Show()
        {
            NativeCalls.godot_icall_0_3(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "hide");

        /// <summary>
        /// <para>Disables rendering of this node. Changes <see cref="Godot.Spatial.Visible"/> to <c>false</c>.</para>
        /// </summary>
        [GodotMethod("hide")]
        public void Hide()
        {
            NativeCalls.godot_icall_0_3(method_bind_32, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_notify_local_transform");

        /// <summary>
        /// <para>Sets whether the node notifies about its local transformation changes. <see cref="Godot.Spatial"/> will not propagate this by default.</para>
        /// </summary>
        [GodotMethod("set_notify_local_transform")]
        public void SetNotifyLocalTransform(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_local_transform_notification_enabled");

        /// <summary>
        /// <para>Returns whether node notifies about its local transformation changes. <see cref="Godot.Spatial"/> will not propagate this by default.</para>
        /// </summary>
        [GodotMethod("is_local_transform_notification_enabled")]
        public bool IsLocalTransformNotificationEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_notify_transform");

        /// <summary>
        /// <para>Sets whether the node notifies about its global and local transformation changes. <see cref="Godot.Spatial"/> will not propagate this by default, unless it is in the editor context and it has a valid gizmo.</para>
        /// </summary>
        [GodotMethod("set_notify_transform")]
        public void SetNotifyTransform(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_35, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_transform_notification_enabled");

        /// <summary>
        /// <para>Returns whether the node notifies about its global and local transformation changes. <see cref="Godot.Spatial"/> will not propagate this by default.</para>
        /// </summary>
        [GodotMethod("is_transform_notification_enabled")]
        public bool IsTransformNotificationEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate");

        /// <summary>
        /// <para>Rotates the local transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians.</para>
        /// </summary>
        [GodotMethod("rotate")]
        public void Rotate(Vector3 axis, float angle)
        {
            NativeCalls.godot_icall_2_867(method_bind_37, Object.GetPtr(this), ref axis, angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_rotate");

        /// <summary>
        /// <para>Rotates the global (world) transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians. The rotation axis is in global coordinate system.</para>
        /// </summary>
        [GodotMethod("global_rotate")]
        public void GlobalRotate(Vector3 axis, float angle)
        {
            NativeCalls.godot_icall_2_867(method_bind_38, Object.GetPtr(this), ref axis, angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_scale");

        /// <summary>
        /// <para>Scales the global (world) transformation by the given <see cref="Godot.Vector3"/> scale factors.</para>
        /// </summary>
        [GodotMethod("global_scale")]
        public void GlobalScale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_39, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "global_translate");

        /// <summary>
        /// <para>Moves the global (world) transformation by <see cref="Godot.Vector3"/> offset. The offset is in global coordinate system.</para>
        /// </summary>
        [GodotMethod("global_translate")]
        public void GlobalTranslate(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_40, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate_object_local");

        /// <summary>
        /// <para>Rotates the local transformation around axis, a unit <see cref="Godot.Vector3"/>, by specified angle in radians. The rotation axis is in object-local coordinate system.</para>
        /// </summary>
        [GodotMethod("rotate_object_local")]
        public void RotateObjectLocal(Vector3 axis, float angle)
        {
            NativeCalls.godot_icall_2_867(method_bind_41, Object.GetPtr(this), ref axis, angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "scale_object_local");

        /// <summary>
        /// <para>Scales the local transformation by given 3D scale factors in object-local coordinate system.</para>
        /// </summary>
        [GodotMethod("scale_object_local")]
        public void ScaleObjectLocal(Vector3 scale)
        {
            NativeCalls.godot_icall_1_148(method_bind_42, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "translate_object_local");

        /// <summary>
        /// <para>Changes the node's position by the given offset <see cref="Godot.Vector3"/> in local space.</para>
        /// </summary>
        [GodotMethod("translate_object_local")]
        public void TranslateObjectLocal(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_43, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate_x");

        /// <summary>
        /// <para>Rotates the local transformation around the X axis by angle in radians.</para>
        /// </summary>
        [GodotMethod("rotate_x")]
        public void RotateX(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_44, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate_y");

        /// <summary>
        /// <para>Rotates the local transformation around the Y axis by angle in radians.</para>
        /// </summary>
        [GodotMethod("rotate_y")]
        public void RotateY(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_45, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rotate_z");

        /// <summary>
        /// <para>Rotates the local transformation around the Z axis by angle in radians.</para>
        /// </summary>
        [GodotMethod("rotate_z")]
        public void RotateZ(float angle)
        {
            NativeCalls.godot_icall_1_15(method_bind_46, Object.GetPtr(this), angle);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "translate");

        /// <summary>
        /// <para>Changes the node's position by the given offset <see cref="Godot.Vector3"/>.</para>
        /// <para>Note that the translation <c>offset</c> is affected by the node's scale, so if scaled by e.g. <c>(10, 1, 1)</c>, a translation by an offset of <c>(2, 0, 0)</c> would actually add 20 (<c>2 * 10</c>) to the X coordinate.</para>
        /// </summary>
        [GodotMethod("translate")]
        public void Translate(Vector3 offset)
        {
            NativeCalls.godot_icall_1_148(method_bind_47, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "orthonormalize");

        /// <summary>
        /// <para>Resets this node's transformations (like scale, skew and taper) preserving its rotation and translation by performing Gram-Schmidt orthonormalization on this node's <see cref="Godot.Transform"/>.</para>
        /// </summary>
        [GodotMethod("orthonormalize")]
        public void Orthonormalize()
        {
            NativeCalls.godot_icall_0_3(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_identity");

        /// <summary>
        /// <para>Reset all transformations for this node (sets its <see cref="Godot.Transform"/> to the identity matrix).</para>
        /// </summary>
        [GodotMethod("set_identity")]
        public void SetIdentity()
        {
            NativeCalls.godot_icall_0_3(method_bind_49, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "look_at");

        /// <summary>
        /// <para>Rotates the node so that the local forward axis (-Z) points toward the <c>target</c> position.</para>
        /// <para>The local up axis (+Y) points as close to the <c>up</c> vector as possible while staying perpendicular to the local forward axis. The resulting transform is orthogonal, and the scale is preserved. Non-uniform scaling may not work correctly.</para>
        /// <para>The <c>target</c> position cannot be the same as the node's position, the <c>up</c> vector cannot be zero, and the direction from the node's position to the <c>target</c> vector cannot be parallel to the <c>up</c> vector.</para>
        /// <para>Operations take place in global space.</para>
        /// </summary>
        [GodotMethod("look_at")]
        public void LookAt(Vector3 target, Vector3 up)
        {
            NativeCalls.godot_icall_2_729(method_bind_50, Object.GetPtr(this), ref target, ref up);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "look_at_from_position");

        /// <summary>
        /// <para>Moves the node to the specified <c>position</c>, and then rotates itself to point toward the <c>target</c> as per <see cref="Godot.Spatial.LookAt"/>. Operations take place in global space.</para>
        /// </summary>
        [GodotMethod("look_at_from_position")]
        public void LookAtFromPosition(Vector3 position, Vector3 target, Vector3 up)
        {
            NativeCalls.godot_icall_3_868(method_bind_51, Object.GetPtr(this), ref position, ref target, ref up);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "to_local");

        /// <summary>
        /// <para>Transforms <c>global_point</c> from world space to this node's local space.</para>
        /// </summary>
        [GodotMethod("to_local")]
        public Vector3 ToLocal(Vector3 globalPoint)
        {
            NativeCalls.godot_icall_1_40(method_bind_52, Object.GetPtr(this), ref globalPoint, out Vector3 argRet); return (Vector3)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "to_global");

        /// <summary>
        /// <para>Transforms <c>local_point</c> from this node's local space to world space.</para>
        /// </summary>
        [GodotMethod("to_global")]
        public Vector3 ToGlobal(Vector3 localPoint)
        {
            NativeCalls.godot_icall_1_40(method_bind_53, Object.GetPtr(this), ref localPoint, out Vector3 argRet); return (Vector3)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
