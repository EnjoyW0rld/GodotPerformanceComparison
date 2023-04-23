using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>PhysicsBody is an abstract base class for implementing a physics body. All *Body types inherit from it.</para>
    /// </summary>
    public abstract partial class PhysicsBody : CollisionObject
    {
        private const string nativeName = "PhysicsBody";

        internal PhysicsBody() {}

        internal PhysicsBody(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_collision_exceptions");

        /// <summary>
        /// <para>Returns an array of nodes that were added as collision exceptions for this body.</para>
        /// </summary>
        [GodotMethod("get_collision_exceptions")]
        public Godot.Collections.Array GetCollisionExceptions()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_collision_exception_with");

        /// <summary>
        /// <para>Adds a body to the list of bodies that this body can't collide with.</para>
        /// </summary>
        [GodotMethod("add_collision_exception_with")]
        public void AddCollisionExceptionWith(Node body)
        {
            NativeCalls.godot_icall_1_53(method_bind_1, Object.GetPtr(this), Object.GetPtr(body));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_collision_exception_with");

        /// <summary>
        /// <para>Removes a body from the list of bodies that this body can't collide with.</para>
        /// </summary>
        [GodotMethod("remove_collision_exception_with")]
        public void RemoveCollisionExceptionWith(Node body)
        {
            NativeCalls.godot_icall_1_53(method_bind_2, Object.GetPtr(this), Object.GetPtr(body));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
