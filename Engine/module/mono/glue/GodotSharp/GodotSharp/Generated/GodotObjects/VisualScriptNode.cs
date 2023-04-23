using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A node which is part of a <see cref="Godot.VisualScript"/>. Not to be confused with <see cref="Godot.Node"/>, which is a part of a <see cref="Godot.SceneTree"/>.</para>
    /// </summary>
    public abstract partial class VisualScriptNode : Resource
    {
        public Godot.Collections.Array _DefaultInputValues
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetDefaultInputValues();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetDefaultInputValues(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptNode";

        internal VisualScriptNode() {}

        internal VisualScriptNode(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visual_script");

        /// <summary>
        /// <para>Returns the <see cref="Godot.VisualScript"/> instance the node is bound to.</para>
        /// </summary>
        [GodotMethod("get_visual_script")]
        public VisualScript GetVisualScript()
        {
            return NativeCalls.godot_icall_0_1038(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_input_value");

        /// <summary>
        /// <para>Change the default value of a given port.</para>
        /// </summary>
        [GodotMethod("set_default_input_value")]
        public void SetDefaultInputValue(int portIdx, object value)
        {
            NativeCalls.godot_icall_2_542(method_bind_1, Object.GetPtr(this), portIdx, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_input_value");

        /// <summary>
        /// <para>Returns the default value of a given port. The default value is used when nothing is connected to the port.</para>
        /// </summary>
        [GodotMethod("get_default_input_value")]
        public object GetDefaultInputValue(int portIdx)
        {
            return NativeCalls.godot_icall_1_543(method_bind_2, Object.GetPtr(this), portIdx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "ports_changed_notify");

        /// <summary>
        /// <para>Notify that the node's ports have changed. Usually used in conjunction with <see cref="Godot.VisualScriptCustomNode"/> .</para>
        /// </summary>
        [GodotMethod("ports_changed_notify")]
        public void PortsChangedNotify()
        {
            NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_default_input_values");

        [Obsolete("_SetDefaultInputValues is deprecated. Use the _DefaultInputValues property instead.")]
        internal void _SetDefaultInputValues(Godot.Collections.Array values)
        {
            NativeCalls.godot_icall_1_92(method_bind_4, Object.GetPtr(this), values.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_default_input_values");

        [Obsolete("_GetDefaultInputValues is deprecated. Use the _DefaultInputValues property instead.")]
        internal Godot.Collections.Array _GetDefaultInputValues()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_5, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
