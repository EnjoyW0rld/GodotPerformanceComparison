using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A resource to add to an <see cref="Godot.AnimationNodeBlendTree"/>. This node will execute a sub-animation and return once it finishes. Blend times for fading in and out can be customized, as well as filters.</para>
    /// </summary>
    public partial class AnimationNodeOneShot : AnimationNode
    {
        public enum MixModeEnum
        {
            Blend = 0,
            Add = 1
        }

        public AnimationNodeOneShot.MixModeEnum MixMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMixMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMixMode(value);
            }
#pragma warning restore CS0618
        }

        public float FadeinTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFadeinTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFadeinTime(value);
            }
#pragma warning restore CS0618
        }

        public float FadeoutTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFadeoutTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFadeoutTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the sub-animation will restart automatically after finishing.</para>
        /// </summary>
        public bool Autorestart
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return HasAutorestart();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutorestart(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The delay after which the automatic restart is triggered, in seconds.</para>
        /// </summary>
        public float AutorestartDelay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAutorestartDelay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutorestartDelay(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <see cref="Godot.AnimationNodeOneShot.Autorestart"/> is <c>true</c>, a random additional delay (in seconds) between 0 and this value will be added to <see cref="Godot.AnimationNodeOneShot.AutorestartDelay"/>.</para>
        /// </summary>
        public float AutorestartRandomDelay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAutorestartRandomDelay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAutorestartRandomDelay(value);
            }
#pragma warning restore CS0618
        }

        public bool Sync
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingSync();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseSync(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeOneShot";

        public AnimationNodeOneShot() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeOneShot_Ctor(this);
        }

        internal AnimationNodeOneShot(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fadein_time");

        [GodotMethod("set_fadein_time")]
        [Obsolete("SetFadeinTime is deprecated. Use the FadeinTime property instead.")]
        public void SetFadeinTime(float time)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fadein_time");

        [GodotMethod("get_fadein_time")]
        [Obsolete("GetFadeinTime is deprecated. Use the FadeinTime property instead.")]
        public float GetFadeinTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fadeout_time");

        [GodotMethod("set_fadeout_time")]
        [Obsolete("SetFadeoutTime is deprecated. Use the FadeoutTime property instead.")]
        public void SetFadeoutTime(float time)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fadeout_time");

        [GodotMethod("get_fadeout_time")]
        [Obsolete("GetFadeoutTime is deprecated. Use the FadeoutTime property instead.")]
        public float GetFadeoutTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autorestart");

        [GodotMethod("set_autorestart")]
        [Obsolete("SetAutorestart is deprecated. Use the Autorestart property instead.")]
        public void SetAutorestart(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_autorestart");

        [GodotMethod("has_autorestart")]
        [Obsolete("HasAutorestart is deprecated. Use the Autorestart property instead.")]
        public bool HasAutorestart()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autorestart_delay");

        [GodotMethod("set_autorestart_delay")]
        [Obsolete("SetAutorestartDelay is deprecated. Use the AutorestartDelay property instead.")]
        public void SetAutorestartDelay(float enable)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_autorestart_delay");

        [GodotMethod("get_autorestart_delay")]
        [Obsolete("GetAutorestartDelay is deprecated. Use the AutorestartDelay property instead.")]
        public float GetAutorestartDelay()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_autorestart_random_delay");

        [GodotMethod("set_autorestart_random_delay")]
        [Obsolete("SetAutorestartRandomDelay is deprecated. Use the AutorestartRandomDelay property instead.")]
        public void SetAutorestartRandomDelay(float enable)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_autorestart_random_delay");

        [GodotMethod("get_autorestart_random_delay")]
        [Obsolete("GetAutorestartRandomDelay is deprecated. Use the AutorestartRandomDelay property instead.")]
        public float GetAutorestartRandomDelay()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mix_mode");

        [GodotMethod("set_mix_mode")]
        [Obsolete("SetMixMode is deprecated. Use the MixMode property instead.")]
        public void SetMixMode(AnimationNodeOneShot.MixModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mix_mode");

        [GodotMethod("get_mix_mode")]
        [Obsolete("GetMixMode is deprecated. Use the MixMode property instead.")]
        public AnimationNodeOneShot.MixModeEnum GetMixMode()
        {
            return (AnimationNodeOneShot.MixModeEnum)NativeCalls.godot_icall_0_113(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_sync");

        [GodotMethod("set_use_sync")]
        [Obsolete("SetUseSync is deprecated. Use the Sync property instead.")]
        public void SetUseSync(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_12, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_sync");

        [GodotMethod("is_using_sync")]
        [Obsolete("IsUsingSync is deprecated. Use the Sync property instead.")]
        public bool IsUsingSync()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
