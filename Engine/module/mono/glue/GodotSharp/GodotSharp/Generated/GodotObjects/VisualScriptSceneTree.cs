using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node for accessing <see cref="Godot.SceneTree"/> methods.</para>
    /// </summary>
    public partial class VisualScriptSceneTree : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSceneTree";

        public VisualScriptSceneTree() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSceneTree_Ctor(this);
        }

        internal VisualScriptSceneTree(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
