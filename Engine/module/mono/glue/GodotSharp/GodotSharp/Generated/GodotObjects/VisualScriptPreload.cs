using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Creates a new <see cref="Godot.Resource"/> or loads one from the filesystem.</para>
    /// <para>Input Ports:</para>
    /// <para>none</para>
    /// <para>Output Ports:</para>
    /// <para>- Data (object): <c>res</c></para>
    /// </summary>
    public partial class VisualScriptPreload : VisualScriptNode
    {
        /// <summary>
        /// <para>The <see cref="Godot.Resource"/> to load.</para>
        /// </summary>
        public Resource Resource
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPreload();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPreload(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptPreload";

        public VisualScriptPreload() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptPreload_Ctor(this);
        }

        internal VisualScriptPreload(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_preload");

        [GodotMethod("set_preload")]
        [Obsolete("SetPreload is deprecated. Use the Resource property instead.")]
        public void SetPreload(Resource resource)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(resource));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_preload");

        [GodotMethod("get_preload")]
        [Obsolete("GetPreload is deprecated. Use the Resource property instead.")]
        public Resource GetPreload()
        {
            return NativeCalls.godot_icall_0_402(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
