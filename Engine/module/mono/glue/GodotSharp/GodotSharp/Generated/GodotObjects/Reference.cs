using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for any object that keeps a reference count. <see cref="Godot.Resource"/> and many other helper objects inherit this class.</para>
    /// <para>Unlike other <see cref="Godot.Object"/> types, References keep an internal reference counter so that they are automatically released when no longer in use, and only then. References therefore do not need to be freed manually with <see cref="Godot.Object.Free"/>.</para>
    /// <para>In the vast majority of use cases, instantiating and using <see cref="Godot.Reference"/>-derived types is all you need to do. The methods provided in this class are only for advanced users, and can cause issues if misused.</para>
    /// <para>Note: In C#, references will not be freed instantly after they are no longer in use. Instead, garbage collection will run periodically and will free references that are no longer in use. This means that unused references will linger on for a while before being removed.</para>
    /// </summary>
    public partial class Reference : Object
    {
        private const string nativeName = "Reference";

        public Reference() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Reference_Ctor(this);
        }

        internal Reference(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "init_ref");

        /// <summary>
        /// <para>Initializes the internal reference counter. Use this only if you really know what you are doing.</para>
        /// <para>Returns whether the initialization was successful.</para>
        /// </summary>
        [GodotMethod("init_ref")]
        public bool InitRef()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "reference");

        /// <summary>
        /// <para>Increments the internal reference counter. Use this only if you really know what you are doing.</para>
        /// <para>Returns <c>true</c> if the increment was successful, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("reference")]
        public bool Reference_()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "unreference");

        /// <summary>
        /// <para>Decrements the internal reference counter. Use this only if you really know what you are doing.</para>
        /// <para>Returns <c>true</c> if the decrement was successful, <c>false</c> otherwise.</para>
        /// </summary>
        [GodotMethod("unreference")]
        public bool Unreference()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
