using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.StyleBox"/> that displays a single line of a given color and thickness. It can be used to draw things like separators.</para>
    /// </summary>
    public partial class StyleBoxLine : StyleBox
    {
        /// <summary>
        /// <para>The line's color.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of pixels the line will extend before the <see cref="Godot.StyleBoxLine"/>'s bounds. If set to a negative value, the line will begin inside the <see cref="Godot.StyleBoxLine"/>'s bounds.</para>
        /// </summary>
        public float GrowBegin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGrowBegin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGrowBegin(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of pixels the line will extend past the <see cref="Godot.StyleBoxLine"/>'s bounds. If set to a negative value, the line will end inside the <see cref="Godot.StyleBoxLine"/>'s bounds.</para>
        /// </summary>
        public float GrowEnd
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGrowEnd();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGrowEnd(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The line's thickness in pixels.</para>
        /// </summary>
        public int Thickness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetThickness();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetThickness(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the line will be vertical. If <c>false</c>, the line will be horizontal.</para>
        /// </summary>
        public bool Vertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVertical();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVertical(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StyleBoxLine";

        public StyleBoxLine() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxLine_Ctor(this);
        }

        internal StyleBoxLine(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_thickness");

        [GodotMethod("set_thickness")]
        [Obsolete("SetThickness is deprecated. Use the Thickness property instead.")]
        public void SetThickness(int thickness)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), thickness);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_thickness");

        [GodotMethod("get_thickness")]
        [Obsolete("GetThickness is deprecated. Use the Thickness property instead.")]
        public int GetThickness()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_grow_begin");

        [GodotMethod("set_grow_begin")]
        [Obsolete("SetGrowBegin is deprecated. Use the GrowBegin property instead.")]
        public void SetGrowBegin(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_grow_begin");

        [GodotMethod("get_grow_begin")]
        [Obsolete("GetGrowBegin is deprecated. Use the GrowBegin property instead.")]
        public float GetGrowBegin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_grow_end");

        [GodotMethod("set_grow_end")]
        [Obsolete("SetGrowEnd is deprecated. Use the GrowEnd property instead.")]
        public void SetGrowEnd(float offset)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_grow_end");

        [GodotMethod("get_grow_end")]
        [Obsolete("GetGrowEnd is deprecated. Use the GrowEnd property instead.")]
        public float GetGrowEnd()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_vertical");

        [GodotMethod("set_vertical")]
        [Obsolete("SetVertical is deprecated. Use the Vertical property instead.")]
        public void SetVertical(bool vertical)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), vertical);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_vertical");

        [GodotMethod("is_vertical")]
        [Obsolete("IsVertical is deprecated. Use the Vertical property instead.")]
        public bool IsVertical()
        {
            return NativeCalls.godot_icall_0_7(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
