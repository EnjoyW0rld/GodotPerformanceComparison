using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node used to display annotations in the script, so that code may be documented.</para>
    /// <para>Comment nodes can be resized so they encompass a group of nodes.</para>
    /// </summary>
    public partial class VisualScriptComment : VisualScriptNode
    {
        /// <summary>
        /// <para>The comment node's title.</para>
        /// </summary>
        public string Title
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTitle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTitle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The text inside the comment node.</para>
        /// </summary>
        public string Description
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDescription();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDescription(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The comment node's size (in pixels).</para>
        /// </summary>
        public Vector2 Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptComment";

        public VisualScriptComment() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptComment_Ctor(this);
        }

        internal VisualScriptComment(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_title");

        [GodotMethod("set_title")]
        [Obsolete("SetTitle is deprecated. Use the Title property instead.")]
        public void SetTitle(string title)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_title");

        [GodotMethod("get_title")]
        [Obsolete("GetTitle is deprecated. Use the Title property instead.")]
        public string GetTitle()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_description");

        [GodotMethod("set_description")]
        [Obsolete("SetDescription is deprecated. Use the Description property instead.")]
        public void SetDescription(string description)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), description);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_description");

        [GodotMethod("get_description")]
        [Obsolete("GetDescription is deprecated. Use the Description property instead.")]
        public string GetDescription()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_4, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
