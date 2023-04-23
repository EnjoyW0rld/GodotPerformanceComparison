using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A class stored as a resource. A script extends the functionality of all objects that instance it.</para>
    /// <para>The <c>new</c> method of a script subclass creates a new instance. <see cref="Godot.Object.SetScript"/> extends an existing object, if that object's class matches one of the script's base classes.</para>
    /// </summary>
    public abstract partial class Script : Resource
    {
        /// <summary>
        /// <para>The script source code or an empty string if source code is not available. When set, does not reload the class implementation automatically.</para>
        /// </summary>
        public string SourceCode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSourceCode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSourceCode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Script";

        internal Script() {}

        internal Script(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_instance");

        /// <summary>
        /// <para>Returns <c>true</c> if the script can be instanced.</para>
        /// </summary>
        [GodotMethod("can_instance")]
        public bool CanInstance()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance_has");

        /// <summary>
        /// <para>Returns <c>true</c> if <c>base_object</c> is an instance of this script.</para>
        /// </summary>
        [GodotMethod("instance_has")]
        public bool InstanceHas(Object baseObject)
        {
            return NativeCalls.godot_icall_1_149(method_bind_1, Object.GetPtr(this), Object.GetPtr(baseObject));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_source_code");

        /// <summary>
        /// <para>Returns <c>true</c> if the script contains non-empty source code.</para>
        /// </summary>
        [GodotMethod("has_source_code")]
        public bool HasSourceCode()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_source_code");

        [GodotMethod("get_source_code")]
        [Obsolete("GetSourceCode is deprecated. Use the SourceCode property instead.")]
        public string GetSourceCode()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_source_code");

        [GodotMethod("set_source_code")]
        [Obsolete("SetSourceCode is deprecated. Use the SourceCode property instead.")]
        public void SetSourceCode(string source)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), source);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reload");

        /// <summary>
        /// <para>Reloads the script's class implementation. Returns an error code.</para>
        /// </summary>
        [GodotMethod("reload")]
        public Error Reload(bool keepState = false)
        {
            return (Error)NativeCalls.godot_icall_1_503(method_bind_5, Object.GetPtr(this), keepState);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_script");

        /// <summary>
        /// <para>Returns the script directly inherited by this script.</para>
        /// </summary>
        [GodotMethod("get_base_script")]
        public Script GetBaseScript()
        {
            return NativeCalls.godot_icall_0_848(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_base_type");

        /// <summary>
        /// <para>Returns the script's base type.</para>
        /// </summary>
        [GodotMethod("get_instance_base_type")]
        public string GetInstanceBaseType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_script_signal");

        /// <summary>
        /// <para>Returns <c>true</c> if the script, or a base class, defines a signal with the given name.</para>
        /// </summary>
        [GodotMethod("has_script_signal")]
        public bool HasScriptSignal(string signalName)
        {
            return NativeCalls.godot_icall_1_108(method_bind_8, Object.GetPtr(this), signalName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_property_list");

        /// <summary>
        /// <para>Returns the list of properties in this <see cref="Godot.Script"/>.</para>
        /// </summary>
        [GodotMethod("get_script_property_list")]
        public Godot.Collections.Array GetScriptPropertyList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_method_list");

        /// <summary>
        /// <para>Returns the list of methods in this <see cref="Godot.Script"/>.</para>
        /// </summary>
        [GodotMethod("get_script_method_list")]
        public Godot.Collections.Array GetScriptMethodList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_10, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_signal_list");

        /// <summary>
        /// <para>Returns the list of user signals defined in this <see cref="Godot.Script"/>.</para>
        /// </summary>
        [GodotMethod("get_script_signal_list")]
        public Godot.Collections.Array GetScriptSignalList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_11, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script_constant_map");

        /// <summary>
        /// <para>Returns a dictionary containing constant names and their values.</para>
        /// </summary>
        [GodotMethod("get_script_constant_map")]
        public Godot.Collections.Dictionary GetScriptConstantMap()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_12, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_property_default_value");

        /// <summary>
        /// <para>Returns the default value of the specified property.</para>
        /// </summary>
        [GodotMethod("get_property_default_value")]
        public object GetPropertyDefaultValue(string property)
        {
            return NativeCalls.godot_icall_1_97(method_bind_13, Object.GetPtr(this), property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_tool");

        /// <summary>
        /// <para>Returns <c>true</c> if the script is a tool script. A tool script can run in the editor.</para>
        /// </summary>
        [GodotMethod("is_tool")]
        public bool IsTool()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
