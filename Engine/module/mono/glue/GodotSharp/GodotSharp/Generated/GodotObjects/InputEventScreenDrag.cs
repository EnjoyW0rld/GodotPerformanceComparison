using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Contains screen drag information. See <see cref="Godot.Node._Input"/>.</para>
    /// </summary>
    public partial class InputEventScreenDrag : InputEvent
    {
        /// <summary>
        /// <para>The drag event index in the case of a multi-drag event.</para>
        /// </summary>
        public int Index
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The drag position.</para>
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
        /// <para>The drag position relative to the previous position (position at the last frame).</para>
        /// </summary>
        public Vector2 Relative
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRelative();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRelative(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The drag speed.</para>
        /// </summary>
        public Vector2 Speed
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpeed();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpeed(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventScreenDrag";

        public InputEventScreenDrag() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventScreenDrag_Ctor(this);
        }

        internal InputEventScreenDrag(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_index");

        [GodotMethod("set_index")]
        [Obsolete("SetIndex is deprecated. Use the Index property instead.")]
        public void SetIndex(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_index");

        [GodotMethod("get_index")]
        [Obsolete("GetIndex is deprecated. Use the Index property instead.")]
        public int GetIndex()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_position");

        [GodotMethod("set_position")]
        [Obsolete("SetPosition is deprecated. Use the Position property instead.")]
        public void SetPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the Position property instead.")]
        public Vector2 GetPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_relative");

        [GodotMethod("set_relative")]
        [Obsolete("SetRelative is deprecated. Use the Relative property instead.")]
        public void SetRelative(Vector2 relative)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref relative);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_relative");

        [GodotMethod("get_relative")]
        [Obsolete("GetRelative is deprecated. Use the Relative property instead.")]
        public Vector2 GetRelative()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed");

        [GodotMethod("set_speed")]
        [Obsolete("SetSpeed is deprecated. Use the Speed property instead.")]
        public void SetSpeed(Vector2 speed)
        {
            NativeCalls.godot_icall_1_57(method_bind_6, Object.GetPtr(this), ref speed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed");

        [GodotMethod("get_speed")]
        [Obsolete("GetSpeed is deprecated. Use the Speed property instead.")]
        public Vector2 GetSpeed()
        {
            NativeCalls.godot_icall_0_18(method_bind_7, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
