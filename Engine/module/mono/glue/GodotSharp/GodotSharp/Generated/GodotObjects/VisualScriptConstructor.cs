using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node which calls a base type constructor. It can be used for type conversion as well.</para>
    /// </summary>
    public partial class VisualScriptConstructor : VisualScriptNode
    {
        public Variant.Type Type
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstructorType();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstructorType(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Dictionary Constructor
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetConstructor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetConstructor(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptConstructor";

        public VisualScriptConstructor() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptConstructor_Ctor(this);
        }

        internal VisualScriptConstructor(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constructor_type");

        [GodotMethod("set_constructor_type")]
        [Obsolete("SetConstructorType is deprecated. Use the Type property instead.")]
        public void SetConstructorType(Variant.Type type)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)type);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constructor_type");

        [GodotMethod("get_constructor_type")]
        [Obsolete("GetConstructorType is deprecated. Use the Type property instead.")]
        public Variant.Type GetConstructorType()
        {
            return (Variant.Type)NativeCalls.godot_icall_0_1030(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_constructor");

        [GodotMethod("set_constructor")]
        [Obsolete("SetConstructor is deprecated. Use the Constructor property instead.")]
        public void SetConstructor(Godot.Collections.Dictionary constructor)
        {
            NativeCalls.godot_icall_1_213(method_bind_2, Object.GetPtr(this), constructor.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constructor");

        [GodotMethod("get_constructor")]
        [Obsolete("GetConstructor is deprecated. Use the Constructor property instead.")]
        public Godot.Collections.Dictionary GetConstructor()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_3, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
