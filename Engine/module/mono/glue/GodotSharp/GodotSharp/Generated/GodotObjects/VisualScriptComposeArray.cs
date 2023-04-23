using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script Node used to compose array from the list of elements provided with custom in-graph UI hard coded in the VisualScript Editor.</para>
    /// </summary>
    public partial class VisualScriptComposeArray : VisualScriptLists
    {
        private const string nativeName = "VisualScriptComposeArray";

        public VisualScriptComposeArray() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptComposeArray_Ctor(this);
        }

        internal VisualScriptComposeArray(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
