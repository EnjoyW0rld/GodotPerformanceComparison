using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Visual shader graphs consist of various nodes. Each node in the graph is a separate object and they are represented as a rectangular boxes with title and a set of properties. Each node has also connection ports that allow to connect it to another nodes and control the flow of the shader.</para>
    /// </summary>
    public abstract partial class VisualShaderNode : Resource
    {
        public enum PortType
        {
            /// <summary>
            /// <para>Floating-point scalar. Translated to <c>float</c> type in shader code.</para>
            /// </summary>
            Scalar = 0,
            /// <summary>
            /// <para>3D vector of floating-point values. Translated to <c>vec3</c> type in shader code.</para>
            /// </summary>
            Vector = 1,
            /// <summary>
            /// <para>Boolean type. Translated to <c>bool</c> type in shader code.</para>
            /// </summary>
            Boolean = 2,
            /// <summary>
            /// <para>Transform type. Translated to <c>mat4</c> type in shader code.</para>
            /// </summary>
            Transform = 3,
            /// <summary>
            /// <para>Sampler type. Translated to reference of sampler uniform in shader code. Can only be used for input ports in non-uniform nodes.</para>
            /// </summary>
            Sampler = 4,
            /// <summary>
            /// <para>Represents the size of the <see cref="Godot.VisualShaderNode.PortType"/> enum.</para>
            /// </summary>
            Max = 5
        }

        /// <summary>
        /// <para>Sets the output port index which will be showed for preview. If set to <c>-1</c> no port will be open for preview.</para>
        /// </summary>
        public int OutputPortForPreview
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOutputPortForPreview();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOutputPortForPreview(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array DefaultInputValues
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultInputValues();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultInputValues(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNode";

        internal VisualShaderNode() {}

        internal VisualShaderNode(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_port_for_preview");

        [GodotMethod("set_output_port_for_preview")]
        [Obsolete("SetOutputPortForPreview is deprecated. Use the OutputPortForPreview property instead.")]
        public void SetOutputPortForPreview(int port)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_output_port_for_preview");

        [GodotMethod("get_output_port_for_preview")]
        [Obsolete("GetOutputPortForPreview is deprecated. Use the OutputPortForPreview property instead.")]
        public int GetOutputPortForPreview()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_port_default_value");

        /// <summary>
        /// <para>Sets the default value for the selected input <c>port</c>.</para>
        /// </summary>
        [GodotMethod("set_input_port_default_value")]
        public void SetInputPortDefaultValue(int port, object value)
        {
            NativeCalls.godot_icall_2_542(method_bind_2, Object.GetPtr(this), port, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_port_default_value");

        /// <summary>
        /// <para>Returns the default value of the input <c>port</c>.</para>
        /// </summary>
        [GodotMethod("get_input_port_default_value")]
        public object GetInputPortDefaultValue(int port)
        {
            return NativeCalls.godot_icall_1_543(method_bind_3, Object.GetPtr(this), port);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_input_values");

        /// <summary>
        /// <para>Sets the default input ports values using an <see cref="Godot.Collections.Array"/> of the form <c>[index0, value0, index1, value1, ...]</c>. For example: <c>[0, Vector3(0, 0, 0), 1, Vector3(0, 0, 0)]</c>.</para>
        /// </summary>
        [GodotMethod("set_default_input_values")]
        [Obsolete("SetDefaultInputValues is deprecated. Use the DefaultInputValues property instead.")]
        public void SetDefaultInputValues(Godot.Collections.Array values)
        {
            NativeCalls.godot_icall_1_92(method_bind_4, Object.GetPtr(this), values.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_input_values");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> containing default values for all of the input ports of the node in the form <c>[index0, value0, index1, value1, ...]</c>.</para>
        /// </summary>
        [GodotMethod("get_default_input_values")]
        [Obsolete("GetDefaultInputValues is deprecated. Use the DefaultInputValues property instead.")]
        public Godot.Collections.Array GetDefaultInputValues()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_5, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
