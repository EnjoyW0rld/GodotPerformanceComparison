using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Currently, has no direct usage, use the derived classes instead.</para>
    /// </summary>
    public partial class VisualShaderNodeGroupBase : VisualShaderNode
    {
        /// <summary>
        /// <para>The size of the node in the visual shader graph.</para>
        /// </summary>
        public Vector2 Size
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSize(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeGroupBase";

        public VisualShaderNodeGroupBase() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeGroupBase_Ctor(this);
        }

        internal VisualShaderNodeGroupBase(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        [GodotMethod("set_size")]
        [Obsolete("SetSize is deprecated. Use the Size property instead.")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the Size property instead.")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_inputs");

        /// <summary>
        /// <para>Defines all input ports using a <see cref="string"/> formatted as a colon-separated list: <c>id,type,name;</c> (see <see cref="Godot.VisualShaderNodeGroupBase.AddInputPort"/>).</para>
        /// </summary>
        [GodotMethod("set_inputs")]
        public void SetInputs(string inputs)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), inputs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inputs");

        /// <summary>
        /// <para>Returns a <see cref="string"/> description of the input ports as a colon-separated list using the format <c>id,type,name;</c> (see <see cref="Godot.VisualShaderNodeGroupBase.AddInputPort"/>).</para>
        /// </summary>
        [GodotMethod("get_inputs")]
        public string GetInputs()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_outputs");

        /// <summary>
        /// <para>Defines all output ports using a <see cref="string"/> formatted as a colon-separated list: <c>id,type,name;</c> (see <see cref="Godot.VisualShaderNodeGroupBase.AddOutputPort"/>).</para>
        /// </summary>
        [GodotMethod("set_outputs")]
        public void SetOutputs(string outputs)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), outputs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_outputs");

        /// <summary>
        /// <para>Returns a <see cref="string"/> description of the output ports as a colon-separated list using the format <c>id,type,name;</c> (see <see cref="Godot.VisualShaderNodeGroupBase.AddOutputPort"/>).</para>
        /// </summary>
        [GodotMethod("get_outputs")]
        public string GetOutputs()
        {
            return NativeCalls.godot_icall_0_6(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_valid_port_name");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified port name does not override an existed port name and is valid within the shader.</para>
        /// </summary>
        [GodotMethod("is_valid_port_name")]
        public bool IsValidPortName(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_6, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_input_port");

        /// <summary>
        /// <para>Adds an input port with the specified <c>type</c> (see <see cref="Godot.VisualShaderNode.PortType"/>) and <c>name</c>.</para>
        /// </summary>
        [GodotMethod("add_input_port")]
        public void AddInputPort(int id, int type, string name)
        {
            NativeCalls.godot_icall_3_88(method_bind_7, Object.GetPtr(this), id, type, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_input_port");

        /// <summary>
        /// <para>Removes the specified input port.</para>
        /// </summary>
        [GodotMethod("remove_input_port")]
        public void RemoveInputPort(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_port_count");

        /// <summary>
        /// <para>Returns the number of input ports in use. Alternative for <see cref="Godot.VisualShaderNodeGroupBase.GetFreeInputPortId"/>.</para>
        /// </summary>
        [GodotMethod("get_input_port_count")]
        public int GetInputPortCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_input_port");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified input port exists.</para>
        /// </summary>
        [GodotMethod("has_input_port")]
        public bool HasInputPort(int id)
        {
            return NativeCalls.godot_icall_1_35(method_bind_10, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_input_ports");

        /// <summary>
        /// <para>Removes all previously specified input ports.</para>
        /// </summary>
        [GodotMethod("clear_input_ports")]
        public void ClearInputPorts()
        {
            NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_output_port");

        /// <summary>
        /// <para>Adds an output port with the specified <c>type</c> (see <see cref="Godot.VisualShaderNode.PortType"/>) and <c>name</c>.</para>
        /// </summary>
        [GodotMethod("add_output_port")]
        public void AddOutputPort(int id, int type, string name)
        {
            NativeCalls.godot_icall_3_88(method_bind_12, Object.GetPtr(this), id, type, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_output_port");

        /// <summary>
        /// <para>Removes the specified output port.</para>
        /// </summary>
        [GodotMethod("remove_output_port")]
        public void RemoveOutputPort(int id)
        {
            NativeCalls.godot_icall_1_4(method_bind_13, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_output_port_count");

        /// <summary>
        /// <para>Returns the number of output ports in use. Alternative for <see cref="Godot.VisualShaderNodeGroupBase.GetFreeOutputPortId"/>.</para>
        /// </summary>
        [GodotMethod("get_output_port_count")]
        public int GetOutputPortCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_output_port");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified output port exists.</para>
        /// </summary>
        [GodotMethod("has_output_port")]
        public bool HasOutputPort(int id)
        {
            return NativeCalls.godot_icall_1_35(method_bind_15, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_output_ports");

        /// <summary>
        /// <para>Removes all previously specified output ports.</para>
        /// </summary>
        [GodotMethod("clear_output_ports")]
        public void ClearOutputPorts()
        {
            NativeCalls.godot_icall_0_3(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_port_name");

        /// <summary>
        /// <para>Renames the specified input port.</para>
        /// </summary>
        [GodotMethod("set_input_port_name")]
        public void SetInputPortName(int id, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_17, Object.GetPtr(this), id, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_port_type");

        /// <summary>
        /// <para>Sets the specified input port's type (see <see cref="Godot.VisualShaderNode.PortType"/>).</para>
        /// </summary>
        [GodotMethod("set_input_port_type")]
        public void SetInputPortType(int id, int type)
        {
            NativeCalls.godot_icall_2_65(method_bind_18, Object.GetPtr(this), id, type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_port_name");

        /// <summary>
        /// <para>Renames the specified output port.</para>
        /// </summary>
        [GodotMethod("set_output_port_name")]
        public void SetOutputPortName(int id, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_19, Object.GetPtr(this), id, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_port_type");

        /// <summary>
        /// <para>Sets the specified output port's type (see <see cref="Godot.VisualShaderNode.PortType"/>).</para>
        /// </summary>
        [GodotMethod("set_output_port_type")]
        public void SetOutputPortType(int id, int type)
        {
            NativeCalls.godot_icall_2_65(method_bind_20, Object.GetPtr(this), id, type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_free_input_port_id");

        /// <summary>
        /// <para>Returns a free input port ID which can be used in <see cref="Godot.VisualShaderNodeGroupBase.AddInputPort"/>.</para>
        /// </summary>
        [GodotMethod("get_free_input_port_id")]
        public int GetFreeInputPortId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_free_output_port_id");

        /// <summary>
        /// <para>Returns a free output port ID which can be used in <see cref="Godot.VisualShaderNodeGroupBase.AddOutputPort"/>.</para>
        /// </summary>
        [GodotMethod("get_free_output_port_id")]
        public int GetFreeOutputPortId()
        {
            return NativeCalls.godot_icall_0_5(method_bind_22, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
