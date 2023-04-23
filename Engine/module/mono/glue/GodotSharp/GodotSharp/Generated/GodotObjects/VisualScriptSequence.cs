using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Steps through a series of one or more output Sequence ports. The <c>current</c> data port outputs the currently executing item.</para>
    /// <para>Input Ports:</para>
    /// <para>- Sequence: <c>in order</c></para>
    /// <para>Output Ports:</para>
    /// <para>- Sequence: <c>1</c></para>
    /// <para>- Sequence: <c>2 - n</c> (optional)</para>
    /// <para>- Data (int): <c>current</c></para>
    /// </summary>
    public partial class VisualScriptSequence : VisualScriptNode
    {
        /// <summary>
        /// <para>The number of steps in the sequence.</para>
        /// </summary>
        public int Steps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSteps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSteps(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptSequence";

        public VisualScriptSequence() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSequence_Ctor(this);
        }

        internal VisualScriptSequence(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_steps");

        [GodotMethod("set_steps")]
        [Obsolete("SetSteps is deprecated. Use the Steps property instead.")]
        public void SetSteps(int steps)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), steps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_steps");

        [GodotMethod("get_steps")]
        [Obsolete("GetSteps is deprecated. Use the Steps property instead.")]
        public int GetSteps()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
