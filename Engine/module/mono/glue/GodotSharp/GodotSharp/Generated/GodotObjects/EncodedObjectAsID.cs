using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Utility class which holds a reference to the internal identifier of an <see cref="Godot.Object"/> instance, as given by <see cref="Godot.Object.GetInstanceId"/>. This ID can then be used to retrieve the object instance with <c>@GDScript.instance_from_id</c>.</para>
    /// <para>This class is used internally by the editor inspector and script debugger, but can also be used in plugins to pass and display objects as their IDs.</para>
    /// </summary>
    public partial class EncodedObjectAsID : Reference
    {
        /// <summary>
        /// <para>The <see cref="Godot.Object"/> identifier stored in this <see cref="Godot.EncodedObjectAsID"/> instance. The object instance can be retrieved with <c>@GDScript.instance_from_id</c>.</para>
        /// </summary>
        public ulong ObjectId
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetObjectId();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetObjectId(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "EncodedObjectAsID";

        public EncodedObjectAsID() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_EncodedObjectAsID_Ctor(this);
        }

        internal EncodedObjectAsID(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_object_id");

        [GodotMethod("set_object_id")]
        [Obsolete("SetObjectId is deprecated. Use the ObjectId property instead.")]
        public void SetObjectId(ulong id)
        {
            NativeCalls.godot_icall_1_283(method_bind_0, Object.GetPtr(this), id);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_object_id");

        [GodotMethod("get_object_id")]
        [Obsolete("GetObjectId is deprecated. Use the ObjectId property instead.")]
        public ulong GetObjectId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
