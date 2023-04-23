using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A shortcut for binding input.</para>
    /// <para>Shortcuts are commonly used for interacting with a <see cref="Godot.Control"/> element from a <see cref="Godot.InputEvent"/>.</para>
    /// </summary>
    public partial class ShortCut : Resource
    {
        /// <summary>
        /// <para>The shortcut's <see cref="Godot.InputEvent"/>.</para>
        /// <para>Generally the <see cref="Godot.InputEvent"/> is a keyboard key, though it can be any <see cref="Godot.InputEvent"/>.</para>
        /// </summary>
        public InputEvent Shortcut
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetShortcut();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShortcut(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ShortCut";

        public ShortCut() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ShortCut_Ctor(this);
        }

        internal ShortCut(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_shortcut");

        [GodotMethod("set_shortcut")]
        [Obsolete("SetShortcut is deprecated. Use the Shortcut property instead.")]
        public void SetShortcut(InputEvent @event)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_shortcut");

        [GodotMethod("get_shortcut")]
        [Obsolete("GetShortcut is deprecated. Use the Shortcut property instead.")]
        public InputEvent GetShortcut()
        {
            return NativeCalls.godot_icall_0_859(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// <para>If <c>true</c>, this shortcut is valid.</para>
        /// </summary>
        [GodotMethod("is_valid")]
        public bool IsValid()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_shortcut");

        /// <summary>
        /// <para>Returns <c>true</c> if the shortcut's <see cref="Godot.InputEvent"/> equals <c>event</c>.</para>
        /// </summary>
        [GodotMethod("is_shortcut")]
        public bool IsShortcut(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_531(method_bind_3, Object.GetPtr(this), Object.GetPtr(@event));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_as_text");

        /// <summary>
        /// <para>Returns the shortcut's <see cref="Godot.InputEvent"/> as a <see cref="string"/>.</para>
        /// </summary>
        [GodotMethod("get_as_text")]
        public string GetAsText()
        {
            return NativeCalls.godot_icall_0_6(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
