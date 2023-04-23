using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.VisualScriptPropertySet"/> can set the value of any property from the current object or other objects.</para>
    /// </summary>
    public partial class VisualScriptPropertySet : VisualScriptNode
    {
        public enum AssignOpEnum
        {
            /// <summary>
            /// <para>The property will be assigned regularly.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>The value will be added to the property. Equivalent of doing <c>+=</c>.</para>
            /// </summary>
            Add = 1,
            /// <summary>
            /// <para>The value will be subtracted from the property. Equivalent of doing <c>-=</c>.</para>
            /// </summary>
            Sub = 2,
            /// <summary>
            /// <para>The property will be multiplied by the value. Equivalent of doing <c>*=</c>.</para>
            /// </summary>
            Mul = 3,
            /// <summary>
            /// <para>The property will be divided by the value. Equivalent of doing <c>/=</c>.</para>
            /// </summary>
            Div = 4,
            /// <summary>
            /// <para>A modulo operation will be performed on the property and the value. Equivalent of doing <c>%=</c>.</para>
            /// </summary>
            Mod = 5,
            /// <summary>
            /// <para>The property will be binarly shifted to the left by the given value. Equivalent of doing <c>&lt;&lt;</c>.</para>
            /// </summary>
            ShiftLeft = 6,
            /// <summary>
            /// <para>The property will be binarly shifted to the right by the given value. Equivalent of doing <c>&gt;&gt;</c>.</para>
            /// </summary>
            ShiftRight = 7,
            /// <summary>
            /// <para>A binary <c>AND</c> operation will be performed on the property. Equivalent of doing <c>&amp;=</c>.</para>
            /// </summary>
            BitAnd = 8,
            /// <summary>
            /// <para>A binary <c>OR</c> operation will be performed on the property. Equivalent of doing <c>|=</c>.</para>
            /// </summary>
            BitOr = 9,
            /// <summary>
            /// <para>A binary <c>XOR</c> operation will be performed on the property. Equivalent of doing <c>^=</c>.</para>
            /// </summary>
            BitXor = 10
        }

        public enum CallMode
        {
            /// <summary>
            /// <para>The property will be set on this <see cref="Godot.Object"/>.</para>
            /// </summary>
            Self = 0,
            /// <summary>
            /// <para>The property will be set on the given <see cref="Godot.Node"/> in the scene tree.</para>
            /// </summary>
            NodePath = 1,
            /// <summary>
            /// <para>The property will be set on an instanced node with the given type and script.</para>
            /// </summary>
            Instance = 2,
            /// <summary>
            /// <para>The property will be set on a GDScript basic type (e.g. <see cref="Godot.Vector2"/>).</para>
            /// </summary>
            BasicType = 3
        }

        /// <summary>
        /// <para><c>set_mode</c> determines the target object on which the property will be set. See <see cref="Godot.VisualScriptPropertySet.CallMode"/> for options.</para>
        /// </summary>
        public VisualScriptPropertySet.CallMode SetMode
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
        /// <para>The base type to be used when <see cref="Godot.VisualScriptPropertySet.SetMode"/> is set to <see cref="Godot.VisualScriptPropertySet.CallMode.Instance"/>.</para>
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
        /// <para>The script to be used when <see cref="Godot.VisualScriptPropertySet.SetMode"/> is set to <see cref="Godot.VisualScriptPropertySet.CallMode.Instance"/>.</para>
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

        public Godot.Collections.Dictionary TypeCache
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTypeCache();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetTypeCache(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The type to be used when <see cref="Godot.VisualScriptPropertySet.SetMode"/> is set to <see cref="Godot.VisualScriptPropertySet.CallMode.BasicType"/>.</para>
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
        /// <para>The node path to use when <see cref="Godot.VisualScriptPropertySet.SetMode"/> is set to <see cref="Godot.VisualScriptPropertySet.CallMode.NodePath"/>.</para>
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
        /// <para>The name of the property to set. Changing this will clear <see cref="Godot.VisualScriptPropertySet.Index"/>.</para>
        /// </summary>
        public string Property
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProperty();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProperty(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The indexed name of the property to set. See <see cref="Godot.Object.SetIndexed"/> for details.</para>
        /// </summary>
        public string Index
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The additional operation to perform when assigning. See <see cref="Godot.VisualScriptPropertySet.AssignOpEnum"/> for options.</para>
        /// </summary>
        public VisualScriptPropertySet.AssignOpEnum AssignOp
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAssignOp();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAssignOp(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptPropertySet";

        public VisualScriptPropertySet() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptPropertySet_Ctor(this);
        }

        internal VisualScriptPropertySet(bool memoryOwn) : base(memoryOwn) {}

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
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_type_cache");

        [Obsolete("_SetTypeCache is deprecated. Use the TypeCache property instead.")]
        internal void _SetTypeCache(Godot.Collections.Dictionary typeCache)
        {
            NativeCalls.godot_icall_1_213(method_bind_6, Object.GetPtr(this), typeCache.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_type_cache");

        [Obsolete("_GetTypeCache is deprecated. Use the TypeCache property instead.")]
        internal Godot.Collections.Dictionary _GetTypeCache()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_7, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_property");

        [GodotMethod("set_property")]
        [Obsolete("SetProperty is deprecated. Use the Property property instead.")]
        public void SetProperty(string property)
        {
            NativeCalls.godot_icall_1_54(method_bind_8, Object.GetPtr(this), property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_property");

        [GodotMethod("get_property")]
        [Obsolete("GetProperty is deprecated. Use the Property property instead.")]
        public string GetProperty()
        {
            return NativeCalls.godot_icall_0_6(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_call_mode");

        [GodotMethod("set_call_mode")]
        [Obsolete("SetCallMode is deprecated. Use the SetMode property instead.")]
        public void SetCallMode(VisualScriptPropertySet.CallMode mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_call_mode");

        [GodotMethod("get_call_mode")]
        [Obsolete("GetCallMode is deprecated. Use the SetMode property instead.")]
        public VisualScriptPropertySet.CallMode GetCallMode()
        {
            return (VisualScriptPropertySet.CallMode)NativeCalls.godot_icall_0_1041(method_bind_11, Object.GetPtr(this));
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
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_index");

        [GodotMethod("set_index")]
        [Obsolete("SetIndex is deprecated. Use the Index property instead.")]
        public void SetIndex(string index)
        {
            NativeCalls.godot_icall_1_54(method_bind_14, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_index");

        [GodotMethod("get_index")]
        [Obsolete("GetIndex is deprecated. Use the Index property instead.")]
        public string GetIndex()
        {
            return NativeCalls.godot_icall_0_6(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_assign_op");

        [GodotMethod("set_assign_op")]
        [Obsolete("SetAssignOp is deprecated. Use the AssignOp property instead.")]
        public void SetAssignOp(VisualScriptPropertySet.AssignOpEnum assignOp)
        {
            NativeCalls.godot_icall_1_4(method_bind_16, Object.GetPtr(this), (int)assignOp);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_assign_op");

        [GodotMethod("get_assign_op")]
        [Obsolete("GetAssignOp is deprecated. Use the AssignOp property instead.")]
        public VisualScriptPropertySet.AssignOpEnum GetAssignOp()
        {
            return (VisualScriptPropertySet.AssignOpEnum)NativeCalls.godot_icall_0_1042(method_bind_17, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
