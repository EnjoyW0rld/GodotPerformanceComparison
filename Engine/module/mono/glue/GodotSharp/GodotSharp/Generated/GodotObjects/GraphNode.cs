using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A GraphNode is a container. Each GraphNode can have several input and output slots, sometimes referred to as ports, allowing connections between GraphNodes. To add a slot to GraphNode, add any <see cref="Godot.Control"/>-derived child node to it.</para>
    /// <para>After adding at least one child to GraphNode new sections will be automatically created in the Inspector called 'Slot'. When 'Slot' is expanded you will see list with index number for each slot. You can click on each of them to expand further.</para>
    /// <para>In the Inspector you can enable (show) or disable (hide) slots. By default, all slots are disabled so you may not see any slots on your GraphNode initially. You can assign a type to each slot. Only slots of the same type will be able to connect to each other. You can also assign colors to slots. A tuple of input and output slots is defined for each GUI element included in the GraphNode. Input connections are on the left and output connections are on the right side of GraphNode. Only enabled slots are counted as connections.</para>
    /// </summary>
    public partial class GraphNode : Container
    {
        public enum OverlayEnum
        {
            /// <summary>
            /// <para>No overlay is shown.</para>
            /// </summary>
            Disabled = 0,
            /// <summary>
            /// <para>Show overlay set in the <c>breakpoint</c> theme property.</para>
            /// </summary>
            Breakpoint = 1,
            /// <summary>
            /// <para>Show overlay set in the <c>position</c> theme property.</para>
            /// </summary>
            Position = 2
        }

        /// <summary>
        /// <para>The text displayed in the GraphNode's title bar.</para>
        /// </summary>
        public string Title
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTitle();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTitle(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The offset of the GraphNode, relative to the scroll offset of the <see cref="Godot.GraphEdit"/>.</para>
        /// <para>Note: You cannot use position directly, as <see cref="Godot.GraphEdit"/> is a <see cref="Godot.Container"/>.</para>
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
        /// <para>If <c>true</c>, the close button will be visible.</para>
        /// <para>Note: Pressing it will only emit the <c>close_request</c> signal, the GraphNode needs to be removed manually.</para>
        /// </summary>
        public bool ShowClose
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsCloseButtonVisible();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetShowCloseButton(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the user can resize the GraphNode.</para>
        /// <para>Note: Dragging the handle will only emit the <c>resize_request</c> signal, the GraphNode needs to be resized manually.</para>
        /// </summary>
        public bool Resizable
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsResizable();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetResizable(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the GraphNode is selected.</para>
        /// </summary>
        public bool Selected
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSelected();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSelected(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the GraphNode is a comment node.</para>
        /// </summary>
        public bool Comment
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsComment();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetComment(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Sets the overlay shown above the GraphNode. See <see cref="Godot.GraphNode.OverlayEnum"/>.</para>
        /// </summary>
        public GraphNode.OverlayEnum Overlay
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOverlay();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOverlay(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GraphNode";

        public GraphNode() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GraphNode_Ctor(this);
        }

        internal GraphNode(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_title");

        [GodotMethod("set_title")]
        [Obsolete("SetTitle is deprecated. Use the Title property instead.")]
        public void SetTitle(string title)
        {
            NativeCalls.godot_icall_1_54(method_bind_0, Object.GetPtr(this), title);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_title");

        [GodotMethod("get_title")]
        [Obsolete("GetTitle is deprecated. Use the Title property instead.")]
        public string GetTitle()
        {
            return NativeCalls.godot_icall_0_6(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot");

        /// <summary>
        /// <para>Sets properties of the slot with ID <c>idx</c>.</para>
        /// <para>If <c>enable_left</c>/<c>right</c>, a port will appear and the slot will be able to be connected from this side.</para>
        /// <para><c>type_left</c>/<c>right</c> is an arbitrary type of the port. Only ports with the same type values can be connected.</para>
        /// <para><c>color_left</c>/<c>right</c> is the tint of the port's icon on this side.</para>
        /// <para><c>custom_left</c>/<c>right</c> is a custom texture for this side's port.</para>
        /// <para>Note: This method only sets properties of the slot. To create the slot, add a <see cref="Godot.Control"/>-derived child to the GraphNode.</para>
        /// <para>Individual properties can be set using one of the <c>set_slot_*</c> methods. You must enable at least one side of the slot to do so.</para>
        /// </summary>
        [GodotMethod("set_slot")]
        public void SetSlot(int idx, bool enableLeft, int typeLeft, Color colorLeft, bool enableRight, int typeRight, Color colorRight, Texture customLeft = null, Texture customRight = null)
        {
            NativeCalls.godot_icall_9_475(method_bind_2, Object.GetPtr(this), idx, enableLeft, typeLeft, ref colorLeft, enableRight, typeRight, ref colorRight, Object.GetPtr(customLeft), Object.GetPtr(customRight));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_slot");

        /// <summary>
        /// <para>Disables input and output slot whose index is <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("clear_slot")]
        public void ClearSlot(int idx)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_all_slots");

        /// <summary>
        /// <para>Disables all input and output slots of the GraphNode.</para>
        /// </summary>
        [GodotMethod("clear_all_slots")]
        public void ClearAllSlots()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_slot_enabled_left");

        /// <summary>
        /// <para>Returns <c>true</c> if left (input) side of the slot <c>idx</c> is enabled.</para>
        /// </summary>
        [GodotMethod("is_slot_enabled_left")]
        public bool IsSlotEnabledLeft(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_enabled_left");

        /// <summary>
        /// <para>Toggles the left (input) side of the slot <c>idx</c>. If <c>enable_left</c> is <c>true</c>, a port will appear on the left side and the slot will be able to be connected from this side.</para>
        /// </summary>
        [GodotMethod("set_slot_enabled_left")]
        public void SetSlotEnabledLeft(int idx, bool enableLeft)
        {
            NativeCalls.godot_icall_2_23(method_bind_6, Object.GetPtr(this), idx, enableLeft);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_type_left");

        /// <summary>
        /// <para>Sets the left (input) type of the slot <c>idx</c> to <c>type_left</c>.</para>
        /// </summary>
        [GodotMethod("set_slot_type_left")]
        public void SetSlotTypeLeft(int idx, int typeLeft)
        {
            NativeCalls.godot_icall_2_65(method_bind_7, Object.GetPtr(this), idx, typeLeft);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slot_type_left");

        /// <summary>
        /// <para>Returns the left (input) type of the slot <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_slot_type_left")]
        public int GetSlotTypeLeft(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_8, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_color_left");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Color"/> of the left (input) side of the slot <c>idx</c> to <c>color_left</c>.</para>
        /// </summary>
        [GodotMethod("set_slot_color_left")]
        public void SetSlotColorLeft(int idx, Color colorLeft)
        {
            NativeCalls.godot_icall_2_464(method_bind_9, Object.GetPtr(this), idx, ref colorLeft);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slot_color_left");

        /// <summary>
        /// <para>Returns the left (input) <see cref="Godot.Color"/> of the slot <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_slot_color_left")]
        public Color GetSlotColorLeft(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_10, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_slot_enabled_right");

        /// <summary>
        /// <para>Returns <c>true</c> if right (output) side of the slot <c>idx</c> is enabled.</para>
        /// </summary>
        [GodotMethod("is_slot_enabled_right")]
        public bool IsSlotEnabledRight(int idx)
        {
            return NativeCalls.godot_icall_1_35(method_bind_11, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_enabled_right");

        /// <summary>
        /// <para>Toggles the right (output) side of the slot <c>idx</c>. If <c>enable_right</c> is <c>true</c>, a port will appear on the right side and the slot will be able to be connected from this side.</para>
        /// </summary>
        [GodotMethod("set_slot_enabled_right")]
        public void SetSlotEnabledRight(int idx, bool enableRight)
        {
            NativeCalls.godot_icall_2_23(method_bind_12, Object.GetPtr(this), idx, enableRight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_type_right");

        /// <summary>
        /// <para>Sets the right (output) type of the slot <c>idx</c> to <c>type_right</c>.</para>
        /// </summary>
        [GodotMethod("set_slot_type_right")]
        public void SetSlotTypeRight(int idx, int typeRight)
        {
            NativeCalls.godot_icall_2_65(method_bind_13, Object.GetPtr(this), idx, typeRight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slot_type_right");

        /// <summary>
        /// <para>Returns the right (output) type of the slot <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_slot_type_right")]
        public int GetSlotTypeRight(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_14, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_slot_color_right");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Color"/> of the right (output) side of the slot <c>idx</c> to <c>color_right</c>.</para>
        /// </summary>
        [GodotMethod("set_slot_color_right")]
        public void SetSlotColorRight(int idx, Color colorRight)
        {
            NativeCalls.godot_icall_2_464(method_bind_15, Object.GetPtr(this), idx, ref colorRight);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_slot_color_right");

        /// <summary>
        /// <para>Returns the right (output) <see cref="Godot.Color"/> of the slot <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_slot_color_right")]
        public Color GetSlotColorRight(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_16, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_offset");

        [GodotMethod("set_offset")]
        [Obsolete("SetOffset is deprecated. Use the Offset property instead.")]
        public void SetOffset(Vector2 offset)
        {
            NativeCalls.godot_icall_1_57(method_bind_17, Object.GetPtr(this), ref offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        [GodotMethod("get_offset")]
        [Obsolete("GetOffset is deprecated. Use the Offset property instead.")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_18, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_comment");

        [GodotMethod("set_comment")]
        [Obsolete("SetComment is deprecated. Use the Comment property instead.")]
        public void SetComment(bool comment)
        {
            NativeCalls.godot_icall_1_16(method_bind_19, Object.GetPtr(this), comment);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_comment");

        [GodotMethod("is_comment")]
        [Obsolete("IsComment is deprecated. Use the Comment property instead.")]
        public bool IsComment()
        {
            return NativeCalls.godot_icall_0_7(method_bind_20, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_resizable");

        [GodotMethod("set_resizable")]
        [Obsolete("SetResizable is deprecated. Use the Resizable property instead.")]
        public void SetResizable(bool resizable)
        {
            NativeCalls.godot_icall_1_16(method_bind_21, Object.GetPtr(this), resizable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_resizable");

        [GodotMethod("is_resizable")]
        [Obsolete("IsResizable is deprecated. Use the Resizable property instead.")]
        public bool IsResizable()
        {
            return NativeCalls.godot_icall_0_7(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_selected");

        [GodotMethod("set_selected")]
        [Obsolete("SetSelected is deprecated. Use the Selected property instead.")]
        public void SetSelected(bool selected)
        {
            NativeCalls.godot_icall_1_16(method_bind_23, Object.GetPtr(this), selected);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_selected");

        [GodotMethod("is_selected")]
        [Obsolete("IsSelected is deprecated. Use the Selected property instead.")]
        public bool IsSelected()
        {
            return NativeCalls.godot_icall_0_7(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_output_count");

        /// <summary>
        /// <para>Returns the number of enabled output slots (connections) of the GraphNode.</para>
        /// </summary>
        [GodotMethod("get_connection_output_count")]
        public int GetConnectionOutputCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_input_count");

        /// <summary>
        /// <para>Returns the number of enabled input slots (connections) to the GraphNode.</para>
        /// </summary>
        [GodotMethod("get_connection_input_count")]
        public int GetConnectionInputCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_26, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_output_position");

        /// <summary>
        /// <para>Returns the position of the output connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_output_position")]
        public Vector2 GetConnectionOutputPosition(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_27, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_output_type");

        /// <summary>
        /// <para>Returns the type of the output connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_output_type")]
        public int GetConnectionOutputType(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_28, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_output_color");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Color"/> of the output connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_output_color")]
        public Color GetConnectionOutputColor(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_29, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_input_position");

        /// <summary>
        /// <para>Returns the position of the input connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_input_position")]
        public Vector2 GetConnectionInputPosition(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_30, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_input_type");

        /// <summary>
        /// <para>Returns the type of the input connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_input_type")]
        public int GetConnectionInputType(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_31, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_connection_input_color");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Color"/> of the input connection <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_connection_input_color")]
        public Color GetConnectionInputColor(int idx)
        {
            NativeCalls.godot_icall_1_465(method_bind_32, Object.GetPtr(this), idx, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_show_close_button");

        [GodotMethod("set_show_close_button")]
        [Obsolete("SetShowCloseButton is deprecated. Use the ShowClose property instead.")]
        public void SetShowCloseButton(bool show)
        {
            NativeCalls.godot_icall_1_16(method_bind_33, Object.GetPtr(this), show);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_close_button_visible");

        [GodotMethod("is_close_button_visible")]
        [Obsolete("IsCloseButtonVisible is deprecated. Use the ShowClose property instead.")]
        public bool IsCloseButtonVisible()
        {
            return NativeCalls.godot_icall_0_7(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_overlay");

        [GodotMethod("set_overlay")]
        [Obsolete("SetOverlay is deprecated. Use the Overlay property instead.")]
        public void SetOverlay(GraphNode.OverlayEnum overlay)
        {
            NativeCalls.godot_icall_1_4(method_bind_35, Object.GetPtr(this), (int)overlay);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_overlay");

        [GodotMethod("get_overlay")]
        [Obsolete("GetOverlay is deprecated. Use the Overlay property instead.")]
        public GraphNode.OverlayEnum GetOverlay()
        {
            return (GraphNode.OverlayEnum)NativeCalls.godot_icall_0_476(method_bind_36, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
