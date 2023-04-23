using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.WorldEnvironment"/> node is used to configure the default <see cref="Godot.Environment"/> for the scene.</para>
    /// <para>The parameters defined in the <see cref="Godot.WorldEnvironment"/> can be overridden by an <see cref="Godot.Environment"/> node set on the current <see cref="Godot.Camera"/>. Additionally, only one <see cref="Godot.WorldEnvironment"/> may be instanced in a given scene at a time.</para>
    /// <para>The <see cref="Godot.WorldEnvironment"/> allows the user to specify default lighting parameters (e.g. ambient lighting), various post-processing effects (e.g. SSAO, DOF, Tonemapping), and how to draw the background (e.g. solid color, skybox). Usually, these are added in order to improve the realism/color balance of the scene.</para>
    /// </summary>
    public partial class WorldEnvironment : Node
    {
        /// <summary>
        /// <para>The <see cref="Godot.Environment"/> resource used by this <see cref="Godot.WorldEnvironment"/>, defining the default properties.</para>
        /// </summary>
        public Environment Environment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironment(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "WorldEnvironment";

        public WorldEnvironment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WorldEnvironment_Ctor(this);
        }

        internal WorldEnvironment(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment");

        [GodotMethod("set_environment")]
        [Obsolete("SetEnvironment is deprecated. Use the Environment property instead.")]
        public void SetEnvironment(Environment env)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(env));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment");

        [GodotMethod("get_environment")]
        [Obsolete("GetEnvironment is deprecated. Use the Environment property instead.")]
        public Environment GetEnvironment()
        {
            return NativeCalls.godot_icall_0_251(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
