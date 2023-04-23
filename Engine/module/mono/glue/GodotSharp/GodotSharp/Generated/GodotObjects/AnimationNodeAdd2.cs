using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A resource to add to an <see cref="Godot.AnimationNodeBlendTree"/>. Blends two animations additively based on an amount value in the <c>[0.0, 1.0]</c> range.</para>
    /// </summary>
    public partial class AnimationNodeAdd2 : AnimationNode
    {
        /// <summary>
        /// <para>If <c>true</c>, sets the <c>optimization</c> to <c>false</c> when calling <see cref="Godot.AnimationNode.BlendInput"/>, forcing the blended animations to update every frame.</para>
        /// </summary>
        public bool Sync
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsUsingSync();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseSync(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeAdd2";

        public AnimationNodeAdd2() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeAdd2_Ctor(this);
        }

        internal AnimationNodeAdd2(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_sync");

        [GodotMethod("set_use_sync")]
        [Obsolete("SetUseSync is deprecated. Use the Sync property instead.")]
        public void SetUseSync(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_using_sync");

        [GodotMethod("is_using_sync")]
        [Obsolete("IsUsingSync is deprecated. Use the Sync property instead.")]
        public bool IsUsingSync()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
