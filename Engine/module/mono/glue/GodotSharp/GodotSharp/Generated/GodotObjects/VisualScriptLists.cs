using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script virtual class that defines the shape and the default behavior of the nodes that have to be in-graph editable nodes.</para>
    /// </summary>
    public abstract partial class VisualScriptLists : VisualScriptNode
    {
        private const string nativeName = "VisualScriptLists";

        internal VisualScriptLists() {}

        internal VisualScriptLists(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_input_data_port");

        /// <summary>
        /// <para>Adds an input port to the Visual Script node.</para>
        /// </summary>
        [GodotMethod("add_input_data_port")]
        public void AddInputDataPort(Variant.Type type, string name, int index)
        {
            NativeCalls.godot_icall_3_1036(method_bind_0, Object.GetPtr(this), (int)type, name, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_data_port_name");

        /// <summary>
        /// <para>Sets the name of an input port.</para>
        /// </summary>
        [GodotMethod("set_input_data_port_name")]
        public void SetInputDataPortName(int index, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_1, Object.GetPtr(this), index, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_data_port_type");

        /// <summary>
        /// <para>Sets the type of an input port.</para>
        /// </summary>
        [GodotMethod("set_input_data_port_type")]
        public void SetInputDataPortType(int index, Variant.Type type)
        {
            NativeCalls.godot_icall_2_65(method_bind_2, Object.GetPtr(this), index, (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_input_data_port");

        /// <summary>
        /// <para>Removes an input port from the Visual Script node.</para>
        /// </summary>
        [GodotMethod("remove_input_data_port")]
        public void RemoveInputDataPort(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_output_data_port");

        /// <summary>
        /// <para>Adds an output port to the Visual Script node.</para>
        /// </summary>
        [GodotMethod("add_output_data_port")]
        public void AddOutputDataPort(Variant.Type type, string name, int index)
        {
            NativeCalls.godot_icall_3_1036(method_bind_4, Object.GetPtr(this), (int)type, name, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_data_port_name");

        /// <summary>
        /// <para>Sets the name of an output port.</para>
        /// </summary>
        [GodotMethod("set_output_data_port_name")]
        public void SetOutputDataPortName(int index, string name)
        {
            NativeCalls.godot_icall_2_121(method_bind_5, Object.GetPtr(this), index, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_output_data_port_type");

        /// <summary>
        /// <para>Sets the type of an output port.</para>
        /// </summary>
        [GodotMethod("set_output_data_port_type")]
        public void SetOutputDataPortType(int index, Variant.Type type)
        {
            NativeCalls.godot_icall_2_65(method_bind_6, Object.GetPtr(this), index, (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_output_data_port");

        /// <summary>
        /// <para>Removes an output port from the Visual Script node.</para>
        /// </summary>
        [GodotMethod("remove_output_data_port")]
        public void RemoveOutputDataPort(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_7, Object.GetPtr(this), index);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
