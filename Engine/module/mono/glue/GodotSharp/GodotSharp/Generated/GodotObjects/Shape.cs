using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for all 3D shape resources. Nodes that inherit from this can be used as shapes for a <see cref="Godot.PhysicsBody"/> or <see cref="Godot.Area"/> objects.</para>
    /// </summary>
    public abstract partial class Shape : Resource
    {
        /// <summary>
        /// <para>The collision margin for the shape. Used in Bullet Physics only.</para>
        /// <para>Collision margins allow collision detection to be more efficient by adding an extra shell around shapes. Collision algorithms are more expensive when objects overlap by more than their margin, so a higher value for margins is better for performance, at the cost of accuracy around edges as it makes them less sharp.</para>
        /// </summary>
        public float Margin
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Shape";

        internal Shape() {}

        internal Shape(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the Margin property instead.")]
        public void SetMargin(float margin)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the Margin property instead.")]
        public float GetMargin()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_debug_mesh");

        /// <summary>
        /// <para>Returns the <see cref="Godot.ArrayMesh"/> used to draw the debug collision for this <see cref="Godot.Shape"/>.</para>
        /// </summary>
        [GodotMethod("get_debug_mesh")]
        public ArrayMesh GetDebugMesh()
        {
            return NativeCalls.godot_icall_0_453(method_bind_2, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
