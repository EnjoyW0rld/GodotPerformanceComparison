using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>GradientTexture uses a <see cref="Godot.Gradient"/> to fill the texture data. The gradient will be filled from left to right using colors obtained from the gradient. This means the texture does not necessarily represent an exact copy of the gradient, but instead an interpolation of samples obtained from the gradient at fixed steps (see <see cref="Godot.GradientTexture.Width"/>). See also <see cref="Godot.GradientTexture2D"/> and <see cref="Godot.CurveTexture"/>.</para>
    /// </summary>
    public partial class GradientTexture : Texture
    {
        /// <summary>
        /// <para>The <see cref="Godot.Gradient"/> that will be used to fill the texture.</para>
        /// </summary>
        public Gradient Gradient
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGradient();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGradient(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of color samples that will be obtained from the <see cref="Godot.Gradient"/>.</para>
        /// </summary>
        public int Width
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWidth(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GradientTexture";

        public GradientTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GradientTexture_Ctor(this);
        }

        internal GradientTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_gradient");

        [GodotMethod("set_gradient")]
        [Obsolete("SetGradient is deprecated. Use the Gradient property instead.")]
        public void SetGradient(Gradient gradient)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(gradient));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_gradient");

        [GodotMethod("get_gradient")]
        [Obsolete("GetGradient is deprecated. Use the Gradient property instead.")]
        public Gradient GetGradient()
        {
            return NativeCalls.godot_icall_0_227(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(int width)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), width);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
