using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFAnimation"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFAnimation : Resource
    {
        public bool Loop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLoop(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFAnimation";

        public GLTFAnimation() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFAnimation_Ctor(this);
        }

        internal GLTFAnimation(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_loop");

        [GodotMethod("get_loop")]
        [Obsolete("GetLoop is deprecated. Use the Loop property instead.")]
        public bool GetLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_loop");

        [GodotMethod("set_loop")]
        [Obsolete("SetLoop is deprecated. Use the Loop property instead.")]
        public void SetLoop(bool loop)
        {
            NativeCalls.godot_icall_1_16(method_bind_1, Object.GetPtr(this), loop);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
