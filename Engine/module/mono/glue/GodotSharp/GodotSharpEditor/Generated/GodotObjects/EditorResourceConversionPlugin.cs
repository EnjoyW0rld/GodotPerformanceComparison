using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class EditorResourceConversionPlugin : Reference
    {
        private const string nativeName = "EditorResourceConversionPlugin";

        public EditorResourceConversionPlugin() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = EditorNativeCalls.godot_icall_EditorResourceConversionPlugin_Ctor(this);
        }

        internal EditorResourceConversionPlugin(bool memoryOwn) : base(memoryOwn) {}

        [GodotMethod("_convert")]
        public virtual Resource _Convert(Resource resource)
        {
            return default(Resource);
        }

        [GodotMethod("_converts_to")]
        public virtual string _ConvertsTo()
        {
            return default(string);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
