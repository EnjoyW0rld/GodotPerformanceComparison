using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Mesh type used internally for collision calculations.</para>
    /// </summary>
    public partial class TriangleMesh : Reference
    {
        private const string nativeName = "TriangleMesh";

        public TriangleMesh() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TriangleMesh_Ctor(this);
        }

        internal TriangleMesh(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
