using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Translations are resources that can be loaded and unloaded on demand. They map a string to another string.</para>
    /// </summary>
    public partial class Translation : Resource
    {
        public string[] Messages
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetMessages();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetMessages(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The locale of the translation.</para>
        /// </summary>
        public string Locale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLocale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLocale(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Translation";

        public Translation() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Translation_Ctor(this);
        }

        internal Translation(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Virtual method to override <see cref="Godot.Translation.GetMessage"/>.</para>
        /// </summary>
        [GodotMethod("_get_message")]
        public virtual string _GetMessage(string srcMessage)
        {
            return default(string);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_locale");

        [GodotMethod("set_locale")]
        [Obsolete("SetLocale is deprecated. Use the Locale property instead.")]
        public void SetLocale(string locale)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), locale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_locale");

        [GodotMethod("get_locale")]
        [Obsolete("GetLocale is deprecated. Use the Locale property instead.")]
        public string GetLocale()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_message");

        /// <summary>
        /// <para>Adds a message if nonexistent, followed by its translation.</para>
        /// </summary>
        [GodotMethod("add_message")]
        public void AddMessage(string srcMessage, string xlatedMessage)
        {
            NativeCalls.godot_icall_2_107(method_bind_2, Object.GetPtr(this), srcMessage, xlatedMessage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_message");

        /// <summary>
        /// <para>Returns a message's translation.</para>
        /// </summary>
        [GodotMethod("get_message")]
        public string GetMessage(string srcMessage)
        {
            return NativeCalls.godot_icall_1_124(method_bind_3, Object.GetPtr(this), srcMessage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_message");

        /// <summary>
        /// <para>Erases a message.</para>
        /// </summary>
        [GodotMethod("erase_message")]
        public void EraseMessage(string srcMessage)
        {
            NativeCalls.godot_icall_1_54(method_bind_4, Object.GetPtr(this), srcMessage);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_message_list");

        /// <summary>
        /// <para>Returns all the messages (keys).</para>
        /// </summary>
        [GodotMethod("get_message_list")]
        public string[] GetMessageList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_message_count");

        /// <summary>
        /// <para>Returns the number of existing messages.</para>
        /// </summary>
        [GodotMethod("get_message_count")]
        public int GetMessageCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_messages");

        [Obsolete("_SetMessages is deprecated. Use the Messages property instead.")]
        internal void _SetMessages(string[] arg0)
        {
            NativeCalls.godot_icall_1_407(method_bind_7, Object.GetPtr(this), arg0);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_messages");

        [Obsolete("_GetMessages is deprecated. Use the Messages property instead.")]
        internal string[] _GetMessages()
        {
            return NativeCalls.godot_icall_0_119(method_bind_8, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
