using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A texture that is loaded from a <c>.stex</c> file.</para>
    /// </summary>
    public partial class StreamTexture : Texture
    {
        /// <summary>
        /// <para>The StreamTexture's file path to a <c>.stex</c> file.</para>
        /// </summary>
        public string LoadPath
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLoadPath();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                Load(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StreamTexture";

        public StreamTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamTexture_Ctor(this);
        }

        internal StreamTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads the texture from the given path.</para>
        /// </summary>
        [GodotMethod("load")]
        [Obsolete("Load is deprecated. Use the LoadPath property instead.")]
        public Error Load(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_0, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_load_path");

        [GodotMethod("get_load_path")]
        [Obsolete("GetLoadPath is deprecated. Use the LoadPath property instead.")]
        public string GetLoadPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
