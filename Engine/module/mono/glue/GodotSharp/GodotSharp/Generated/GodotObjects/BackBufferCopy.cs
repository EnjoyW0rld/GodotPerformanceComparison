using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Node for back-buffering the currently-displayed screen. The region defined in the <see cref="Godot.BackBufferCopy"/> node is buffered with the content of the screen it covers, or the entire screen according to the copy mode set. Use the <c>texture(SCREEN_TEXTURE, ...)</c> function in your shader scripts to access the buffer.</para>
    /// <para>Note: Since this node inherits from <see cref="Godot.Node2D"/> (and not <see cref="Godot.Control"/>), anchors and margins won't apply to child <see cref="Godot.Control"/>-derived nodes. This can be problematic when resizing the window. To avoid this, add <see cref="Godot.Control"/>-derived nodes as siblings to the <see cref="Godot.BackBufferCopy"/> node instead of adding them as children.</para>
    /// </summary>
    public partial class BackBufferCopy : Node2D
    {
        public enum CopyModeEnum
        {
            /// <summary>
            /// <para>Disables the buffering mode. This means the <see cref="Godot.BackBufferCopy"/> node will directly use the portion of screen it covers.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para><see cref="Godot.BackBufferCopy"/> buffers a rectangular region.</para>
            /// </summary>
            Rect = 1,
            /// <summary>
            /// <para><see cref="Godot.BackBufferCopy"/> buffers the entire screen.</para>
            /// </summary>
            Viewport = 2
        }

        /// <summary>
        /// <para>Buffer mode. See <see cref="Godot.BackBufferCopy.CopyModeEnum"/> constants.</para>
        /// </summary>
        public BackBufferCopy.CopyModeEnum CopyMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCopyMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCopyMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The area covered by the <see cref="Godot.BackBufferCopy"/>. Only used if <see cref="Godot.BackBufferCopy.CopyMode"/> is <see cref="Godot.BackBufferCopy.CopyModeEnum.Rect"/>.</para>
        /// </summary>
        public Rect2 Rect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRect(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BackBufferCopy";

        public BackBufferCopy() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BackBufferCopy_Ctor(this);
        }

        internal BackBufferCopy(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rect");

        [GodotMethod("set_rect")]
        [Obsolete("SetRect is deprecated. Use the Rect property instead.")]
        public void SetRect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_162(method_bind_0, Object.GetPtr(this), ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect");

        [GodotMethod("get_rect")]
        [Obsolete("GetRect is deprecated. Use the Rect property instead.")]
        public Rect2 GetRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_1, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_copy_mode");

        [GodotMethod("set_copy_mode")]
        [Obsolete("SetCopyMode is deprecated. Use the CopyMode property instead.")]
        public void SetCopyMode(BackBufferCopy.CopyModeEnum copyMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)copyMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_copy_mode");

        [GodotMethod("get_copy_mode")]
        [Obsolete("GetCopyMode is deprecated. Use the CopyMode property instead.")]
        public BackBufferCopy.CopyModeEnum GetCopyMode()
        {
            return (BackBufferCopy.CopyModeEnum)NativeCalls.godot_icall_0_194(method_bind_3, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
