using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node which deconstructs a base type instance into its parts.</para>
    /// </summary>
    public partial class VisualScriptDeconstruct : VisualScriptNode
    {
        /// <summary>
        /// <para>The type to deconstruct.</para>
        /// </summary>
        public Variant.Type Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDeconstructType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDeconstructType(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array ElemCache
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetElemCache();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetElemCache(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptDeconstruct";

        public VisualScriptDeconstruct() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptDeconstruct_Ctor(this);
        }

        internal VisualScriptDeconstruct(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deconstruct_type");

        [GodotMethod("set_deconstruct_type")]
        [Obsolete("SetDeconstructType is deprecated. Use the Type property instead.")]
        public void SetDeconstructType(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_deconstruct_type");

        [GodotMethod("get_deconstruct_type")]
        [Obsolete("GetDeconstructType is deprecated. Use the Type property instead.")]
        public Variant.Type GetDeconstructType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_elem_cache");

        [Obsolete("_SetElemCache is deprecated. Use the ElemCache property instead.")]
        internal void _SetElemCache(Godot.Collections.Array _Cache)
        {
            NativeCalls.godot_icall_1_92(method_bind_2, Object.GetPtr(this), _Cache.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_elem_cache");

        [Obsolete("_GetElemCache is deprecated. Use the ElemCache property instead.")]
        internal Godot.Collections.Array _GetElemCache()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_3, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
