using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A custom effect for use with <see cref="Godot.RichTextLabel"/>.</para>
    /// <para>Note: For a <see cref="Godot.RichTextEffect"/> to be usable, a BBCode tag must be defined as a member variable called <c>bbcode</c> in the script.</para>
    /// <para><code>
    /// # The RichTextEffect will be usable like this: `[example]Some text[/example]`
    /// var bbcode = "example"
    /// </code></para>
    /// <para>Note: As soon as a <see cref="Godot.RichTextLabel"/> contains at least one <see cref="Godot.RichTextEffect"/>, it will continuously process the effect unless the project is paused. This may impact battery life negatively.</para>
    /// </summary>
    public partial class RichTextEffect : Resource
    {
        private const string nativeName = "RichTextEffect";

        public RichTextEffect() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RichTextEffect_Ctor(this);
        }

        internal RichTextEffect(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Override this method to modify properties in <c>char_fx</c>. The method must return <c>true</c> if the character could be transformed successfully. If the method returns <c>false</c>, it will skip transformation to avoid displaying broken text.</para>
        /// </summary>
        [GodotMethod("_process_custom_fx")]
        public virtual bool _ProcessCustomFx(CharFXTransform charFx)
        {
            return default(bool);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
