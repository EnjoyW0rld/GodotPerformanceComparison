using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A resource to add to an <see cref="Godot.AnimationNodeBlendTree"/>. Only features one output set using the <see cref="Godot.AnimationNodeAnimation.Animation"/> property. Use it as an input for <see cref="Godot.AnimationNode"/> that blend animations together.</para>
    /// </summary>
    public partial class AnimationNodeAnimation : AnimationRootNode
    {
        /// <summary>
        /// <para>Animation to use as an output. It is one of the animations provided by <see cref="Godot.AnimationTree.AnimPlayer"/>.</para>
        /// </summary>
        public string Animation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimation(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeAnimation";

        public AnimationNodeAnimation() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeAnimation_Ctor(this);
        }

        internal AnimationNodeAnimation(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animation");

        [GodotMethod("set_animation")]
        [Obsolete("SetAnimation is deprecated. Use the Animation property instead.")]
        public void SetAnimation(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation");

        [GodotMethod("get_animation")]
        [Obsolete("GetAnimation is deprecated. Use the Animation property instead.")]
        public string GetAnimation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
