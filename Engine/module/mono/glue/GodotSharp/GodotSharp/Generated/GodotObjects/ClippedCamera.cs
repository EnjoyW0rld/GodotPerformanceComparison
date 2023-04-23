using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node extends <see cref="Godot.Camera"/> to add collisions with <see cref="Godot.Area"/> and/or <see cref="Godot.PhysicsBody"/> nodes. The camera cannot move through colliding objects.</para>
    /// </summary>
    public partial class ClippedCamera : Camera
    {
        public enum ProcessModeEnum
        {
            /// <summary>
            /// <para>The camera updates with the <c>_physics_process</c> callback.</para>
            /// </summary>
            Physics = 0,
            /// <summary>
            /// <para>The camera updates with the <c>_process</c> callback.</para>
            /// </summary>
            Idle = 1
        }

        /// <summary>
        /// <para>The camera's collision margin. The camera can't get closer than this distance to a colliding object.</para>
        /// </summary>
        public float Margin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's process callback. See <see cref="Godot.ClippedCamera.ProcessModeEnum"/>.</para>
        /// </summary>
        public ClippedCamera.ProcessModeEnum ProcessMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProcessMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProcessMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The camera's collision mask. Only objects in at least one collision layer matching the mask will be detected. See <a href="$DOCS_URL/tutorials/physics/physics_introduction.html#collision-layers-and-masks">Collision layers and masks</a> in the documentation for more information.</para>
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
        /// <para>If <c>true</c>, the camera stops on contact with <see cref="Godot.Area"/>s.</para>
        /// </summary>
        public bool ClipToAreas
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClipToAreasEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipToAreas(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the camera stops on contact with <see cref="Godot.PhysicsBody"/>s.</para>
        /// </summary>
        public bool ClipToBodies
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClipToBodiesEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipToBodies(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ClippedCamera";

        public ClippedCamera() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ClippedCamera_Ctor(this);
        }

        internal ClippedCamera(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public float GetMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_mode");

        [GodotMethod("set_process_mode")]
        [Obsolete("SetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public void SetProcessMode(ClippedCamera.ProcessModeEnum processMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)processMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_mode");

        [GodotMethod("get_process_mode")]
        [Obsolete("GetProcessMode is deprecated. Use the ProcessMode property instead.")]
        public ClippedCamera.ProcessModeEnum GetProcessMode()
        {
            return (ClippedCamera.ProcessModeEnum)NativeCalls.godot_icall_0_284(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask");

        [GodotMethod("set_collision_mask")]
        [Obsolete("SetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public void SetCollisionMask(uint mask)
        {
            NativeCalls.godot_icall_1_187(method_bind_4, Object.GetPtr(this), mask);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask");

        [GodotMethod("get_collision_mask")]
        [Obsolete("GetCollisionMask is deprecated. Use the CollisionMask property instead.")]
        public uint GetCollisionMask()
        {
            return NativeCalls.godot_icall_0_188(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// <para>Sets the specified bit index to the <c>value</c>.</para>
        /// <para>Note: Bit indices range from 0-19.</para>
        /// </summary>
        [GodotMethod("set_collision_mask_bit")]
        public void SetCollisionMaskBit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), bit, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified bit index is on.</para>
        /// <para>Note: Bit indices range from 0-19.</para>
        /// </summary>
        [GodotMethod("get_collision_mask_bit")]
        public bool GetCollisionMaskBit(int bit)
        {
            return NativeCalls.godot_icall_1_35(method_bind_7, Object.GetPtr(this), bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_exception_rid");

        /// <summary>
        /// <para>Adds a collision exception so the camera does not collide with the specified <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("add_exception_rid")]
        public void AddExceptionRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_8, Object.GetPtr(this), RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_exception");

        /// <summary>
        /// <para>Adds a collision exception so the camera does not collide with the specified node.</para>
        /// </summary>
        [GodotMethod("add_exception")]
        public void AddException(Object node)
        {
            NativeCalls.godot_icall_1_53(method_bind_9, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_exception_rid");

        /// <summary>
        /// <para>Removes a collision exception with the specified <see cref="Godot.RID"/>.</para>
        /// </summary>
        [GodotMethod("remove_exception_rid")]
        public void RemoveExceptionRid(RID rid)
        {
            NativeCalls.godot_icall_1_285(method_bind_10, Object.GetPtr(this), RID.GetPtr(rid));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_exception");

        /// <summary>
        /// <para>Removes a collision exception with the specified node.</para>
        /// </summary>
        [GodotMethod("remove_exception")]
        public void RemoveException(Object node)
        {
            NativeCalls.godot_icall_1_53(method_bind_11, Object.GetPtr(this), Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_to_areas");

        [GodotMethod("set_clip_to_areas")]
        [Obsolete("SetClipToAreas is deprecated. Use the ClipToAreas property instead.")]
        public void SetClipToAreas(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_clip_to_areas_enabled");

        [GodotMethod("is_clip_to_areas_enabled")]
        [Obsolete("IsClipToAreasEnabled is deprecated. Use the ClipToAreas property instead.")]
        public bool IsClipToAreasEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_clip_offset");

        /// <summary>
        /// <para>Returns the distance the camera has been offset due to a collision.</para>
        /// </summary>
        [GodotMethod("get_clip_offset")]
        public float GetClipOffset()
        {
            return NativeCalls.godot_icall_0_14(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_to_bodies");

        [GodotMethod("set_clip_to_bodies")]
        [Obsolete("SetClipToBodies is deprecated. Use the ClipToBodies property instead.")]
        public void SetClipToBodies(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_15, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_clip_to_bodies_enabled");

        [GodotMethod("is_clip_to_bodies_enabled")]
        [Obsolete("IsClipToBodiesEnabled is deprecated. Use the ClipToBodies property instead.")]
        public bool IsClipToBodiesEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_exceptions");

        /// <summary>
        /// <para>Removes all collision exceptions.</para>
        /// </summary>
        [GodotMethod("clear_exceptions")]
        public void ClearExceptions()
        {
            NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
