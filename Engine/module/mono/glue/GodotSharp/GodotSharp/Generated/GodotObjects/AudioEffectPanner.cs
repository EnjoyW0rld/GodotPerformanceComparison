using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Determines how much of an audio signal is sent to the left and right buses.</para>
    /// </summary>
    public partial class AudioEffectPanner : AudioEffect
    {
        /// <summary>
        /// <para>Pan position. Value can range from -1 (fully left) to 1 (fully right).</para>
        /// </summary>
        public float Pan
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPan();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPan(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AudioEffectPanner";

        public AudioEffectPanner() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPanner_Ctor(this);
        }

        internal AudioEffectPanner(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pan");

        [GodotMethod("set_pan")]
        [Obsolete("SetPan is deprecated. Use the Pan property instead.")]
        public void SetPan(float cpanume)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), cpanume);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pan");

        [GodotMethod("get_pan")]
        [Obsolete("GetPan is deprecated. Use the Pan property instead.")]
        public float GetPan()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
