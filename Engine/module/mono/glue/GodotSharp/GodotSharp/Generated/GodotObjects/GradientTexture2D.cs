using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The texture uses a <see cref="Godot.Gradient"/> to fill the texture data in 2D space. The gradient is filled according to the specified <see cref="Godot.GradientTexture2D.Fill"/> and <see cref="Godot.GradientTexture2D.Repeat"/> types using colors obtained from the gradient. The texture does not necessarily represent an exact copy of the gradient, but instead an interpolation of samples obtained from the gradient at fixed steps (see <see cref="Godot.GradientTexture2D.Width"/> and <see cref="Godot.GradientTexture2D.Height"/>). See also <see cref="Godot.GradientTexture"/> and <see cref="Godot.CurveTexture"/>.</para>
    /// </summary>
    public partial class GradientTexture2D : Texture
    {
        public enum FillEnum
        {
            /// <summary>
            /// <para>The colors are linearly interpolated in a straight line.</para>
            /// </summary>
            Linear = 0,
            /// <summary>
            /// <para>The colors are linearly interpolated in a circular pattern.</para>
            /// </summary>
            Radial = 1
        }

        public enum RepeatEnum
        {
            /// <summary>
            /// <para>The gradient fill is restricted to the range defined by <see cref="Godot.GradientTexture2D.FillFrom"/> to <see cref="Godot.GradientTexture2D.FillTo"/> offsets.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>The texture is filled starting from <see cref="Godot.GradientTexture2D.FillFrom"/> to <see cref="Godot.GradientTexture2D.FillTo"/> offsets, repeating the same pattern in both directions.</para>
            /// </summary>
            Repeat = 1,
            /// <summary>
            /// <para>The texture is filled starting from <see cref="Godot.GradientTexture2D.FillFrom"/> to <see cref="Godot.GradientTexture2D.FillTo"/> offsets, mirroring the pattern in both directions.</para>
            /// </summary>
            Mirror = 2
        }

        /// <summary>
        /// <para>The <see cref="Godot.Gradient"/> used to fill the texture.</para>
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
        /// <para>The number of horizontal color samples that will be obtained from the <see cref="Godot.Gradient"/>, which also represents the texture's width.</para>
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

        /// <summary>
        /// <para>The number of vertical color samples that will be obtained from the <see cref="Godot.Gradient"/>, which also represents the texture's height.</para>
        /// </summary>
        public int Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the generated texture will support high dynamic range (<see cref="Godot.Image.Format.Rgbaf"/> format). This allows for glow effects to work if <see cref="Godot.Environment.GlowEnabled"/> is <c>true</c>. If <c>false</c>, the generated texture will use low dynamic range; overbright colors will be clamped (<see cref="Godot.Image.Format.Rgba8"/> format).</para>
        /// </summary>
        public bool UseHdr
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingHdr();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseHdr(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The gradient fill type, one of the <see cref="Godot.GradientTexture2D.FillEnum"/> values. The texture is filled by interpolating colors starting from <see cref="Godot.GradientTexture2D.FillFrom"/> to <see cref="Godot.GradientTexture2D.FillTo"/> offsets.</para>
        /// </summary>
        public GradientTexture2D.FillEnum Fill
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFill();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFill(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The initial offset used to fill the texture specified in UV coordinates.</para>
        /// </summary>
        public Vector2 FillFrom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFillFrom();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFillFrom(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The final offset used to fill the texture specified in UV coordinates.</para>
        /// </summary>
        public Vector2 FillTo
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFillTo();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFillTo(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The gradient repeat type, one of the <see cref="Godot.GradientTexture2D.RepeatEnum"/> values. The texture is filled starting from <see cref="Godot.GradientTexture2D.FillFrom"/> to <see cref="Godot.GradientTexture2D.FillTo"/> offsets by default, but the gradient fill can be repeated to cover the entire texture.</para>
        /// </summary>
        public GradientTexture2D.RepeatEnum Repeat
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRepeat();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRepeat(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GradientTexture2D";

        public GradientTexture2D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GradientTexture2D_Ctor(this);
        }

        internal GradientTexture2D(bool memoryOwn) : base(memoryOwn) {}

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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(int height)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_hdr");

        [GodotMethod("set_use_hdr")]
        [Obsolete("SetUseHdr is deprecated. Use the UseHdr property instead.")]
        public void SetUseHdr(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_hdr");

        [GodotMethod("is_using_hdr")]
        [Obsolete("IsUsingHdr is deprecated. Use the UseHdr property instead.")]
        public bool IsUsingHdr()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fill");

        [GodotMethod("set_fill")]
        [Obsolete("SetFill is deprecated. Use the Fill property instead.")]
        public void SetFill(GradientTexture2D.FillEnum fill)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)fill);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fill");

        [GodotMethod("get_fill")]
        [Obsolete("GetFill is deprecated. Use the Fill property instead.")]
        public GradientTexture2D.FillEnum GetFill()
        {
            return (GradientTexture2D.FillEnum)NativeCalls.godot_icall_0_468(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fill_from");

        [GodotMethod("set_fill_from")]
        [Obsolete("SetFillFrom is deprecated. Use the FillFrom property instead.")]
        public void SetFillFrom(Vector2 fillFrom)
        {
            NativeCalls.godot_icall_1_57(method_bind_8, Object.GetPtr(this), ref fillFrom);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fill_from");

        [GodotMethod("get_fill_from")]
        [Obsolete("GetFillFrom is deprecated. Use the FillFrom property instead.")]
        public Vector2 GetFillFrom()
        {
            NativeCalls.godot_icall_0_18(method_bind_9, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fill_to");

        [GodotMethod("set_fill_to")]
        [Obsolete("SetFillTo is deprecated. Use the FillTo property instead.")]
        public void SetFillTo(Vector2 fillTo)
        {
            NativeCalls.godot_icall_1_57(method_bind_10, Object.GetPtr(this), ref fillTo);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fill_to");

        [GodotMethod("get_fill_to")]
        [Obsolete("GetFillTo is deprecated. Use the FillTo property instead.")]
        public Vector2 GetFillTo()
        {
            NativeCalls.godot_icall_0_18(method_bind_11, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_repeat");

        [GodotMethod("set_repeat")]
        [Obsolete("SetRepeat is deprecated. Use the Repeat property instead.")]
        public void SetRepeat(GradientTexture2D.RepeatEnum repeat)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), (int)repeat);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_repeat");

        [GodotMethod("get_repeat")]
        [Obsolete("GetRepeat is deprecated. Use the Repeat property instead.")]
        public GradientTexture2D.RepeatEnum GetRepeat()
        {
            return (GradientTexture2D.RepeatEnum)NativeCalls.godot_icall_0_469(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
