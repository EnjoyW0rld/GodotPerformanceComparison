using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptFunctionCall"/> is created when you add or drag and drop a function onto the Visual Script graph. It allows to tweak parameters of the call, e.g. what object the function is called on.</para>
    /// </summary>
    public partial class VisualScriptFunctionCall : VisualScriptNode
    {
        public enum RPCCallMode
        {
            /// <summary>
            /// <para>The method will be called locally.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>The method will be called remotely.</para>
            /// </summary>
            Reliable = 1,
            /// <summary>
            /// <para>The method will be called remotely using an unreliable protocol.</para>
            /// </summary>
            Unreliable = 2,
            /// <summary>
            /// <para>The method will be called remotely for the given peer.</para>
            /// </summary>
            ReliableToId = 3,
            /// <summary>
            /// <para>The method will be called remotely for the given peer, using an unreliable protocol.</para>
            /// </summary>
            UnreliableToId = 4
        }

        public enum CallModeEnum
        {
            /// <summary>
            /// <para>The method will be called on this <see cref="Godot.Object"/>.</para>
            /// </summary>
            Self = 0,
            /// <summary>
            /// <para>The method will be called on the given <see cref="Godot.Node"/> in the scene tree.</para>
            /// </summary>
            NodePath = 1,
            /// <summary>
            /// <para>The method will be called on an instanced node with the given type and script.</para>
            /// </summary>
            Instance = 2,
            /// <summary>
            /// <para>The method will be called on a GDScript basic type (e.g. <see cref="Godot.Vector2"/>).</para>
            /// </summary>
            BasicType = 3,
            /// <summary>
            /// <para>The method will be called on a singleton.</para>
            /// </summary>
            Singleton = 4
        }

        /// <summary>
        /// <para><c>call_mode</c> determines the target object on which the method will be called. See <see cref="Godot.VisualScriptFunctionCall.CallModeEnum"/> for options.</para>
        /// </summary>
        public VisualScriptFunctionCall.CallModeEnum CallMode
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
        /// <para>The base type to be used when <see cref="Godot.VisualScriptFunctionCall.CallMode"/> is set to <see cref="Godot.VisualScriptFunctionCall.CallModeEnum.Instance"/>.</para>
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
        /// <para>The script to be used when <see cref="Godot.VisualScriptFunctionCall.CallMode"/> is set to <see cref="Godot.VisualScriptFunctionCall.CallModeEnum.Instance"/>.</para>
        /// </summary>
        public string BaseScript
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBaseScript();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBaseScript(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The singleton to call the method on. Used when <see cref="Godot.VisualScriptFunctionCall.CallMode"/> is set to <see cref="Godot.VisualScriptFunctionCall.CallModeEnum.Singleton"/>.</para>
        /// </summary>
        public string Singleton
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSingleton();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSingleton(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The type to be used when <see cref="Godot.VisualScriptFunctionCall.CallMode"/> is set to <see cref="Godot.VisualScriptFunctionCall.CallModeEnum.BasicType"/>.</para>
        /// </summary>
        public Variant.Type BasicType
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBasicType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBasicType(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node path to use when <see cref="Godot.VisualScriptFunctionCall.CallMode"/> is set to <see cref="Godot.VisualScriptFunctionCall.CallModeEnum.NodePath"/>.</para>
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

        public Godot.Collections.Dictionary ArgumentCache
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetArgumentCache();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetArgumentCache(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of the function to be called.</para>
        /// </summary>
        public string Function
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFunction();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFunction(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Number of default arguments that will be used when calling the function. Can't be higher than the number of available default arguments in the method's declaration.</para>
        /// </summary>
        public int UseDefaultArgs
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseDefaultArgs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseDefaultArgs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>false</c>, call errors (e.g. wrong number of arguments) will be ignored.</para>
        /// </summary>
        public bool Validate
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetValidate();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetValidate(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The mode for RPC calls. See <see cref="Godot.Node.Rpc"/> for more details and <see cref="Godot.VisualScriptFunctionCall.RPCCallMode"/> for available options.</para>
        /// </summary>
        public VisualScriptFunctionCall.RPCCallMode RpcCallMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRpcCallMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRpcCallMode(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptFunctionCall";

        public VisualScriptFunctionCall() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptFunctionCall_Ctor(this);
        }

        internal VisualScriptFunctionCall(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_script");

        [GodotMethod("set_base_script")]
        [Obsolete("SetBaseScript is deprecated. Use the BaseScript property instead.")]
        public void SetBaseScript(string baseScript)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), baseScript);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_script");

        [GodotMethod("get_base_script")]
        [Obsolete("GetBaseScript is deprecated. Use the BaseScript property instead.")]
        public string GetBaseScript()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_basic_type");

        [GodotMethod("set_basic_type")]
        [Obsolete("SetBasicType is deprecated. Use the BasicType property instead.")]
        public void SetBasicType(Variant.Type basicType)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), (int)basicType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_basic_type");

        [GodotMethod("get_basic_type")]
        [Obsolete("GetBasicType is deprecated. Use the BasicType property instead.")]
        public Variant.Type GetBasicType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_singleton");

        [GodotMethod("set_singleton")]
        [Obsolete("SetSingleton is deprecated. Use the Singleton property instead.")]
        public void SetSingleton(string singleton)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), singleton);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_singleton");

        [GodotMethod("get_singleton")]
        [Obsolete("GetSingleton is deprecated. Use the Singleton property instead.")]
        public string GetSingleton()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_function");

        [GodotMethod("set_function")]
        [Obsolete("SetFunction is deprecated. Use the Function property instead.")]
        public void SetFunction(string function)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), function);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_function");

        [GodotMethod("get_function")]
        [Obsolete("GetFunction is deprecated. Use the Function property instead.")]
        public string GetFunction()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_call_mode");

        [GodotMethod("set_call_mode")]
        [Obsolete("SetCallMode is deprecated. Use the CallMode property instead.")]
        public void SetCallMode(VisualScriptFunctionCall.CallModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_call_mode");

        [GodotMethod("get_call_mode")]
        [Obsolete("GetCallMode is deprecated. Use the CallMode property instead.")]
        public VisualScriptFunctionCall.CallModeEnum GetCallMode()
        {
            return (VisualScriptFunctionCall.CallModeEnum)NativeCalls.godot_icall_0_1032(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base_path");

        [GodotMethod("set_base_path")]
        [Obsolete("SetBasePath is deprecated. Use the NodePath property instead.")]
        public void SetBasePath(NodePath basePath)
        {
            NativeCalls.godot_icall_1_129(method_bind_12, Object.GetPtr(this), NodePath.GetPtr(basePath));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base_path");

        [GodotMethod("get_base_path")]
        [Obsolete("GetBasePath is deprecated. Use the NodePath property instead.")]
        public NodePath GetBasePath()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_13, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_default_args");

        [GodotMethod("set_use_default_args")]
        [Obsolete("SetUseDefaultArgs is deprecated. Use the UseDefaultArgs property instead.")]
        public void SetUseDefaultArgs(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_default_args");

        [GodotMethod("get_use_default_args")]
        [Obsolete("GetUseDefaultArgs is deprecated. Use the UseDefaultArgs property instead.")]
        public int GetUseDefaultArgs()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_argument_cache");

        [Obsolete("_SetArgumentCache is deprecated. Use the ArgumentCache property instead.")]
        internal void _SetArgumentCache(Godot.Collections.Dictionary argumentCache)
        {
            NativeCalls.godot_icall_1_213(method_bind_16, Object.GetPtr(this), argumentCache.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_argument_cache");

        [Obsolete("_GetArgumentCache is deprecated. Use the ArgumentCache property instead.")]
        internal Godot.Collections.Dictionary _GetArgumentCache()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_17, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rpc_call_mode");

        [GodotMethod("set_rpc_call_mode")]
        [Obsolete("SetRpcCallMode is deprecated. Use the RpcCallMode property instead.")]
        public void SetRpcCallMode(VisualScriptFunctionCall.RPCCallMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_18, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rpc_call_mode");

        [GodotMethod("get_rpc_call_mode")]
        [Obsolete("GetRpcCallMode is deprecated. Use the RpcCallMode property instead.")]
        public VisualScriptFunctionCall.RPCCallMode GetRpcCallMode()
        {
            return (VisualScriptFunctionCall.RPCCallMode)NativeCalls.godot_icall_0_1033(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_validate");

        [GodotMethod("set_validate")]
        [Obsolete("SetValidate is deprecated. Use the Validate property instead.")]
        public void SetValidate(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_20, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_validate");

        [GodotMethod("get_validate")]
        [Obsolete("GetValidate is deprecated. Use the Validate property instead.")]
        public bool GetValidate()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
