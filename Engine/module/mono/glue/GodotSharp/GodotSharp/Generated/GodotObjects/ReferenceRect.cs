using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A rectangle box that displays only a <see cref="Godot.ReferenceRect.BorderColor"/> border color around its rectangle. <see cref="Godot.ReferenceRect"/> has no fill <see cref="Godot.Color"/>. If you need to display a rectangle filled with a solid color, consider using <see cref="Godot.ColorRect"/> instead.</para>
    /// </summary>
    public partial class ReferenceRect : Control
    {
        /// <summary>
        /// <para>Sets the border <see cref="Godot.Color"/> of the <see cref="Godot.ReferenceRect"/>.</para>
        /// </summary>
        public Color BorderColor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the border width of the <see cref="Godot.ReferenceRect"/>. The border grows both inwards and outwards with respect to the rectangle box.</para>
        /// </summary>
        public float BorderWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBorderWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBorderWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If set to <c>true</c>, the <see cref="Godot.ReferenceRect"/> will only be visible while in editor. Otherwise, <see cref="Godot.ReferenceRect"/> will be visible in game.</para>
        /// </summary>
        public bool EditorOnly
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEditorOnly();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEditorOnly(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ReferenceRect";

        public ReferenceRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ReferenceRect_Ctor(this);
        }

        internal ReferenceRect(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_color");

        [GodotMethod("get_border_color")]
        [Obsolete("GetBorderColor is deprecated. Use the BorderColor property instead.")]
        public Color GetBorderColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_0, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_color");

        [GodotMethod("set_border_color")]
        [Obsolete("SetBorderColor is deprecated. Use the BorderColor property instead.")]
        public void SetBorderColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_1, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_border_width");

        [GodotMethod("get_border_width")]
        [Obsolete("GetBorderWidth is deprecated. Use the BorderWidth property instead.")]
        public float GetBorderWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_border_width");

        [GodotMethod("set_border_width")]
        [Obsolete("SetBorderWidth is deprecated. Use the BorderWidth property instead.")]
        public void SetBorderWidth(float width)
        {
            NativeCalls.godot_icall_1_15(method_bind_3, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_editor_only");

        [GodotMethod("get_editor_only")]
        [Obsolete("GetEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public bool GetEditorOnly()
        {
            return NativeCalls.godot_icall_0_7(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_editor_only");

        [GodotMethod("set_editor_only")]
        [Obsolete("SetEditorOnly is deprecated. Use the EditorOnly property instead.")]
        public void SetEditorOnly(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_5, Object.GetPtr(this), enabled);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
