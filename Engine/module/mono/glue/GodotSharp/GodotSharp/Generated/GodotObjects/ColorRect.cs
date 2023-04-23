using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Displays a rectangle filled with a solid <see cref="Godot.ColorRect.Color"/>. If you need to display the border alone, consider using <see cref="Godot.ReferenceRect"/> instead.</para>
    /// </summary>
    public partial class ColorRect : Control
    {
        /// <summary>
        /// <para>The fill color.</para>
        /// <para><code>
        /// $ColorRect.color = Color(1, 0, 0, 1) # Set ColorRect's color to red.
        /// </code></para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFrameColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFrameColor(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ColorRect";

        public ColorRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ColorRect_Ctor(this);
        }

        internal ColorRect(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_frame_color");

        [GodotMethod("set_frame_color")]
        [Obsolete("SetFrameColor is deprecated. Use the Color property instead.")]
        public void SetFrameColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_0, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_frame_color");

        [GodotMethod("get_frame_color")]
        [Obsolete("GetFrameColor is deprecated. Use the Color property instead.")]
        public Color GetFrameColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_1, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
