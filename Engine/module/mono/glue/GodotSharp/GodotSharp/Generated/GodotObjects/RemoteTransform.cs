using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>RemoteTransform pushes its own <see cref="Godot.Transform"/> to another <see cref="Godot.Spatial"/> derived Node (called the remote node) in the scene.</para>
    /// <para>It can be set to update another Node's position, rotation and/or scale. It can use either global or local coordinates.</para>
    /// </summary>
    public partial class RemoteTransform : Spatial
    {
        /// <summary>
        /// <para>The <see cref="Godot.NodePath"/> to the remote node, relative to the RemoteTransform's position in the scene.</para>
        /// </summary>
        public NodePath RemotePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRemoteNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRemoteNode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, global coordinates are used. If <c>false</c>, local coordinates are used.</para>
        /// </summary>
        public bool UseGlobalCoordinates
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseGlobalCoordinates();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseGlobalCoordinates(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the remote node's position is updated.</para>
        /// </summary>
        public bool UpdatePosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUpdatePosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUpdatePosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the remote node's rotation is updated.</para>
        /// </summary>
        public bool UpdateRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUpdateRotation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUpdateRotation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the remote node's scale is updated.</para>
        /// </summary>
        public bool UpdateScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUpdateScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUpdateScale(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "RemoteTransform";

        public RemoteTransform() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RemoteTransform_Ctor(this);
        }

        internal RemoteTransform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_remote_node");

        [GodotMethod("set_remote_node")]
        [Obsolete("SetRemoteNode is deprecated. Use the RemotePath property instead.")]
        public void SetRemoteNode(NodePath path)
        {
            NativeCalls.godot_icall_1_129(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_remote_node");

        [GodotMethod("get_remote_node")]
        [Obsolete("GetRemoteNode is deprecated. Use the RemotePath property instead.")]
        public NodePath GetRemoteNode()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_1, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_update_cache");

        /// <summary>
        /// <para><see cref="Godot.RemoteTransform"/> caches the remote node. It may not notice if the remote node disappears; <see cref="Godot.RemoteTransform.ForceUpdateCache"/> forces it to update the cache again.</para>
        /// </summary>
        [GodotMethod("force_update_cache")]
        public void ForceUpdateCache()
        {
            NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_global_coordinates");

        [GodotMethod("set_use_global_coordinates")]
        [Obsolete("SetUseGlobalCoordinates is deprecated. Use the UseGlobalCoordinates property instead.")]
        public void SetUseGlobalCoordinates(bool useGlobalCoordinates)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), useGlobalCoordinates);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_global_coordinates");

        [GodotMethod("get_use_global_coordinates")]
        [Obsolete("GetUseGlobalCoordinates is deprecated. Use the UseGlobalCoordinates property instead.")]
        public bool GetUseGlobalCoordinates()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_update_position");

        [GodotMethod("set_update_position")]
        [Obsolete("SetUpdatePosition is deprecated. Use the UpdatePosition property instead.")]
        public void SetUpdatePosition(bool updateRemotePosition)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), updateRemotePosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_update_position");

        [GodotMethod("get_update_position")]
        [Obsolete("GetUpdatePosition is deprecated. Use the UpdatePosition property instead.")]
        public bool GetUpdatePosition()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_update_rotation");

        [GodotMethod("set_update_rotation")]
        [Obsolete("SetUpdateRotation is deprecated. Use the UpdateRotation property instead.")]
        public void SetUpdateRotation(bool updateRemoteRotation)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), updateRemoteRotation);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_update_rotation");

        [GodotMethod("get_update_rotation")]
        [Obsolete("GetUpdateRotation is deprecated. Use the UpdateRotation property instead.")]
        public bool GetUpdateRotation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_update_scale");

        [GodotMethod("set_update_scale")]
        [Obsolete("SetUpdateScale is deprecated. Use the UpdateScale property instead.")]
        public void SetUpdateScale(bool updateRemoteScale)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), updateRemoteScale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_update_scale");

        [GodotMethod("get_update_scale")]
        [Obsolete("GetUpdateScale is deprecated. Use the UpdateScale property instead.")]
        public bool GetUpdateScale()
        {
            return NativeCalls.godot_icall_0_7(method_bind_10, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
