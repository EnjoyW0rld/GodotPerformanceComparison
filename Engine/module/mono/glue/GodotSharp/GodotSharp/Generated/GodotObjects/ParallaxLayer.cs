using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A ParallaxLayer must be the child of a <see cref="Godot.ParallaxBackground"/> node. Each ParallaxLayer can be set to move at different speeds relative to the camera movement or the <see cref="Godot.ParallaxBackground.ScrollOffset"/> value.</para>
    /// <para>This node's children will be affected by its scroll offset.</para>
    /// <para>Note: Any changes to this node's position and scale made after it enters the scene will be ignored.</para>
    /// </summary>
    public partial class ParallaxLayer : Node2D
    {
        /// <summary>
        /// <para>Multiplies the ParallaxLayer's motion. If an axis is set to <c>0</c>, it will not scroll.</para>
        /// </summary>
        public Vector2 MotionScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMotionScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMotionScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ParallaxLayer's offset relative to the parent ParallaxBackground's <see cref="Godot.ParallaxBackground.ScrollOffset"/>.</para>
        /// </summary>
        public Vector2 MotionOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMotionOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMotionOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The ParallaxLayer's <see cref="Godot.Texture"/> mirroring. Useful for creating an infinite scrolling background. If an axis is set to <c>0</c>, the <see cref="Godot.Texture"/> will not be mirrored.</para>
        /// </summary>
        public Vector2 MotionMirroring
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMirroring();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMirroring(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ParallaxLayer";

        public ParallaxLayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ParallaxLayer_Ctor(this);
        }

        internal ParallaxLayer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_motion_scale");

        [GodotMethod("set_motion_scale")]
        [Obsolete("SetMotionScale is deprecated. Use the MotionScale property instead.")]
        public void SetMotionScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_motion_scale");

        [GodotMethod("get_motion_scale")]
        [Obsolete("GetMotionScale is deprecated. Use the MotionScale property instead.")]
        public Vector2 GetMotionScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_motion_offset");

        [GodotMethod("set_motion_offset")]
        [Obsolete("SetMotionOffset is deprecated. Use the MotionOffset property instead.")]
        public void SetMotionOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_motion_offset");

        [GodotMethod("get_motion_offset")]
        [Obsolete("GetMotionOffset is deprecated. Use the MotionOffset property instead.")]
        public Vector2 GetMotionOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_3, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mirroring");

        [GodotMethod("set_mirroring")]
        [Obsolete("SetMirroring is deprecated. Use the MotionMirroring property instead.")]
        public void SetMirroring(Vector2 mirror)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref mirror);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mirroring");

        [GodotMethod("get_mirroring")]
        [Obsolete("GetMirroring is deprecated. Use the MotionMirroring property instead.")]
        public Vector2 GetMirroring()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
