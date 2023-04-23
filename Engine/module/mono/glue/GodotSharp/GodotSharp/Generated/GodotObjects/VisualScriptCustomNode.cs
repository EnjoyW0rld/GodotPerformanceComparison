using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A custom Visual Script node which can be scripted in powerful ways.</para>
    /// </summary>
    public partial class VisualScriptCustomNode : VisualScriptNode
    {
        /// <summary>
        /// <para>Hint used by <see cref="Godot.VisualScriptCustomNode._Step"/> to tell that control should return to it when there is no other node left to execute.</para>
        /// <para>This is used by <see cref="Godot.VisualScriptCondition"/> to redirect the sequence to the "Done" port after the <c>true</c>/<c>false</c> branch has finished execution.</para>
        /// </summary>
        public const int StepPushStackBit = 16777216;
        /// <summary>
        /// <para>Hint used by <see cref="Godot.VisualScriptCustomNode._Step"/> to tell that control should return back, either hitting a previous <see cref="Godot.VisualScriptCustomNode.StepPushStackBit"/> or exiting the function.</para>
        /// </summary>
        public const int StepGoBackBit = 33554432;
        public const int StepNoAdvanceBit = 67108864;
        /// <summary>
        /// <para>Hint used by <see cref="Godot.VisualScriptCustomNode._Step"/> to tell that control should stop and exit the function.</para>
        /// </summary>
        public const int StepExitFunctionBit = 134217728;
        /// <summary>
        /// <para>Hint used by <see cref="Godot.VisualScriptCustomNode._Step"/> to tell that the function should be yielded.</para>
        /// <para>Using this requires you to have at least one working memory slot, which is used for the <see cref="Godot.VisualScriptFunctionState"/>.</para>
        /// </summary>
        public const int StepYieldBit = 268435456;

        public enum StartMode
        {
            /// <summary>
            /// <para>The start mode used the first time when <see cref="Godot.VisualScriptCustomNode._Step"/> is called.</para>
            /// </summary>
            BeginSequence = 0,
            /// <summary>
            /// <para>The start mode used when <see cref="Godot.VisualScriptCustomNode._Step"/> is called after coming back from a <see cref="Godot.VisualScriptCustomNode.StepPushStackBit"/>.</para>
            /// </summary>
            ContinueSequence = 1,
            /// <summary>
            /// <para>The start mode used when <see cref="Godot.VisualScriptCustomNode._Step"/> is called after resuming from <see cref="Godot.VisualScriptCustomNode.StepYieldBit"/>.</para>
            /// </summary>
            ResumeYield = 2
        }

        private const string nativeName = "VisualScriptCustomNode";

        public VisualScriptCustomNode() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptCustomNode_Ctor(this);
        }

        internal VisualScriptCustomNode(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Return the node's title.</para>
        /// </summary>
        [GodotMethod("_get_caption")]
        public virtual string _GetCaption()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the node's category.</para>
        /// </summary>
        [GodotMethod("_get_category")]
        public virtual string _GetCategory()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the count of input value ports.</para>
        /// </summary>
        [GodotMethod("_get_input_value_port_count")]
        public virtual int _GetInputValuePortCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the specified input port's hint. See the <see cref="Godot.PropertyHint"/> hints.</para>
        /// </summary>
        [GodotMethod("_get_input_value_port_hint")]
        public virtual int _GetInputValuePortHint(int idx)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the specified input port's hint string.</para>
        /// </summary>
        [GodotMethod("_get_input_value_port_hint_string")]
        public virtual string _GetInputValuePortHintString(int idx)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the specified input port's name.</para>
        /// </summary>
        [GodotMethod("_get_input_value_port_name")]
        public virtual string _GetInputValuePortName(int idx)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the specified input port's type. See the <see cref="Godot.Variant.Type"/> values.</para>
        /// </summary>
        [GodotMethod("_get_input_value_port_type")]
        public virtual int _GetInputValuePortType(int idx)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the amount of output sequence ports.</para>
        /// </summary>
        [GodotMethod("_get_output_sequence_port_count")]
        public virtual int _GetOutputSequencePortCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the specified sequence output's name.</para>
        /// </summary>
        [GodotMethod("_get_output_sequence_port_text")]
        public virtual string _GetOutputSequencePortText(int idx)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the amount of output value ports.</para>
        /// </summary>
        [GodotMethod("_get_output_value_port_count")]
        public virtual int _GetOutputValuePortCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the specified output port's hint. See the <see cref="Godot.PropertyHint"/> hints.</para>
        /// </summary>
        [GodotMethod("_get_output_value_port_hint")]
        public virtual int _GetOutputValuePortHint(int idx)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the specified output port's hint string.</para>
        /// </summary>
        [GodotMethod("_get_output_value_port_hint_string")]
        public virtual string _GetOutputValuePortHintString(int idx)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the specified output port's name.</para>
        /// </summary>
        [GodotMethod("_get_output_value_port_name")]
        public virtual string _GetOutputValuePortName(int idx)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the specified output port's type. See the <see cref="Godot.Variant.Type"/> values.</para>
        /// </summary>
        [GodotMethod("_get_output_value_port_type")]
        public virtual int _GetOutputValuePortType(int idx)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return the custom node's text, which is shown right next to the input sequence port (if there is none, on the place that is usually taken by it).</para>
        /// </summary>
        [GodotMethod("_get_text")]
        public virtual string _GetText()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Return the size of the custom node's working memory. See <see cref="Godot.VisualScriptCustomNode._Step"/> for more details.</para>
        /// </summary>
        [GodotMethod("_get_working_memory_size")]
        public virtual int _GetWorkingMemorySize()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Return whether the custom node has an input sequence port.</para>
        /// </summary>
        [GodotMethod("_has_input_sequence_port")]
        public virtual bool _HasInputSequencePort()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Execute the custom node's logic, returning the index of the output sequence port to use or a <see cref="string"/> when there is an error.</para>
        /// <para>The <c>inputs</c> array contains the values of the input ports.</para>
        /// <para><c>outputs</c> is an array whose indices should be set to the respective outputs.</para>
        /// <para>The <c>start_mode</c> is usually <see cref="Godot.VisualScriptCustomNode.StartMode.BeginSequence"/>, unless you have used the <c>STEP_*</c> constants.</para>
        /// <para><c>working_mem</c> is an array which can be used to persist information between runs of the custom node. The size needs to be predefined using <see cref="Godot.VisualScriptCustomNode._GetWorkingMemorySize"/>.</para>
        /// <para>When returning, you can mask the returned value with one of the <c>STEP_*</c> constants.</para>
        /// </summary>
        [GodotMethod("_step")]
        public virtual object _Step(Godot.Collections.Array inputs, Godot.Collections.Array outputs, int startMode, Godot.Collections.Array workingMem)
        {
            return default(object);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
