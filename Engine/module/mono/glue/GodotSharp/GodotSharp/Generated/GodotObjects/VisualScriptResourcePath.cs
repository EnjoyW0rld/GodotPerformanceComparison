using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class VisualScriptResourcePath : VisualScriptNode
    {
        public string Path
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetResourcePath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResourcePath(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptResourcePath";

        public VisualScriptResourcePath() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptResourcePath_Ctor(this);
        }

        internal VisualScriptResourcePath(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_resource_path");

        [GodotMethod("set_resource_path")]
        [Obsolete("SetResourcePath is deprecated. Use the Path property instead.")]
        public void SetResourcePath(string path)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource_path");

        [GodotMethod("get_resource_path")]
        [Obsolete("GetResourcePath is deprecated. Use the Path property instead.")]
        public string GetResourcePath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
