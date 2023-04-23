using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class AudioEffectStereoEnhance : AudioEffect
    {
        public float PanPullout
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPanPullout();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPanPullout(value);
            }
#pragma warning restore CS0618
        }

        public float TimePulloutMs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTimePullout();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTimePullout(value);
            }
#pragma warning restore CS0618
        }

        public float Surround
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSurround();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSurround(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectStereoEnhance";

        public AudioEffectStereoEnhance() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectStereoEnhance_Ctor(this);
        }

        internal AudioEffectStereoEnhance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pan_pullout");

        [GodotMethod("set_pan_pullout")]
        [Obsolete("SetPanPullout is deprecated. Use the PanPullout property instead.")]
        public void SetPanPullout(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pan_pullout");

        [GodotMethod("get_pan_pullout")]
        [Obsolete("GetPanPullout is deprecated. Use the PanPullout property instead.")]
        public float GetPanPullout()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_time_pullout");

        [GodotMethod("set_time_pullout")]
        [Obsolete("SetTimePullout is deprecated. Use the TimePulloutMs property instead.")]
        public void SetTimePullout(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_pullout");

        [GodotMethod("get_time_pullout")]
        [Obsolete("GetTimePullout is deprecated. Use the TimePulloutMs property instead.")]
        public float GetTimePullout()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_surround");

        [GodotMethod("set_surround")]
        [Obsolete("SetSurround is deprecated. Use the Surround property instead.")]
        public void SetSurround(float amount)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_surround");

        [GodotMethod("get_surround")]
        [Obsolete("GetSurround is deprecated. Use the Surround property instead.")]
        public float GetSurround()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
