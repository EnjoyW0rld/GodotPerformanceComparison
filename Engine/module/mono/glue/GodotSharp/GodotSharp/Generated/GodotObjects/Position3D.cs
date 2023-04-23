using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Generic 3D position hint for editing. It's just like a plain <see cref="Godot.Spatial"/>, but it displays as a cross in the 3D editor at all times.</para>
    /// </summary>
    public partial class Position3D : Spatial
    {
        private const string nativeName = "Position3D";

        public Position3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Position3D_Ctor(this);
        }

        internal Position3D(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
