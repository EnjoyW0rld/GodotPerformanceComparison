using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public abstract partial class AudioEffectSpectrumAnalyzerInstance : AudioEffectInstance
    {
        public enum MagnitudeMode
        {
            /// <summary>
            /// <para>Use the average value as magnitude.</para>
            /// </summary>
            Average = 0,
            /// <summary>
            /// <para>Use the maximum value as magnitude.</para>
            /// </summary>
            Max = 1
        }

        private const string nativeName = "AudioEffectSpectrumAnalyzerInstance";

        internal AudioEffectSpectrumAnalyzerInstance() {}

        internal AudioEffectSpectrumAnalyzerInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_magnitude_for_frequency_range");

        [GodotMethod("get_magnitude_for_frequency_range")]
        public Vector2 GetMagnitudeForFrequencyRange(float fromHz, float toHz, AudioEffectSpectrumAnalyzerInstance.MagnitudeMode mode = (AudioEffectSpectrumAnalyzerInstance.MagnitudeMode)1)
        {
            NativeCalls.godot_icall_3_172(method_bind_0, Object.GetPtr(this), fromHz, toHz, (int)mode, out Vector2 argRet); return (Vector2)argRet;
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
