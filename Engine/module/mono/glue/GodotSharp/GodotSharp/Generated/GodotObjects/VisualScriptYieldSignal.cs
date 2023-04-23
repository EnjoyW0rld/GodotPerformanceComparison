using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptYieldSignal"/> will pause the function execution until the provided signal is emitted.</para>
    /// </summary>
    public partial class VisualScriptYieldSignal : VisualScriptNode
    {
        public enum CallModeEnum
        {
            /// <summary>
            /// <para>A signal from this <see cref="Godot.Object"/> will be used.</para>
            /// </summary>
            Self = 0,
            /// <summary>
            /// <para>A signal from the given <see cref="Godot.Node"/> in the scene tree will be used.</para>
            /// </summary>
            NodePath = 1,
            /// <summary>
            /// <para>A signal from an instanced node with the given type will be used.</para>
            /// </summary>
            Instance = 2
        }

        /// <summary>
        /// <para><c>call_mode</c> determines the target object to wait for the signal emission. See <see cref="Godot.VisualScriptYieldSignal.CallModeEnum"/> for options.</para>
        /// </summary>
        public VisualScriptYieldSignal.CallModeEnum CallMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCallMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCallMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The base type to be used when <see cref="Godot.VisualScriptYieldSignal.CallMode"/> is set to <see cref="Godot.VisualScriptYieldSignal.CallModeEnum.Instance"/>.</para>
        /// </summary>
        public string BaseType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node path to use when <see cref="Godot.VisualScriptYieldSignal.CallMode"/> is set to <see cref="Godot.VisualScriptYieldSignal.CallModeEnum.NodePath"/>.</para>
        /// </summary>
        public NodePath NodePath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBasePath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBasePath(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The signal name to be waited for.</para>
        /// </summary>
        public string Signal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSignal();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSignal(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptYieldSignal";

        public VisualScriptYieldSignal() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptYieldSignal_Ctor(this);
        }

        internal VisualScriptYieldSignal(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_type");

        [GodotMethod("set_base_type")]
        [Obsolete("SetBaseType is deprecated. Use the BaseType property instead.")]
        public void SetBaseType(string baseType)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), baseType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_type");

        [GodotMethod("get_base_type")]
        [Obsolete("GetBaseType is deprecated. Use the BaseType property instead.")]
        public string GetBaseType()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_signal");

        [GodotMethod("set_signal")]
        [Obsolete("SetSignal is deprecated. Use the Signal property instead.")]
        public void SetSignal(string signal)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), signal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_signal");

        [GodotMethod("get_signal")]
        [Obsolete("GetSignal is deprecated. Use the Signal property instead.")]
        public string GetSignal()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_call_mode");

        [GodotMethod("set_call_mode")]
        [Obsolete("SetCallMode is deprecated. Use the CallMode property instead.")]
        public void SetCallMode(VisualScriptYieldSignal.CallModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_call_mode");

        [GodotMethod("get_call_mode")]
        [Obsolete("GetCallMode is deprecated. Use the CallMode property instead.")]
        public VisualScriptYieldSignal.CallModeEnum GetCallMode()
        {
            return (VisualScriptYieldSignal.CallModeEnum)NativeCalls.godot_icall_0_1044(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_path");

        [GodotMethod("set_base_path")]
        [Obsolete("SetBasePath is deprecated. Use the NodePath property instead.")]
        public void SetBasePath(NodePath basePath)
        {
            NativeCalls.godot_icall_1_129(method_bind_6, Object.GetPtr(this), NodePath.GetPtr(basePath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_path");

        [GodotMethod("get_base_path")]
        [Obsolete("GetBasePath is deprecated. Use the NodePath property instead.")]
        public NodePath GetBasePath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_7, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
