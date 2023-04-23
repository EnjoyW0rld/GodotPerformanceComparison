using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This class can serve as base to make custom XML parsers. Since XML is a very flexible standard, this interface is low-level so it can be applied to any possible schema.</para>
    /// </summary>
    public partial class XMLParser : Reference
    {
        public enum NodeType
        {
            /// <summary>
            /// <para>There's no node (no file or buffer opened).</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>Element (tag).</para>
            /// </summary>
            Element = 1,
            /// <summary>
            /// <para>End of element.</para>
            /// </summary>
            ElementEnd = 2,
            /// <summary>
            /// <para>Text node.</para>
            /// </summary>
            Text = 3,
            /// <summary>
            /// <para>Comment node.</para>
            /// </summary>
            Comment = 4,
            /// <summary>
            /// <para>CDATA content.</para>
            /// </summary>
            Cdata = 5,
            /// <summary>
            /// <para>Unknown node.</para>
            /// </summary>
            Unknown = 6
        }

        private const string nativeName = "XMLParser";

        public XMLParser() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_XMLParser_Ctor(this);
        }

        internal XMLParser(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "read");

        /// <summary>
        /// <para>Reads the next node of the file. This returns an error code.</para>
        /// </summary>
        [GodotMethod("read")]
        public Error Read()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_type");

        /// <summary>
        /// <para>Gets the type of the current node. Compare with <see cref="Godot.XMLParser.NodeType"/> constants.</para>
        /// </summary>
        [GodotMethod("get_node_type")]
        public XMLParser.NodeType GetNodeType()
        {
            return (XMLParser.NodeType)NativeCalls.godot_icall_0_1166(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_name");

        /// <summary>
        /// <para>Gets the name of the current element node. This will raise an error if the current node type is neither <see cref="Godot.XMLParser.NodeType.Element"/> nor <see cref="Godot.XMLParser.NodeType.ElementEnd"/>.</para>
        /// </summary>
        [GodotMethod("get_node_name")]
        public string GetNodeName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_data");

        /// <summary>
        /// <para>Gets the contents of a text node. This will raise an error in any other type of node.</para>
        /// </summary>
        [GodotMethod("get_node_data")]
        public string GetNodeData()
        {
            return NativeCalls.godot_icall_0_6(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_node_offset");

        /// <summary>
        /// <para>Gets the byte offset of the current node since the beginning of the file or buffer.</para>
        /// </summary>
        [GodotMethod("get_node_offset")]
        public ulong GetNodeOffset()
        {
            return NativeCalls.godot_icall_0_30(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attribute_count");

        /// <summary>
        /// <para>Gets the amount of attributes in the current element.</para>
        /// </summary>
        [GodotMethod("get_attribute_count")]
        public int GetAttributeCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attribute_name");

        /// <summary>
        /// <para>Gets the name of the attribute specified by the index in <c>idx</c> argument.</para>
        /// </summary>
        [GodotMethod("get_attribute_name")]
        public string GetAttributeName(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_6, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_attribute_value");

        /// <summary>
        /// <para>Gets the value of the attribute specified by the index in <c>idx</c> argument.</para>
        /// </summary>
        [GodotMethod("get_attribute_value")]
        public string GetAttributeValue(int idx)
        {
            return NativeCalls.godot_icall_1_89(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_attribute");

        /// <summary>
        /// <para>Check whether the current element has a certain attribute.</para>
        /// </summary>
        [GodotMethod("has_attribute")]
        public bool HasAttribute(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_8, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_named_attribute_value");

        /// <summary>
        /// <para>Gets the value of a certain attribute of the current element by name. This will raise an error if the element has no such attribute.</para>
        /// </summary>
        [GodotMethod("get_named_attribute_value")]
        public string GetNamedAttributeValue(string name)
        {
            return NativeCalls.godot_icall_1_124(method_bind_9, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_named_attribute_value_safe");

        /// <summary>
        /// <para>Gets the value of a certain attribute of the current element by name. This will return an empty <see cref="string"/> if the attribute is not found.</para>
        /// </summary>
        [GodotMethod("get_named_attribute_value_safe")]
        public string GetNamedAttributeValueSafe(string name)
        {
            return NativeCalls.godot_icall_1_124(method_bind_10, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_empty");

        /// <summary>
        /// <para>Check whether the current element is empty (this only works for completely empty tags, e.g. <c>&lt;element \&gt;</c>).</para>
        /// </summary>
        [GodotMethod("is_empty")]
        public bool IsEmpty()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_line");

        /// <summary>
        /// <para>Gets the current line in the parsed file (currently not implemented).</para>
        /// </summary>
        [GodotMethod("get_current_line")]
        public int GetCurrentLine()
        {
            return NativeCalls.godot_icall_0_5(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "skip_section");

        /// <summary>
        /// <para>Skips the current section. If the node contains other elements, they will be ignored and the cursor will go to the closing of the current element.</para>
        /// </summary>
        [GodotMethod("skip_section")]
        public void SkipSection()
        {
            NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "seek");

        /// <summary>
        /// <para>Moves the buffer cursor to a certain offset (since the beginning) and read the next node there. This returns an error code.</para>
        /// </summary>
        [GodotMethod("seek")]
        public Error Seek(ulong position)
        {
            return (Error)NativeCalls.godot_icall_1_1167(method_bind_14, Object.GetPtr(this), position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open");

        /// <summary>
        /// <para>Opens an XML file for parsing. This returns an error code.</para>
        /// </summary>
        [GodotMethod("open")]
        public Error Open(string file)
        {
            return (Error)NativeCalls.godot_icall_1_193(method_bind_15, Object.GetPtr(this), file);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "open_buffer");

        /// <summary>
        /// <para>Opens an XML raw buffer for parsing. This returns an error code.</para>
        /// </summary>
        [GodotMethod("open_buffer")]
        public Error OpenBuffer(byte[] buffer)
        {
            return (Error)NativeCalls.godot_icall_1_487(method_bind_16, Object.GetPtr(this), buffer);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
