using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is a generic mobile VR implementation where you need to provide details about the phone and HMD used. It does not rely on any existing framework. This is the most basic interface we have. For the best effect, you need a mobile phone with a gyroscope and accelerometer.</para>
    /// <para>Note that even though there is no positional tracking, the camera will assume the headset is at a height of 1.85 meters. You can change this by setting <see cref="Godot.MobileVRInterface.EyeHeight"/>.</para>
    /// <para>You can initialise this interface as follows:</para>
    /// <para><code>
    /// var interface = ARVRServer.find_interface("Native mobile")
    /// if interface and interface.initialize():
    ///     get_viewport().arvr = true
    /// </code></para>
    /// </summary>
    public partial class MobileVRInterface : ARVRInterface
    {
        /// <summary>
        /// <para>The height at which the camera is placed in relation to the ground (i.e. <see cref="Godot.ARVROrigin"/> node).</para>
        /// </summary>
        public float EyeHeight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEyeHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEyeHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The interocular distance, also known as the interpupillary distance. The distance between the pupils of the left and right eye.</para>
        /// </summary>
        public float Iod
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIod();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIod(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The width of the display in centimeters.</para>
        /// </summary>
        public float DisplayWidth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDisplayWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisplayWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The distance between the display and the lenses inside of the device in centimeters.</para>
        /// </summary>
        public float DisplayToLens
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDisplayToLens();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDisplayToLens(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The oversample setting. Because of the lens distortion we have to render our buffers at a higher resolution then the screen can natively handle. A value between 1.5 and 2.0 often provides good results but at the cost of performance.</para>
        /// </summary>
        public float Oversample
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOversample();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOversample(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The k1 lens factor is one of the two constants that define the strength of the lens used and directly influences the lens distortion effect.</para>
        /// </summary>
        public float K1
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetK1();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetK1(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The k2 lens factor, see k1.</para>
        /// </summary>
        public float K2
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetK2();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetK2(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MobileVRInterface";

        public MobileVRInterface() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MobileVRInterface_Ctor(this);
        }

        internal MobileVRInterface(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_eye_height");

        [GodotMethod("set_eye_height")]
        [Obsolete("SetEyeHeight is deprecated. Use the EyeHeight property instead.")]
        public void SetEyeHeight(float eyeHeight)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), eyeHeight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_eye_height");

        [GodotMethod("get_eye_height")]
        [Obsolete("GetEyeHeight is deprecated. Use the EyeHeight property instead.")]
        public float GetEyeHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_iod");

        [GodotMethod("set_iod")]
        [Obsolete("SetIod is deprecated. Use the Iod property instead.")]
        public void SetIod(float iod)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), iod);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_iod");

        [GodotMethod("get_iod")]
        [Obsolete("GetIod is deprecated. Use the Iod property instead.")]
        public float GetIod()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_display_width");

        [GodotMethod("set_display_width")]
        [Obsolete("SetDisplayWidth is deprecated. Use the DisplayWidth property instead.")]
        public void SetDisplayWidth(float displayWidth)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), displayWidth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_display_width");

        [GodotMethod("get_display_width")]
        [Obsolete("GetDisplayWidth is deprecated. Use the DisplayWidth property instead.")]
        public float GetDisplayWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_display_to_lens");

        [GodotMethod("set_display_to_lens")]
        [Obsolete("SetDisplayToLens is deprecated. Use the DisplayToLens property instead.")]
        public void SetDisplayToLens(float displayToLens)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), displayToLens);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_display_to_lens");

        [GodotMethod("get_display_to_lens")]
        [Obsolete("GetDisplayToLens is deprecated. Use the DisplayToLens property instead.")]
        public float GetDisplayToLens()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_oversample");

        [GodotMethod("set_oversample")]
        [Obsolete("SetOversample is deprecated. Use the Oversample property instead.")]
        public void SetOversample(float oversample)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), oversample);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_oversample");

        [GodotMethod("get_oversample")]
        [Obsolete("GetOversample is deprecated. Use the Oversample property instead.")]
        public float GetOversample()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_k1");

        [GodotMethod("set_k1")]
        [Obsolete("SetK1 is deprecated. Use the K1 property instead.")]
        public void SetK1(float k)
        {
            NativeCalls.godot_icall_1_15(method_bind_10, Object.GetPtr(this), k);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_k1");

        [GodotMethod("get_k1")]
        [Obsolete("GetK1 is deprecated. Use the K1 property instead.")]
        public float GetK1()
        {
            return NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_k2");

        [GodotMethod("set_k2")]
        [Obsolete("SetK2 is deprecated. Use the K2 property instead.")]
        public void SetK2(float k)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), k);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_k2");

        [GodotMethod("get_k2")]
        [Obsolete("GetK2 is deprecated. Use the K2 property instead.")]
        public float GetK2()
        {
            return NativeCalls.godot_icall_0_14(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
