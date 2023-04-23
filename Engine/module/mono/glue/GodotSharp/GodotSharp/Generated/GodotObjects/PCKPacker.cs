using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The <see cref="Godot.PCKPacker"/> is used to create packages that can be loaded into a running project using <see cref="Godot.ProjectSettings.LoadResourcePack"/>.</para>
    /// <para><code>
    /// var packer = PCKPacker.new()
    /// packer.pck_start("test.pck")
    /// packer.add_file("res://text.txt", "text.txt")
    /// packer.flush()
    /// </code></para>
    /// <para>The above <see cref="Godot.PCKPacker"/> creates package <c>test.pck</c>, then adds a file named <c>text.txt</c> at the root of the package.</para>
    /// </summary>
    public partial class PCKPacker : Reference
    {
        private const string nativeName = "PCKPacker";

        public PCKPacker() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PCKPacker_Ctor(this);
        }

        internal PCKPacker(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "pck_start");

        /// <summary>
        /// <para>Creates a new PCK file with the name <c>pck_name</c>. The <c>.pck</c> file extension isn't added automatically, so it should be part of <c>pck_name</c> (even though it's not required).</para>
        /// </summary>
        [GodotMethod("pck_start")]
        public Error PckStart(string pckName, int alignment = 0)
        {
            return (Error)NativeCalls.godot_icall_2_709(method_bind_0, Object.GetPtr(this), pckName, alignment);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_file");

        /// <summary>
        /// <para>Adds the <c>source_path</c> file to the current PCK package at the <c>pck_path</c> internal path (should start with <c>res://</c>).</para>
        /// </summary>
        [GodotMethod("add_file")]
        public Error AddFile(string pckPath, string sourcePath)
        {
            return (Error)NativeCalls.godot_icall_2_136(method_bind_1, Object.GetPtr(this), pckPath, sourcePath);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "flush");

        /// <summary>
        /// <para>Writes the files specified using all <see cref="Godot.PCKPacker.AddFile"/> calls since the last flush. If <c>verbose</c> is <c>true</c>, a list of files added will be printed to the console for easier debugging.</para>
        /// </summary>
        [GodotMethod("flush")]
        public Error Flush(bool verbose = false)
        {
            return (Error)NativeCalls.godot_icall_1_503(method_bind_2, Object.GetPtr(this), verbose);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
