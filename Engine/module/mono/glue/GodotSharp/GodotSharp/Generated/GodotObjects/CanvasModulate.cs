using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.CanvasModulate"/> tints the canvas elements using its assigned <see cref="Godot.CanvasModulate.Color"/>.</para>
    /// </summary>
    public partial class CanvasModulate : Node2D
    {
        /// <summary>
        /// <para>The tint color to apply.</para>
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

        private const string nativeName = "CanvasModulate";

        public CanvasModulate() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CanvasModulate_Ctor(this);
        }

        internal CanvasModulate(bool memoryOwn) : base(memoryOwn) {}

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
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
