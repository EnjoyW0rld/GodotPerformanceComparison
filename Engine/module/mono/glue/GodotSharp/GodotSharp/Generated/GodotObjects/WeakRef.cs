using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A weakref can hold a <see cref="Godot.Reference"/>, without contributing to the reference counter. A weakref can be created from an <see cref="Godot.Object"/> using <c>@GDScript.weakref</c>. If this object is not a reference, weakref still works, however, it does not have any effect on the object. Weakrefs are useful in cases where multiple classes have variables that refer to each other. Without weakrefs, using these classes could lead to memory leaks, since both references keep each other from being released. Making part of the variables a weakref can prevent this cyclic dependency, and allows the references to be released.</para>
    /// </summary>
    public partial class WeakRef : Reference
    {
        private const string nativeName = "WeakRef";

        public WeakRef() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WeakRef_Ctor(this);
        }

        internal WeakRef(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ref");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Object"/> this weakref is referring to. Returns <c>null</c> if that object no longer exists.</para>
        /// </summary>
        [GodotMethod("get_ref")]
        public object GetRef()
        {
            return NativeCalls.godot_icall_0_547(method_bind_0, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
