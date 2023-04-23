using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>By setting various properties on this object, you can control how individual characters will be displayed in a <see cref="Godot.RichTextEffect"/>.</para>
    /// </summary>
    public partial class CharFXTransform : Reference
    {
        /// <summary>
        /// <para>The index of the current character (starting from 0) for this <see cref="Godot.RichTextEffect"/> custom block. Setting this property won't affect drawing.</para>
        /// </summary>
        public ulong RelativeIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRelativeIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRelativeIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The index of the current character (starting from 0) for the <see cref="Godot.RichTextLabel"/>'s BBCode text. Setting this property won't affect drawing.</para>
        /// </summary>
        public ulong AbsoluteIndex
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAbsoluteIndex();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAbsoluteIndex(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The time elapsed since the <see cref="Godot.RichTextLabel"/> was added to the scene tree (in seconds). Time stops when the <see cref="Godot.RichTextLabel"/> is paused (see <see cref="Godot.Node.PauseMode"/>). Resets when the text in the <see cref="Godot.RichTextLabel"/> is changed.</para>
        /// <para>Note: Time still passes while the <see cref="Godot.RichTextLabel"/> is hidden.</para>
        /// </summary>
        public float ElapsedTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetElapsedTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetElapsedTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the character will be drawn. If <c>false</c>, the character will be hidden. Characters around hidden characters will reflow to take the space of hidden characters. If this is not desired, set their <see cref="Godot.CharFXTransform.Color"/> to <c>Color(1, 1, 1, 0)</c> instead.</para>
        /// </summary>
        public bool Visible
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisibility(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The position offset the character will be drawn with (in pixels).</para>
        /// </summary>
        public Vector2 Offset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The color the character will be drawn with.</para>
        /// </summary>
        public Color Color
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColor();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColor(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Contains the arguments passed in the opening BBCode tag. By default, arguments are strings; if their contents match a type such as <see cref="bool"/>, <see cref="int"/> or <see cref="float"/>, they will be converted automatically. Color codes in the form <c>#rrggbb</c> or <c>#rgb</c> will be converted to an opaque <see cref="Godot.Color"/>. String arguments may not contain spaces, even if they're quoted. If present, quotes will also be present in the final string.</para>
        /// <para>For example, the opening BBCode tag <c>[example foo=hello bar=true baz=42 color=#ffffff]</c> will map to the following <see cref="Godot.Collections.Dictionary"/>:</para>
        /// <para><code>
        /// {"foo": "hello", "bar": true, "baz": 42, "color": Color(1, 1, 1, 1)}
        /// </code></para>
        /// </summary>
        public Godot.Collections.Dictionary Env
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnvironment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnvironment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The Unicode codepoint the character will use. This only affects non-whitespace characters. <c>@GDScript.ord</c> can be useful here. For example, the following will replace all characters with asterisks:</para>
        /// <para><code>
        /// # `char_fx` is the CharFXTransform parameter from `_process_custom_fx()`.
        /// # See the RichTextEffect documentation for details.
        /// char_fx.character = ord("*")
        /// </code></para>
        /// </summary>
        public int Character
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCharacter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCharacter(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CharFXTransform";

        public CharFXTransform() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CharFXTransform_Ctor(this);
        }

        internal CharFXTransform(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_relative_index");

        [GodotMethod("get_relative_index")]
        [Obsolete("GetRelativeIndex is deprecated. Use the RelativeIndex property instead.")]
        public ulong GetRelativeIndex()
        {
            return NativeCalls.godot_icall_0_30(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_relative_index");

        [GodotMethod("set_relative_index")]
        [Obsolete("SetRelativeIndex is deprecated. Use the RelativeIndex property instead.")]
        public void SetRelativeIndex(ulong index)
        {
            NativeCalls.godot_icall_1_283(method_bind_1, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_absolute_index");

        [GodotMethod("get_absolute_index")]
        [Obsolete("GetAbsoluteIndex is deprecated. Use the AbsoluteIndex property instead.")]
        public ulong GetAbsoluteIndex()
        {
            return NativeCalls.godot_icall_0_30(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_absolute_index");

        [GodotMethod("set_absolute_index")]
        [Obsolete("SetAbsoluteIndex is deprecated. Use the AbsoluteIndex property instead.")]
        public void SetAbsoluteIndex(ulong index)
        {
            NativeCalls.godot_icall_1_283(method_bind_3, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_elapsed_time");

        [GodotMethod("get_elapsed_time")]
        [Obsolete("GetElapsedTime is deprecated. Use the ElapsedTime property instead.")]
        public float GetElapsedTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_elapsed_time");

        [GodotMethod("set_elapsed_time")]
        [Obsolete("SetElapsedTime is deprecated. Use the ElapsedTime property instead.")]
        public void SetElapsedTime(float time)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_visible");

        [GodotMethod("is_visible")]
        [Obsolete("IsVisible is deprecated. Use the Visible property instead.")]
        public bool IsVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visibility");

        [GodotMethod("set_visibility")]
        [Obsolete("SetVisibility is deprecated. Use the Visible property instead.")]
        public void SetVisibility(bool visibility)
        {
            NativeCalls.godot_icall_1_16(method_bind_7, Object.GetPtr(this), visibility);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_8, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_9, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        [GodotMethod("get_color")]
        [Obsolete("GetColor is deprecated. Use the Color property instead.")]
        public Color GetColor()
        {
            NativeCalls.godot_icall_0_200(method_bind_10, Object.GetPtr(this), out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_color");

        [GodotMethod("set_color")]
        [Obsolete("SetColor is deprecated. Use the Color property instead.")]
        public void SetColor(Color color)
        {
            NativeCalls.godot_icall_1_199(method_bind_11, Object.GetPtr(this), ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_environment");

        [GodotMethod("get_environment")]
        [Obsolete("GetEnvironment is deprecated. Use the Env property instead.")]
        public Godot.Collections.Dictionary GetEnvironment()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_12, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_environment");

        [GodotMethod("set_environment")]
        [Obsolete("SetEnvironment is deprecated. Use the Env property instead.")]
        public void SetEnvironment(Godot.Collections.Dictionary environment)
        {
            NativeCalls.godot_icall_1_213(method_bind_13, Object.GetPtr(this), environment.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_character");

        [GodotMethod("get_character")]
        [Obsolete("GetCharacter is deprecated. Use the Character property instead.")]
        public int GetCharacter()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_character");

        [GodotMethod("set_character")]
        [Obsolete("SetCharacter is deprecated. Use the Character property instead.")]
        public void SetCharacter(int character)
        {
            NativeCalls.godot_icall_1_4(method_bind_15, Object.GetPtr(this), character);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
