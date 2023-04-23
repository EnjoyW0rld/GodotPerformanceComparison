using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.MultiMeshInstance"/> is a specialized node to instance <see cref="Godot.GeometryInstance"/>s based on a <see cref="Godot.MultiMesh"/> resource.</para>
    /// <para>This is useful to optimize the rendering of a high amount of instances of a given mesh (for example trees in a forest or grass strands).</para>
    /// </summary>
    public partial class MultiMeshInstance : GeometryInstance
    {
        /// <summary>
        /// <para>The <see cref="Godot.MultiMesh"/> resource that will be used and shared among all instances of the <see cref="Godot.MultiMeshInstance"/>.</para>
        /// </summary>
        public MultiMesh Multimesh
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMultimesh();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMultimesh(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "MultiMeshInstance";

        public MultiMeshInstance() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MultiMeshInstance_Ctor(this);
        }

        internal MultiMeshInstance(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_multimesh");

        [GodotMethod("set_multimesh")]
        [Obsolete("SetMultimesh is deprecated. Use the Multimesh property instead.")]
        public void SetMultimesh(MultiMesh multimesh)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(multimesh));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_multimesh");

        [GodotMethod("get_multimesh")]
        [Obsolete("GetMultimesh is deprecated. Use the Multimesh property instead.")]
        public MultiMesh GetMultimesh()
        {
            return NativeCalls.godot_icall_0_620(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
