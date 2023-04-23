using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>File type. This is used to permanently store data into the user device's file system and to read from it. This can be used to store game save data or player configuration files, for example.</para>
    /// <para>Here's a sample on how to write and read from a file:</para>
    /// <para><code>
    /// func save(content):
    ///     var file = File.new()
    ///     file.open("user://save_game.dat", File.WRITE)
    ///     file.store_string(content)
    ///     file.close()
    /// 
    /// func load():
    ///     var file = File.new()
    ///     file.open("user://save_game.dat", File.READ)
    ///     var content = file.get_as_text()
    ///     file.close()
    ///     return content
    /// </code></para>
    /// <para>In the example above, the file will be saved in the user data folder as specified in the <a href="$DOCS_URL/tutorials/io/data_paths.html">Data paths</a> documentation.</para>
    /// <para>Note: To access project resources once exported, it is recommended to use <see cref="Godot.ResourceLoader"/> instead of the <see cref="Godot.File"/> API, as some files are converted to engine-specific formats and their original source files might not be present in the exported PCK package.</para>
    /// <para>Note: Files are automatically closed only if the process exits "normally" (such as by clicking the window manager's close button or pressing Alt + F4). If you stop the project execution by pressing F8 while the project is running, the file won't be closed as the game process will be killed. You can work around this by calling <see cref="Godot.File.Flush"/> at regular intervals.</para>
    /// </summary>
    public partial class File : Reference
    {
        public enum CompressionMode
        {
            /// <summary>
            /// <para>Uses the <a href="http://fastlz.org/">FastLZ</a> compression method.</para>
            /// </summary>
            Fastlz = 0,
            /// <summary>
            /// <para>Uses the <a href="https://en.wikipedia.org/wiki/DEFLATE">DEFLATE</a> compression method.</para>
            /// </summary>
            Deflate = 1,
            /// <summary>
            /// <para>Uses the <a href="https://facebook.github.io/zstd/">Zstandard</a> compression method.</para>
            /// </summary>
            Zstd = 2,
            /// <summary>
            /// <para>Uses the <a href="https://www.gzip.org/">gzip</a> compression method.</para>
            /// </summary>
            Gzip = 3
        }

        public enum ModeFlags
        {
            /// <summary>
            /// <para>Opens the file for read operations. The cursor is positioned at the beginning of the file.</para>
            /// </summary>
            Read = 1,
            /// <summary>
            /// <para>Opens the file for write operations. The file is created if it does not exist, and truncated if it does.</para>
            /// </summary>
            Write = 2,
            /// <summary>
            /// <para>Opens the file for read and write operations. Does not truncate the file. The cursor is positioned at the beginning of the file.</para>
            /// </summary>
            ReadWrite = 3,
            /// <summary>
            /// <para>Opens the file for read and write operations. The file is created if it does not exist, and truncated if it does. The cursor is positioned at the beginning of the file.</para>
            /// </summary>
            WriteRead = 7
        }

        /// <summary>
        /// <para>If <c>true</c>, the file is read with big-endian <a href="https://en.wikipedia.org/wiki/Endianness">endianness</a>. If <c>false</c>, the file is read with little-endian endianness. If in doubt, leave this to <c>false</c> as most files are written with little-endian endianness.</para>
        /// <para>Note: <see cref="Godot.File.EndianSwap"/> is only about the file format, not the CPU type. The CPU endianness doesn't affect the default endianness for files written.</para>
        /// <para>Note: This is always reset to <c>false</c> whenever you open the file. Therefore, you must set <see cref="Godot.File.EndianSwap"/> after opening the file, not before.</para>
        /// </summary>
        public bool EndianSwap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEndianSwap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEndianSwap(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "_File";

        public File() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_File_Ctor(this);
        }

        internal File(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_encrypted");

        /// <summary>
        /// <para>Opens an encrypted file in write or read mode. You need to pass a binary key to encrypt/decrypt it.</para>
        /// <para>Note: The provided key must be 32 bytes long.</para>
        /// </summary>
        [GodotMethod("open_encrypted")]
        public Error OpenEncrypted(string path, File.ModeFlags modeFlags, byte[] key)
        {
            return (Error)NativeCalls.godot_icall_3_1178(method_bind_0, Object.GetPtr(this), path, (int)modeFlags, key);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_encrypted_with_pass");

        /// <summary>
        /// <para>Opens an encrypted file in write or read mode. You need to pass a password to encrypt/decrypt it.</para>
        /// </summary>
        [GodotMethod("open_encrypted_with_pass")]
        public Error OpenEncryptedWithPass(string path, File.ModeFlags modeFlags, string pass)
        {
            return (Error)NativeCalls.godot_icall_3_1156(method_bind_1, Object.GetPtr(this), path, (int)modeFlags, pass);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_compressed");

        /// <summary>
        /// <para>Opens a compressed file for reading or writing.</para>
        /// <para>Note: <see cref="Godot.File.OpenCompressed"/> can only read files that were saved by Godot, not third-party compression formats. See <a href="https://github.com/godotengine/godot/issues/28999">GitHub issue #28999</a> for a workaround.</para>
        /// </summary>
        [GodotMethod("open_compressed")]
        public Error OpenCompressed(string path, File.ModeFlags modeFlags, File.CompressionMode compressionMode = (File.CompressionMode)0)
        {
            return (Error)NativeCalls.godot_icall_3_1179(method_bind_2, Object.GetPtr(this), path, (int)modeFlags, (int)compressionMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open");

        /// <summary>
        /// <para>Opens the file for writing or reading, depending on the flags.</para>
        /// </summary>
        [GodotMethod("open")]
        public Error Open(string path, File.ModeFlags flags)
        {
            return (Error)NativeCalls.godot_icall_2_709(method_bind_3, Object.GetPtr(this), path, (int)flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "flush");

        /// <summary>
        /// <para>Writes the file's buffer to disk. Flushing is automatically performed when the file is closed. This means you don't need to call <see cref="Godot.File.Flush"/> manually before closing a file using <see cref="Godot.File.Close"/>. Still, calling <see cref="Godot.File.Flush"/> can be used to ensure the data is safe even if the project crashes instead of being closed gracefully.</para>
        /// <para>Note: Only call <see cref="Godot.File.Flush"/> when you actually need it. Otherwise, it will decrease performance due to constant disk writes.</para>
        /// </summary>
        [GodotMethod("flush")]
        public void Flush()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "close");

        /// <summary>
        /// <para>Closes the currently opened file and prevents subsequent read/write operations. Use <see cref="Godot.File.Flush"/> to persist the data to disk without closing the file.</para>
        /// </summary>
        [GodotMethod("close")]
        public void Close()
        {
            NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path");

        /// <summary>
        /// <para>Returns the path as a <see cref="string"/> for the current open file.</para>
        /// </summary>
        [GodotMethod("get_path")]
        public string GetPath()
        {
            return NativeCalls.godot_icall_0_6(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_path_absolute");

        /// <summary>
        /// <para>Returns the absolute path as a <see cref="string"/> for the current open file.</para>
        /// </summary>
        [GodotMethod("get_path_absolute")]
        public string GetPathAbsolute()
        {
            return NativeCalls.godot_icall_0_6(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_open");

        /// <summary>
        /// <para>Returns <c>true</c> if the file is currently opened.</para>
        /// </summary>
        [GodotMethod("is_open")]
        public bool IsOpen()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Changes the file reading/writing cursor to the specified position (in bytes from the beginning of the file).</para>
        /// </summary>
        [GodotMethod("seek")]
        public void Seek(long position)
        {
            NativeCalls.godot_icall_1_890(method_bind_9, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek_end");

        /// <summary>
        /// <para>Changes the file reading/writing cursor to the specified position (in bytes from the end of the file).</para>
        /// <para>Note: This is an offset, so you should use negative numbers or the cursor will be at the end of the file.</para>
        /// </summary>
        [GodotMethod("seek_end")]
        public void SeekEnd(long position = (long)0)
        {
            NativeCalls.godot_icall_1_890(method_bind_10, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        /// <summary>
        /// <para>Returns the file cursor's position.</para>
        /// </summary>
        [GodotMethod("get_position")]
        public ulong GetPosition()
        {
            return NativeCalls.godot_icall_0_30(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_len");

        /// <summary>
        /// <para>Returns the size of the file in bytes.</para>
        /// </summary>
        [GodotMethod("get_len")]
        public ulong GetLen()
        {
            return NativeCalls.godot_icall_0_30(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "eof_reached");

        /// <summary>
        /// <para>Returns <c>true</c> if the file cursor has already read past the end of the file.</para>
        /// <para>Note: <c>eof_reached() == false</c> cannot be used to check whether there is more data available. To loop while there is more data available, use:</para>
        /// <para><code>
        /// while file.get_position() &lt; file.get_len():
        ///     # Read data
        /// </code></para>
        /// </summary>
        [GodotMethod("eof_reached")]
        public bool EofReached()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_8");

        /// <summary>
        /// <para>Returns the next 8 bits from the file as an integer. See <see cref="Godot.File.Store8"/> for details on what values can be stored and retrieved this way.</para>
        /// </summary>
        [GodotMethod("get_8")]
        public byte Get8()
        {
            return NativeCalls.godot_icall_0_893(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_16");

        /// <summary>
        /// <para>Returns the next 16 bits from the file as an integer. See <see cref="Godot.File.Store16"/> for details on what values can be stored and retrieved this way.</para>
        /// </summary>
        [GodotMethod("get_16")]
        public ushort Get16()
        {
            return NativeCalls.godot_icall_0_895(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_32");

        /// <summary>
        /// <para>Returns the next 32 bits from the file as an integer. See <see cref="Godot.File.Store32"/> for details on what values can be stored and retrieved this way.</para>
        /// </summary>
        [GodotMethod("get_32")]
        public uint Get32()
        {
            return NativeCalls.godot_icall_0_188(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_64");

        /// <summary>
        /// <para>Returns the next 64 bits from the file as an integer. See <see cref="Godot.File.Store64"/> for details on what values can be stored and retrieved this way.</para>
        /// </summary>
        [GodotMethod("get_64")]
        public ulong Get64()
        {
            return NativeCalls.godot_icall_0_30(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_float");

        /// <summary>
        /// <para>Returns the next 32 bits from the file as a floating-point number.</para>
        /// </summary>
        [GodotMethod("get_float")]
        public float GetFloat()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_double");

        /// <summary>
        /// <para>Returns the next 64 bits from the file as a floating-point number.</para>
        /// </summary>
        [GodotMethod("get_double")]
        public double GetDouble()
        {
            return NativeCalls.godot_icall_0_179(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_real");

        /// <summary>
        /// <para>Returns the next bits from the file as a floating-point number.</para>
        /// </summary>
        [GodotMethod("get_real")]
        public float GetReal()
        {
            return NativeCalls.godot_icall_0_14(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer");

        /// <summary>
        /// <para>Returns next <c>len</c> bytes of the file as a <see cref="byte"/>.</para>
        /// </summary>
        [GodotMethod("get_buffer")]
        public byte[] GetBuffer(long len)
        {
            return NativeCalls.godot_icall_1_1180(method_bind_21, Object.GetPtr(this), len);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_line");

        /// <summary>
        /// <para>Returns the next line of the file as a <see cref="string"/>.</para>
        /// <para>Text is interpreted as being UTF-8 encoded.</para>
        /// </summary>
        [GodotMethod("get_line")]
        public string GetLine()
        {
            return NativeCalls.godot_icall_0_6(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_csv_line");

        /// <summary>
        /// <para>Returns the next value of the file in CSV (Comma-Separated Values) format. You can pass a different delimiter <c>delim</c> to use other than the default <c>","</c> (comma). This delimiter must be one-character long, and cannot be a double quotation mark.</para>
        /// <para>Text is interpreted as being UTF-8 encoded. Text values must be enclosed in double quotes if they include the delimiter character. Double quotes within a text value can be escaped by doubling their occurrence.</para>
        /// <para>For example, the following CSV lines are valid and will be properly parsed as two strings each:</para>
        /// <para><code>
        /// Alice,"Hello, Bob!"
        /// Bob,Alice! What a surprise!
        /// Alice,"I thought you'd reply with ""Hello, world""."
        /// </code></para>
        /// <para>Note how the second line can omit the enclosing quotes as it does not include the delimiter. However it could very well use quotes, it was only written without for demonstration purposes. The third line must use <c>""</c> for each quotation mark that needs to be interpreted as such instead of the end of a text value.</para>
        /// </summary>
        [GodotMethod("get_csv_line")]
        public string[] GetCsvLine(string delim = ",")
        {
            return NativeCalls.godot_icall_1_309(method_bind_23, Object.GetPtr(this), delim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_as_text");

        /// <summary>
        /// <para>Returns the whole file as a <see cref="string"/>. Text is interpreted as being UTF-8 encoded.</para>
        /// <para>If <c>skip_cr</c> is <c>true</c>, carriage return characters (<c>\r</c>, CR) will be ignored when parsing the UTF-8, so that only line feed characters (<c>\n</c>, LF) represent a new line (Unix convention).</para>
        /// </summary>
        [GodotMethod("get_as_text")]
        public string GetAsText(bool skipCr = true)
        {
            return NativeCalls.godot_icall_1_338(method_bind_24, Object.GetPtr(this), skipCr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_md5");

        /// <summary>
        /// <para>Returns an MD5 String representing the file at the given path or an empty <see cref="string"/> on failure.</para>
        /// </summary>
        [GodotMethod("get_md5")]
        public string GetMd5(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_25, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_sha256");

        /// <summary>
        /// <para>Returns a SHA-256 <see cref="string"/> representing the file at the given path or an empty <see cref="string"/> on failure.</para>
        /// </summary>
        [GodotMethod("get_sha256")]
        public string GetSha256(string path)
        {
            return NativeCalls.godot_icall_1_124(method_bind_26, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_endian_swap");

        [GodotMethod("get_endian_swap")]
        [Obsolete("GetEndianSwap is deprecated. Use the EndianSwap property instead.")]
        public bool GetEndianSwap()
        {
            return NativeCalls.godot_icall_0_7(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_endian_swap");

        [GodotMethod("set_endian_swap")]
        [Obsolete("SetEndianSwap is deprecated. Use the EndianSwap property instead.")]
        public void SetEndianSwap(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_28, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_error");

        /// <summary>
        /// <para>Returns the last error that happened when trying to perform operations. Compare with the <c>ERR_FILE_*</c> constants from <see cref="Godot.Error"/>.</para>
        /// </summary>
        [GodotMethod("get_error")]
        public Error GetError()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_var");

        /// <summary>
        /// <para>Returns the next <c>Variant</c> value from the file. If <c>allow_objects</c> is <c>true</c>, decoding objects is allowed.</para>
        /// <para>Warning: Deserialized objects can contain code which gets executed. Do not use this option if the serialized object comes from untrusted sources to avoid potential security threats such as remote code execution.</para>
        /// </summary>
        [GodotMethod("get_var")]
        public object GetVar(bool allowObjects = false)
        {
            return NativeCalls.godot_icall_1_716(method_bind_30, Object.GetPtr(this), allowObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_8");

        /// <summary>
        /// <para>Stores an integer as 8 bits in the file.</para>
        /// <para>Note: The <c>value</c> should lie in the interval <c>[0, 255]</c>. Any other value will overflow and wrap around.</para>
        /// <para>To store a signed integer, use <see cref="Godot.File.Store64"/>, or convert it manually (see <see cref="Godot.File.Store16"/> for an example).</para>
        /// </summary>
        [GodotMethod("store_8")]
        public void Store8(byte value)
        {
            NativeCalls.godot_icall_1_887(method_bind_31, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_16");

        /// <summary>
        /// <para>Stores an integer as 16 bits in the file.</para>
        /// <para>Note: The <c>value</c> should lie in the interval <c>[0, 2^16 - 1]</c>. Any other value will overflow and wrap around.</para>
        /// <para>To store a signed integer, use <see cref="Godot.File.Store64"/> or store a signed integer from the interval <c>[-2^15, 2^15 - 1]</c> (i.e. keeping one bit for the signedness) and compute its sign manually when reading. For example:</para>
        /// <para><code>
        /// const MAX_15B = 1 &lt;&lt; 15
        /// const MAX_16B = 1 &lt;&lt; 16
        /// 
        /// func unsigned16_to_signed(unsigned):
        ///     return (unsigned + MAX_15B) % MAX_16B - MAX_15B
        /// 
        /// func _ready():
        ///     var f = File.new()
        ///     f.open("user://file.dat", File.WRITE_READ)
        ///     f.store_16(-42) # This wraps around and stores 65494 (2^16 - 42).
        ///     f.store_16(121) # In bounds, will store 121.
        ///     f.seek(0) # Go back to start to read the stored value.
        ///     var read1 = f.get_16() # 65494
        ///     var read2 = f.get_16() # 121
        ///     var converted1 = unsigned16_to_signed(read1) # -42
        ///     var converted2 = unsigned16_to_signed(read2) # 121
        /// </code></para>
        /// </summary>
        [GodotMethod("store_16")]
        public void Store16(ushort value)
        {
            NativeCalls.godot_icall_1_889(method_bind_32, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_32");

        /// <summary>
        /// <para>Stores an integer as 32 bits in the file.</para>
        /// <para>Note: The <c>value</c> should lie in the interval <c>[0, 2^32 - 1]</c>. Any other value will overflow and wrap around.</para>
        /// <para>To store a signed integer, use <see cref="Godot.File.Store64"/>, or convert it manually (see <see cref="Godot.File.Store16"/> for an example).</para>
        /// </summary>
        [GodotMethod("store_32")]
        public void Store32(uint value)
        {
            NativeCalls.godot_icall_1_187(method_bind_33, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_64");

        /// <summary>
        /// <para>Stores an integer as 64 bits in the file.</para>
        /// <para>Note: The <c>value</c> must lie in the interval <c>[-2^63, 2^63 - 1]</c> (i.e. be a valid <see cref="int"/> value).</para>
        /// </summary>
        [GodotMethod("store_64")]
        public void Store64(ulong value)
        {
            NativeCalls.godot_icall_1_283(method_bind_34, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_float");

        /// <summary>
        /// <para>Stores a floating-point number as 32 bits in the file.</para>
        /// </summary>
        [GodotMethod("store_float")]
        public void StoreFloat(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_35, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_double");

        /// <summary>
        /// <para>Stores a floating-point number as 64 bits in the file.</para>
        /// </summary>
        [GodotMethod("store_double")]
        public void StoreDouble(double value)
        {
            NativeCalls.godot_icall_1_496(method_bind_36, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_real");

        /// <summary>
        /// <para>Stores a floating-point number in the file.</para>
        /// </summary>
        [GodotMethod("store_real")]
        public void StoreReal(float value)
        {
            NativeCalls.godot_icall_1_15(method_bind_37, Object.GetPtr(this), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_buffer");

        /// <summary>
        /// <para>Stores the given array of bytes in the file.</para>
        /// </summary>
        [GodotMethod("store_buffer")]
        public void StoreBuffer(byte[] buffer)
        {
            NativeCalls.godot_icall_1_183(method_bind_38, Object.GetPtr(this), buffer);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_line");

        /// <summary>
        /// <para>Appends <c>line</c> to the file followed by a line return character (<c>\n</c>), encoding the text as UTF-8.</para>
        /// </summary>
        [GodotMethod("store_line")]
        public void StoreLine(string line)
        {
            NativeCalls.godot_icall_1_54(method_bind_39, Object.GetPtr(this), line);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_csv_line");

        /// <summary>
        /// <para>Store the given <see cref="string"/> in the file as a line formatted in the CSV (Comma-Separated Values) format. You can pass a different delimiter <c>delim</c> to use other than the default <c>","</c> (comma). This delimiter must be one-character long.</para>
        /// <para>Text will be encoded as UTF-8.</para>
        /// </summary>
        [GodotMethod("store_csv_line")]
        public void StoreCsvLine(string[] values, string delim = ",")
        {
            NativeCalls.godot_icall_2_1181(method_bind_40, Object.GetPtr(this), values, delim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_string");

        /// <summary>
        /// <para>Appends <c>string</c> to the file without a line return, encoding the text as UTF-8.</para>
        /// <para>Note: This method is intended to be used to write text files. The string is stored as a UTF-8 encoded buffer without string length or terminating zero, which means that it can't be loaded back easily. If you want to store a retrievable string in a binary file, consider using <see cref="Godot.File.StorePascalString"/> instead. For retrieving strings from a text file, you can use <c>get_buffer(length).get_string_from_utf8()</c> (if you know the length) or <see cref="Godot.File.GetAsText"/>.</para>
        /// </summary>
        [GodotMethod("store_string")]
        public void StoreString(string @string)
        {
            NativeCalls.godot_icall_1_54(method_bind_41, Object.GetPtr(this), @string);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_var");

        /// <summary>
        /// <para>Stores any Variant value in the file. If <c>full_objects</c> is <c>true</c>, encoding objects is allowed (and can potentially include code).</para>
        /// <para>Note: Not all properties are included. Only properties that are configured with the <c>PROPERTY_USAGE_STORAGE</c> flag set will be serialized. You can add a new usage flag to a property by overriding the <see cref="Godot.Object._GetPropertyList"/> method in your class. You can also check how property usage is configured by calling <see cref="Godot.Object._GetPropertyList"/>. See <see cref="Godot.PropertyUsageFlags"/> for the possible usage flags.</para>
        /// </summary>
        [GodotMethod("store_var")]
        public void StoreVar(object value, bool fullObjects = false)
        {
            NativeCalls.godot_icall_2_891(method_bind_42, Object.GetPtr(this), value, fullObjects);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "store_pascal_string");

        /// <summary>
        /// <para>Stores the given <see cref="string"/> as a line in the file in Pascal format (i.e. also store the length of the string).</para>
        /// <para>Text will be encoded as UTF-8.</para>
        /// </summary>
        [GodotMethod("store_pascal_string")]
        public void StorePascalString(string @string)
        {
            NativeCalls.godot_icall_1_54(method_bind_43, Object.GetPtr(this), @string);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pascal_string");

        /// <summary>
        /// <para>Returns a <see cref="string"/> saved in Pascal format from the file.</para>
        /// <para>Text is interpreted as being UTF-8 encoded.</para>
        /// </summary>
        [GodotMethod("get_pascal_string")]
        public string GetPascalString()
        {
            return NativeCalls.godot_icall_0_6(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "file_exists");

        /// <summary>
        /// <para>Returns <c>true</c> if the file exists in the given path.</para>
        /// <para>Note: Many resources types are imported (e.g. textures or sound files), and their source asset will not be included in the exported game, as only the imported version is used. See <see cref="Godot.ResourceLoader.Exists"/> for an alternative approach that takes resource remapping into account.</para>
        /// </summary>
        [GodotMethod("file_exists")]
        public bool FileExists(string path)
        {
            return NativeCalls.godot_icall_1_108(method_bind_45, Object.GetPtr(this), path);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_modified_time");

        /// <summary>
        /// <para>Returns the last time the <c>file</c> was modified in unix timestamp format or returns a <see cref="string"/> "ERROR IN <c>file</c>". This unix timestamp can be converted to datetime by using <see cref="Godot.OS.GetDatetimeFromUnixTime"/>.</para>
        /// </summary>
        [GodotMethod("get_modified_time")]
        public ulong GetModifiedTime(string file)
        {
            return NativeCalls.godot_icall_1_1182(method_bind_46, Object.GetPtr(this), file);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
