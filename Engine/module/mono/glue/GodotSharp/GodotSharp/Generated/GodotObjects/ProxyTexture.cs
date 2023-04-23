using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class ProxyTexture : Texture
    {
        public Texture Base
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBase();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBase(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "ProxyTexture";

        public ProxyTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ProxyTexture_Ctor(this);
        }

        internal ProxyTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_base");

        [GodotMethod("set_base")]
        [Obsolete("SetBase is deprecated. Use the Base property instead.")]
        public void SetBase(Texture @base)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(@base));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_base");

        [GodotMethod("get_base")]
        [Obsolete("GetBase is deprecated. Use the Base property instead.")]
        public Texture GetBase()
        {
            return NativeCalls.godot_icall_0_161(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
