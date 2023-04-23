using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This helper class can be used to store <c>Variant</c> values on the filesystem using INI-style formatting. The stored values are identified by a section and a key:</para>
    /// <para><code>
    /// [section]
    /// some_key=42
    /// string_example="Hello World!"
    /// a_vector=Vector3( 1, 0, 2 )
    /// </code></para>
    /// <para>The stored data can be saved to or parsed from a file, though ConfigFile objects can also be used directly without accessing the filesystem.</para>
    /// <para>The following example shows how to create a simple <see cref="Godot.ConfigFile"/> and save it on disk:</para>
    /// <para><code>
    /// # Create new ConfigFile object.
    /// var config = ConfigFile.new()
    /// 
    /// # Store some values.
    /// config.set_value("Player1", "player_name", "Steve")
    /// config.set_value("Player1", "best_score", 10)
    /// config.set_value("Player2", "player_name", "V3geta")
    /// config.set_value("Player2", "best_score", 9001)
    /// 
    /// # Save it to a file (overwrite if already exists).
    /// config.save("user://scores.cfg")
    /// </code></para>
    /// <para>This example shows how the above file could be loaded:</para>
    /// <para><code>
    /// var score_data = {}
    /// var config = ConfigFile.new()
    /// 
    /// # Load data from a file.
    /// var err = config.load("user://scores.cfg")
    /// 
    /// # If the file didn't load, ignore it.
    /// if err != OK:
    ///     return
    /// 
    /// # Iterate over all sections.
    /// for player in config.get_sections():
    ///     # Fetch the data for each section.
    ///     var player_name = config.get_value(player, "player_name")
    ///     var player_score = config.get_value(player, "best_score")
    ///     score_data[player_name] = player_score
    /// </code></para>
    /// <para>Any operation that mutates the ConfigFile such as <see cref="Godot.ConfigFile.SetValue"/>, <see cref="Godot.ConfigFile.Clear"/>, or <see cref="Godot.ConfigFile.EraseSection"/>, only changes what is loaded in memory. If you want to write the change to a file, you have to save the changes with <see cref="Godot.ConfigFile.Save"/>, <see cref="Godot.ConfigFile.SaveEncrypted"/>, or <see cref="Godot.ConfigFile.SaveEncryptedPass"/>.</para>
    /// <para>Keep in mind that section and property names can't contain spaces. Anything after a space will be ignored on save and on load.</para>
    /// <para>ConfigFiles can also contain manually written comment lines starting with a semicolon (<c>;</c>). Those lines will be ignored when parsing the file. Note that comments will be lost when saving the ConfigFile. This can still be useful for dedicated server configuration files, which are typically never overwritten without explicit user action.</para>
    /// <para>Note: The file extension given to a ConfigFile does not have any impact on its formatting or behavior. By convention, the <c>.cfg</c> extension is used here, but any other extension such as <c>.ini</c> is also valid. Since neither <c>.cfg</c> nor <c>.ini</c> are standardized, Godot's ConfigFile formatting may differ from files written by other programs.</para>
    /// </summary>
    public partial class ConfigFile : Reference
    {
        private const string nativeName = "ConfigFile";

        public ConfigFile() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConfigFile_Ctor(this);
        }

        internal ConfigFile(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_value");

        /// <summary>
        /// <para>Assigns a value to the specified key of the specified section. If either the section or the key do not exist, they are created. Passing a <c>null</c> value deletes the specified key if it exists, and deletes the section if it ends up empty once the key has been removed.</para>
        /// </summary>
        [GodotMethod("set_value")]
        public void SetValue(string section, string key, object value)
        {
            NativeCalls.godot_icall_3_307(method_bind_0, Object.GetPtr(this), section, key, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_value");

        /// <summary>
        /// <para>Returns the current value for the specified section and key. If either the section or the key do not exist, the method returns the fallback <c>default</c> value. If <c>default</c> is not specified or set to <c>null</c>, an error is also raised.</para>
        /// </summary>
        [GodotMethod("get_value")]
        public object GetValue(string section, string key, object @default = null)
        {
            return NativeCalls.godot_icall_3_308(method_bind_1, Object.GetPtr(this), section, key, @default);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_section");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified section exists.</para>
        /// </summary>
        [GodotMethod("has_section")]
        public bool HasSection(string section)
        {
            return NativeCalls.godot_icall_1_108(method_bind_2, Object.GetPtr(this), section);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_section_key");

        /// <summary>
        /// <para>Returns <c>true</c> if the specified section-key pair exists.</para>
        /// </summary>
        [GodotMethod("has_section_key")]
        public bool HasSectionKey(string section, string key)
        {
            return NativeCalls.godot_icall_2_116(method_bind_3, Object.GetPtr(this), section, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sections");

        /// <summary>
        /// <para>Returns an array of all defined section identifiers.</para>
        /// </summary>
        [GodotMethod("get_sections")]
        public string[] GetSections()
        {
            return NativeCalls.godot_icall_0_119(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_section_keys");

        /// <summary>
        /// <para>Returns an array of all defined key identifiers in the specified section. Raises an error and returns an empty array if the section does not exist.</para>
        /// </summary>
        [GodotMethod("get_section_keys")]
        public string[] GetSectionKeys(string section)
        {
            return NativeCalls.godot_icall_1_309(method_bind_5, Object.GetPtr(this), section);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_section");

        /// <summary>
        /// <para>Deletes the specified section along with all the key-value pairs inside. Raises an error if the section does not exist.</para>
        /// </summary>
        [GodotMethod("erase_section")]
        public void EraseSection(string section)
        {
            NativeCalls.godot_icall_1_54(method_bind_6, Object.GetPtr(this), section);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "erase_section_key");

        /// <summary>
        /// <para>Deletes the specified key in a section. Raises an error if either the section or the key do not exist.</para>
        /// </summary>
        [GodotMethod("erase_section_key")]
        public void EraseSectionKey(string section, string key)
        {
            NativeCalls.godot_icall_2_107(method_bind_7, Object.GetPtr(this), section, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load");

        /// <summary>
        /// <para>Loads the config file specified as a parameter. The file's contents are parsed and loaded in the <see cref="Godot.ConfigFile"/> object which the method was called on.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("load")]
        public Error Load(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_8, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "parse");

        /// <summary>
        /// <para>Parses the passed string as the contents of a config file. The string is parsed and loaded in the ConfigFile object which the method was called on.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("parse")]
        public Error Parse(string data)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_9, Object.GetPtr(this), data);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save");

        /// <summary>
        /// <para>Saves the contents of the <see cref="Godot.ConfigFile"/> object to the file specified as a parameter. The output file uses an INI-style structure.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("save")]
        public Error Save(string path)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_10, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_encrypted");

        /// <summary>
        /// <para>Loads the encrypted config file specified as a parameter, using the provided <c>key</c> to decrypt it. The file's contents are parsed and loaded in the <see cref="Godot.ConfigFile"/> object which the method was called on.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("load_encrypted")]
        public Error LoadEncrypted(string path, byte[] key)
        {
            return (Error)NativeCalls.godot_icall_2_310(method_bind_11, Object.GetPtr(this), path, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "load_encrypted_pass");

        /// <summary>
        /// <para>Loads the encrypted config file specified as a parameter, using the provided <c>password</c> to decrypt it. The file's contents are parsed and loaded in the <see cref="Godot.ConfigFile"/> object which the method was called on.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("load_encrypted_pass")]
        public Error LoadEncryptedPass(string path, string password)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_12, Object.GetPtr(this), path, password);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_encrypted");

        /// <summary>
        /// <para>Saves the contents of the <see cref="Godot.ConfigFile"/> object to the AES-256 encrypted file specified as a parameter, using the provided <c>key</c> to encrypt it. The output file uses an INI-style structure.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("save_encrypted")]
        public Error SaveEncrypted(string path, byte[] key)
        {
            return (Error)NativeCalls.godot_icall_2_310(method_bind_13, Object.GetPtr(this), path, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "save_encrypted_pass");

        /// <summary>
        /// <para>Saves the contents of the <see cref="Godot.ConfigFile"/> object to the AES-256 encrypted file specified as a parameter, using the provided <c>password</c> to encrypt it. The output file uses an INI-style structure.</para>
        /// <para>Returns one of the <see cref="Godot.Error"/> code constants (<c>OK</c> on success).</para>
        /// </summary>
        [GodotMethod("save_encrypted_pass")]
        public Error SaveEncryptedPass(string path, string password)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_14, Object.GetPtr(this), path, password);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Removes the entire contents of the config.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
