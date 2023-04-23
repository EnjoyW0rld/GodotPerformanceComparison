using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A Visual Script node returning a singleton from <c>@GlobalScope</c>.</para>
    /// </summary>
    public partial class VisualScriptEngineSingleton : VisualScriptNode
    {
        /// <summary>
        /// <para>The singleton's name.</para>
        /// </summary>
        public string Constant
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSingleton();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSingleton(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualScriptEngineSingleton";

        public VisualScriptEngineSingleton() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptEngineSingleton_Ctor(this);
        }

        internal VisualScriptEngineSingleton(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_singleton");

        [GodotMethod("set_singleton")]
        [Obsolete("SetSingleton is deprecated. Use the Constant property instead.")]
        public void SetSingleton(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_singleton");

        [GodotMethod("get_singleton")]
        [Obsolete("GetSingleton is deprecated. Use the Constant property instead.")]
        public string GetSingleton()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
