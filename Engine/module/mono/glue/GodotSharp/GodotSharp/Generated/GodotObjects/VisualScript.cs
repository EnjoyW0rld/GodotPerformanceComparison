using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A script implemented in the Visual Script programming environment. The script extends the functionality of all objects that instance it.</para>
    /// <para><see cref="Godot.Object.SetScript"/> extends an existing object, if that object's class matches one of the script's base classes.</para>
    /// <para>You are most likely to use this class via the Visual Script editor or when writing plugins for it.</para>
    /// </summary>
    public partial class VisualScript : Script
    {
        public Godot.Collections.Dictionary Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScript";

        public VisualScript() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScript_Ctor(this);
        }

        internal VisualScript(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_function");

        /// <summary>
        /// <para>Add a function with the specified name to the VisualScript.</para>
        /// </summary>
        [GodotMethod("add_function")]
        public void AddFunction(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_function");

        /// <summary>
        /// <para>Returns whether a function exists with the specified name.</para>
        /// </summary>
        [GodotMethod("has_function")]
        public bool HasFunction(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_function");

        /// <summary>
        /// <para>Remove a specific function and its nodes from the script.</para>
        /// </summary>
        [GodotMethod("remove_function")]
        public void RemoveFunction(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_function");

        /// <summary>
        /// <para>Change the name of a function.</para>
        /// </summary>
        [GodotMethod("rename_function")]
        public void RenameFunction(string name, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_3, Object.GetPtr(this), name, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function_scroll");

        /// <summary>
        /// <para>Position the center of the screen for a function.</para>
        /// </summary>
        [GodotMethod("set_function_scroll")]
        public void SetFunctionScroll(string name, Vector2 ofs)
        {
            NativeCalls.godot_icall_2_111(method_bind_4, Object.GetPtr(this), name, ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function_scroll");

        /// <summary>
        /// <para>Returns the position of the center of the screen for a given function.</para>
        /// </summary>
        [GodotMethod("get_function_scroll")]
        public Vector2 GetFunctionScroll(string name)
        {
            NativeCalls.godot_icall_1_112(method_bind_5, Object.GetPtr(this), name, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_node");

        /// <summary>
        /// <para>Add a node to a function of the VisualScript.</para>
        /// </summary>
        /// <param name="position">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("add_node")]
        public void AddNode(string func, int id, VisualScriptNode node, Nullable<Vector2> position = null)
        {
            Vector2 position_in = position.HasValue ? position.Value : new Vector2(0, 0);
            NativeCalls.godot_icall_4_1018(method_bind_6, Object.GetPtr(this), func, id, Object.GetPtr(node), ref position_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_node");

        /// <summary>
        /// <para>Remove a specific node.</para>
        /// </summary>
        [GodotMethod("remove_node")]
        public void RemoveNode(string func, int id)
        {
            NativeCalls.godot_icall_2_110(method_bind_7, Object.GetPtr(this), func, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function_node_id");

        /// <summary>
        /// <para>Returns the id of a function's entry point node.</para>
        /// </summary>
        [GodotMethod("get_function_node_id")]
        public int GetFunctionNodeId(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_8, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node");

        /// <summary>
        /// <para>Returns a node given its id and its function.</para>
        /// </summary>
        [GodotMethod("get_node")]
        public VisualScriptNode GetNode(string func, int id)
        {
            return NativeCalls.godot_icall_2_1019(method_bind_9, Object.GetPtr(this), func, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_node");

        /// <summary>
        /// <para>Returns whether a node exists with the given id.</para>
        /// </summary>
        [GodotMethod("has_node")]
        public bool HasNode(string func, int id)
        {
            return NativeCalls.godot_icall_2_143(method_bind_10, Object.GetPtr(this), func, id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_node_position");

        /// <summary>
        /// <para>Position a node on the screen.</para>
        /// </summary>
        [GodotMethod("set_node_position")]
        public void SetNodePosition(string func, int id, Vector2 position)
        {
            NativeCalls.godot_icall_3_1020(method_bind_11, Object.GetPtr(this), func, id, ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_position");

        /// <summary>
        /// <para>Returns a node's position in pixels.</para>
        /// </summary>
        [GodotMethod("get_node_position")]
        public Vector2 GetNodePosition(string func, int id)
        {
            NativeCalls.godot_icall_2_1021(method_bind_12, Object.GetPtr(this), func, id, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sequence_connect");

        /// <summary>
        /// <para>Connect two sequence ports. The execution will flow from of <c>from_node</c>'s <c>from_output</c> into <c>to_node</c>.</para>
        /// <para>Unlike <see cref="Godot.VisualScript.DataConnect"/>, there isn't a <c>to_port</c>, since the target node can have only one sequence port.</para>
        /// </summary>
        [GodotMethod("sequence_connect")]
        public void SequenceConnect(string func, int fromNode, int fromOutput, int toNode)
        {
            NativeCalls.godot_icall_4_1022(method_bind_13, Object.GetPtr(this), func, fromNode, fromOutput, toNode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "sequence_disconnect");

        /// <summary>
        /// <para>Disconnect two sequence ports previously connected with <see cref="Godot.VisualScript.SequenceConnect"/>.</para>
        /// </summary>
        [GodotMethod("sequence_disconnect")]
        public void SequenceDisconnect(string func, int fromNode, int fromOutput, int toNode)
        {
            NativeCalls.godot_icall_4_1022(method_bind_14, Object.GetPtr(this), func, fromNode, fromOutput, toNode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_sequence_connection");

        /// <summary>
        /// <para>Returns whether the specified sequence ports are connected.</para>
        /// </summary>
        [GodotMethod("has_sequence_connection")]
        public bool HasSequenceConnection(string func, int fromNode, int fromOutput, int toNode)
        {
            return NativeCalls.godot_icall_4_1023(method_bind_15, Object.GetPtr(this), func, fromNode, fromOutput, toNode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "data_connect");

        /// <summary>
        /// <para>Connect two data ports. The value of <c>from_node</c>'s <c>from_port</c> would be fed into <c>to_node</c>'s <c>to_port</c>.</para>
        /// </summary>
        [GodotMethod("data_connect")]
        public void DataConnect(string func, int fromNode, int fromPort, int toNode, int toPort)
        {
            NativeCalls.godot_icall_5_1024(method_bind_16, Object.GetPtr(this), func, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "data_disconnect");

        /// <summary>
        /// <para>Disconnect two data ports previously connected with <see cref="Godot.VisualScript.DataConnect"/>.</para>
        /// </summary>
        [GodotMethod("data_disconnect")]
        public void DataDisconnect(string func, int fromNode, int fromPort, int toNode, int toPort)
        {
            NativeCalls.godot_icall_5_1024(method_bind_17, Object.GetPtr(this), func, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_data_connection");

        /// <summary>
        /// <para>Returns whether the specified data ports are connected.</para>
        /// </summary>
        [GodotMethod("has_data_connection")]
        public bool HasDataConnection(string func, int fromNode, int fromPort, int toNode, int toPort)
        {
            return NativeCalls.godot_icall_5_1025(method_bind_18, Object.GetPtr(this), func, fromNode, fromPort, toNode, toPort);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_variable");

        /// <summary>
        /// <para>Add a variable to the VisualScript, optionally giving it a default value or marking it as exported.</para>
        /// </summary>
        [GodotMethod("add_variable")]
        public void AddVariable(string name, object defaultValue = null, bool export = false)
        {
            NativeCalls.godot_icall_3_406(method_bind_19, Object.GetPtr(this), name, defaultValue, export);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_variable");

        /// <summary>
        /// <para>Returns whether a variable exists with the specified name.</para>
        /// </summary>
        [GodotMethod("has_variable")]
        public bool HasVariable(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_20, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_variable");

        /// <summary>
        /// <para>Remove a variable with the given name.</para>
        /// </summary>
        [GodotMethod("remove_variable")]
        public void RemoveVariable(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_21, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_variable_default_value");

        /// <summary>
        /// <para>Change the default (initial) value of a variable.</para>
        /// </summary>
        [GodotMethod("set_variable_default_value")]
        public void SetVariableDefaultValue(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_22, Object.GetPtr(this), name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_variable_default_value");

        /// <summary>
        /// <para>Returns the default (initial) value of a variable.</para>
        /// </summary>
        [GodotMethod("get_variable_default_value")]
        public object GetVariableDefaultValue(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_23, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_variable_info");

        /// <summary>
        /// <para>Set a variable's info, using the same format as <see cref="Godot.VisualScript.GetVariableInfo"/>.</para>
        /// </summary>
        [GodotMethod("set_variable_info")]
        public void SetVariableInfo(string name, Godot.Collections.Dictionary value)
        {
            NativeCalls.godot_icall_2_1026(method_bind_24, Object.GetPtr(this), name, value.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_variable_info");

        /// <summary>
        /// <para>Returns the information for a given variable as a dictionary. The information includes its name, type, hint and usage.</para>
        /// </summary>
        [GodotMethod("get_variable_info")]
        public Godot.Collections.Dictionary GetVariableInfo(string name)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_1027(method_bind_25, Object.GetPtr(this), name));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_variable_export");

        /// <summary>
        /// <para>Change whether a variable is exported.</para>
        /// </summary>
        [GodotMethod("set_variable_export")]
        public void SetVariableExport(string name, bool enable)
        {
            NativeCalls.godot_icall_2_56(method_bind_26, Object.GetPtr(this), name, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_variable_export");

        /// <summary>
        /// <para>Returns whether a variable is exported.</para>
        /// </summary>
        [GodotMethod("get_variable_export")]
        public bool GetVariableExport(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_27, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_variable");

        /// <summary>
        /// <para>Change the name of a variable.</para>
        /// </summary>
        [GodotMethod("rename_variable")]
        public void RenameVariable(string name, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_28, Object.GetPtr(this), name, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_custom_signal");

        /// <summary>
        /// <para>Add a custom signal with the specified name to the VisualScript.</para>
        /// </summary>
        [GodotMethod("add_custom_signal")]
        public void AddCustomSignal(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_29, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_custom_signal");

        /// <summary>
        /// <para>Returns whether a signal exists with the specified name.</para>
        /// </summary>
        [GodotMethod("has_custom_signal")]
        public bool HasCustomSignal(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_30, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_add_argument");

        /// <summary>
        /// <para>Add an argument to a custom signal added with <see cref="Godot.VisualScript.AddCustomSignal"/>.</para>
        /// </summary>
        [GodotMethod("custom_signal_add_argument")]
        public void CustomSignalAddArgument(string name, Variant.Type type, string argname, int index = -1)
        {
            NativeCalls.godot_icall_4_472(method_bind_31, Object.GetPtr(this), name, (int)type, argname, index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_set_argument_type");

        /// <summary>
        /// <para>Change the type of a custom signal's argument.</para>
        /// </summary>
        [GodotMethod("custom_signal_set_argument_type")]
        public void CustomSignalSetArgumentType(string name, int argidx, Variant.Type type)
        {
            NativeCalls.godot_icall_3_1028(method_bind_32, Object.GetPtr(this), name, argidx, (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_get_argument_type");

        /// <summary>
        /// <para>Get the type of a custom signal's argument.</para>
        /// </summary>
        [GodotMethod("custom_signal_get_argument_type")]
        public Variant.Type CustomSignalGetArgumentType(string name, int argidx)
        {
            return (Variant.Type)NativeCalls.godot_icall_2_1029(method_bind_33, Object.GetPtr(this), name, argidx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_set_argument_name");

        /// <summary>
        /// <para>Rename a custom signal's argument.</para>
        /// </summary>
        [GodotMethod("custom_signal_set_argument_name")]
        public void CustomSignalSetArgumentName(string name, int argidx, string argname)
        {
            NativeCalls.godot_icall_3_109(method_bind_34, Object.GetPtr(this), name, argidx, argname);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_get_argument_name");

        /// <summary>
        /// <para>Get the name of a custom signal's argument.</para>
        /// </summary>
        [GodotMethod("custom_signal_get_argument_name")]
        public string CustomSignalGetArgumentName(string name, int argidx)
        {
            return NativeCalls.godot_icall_2_139(method_bind_35, Object.GetPtr(this), name, argidx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_remove_argument");

        /// <summary>
        /// <para>Remove a specific custom signal's argument.</para>
        /// </summary>
        [GodotMethod("custom_signal_remove_argument")]
        public void CustomSignalRemoveArgument(string name, int argidx)
        {
            NativeCalls.godot_icall_2_110(method_bind_36, Object.GetPtr(this), name, argidx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_get_argument_count");

        /// <summary>
        /// <para>Get the count of a custom signal's arguments.</para>
        /// </summary>
        [GodotMethod("custom_signal_get_argument_count")]
        public int CustomSignalGetArgumentCount(string name)
        {
            return NativeCalls.godot_icall_1_138(method_bind_37, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "custom_signal_swap_argument");

        /// <summary>
        /// <para>Swap two of the arguments of a custom signal.</para>
        /// </summary>
        [GodotMethod("custom_signal_swap_argument")]
        public void CustomSignalSwapArgument(string name, int argidx, int withidx)
        {
            NativeCalls.godot_icall_3_1028(method_bind_38, Object.GetPtr(this), name, argidx, withidx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_custom_signal");

        /// <summary>
        /// <para>Remove a custom signal with the given name.</para>
        /// </summary>
        [GodotMethod("remove_custom_signal")]
        public void RemoveCustomSignal(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_39, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "rename_custom_signal");

        /// <summary>
        /// <para>Change the name of a custom signal.</para>
        /// </summary>
        [GodotMethod("rename_custom_signal")]
        public void RenameCustomSignal(string name, string newName)
        {
            NativeCalls.godot_icall_2_107(method_bind_40, Object.GetPtr(this), name, newName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instance_base_type");

        /// <summary>
        /// <para>Set the base type of the script.</para>
        /// </summary>
        [GodotMethod("set_instance_base_type")]
        public void SetInstanceBaseType(string type)
        {
            NativeCalls.godot_icall_1_54(method_bind_41, Object.GetPtr(this), type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary data)
        {
            NativeCalls.godot_icall_1_213(method_bind_42, Object.GetPtr(this), data.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_43, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
