using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Optimized translation. Uses real-time compressed translations, which results in very small dictionaries.</para>
    /// </summary>
    public partial class PHashTranslation : Translation
    {
        private const string nativeName = "PHashTranslation";

        public PHashTranslation() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PHashTranslation_Ctor(this);
        }

        internal PHashTranslation(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "generate");

        /// <summary>
        /// <para>Generates and sets an optimized translation from the given <see cref="Godot.Translation"/> resource.</para>
        /// </summary>
        [GodotMethod("generate")]
        public void Generate(Translation from)
        {
            NativeCalls.godot_icall_1_24(method_bind_0, Object.GetPtr(this), Object.GetPtr(from));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
