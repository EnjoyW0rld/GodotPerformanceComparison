using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base class for all UI-related nodes. <see cref="Godot.Control"/> features a bounding rectangle that defines its extents, an anchor position relative to its parent control or the current viewport, and margins that represent an offset to the anchor. The margins update automatically when the node, any of its parents, or the screen size change.</para>
    /// <para>For more information on Godot's UI system, anchors, margins, and containers, see the related tutorials in the manual. To build flexible UIs, you'll need a mix of UI elements that inherit from <see cref="Godot.Control"/> and <see cref="Godot.Container"/> nodes.</para>
    /// <para>User Interface nodes and input</para>
    /// <para>Godot sends input events to the scene's root node first, by calling <see cref="Godot.Node._Input"/>. <see cref="Godot.Node._Input"/> forwards the event down the node tree to the nodes under the mouse cursor, or on keyboard focus. To do so, it calls <see cref="Godot.MainLoop._InputEvent"/>. Call <see cref="Godot.Control.AcceptEvent"/> so no other node receives the event. Once you accept an input, it becomes handled so <see cref="Godot.Node._UnhandledInput"/> will not process it.</para>
    /// <para>Only one <see cref="Godot.Control"/> node can be in keyboard focus. Only the node in focus will receive keyboard events. To get the focus, call <see cref="Godot.Control.GrabFocus"/>. <see cref="Godot.Control"/> nodes lose focus when another node grabs it, or if you hide the node in focus.</para>
    /// <para>Sets <see cref="Godot.Control.MouseFilter"/> to <see cref="Godot.Control.MouseFilterEnum.Ignore"/> to tell a <see cref="Godot.Control"/> node to ignore mouse or touch events. You'll need it if you place an icon on top of a button.</para>
    /// <para><see cref="Godot.Theme"/> resources change the Control's appearance. If you change the <see cref="Godot.Theme"/> on a <see cref="Godot.Control"/> node, it affects all of its children. To override some of the theme's parameters, call one of the <c>add_*_override</c> methods, like <see cref="Godot.Control.AddFontOverride"/>. You can override the theme with the inspector.</para>
    /// <para>Note: Theme items are not <see cref="Godot.Object"/> properties. This means you can't access their values using <see cref="Godot.Object.Get"/> and <see cref="Godot.Object.Set"/>. Instead, use <see cref="Godot.Control.GetColor"/>, <see cref="Godot.Control.GetConstant"/>, <see cref="Godot.Control.GetFont"/>, <see cref="Godot.Control.GetIcon"/>, <see cref="Godot.Control.GetStylebox"/>, and the <c>add_*_override</c> methods provided by this class.</para>
    /// </summary>
    public partial class Control : CanvasItem
    {
        /// <summary>
        /// <para>Sent when the node changes size. Use <see cref="Godot.Control.RectSize"/> to get the new size.</para>
        /// </summary>
        public const int NotificationResized = 40;
        /// <summary>
        /// <para>Sent when the mouse pointer enters the node.</para>
        /// </summary>
        public const int NotificationMouseEnter = 41;
        /// <summary>
        /// <para>Sent when the mouse pointer exits the node.</para>
        /// </summary>
        public const int NotificationMouseExit = 42;
        /// <summary>
        /// <para>Sent when the node grabs focus.</para>
        /// </summary>
        public const int NotificationFocusEnter = 43;
        /// <summary>
        /// <para>Sent when the node loses focus.</para>
        /// </summary>
        public const int NotificationFocusExit = 44;
        /// <summary>
        /// <para>Sent when the node's <see cref="Godot.Control.Theme"/> changes, right before Godot redraws the control. Happens when you call one of the <c>add_*_override</c> methods.</para>
        /// </summary>
        public const int NotificationThemeChanged = 45;
        /// <summary>
        /// <para>Sent when an open modal dialog closes. See <see cref="Godot.Control.ShowModal"/>.</para>
        /// </summary>
        public const int NotificationModalClose = 46;
        /// <summary>
        /// <para>Sent when this node is inside a <see cref="Godot.ScrollContainer"/> which has begun being scrolled.</para>
        /// </summary>
        public const int NotificationScrollBegin = 47;
        /// <summary>
        /// <para>Sent when this node is inside a <see cref="Godot.ScrollContainer"/> which has stopped being scrolled.</para>
        /// </summary>
        public const int NotificationScrollEnd = 48;

        public enum Anchor
        {
            /// <summary>
            /// <para>Snaps one of the 4 anchor's sides to the origin of the node's <c>Rect</c>, in the top left. Use it with one of the <c>anchor_*</c> member variables, like <see cref="Godot.Control.AnchorLeft"/>. To change all 4 anchors at once, use <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            Begin = 0,
            /// <summary>
            /// <para>Snaps one of the 4 anchor's sides to the end of the node's <c>Rect</c>, in the bottom right. Use it with one of the <c>anchor_*</c> member variables, like <see cref="Godot.Control.AnchorLeft"/>. To change all 4 anchors at once, use <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            End = 1
        }

        public enum FocusModeEnum
        {
            /// <summary>
            /// <para>The node cannot grab focus. Use with <see cref="Godot.Control.FocusMode"/>.</para>
            /// </summary>
            None = 0,
            /// <summary>
            /// <para>The node can only grab focus on mouse clicks. Use with <see cref="Godot.Control.FocusMode"/>.</para>
            /// </summary>
            Click = 1,
            /// <summary>
            /// <para>The node can grab focus on mouse click or using the arrows and the Tab keys on the keyboard. Use with <see cref="Godot.Control.FocusMode"/>.</para>
            /// </summary>
            All = 2
        }

        public enum LayoutPresetMode
        {
            /// <summary>
            /// <para>The control will be resized to its minimum size.</para>
            /// </summary>
            Minsize = 0,
            /// <summary>
            /// <para>The control's width will not change.</para>
            /// </summary>
            KeepWidth = 1,
            /// <summary>
            /// <para>The control's height will not change.</para>
            /// </summary>
            KeepHeight = 2,
            /// <summary>
            /// <para>The control's size will not change.</para>
            /// </summary>
            KeepSize = 3
        }

        public enum MouseFilterEnum
        {
            /// <summary>
            /// <para>The control will receive mouse button input events through <see cref="Godot.Control._GuiInput"/> if clicked on. And the control will receive the <c>mouse_entered</c> and <c>mouse_exited</c> signals. These events are automatically marked as handled, and they will not propagate further to other controls. This also results in blocking signals in other controls.</para>
            /// </summary>
            Stop = 0,
            /// <summary>
            /// <para>The control will receive mouse button input events through <see cref="Godot.Control._GuiInput"/> if clicked on. And the control will receive the <c>mouse_entered</c> and <c>mouse_exited</c> signals. If this control does not handle the event, the parent control (if any) will be considered, and so on until there is no more parent control to potentially handle it. This also allows signals to fire in other controls. Even if no control handled it at all, the event will still be handled automatically, so unhandled input will not be fired.</para>
            /// </summary>
            Pass = 1,
            /// <summary>
            /// <para>The control will not receive mouse button input events through <see cref="Godot.Control._GuiInput"/>. The control will also not receive the <c>mouse_entered</c> nor <c>mouse_exited</c> signals. This will not block other controls from receiving these events or firing the signals. Ignored events will not be handled automatically.</para>
            /// </summary>
            Ignore = 2
        }

        public enum CursorShape
        {
            /// <summary>
            /// <para>Show the system's arrow mouse cursor when the user hovers the node. Use with <see cref="Godot.Control.MouseDefaultCursorShape"/>.</para>
            /// </summary>
            Arrow = 0,
            /// <summary>
            /// <para>Show the system's I-beam mouse cursor when the user hovers the node. The I-beam pointer has a shape similar to "I". It tells the user they can highlight or insert text.</para>
            /// </summary>
            Ibeam = 1,
            /// <summary>
            /// <para>Show the system's pointing hand mouse cursor when the user hovers the node.</para>
            /// </summary>
            PointingHand = 2,
            /// <summary>
            /// <para>Show the system's cross mouse cursor when the user hovers the node.</para>
            /// </summary>
            Cross = 3,
            /// <summary>
            /// <para>Show the system's wait mouse cursor when the user hovers the node. Often an hourglass.</para>
            /// </summary>
            Wait = 4,
            /// <summary>
            /// <para>Show the system's busy mouse cursor when the user hovers the node. Often an arrow with a small hourglass.</para>
            /// </summary>
            Busy = 5,
            /// <summary>
            /// <para>Show the system's drag mouse cursor, often a closed fist or a cross symbol, when the user hovers the node. It tells the user they're currently dragging an item, like a node in the Scene dock.</para>
            /// </summary>
            Drag = 6,
            /// <summary>
            /// <para>Show the system's drop mouse cursor when the user hovers the node. It can be an open hand. It tells the user they can drop an item they're currently grabbing, like a node in the Scene dock.</para>
            /// </summary>
            CanDrop = 7,
            /// <summary>
            /// <para>Show the system's forbidden mouse cursor when the user hovers the node. Often a crossed circle.</para>
            /// </summary>
            Forbidden = 8,
            /// <summary>
            /// <para>Show the system's vertical resize mouse cursor when the user hovers the node. A double-headed vertical arrow. It tells the user they can resize the window or the panel vertically.</para>
            /// </summary>
            Vsize = 9,
            /// <summary>
            /// <para>Show the system's horizontal resize mouse cursor when the user hovers the node. A double-headed horizontal arrow. It tells the user they can resize the window or the panel horizontally.</para>
            /// </summary>
            Hsize = 10,
            /// <summary>
            /// <para>Show the system's window resize mouse cursor when the user hovers the node. The cursor is a double-headed arrow that goes from the bottom left to the top right. It tells the user they can resize the window or the panel both horizontally and vertically.</para>
            /// </summary>
            Bdiagsize = 11,
            /// <summary>
            /// <para>Show the system's window resize mouse cursor when the user hovers the node. The cursor is a double-headed arrow that goes from the top left to the bottom right, the opposite of <see cref="Godot.Control.CursorShape.Bdiagsize"/>. It tells the user they can resize the window or the panel both horizontally and vertically.</para>
            /// </summary>
            Fdiagsize = 12,
            /// <summary>
            /// <para>Show the system's move mouse cursor when the user hovers the node. It shows 2 double-headed arrows at a 90 degree angle. It tells the user they can move a UI element freely.</para>
            /// </summary>
            Move = 13,
            /// <summary>
            /// <para>Show the system's vertical split mouse cursor when the user hovers the node. On Windows, it's the same as <see cref="Godot.Control.CursorShape.Vsize"/>.</para>
            /// </summary>
            Vsplit = 14,
            /// <summary>
            /// <para>Show the system's horizontal split mouse cursor when the user hovers the node. On Windows, it's the same as <see cref="Godot.Control.CursorShape.Hsize"/>.</para>
            /// </summary>
            Hsplit = 15,
            /// <summary>
            /// <para>Show the system's help mouse cursor when the user hovers the node, a question mark.</para>
            /// </summary>
            Help = 16
        }

        public enum GrowDirection
        {
            /// <summary>
            /// <para>The control will grow to the left or top to make up if its minimum size is changed to be greater than its current size on the respective axis.</para>
            /// </summary>
            Begin = 0,
            /// <summary>
            /// <para>The control will grow to the right or bottom to make up if its minimum size is changed to be greater than its current size on the respective axis.</para>
            /// </summary>
            End = 1,
            /// <summary>
            /// <para>The control will grow in both directions equally to make up if its minimum size is changed to be greater than its current size.</para>
            /// </summary>
            Both = 2
        }

        public enum SizeFlags
        {
            /// <summary>
            /// <para>Tells the parent <see cref="Godot.Container"/> to expand the bounds of this node to fill all the available space without pushing any other node. Use with <see cref="Godot.Control.SizeFlagsHorizontal"/> and <see cref="Godot.Control.SizeFlagsVertical"/>.</para>
            /// </summary>
            Fill = 1,
            /// <summary>
            /// <para>Tells the parent <see cref="Godot.Container"/> to let this node take all the available space on the axis you flag. If multiple neighboring nodes are set to expand, they'll share the space based on their stretch ratio. See <see cref="Godot.Control.SizeFlagsStretchRatio"/>. Use with <see cref="Godot.Control.SizeFlagsHorizontal"/> and <see cref="Godot.Control.SizeFlagsVertical"/>.</para>
            /// </summary>
            Expand = 2,
            /// <summary>
            /// <para>Sets the node's size flags to both fill and expand. See the 2 constants above for more information.</para>
            /// </summary>
            ExpandFill = 3,
            /// <summary>
            /// <para>Tells the parent <see cref="Godot.Container"/> to center the node in itself. It centers the control based on its bounding box, so it doesn't work with the fill or expand size flags. Use with <see cref="Godot.Control.SizeFlagsHorizontal"/> and <see cref="Godot.Control.SizeFlagsVertical"/>.</para>
            /// </summary>
            ShrinkCenter = 4,
            /// <summary>
            /// <para>Tells the parent <see cref="Godot.Container"/> to align the node with its end, either the bottom or the right edge. It doesn't work with the fill or expand size flags. Use with <see cref="Godot.Control.SizeFlagsHorizontal"/> and <see cref="Godot.Control.SizeFlagsVertical"/>.</para>
            /// </summary>
            ShrinkEnd = 8
        }

        public enum LayoutPreset
        {
            /// <summary>
            /// <para>Snap all 4 anchors to the top-left of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            TopLeft = 0,
            /// <summary>
            /// <para>Snap all 4 anchors to the top-right of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            TopRight = 1,
            /// <summary>
            /// <para>Snap all 4 anchors to the bottom-left of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            BottomLeft = 2,
            /// <summary>
            /// <para>Snap all 4 anchors to the bottom-right of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            BottomRight = 3,
            /// <summary>
            /// <para>Snap all 4 anchors to the center of the left edge of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            CenterLeft = 4,
            /// <summary>
            /// <para>Snap all 4 anchors to the center of the top edge of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            CenterTop = 5,
            /// <summary>
            /// <para>Snap all 4 anchors to the center of the right edge of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            CenterRight = 6,
            /// <summary>
            /// <para>Snap all 4 anchors to the center of the bottom edge of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            CenterBottom = 7,
            /// <summary>
            /// <para>Snap all 4 anchors to the center of the parent control's bounds. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            Center = 8,
            /// <summary>
            /// <para>Snap all 4 anchors to the left edge of the parent control. The left margin becomes relative to the left edge and the top margin relative to the top left corner of the node's parent. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            LeftWide = 9,
            /// <summary>
            /// <para>Snap all 4 anchors to the top edge of the parent control. The left margin becomes relative to the top left corner, the top margin relative to the top edge, and the right margin relative to the top right corner of the node's parent. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            TopWide = 10,
            /// <summary>
            /// <para>Snap all 4 anchors to the right edge of the parent control. The right margin becomes relative to the right edge and the top margin relative to the top right corner of the node's parent. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            RightWide = 11,
            /// <summary>
            /// <para>Snap all 4 anchors to the bottom edge of the parent control. The left margin becomes relative to the bottom left corner, the bottom margin relative to the bottom edge, and the right margin relative to the bottom right corner of the node's parent. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            BottomWide = 12,
            /// <summary>
            /// <para>Snap all 4 anchors to a vertical line that cuts the parent control in half. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            VcenterWide = 13,
            /// <summary>
            /// <para>Snap all 4 anchors to a horizontal line that cuts the parent control in half. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            HcenterWide = 14,
            /// <summary>
            /// <para>Snap all 4 anchors to the respective corners of the parent control. Set all 4 margins to 0 after you applied this preset and the <see cref="Godot.Control"/> will fit its parent control. This is equivalent to the "Full Rect" layout option in the editor. Use with <see cref="Godot.Control.SetAnchorsPreset"/>.</para>
            /// </summary>
            Wide = 15
        }

        /// <summary>
        /// <para>Anchors the left edge of the node to the origin, the center or the end of its parent control. It changes how the left margin updates when the node moves or changes size. You can use one of the <see cref="Godot.Control.Anchor"/> constants for convenience.</para>
        /// </summary>
        public float AnchorLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchor((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAnchor((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Anchors the top edge of the node to the origin, the center or the end of its parent control. It changes how the top margin updates when the node moves or changes size. You can use one of the <see cref="Godot.Control.Anchor"/> constants for convenience.</para>
        /// </summary>
        public float AnchorTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchor((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAnchor((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Anchors the right edge of the node to the origin, the center or the end of its parent control. It changes how the right margin updates when the node moves or changes size. You can use one of the <see cref="Godot.Control.Anchor"/> constants for convenience.</para>
        /// </summary>
        public float AnchorRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchor((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAnchor((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Anchors the bottom edge of the node to the origin, the center, or the end of its parent control. It changes how the bottom margin updates when the node moves or changes size. You can use one of the <see cref="Godot.Control.Anchor"/> constants for convenience.</para>
        /// </summary>
        public float AnchorBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnchor((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetAnchor((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance between the node's left edge and its parent control, based on <see cref="Godot.Control.AnchorLeft"/>.</para>
        /// <para>Margins are often controlled by one or multiple parent <see cref="Godot.Container"/> nodes, so you should not modify them manually if your node is a direct child of a <see cref="Godot.Container"/>. Margins update automatically when you move or resize the node.</para>
        /// </summary>
        public float MarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance between the node's top edge and its parent control, based on <see cref="Godot.Control.AnchorTop"/>.</para>
        /// <para>Margins are often controlled by one or multiple parent <see cref="Godot.Container"/> nodes, so you should not modify them manually if your node is a direct child of a <see cref="Godot.Container"/>. Margins update automatically when you move or resize the node.</para>
        /// </summary>
        public float MarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance between the node's right edge and its parent control, based on <see cref="Godot.Control.AnchorRight"/>.</para>
        /// <para>Margins are often controlled by one or multiple parent <see cref="Godot.Container"/> nodes, so you should not modify them manually if your node is a direct child of a <see cref="Godot.Container"/>. Margins update automatically when you move or resize the node.</para>
        /// </summary>
        public float MarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Distance between the node's bottom edge and its parent control, based on <see cref="Godot.Control.AnchorBottom"/>.</para>
        /// <para>Margins are often controlled by one or multiple parent <see cref="Godot.Container"/> nodes, so you should not modify them manually if your node is a direct child of a <see cref="Godot.Container"/>. Margins update automatically when you move or resize the node.</para>
        /// </summary>
        public float MarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the direction on the horizontal axis in which the control should grow if its horizontal minimum size is changed to be greater than its current size, as the control always has to be at least the minimum size.</para>
        /// </summary>
        public Control.GrowDirection GrowHorizontal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHGrowDirection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHGrowDirection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls the direction on the vertical axis in which the control should grow if its vertical minimum size is changed to be greater than its current size, as the control always has to be at least the minimum size.</para>
        /// </summary>
        public Control.GrowDirection GrowVertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVGrowDirection();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVGrowDirection(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's position, relative to its parent. It corresponds to the rectangle's top-left corner. The property is not affected by <see cref="Godot.Control.RectPivotOffset"/>.</para>
        /// </summary>
        public Vector2 RectPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's global position, relative to the world (usually to the top-left corner of the window).</para>
        /// </summary>
        public Vector2 RectGlobalPosition
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlobalPosition();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetGlobalPosition(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The size of the node's bounding rectangle, in pixels. <see cref="Godot.Container"/> nodes update this property automatically.</para>
        /// </summary>
        public Vector2 RectSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The minimum size of the node's bounding rectangle. If you set it to a value greater than (0, 0), the node's bounding rectangle will always have at least this size, even if its content is smaller. If it's set to (0, 0), the node sizes automatically to fit its content, be it a texture or child nodes.</para>
        /// </summary>
        public Vector2 RectMinSize
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCustomMinimumSize();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCustomMinimumSize(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's rotation around its pivot, in degrees. See <see cref="Godot.Control.RectPivotOffset"/> to change the pivot's position.</para>
        /// </summary>
        public float RectRotation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRotationDegrees();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRotationDegrees(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The node's scale, relative to its <see cref="Godot.Control.RectSize"/>. Change this property to scale the node around its <see cref="Godot.Control.RectPivotOffset"/>. The Control's <see cref="Godot.Control.HintTooltip"/> will also scale according to this value.</para>
        /// <para>Note: This property is mainly intended to be used for animation purposes. Text inside the Control will look pixelated or blurry when the Control is scaled. To support multiple resolutions in your project, use an appropriate viewport stretch mode as described in the <a href="$DOCS_URL/tutorials/rendering/multiple_resolutions.html">documentation</a> instead of scaling Controls individually.</para>
        /// <para>Note: If the Control node is a child of a <see cref="Godot.Container"/> node, the scale will be reset to <c>Vector2(1, 1)</c> when the scene is instanced. To set the Control's scale when it's instanced, wait for one frame using <c>yield(get_tree(), "idle_frame")</c> then set its <see cref="Godot.Control.RectScale"/> property.</para>
        /// </summary>
        public Vector2 RectScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>By default, the node's pivot is its top-left corner. When you change its <see cref="Godot.Control.RectRotation"/> or <see cref="Godot.Control.RectScale"/>, it will rotate or scale around this pivot. Set this property to <see cref="Godot.Control.RectSize"/> / 2 to pivot around the Control's center.</para>
        /// </summary>
        public Vector2 RectPivotOffset
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPivotOffset();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPivotOffset(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables whether rendering of <see cref="Godot.CanvasItem"/> based children should be clipped to this control's rectangle. If <c>true</c>, parts of a child which would be visibly outside of this control's rectangle will not be rendered.</para>
        /// </summary>
        public bool RectClipContent
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsClippingContents();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetClipContents(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Changes the tooltip text. The tooltip appears when the user's mouse cursor stays idle over this control for a few moments, provided that the <see cref="Godot.Control.MouseFilter"/> property is not <see cref="Godot.Control.MouseFilterEnum.Ignore"/>. You can change the time required for the tooltip to appear with <c>gui/timers/tooltip_delay_sec</c> option in Project Settings.</para>
        /// <para>The tooltip popup will use either a default implementation, or a custom one that you can provide by overriding <see cref="Godot.Control._MakeCustomTooltip"/>. The default tooltip includes a <see cref="Godot.PopupPanel"/> and <see cref="Godot.Label"/> whose theme properties can be customized using <see cref="Godot.Theme"/> methods with the <c>"TooltipPanel"</c> and <c>"TooltipLabel"</c> respectively. For example:</para>
        /// <para><code>
        /// var style_box = StyleBoxFlat.new()
        /// style_box.set_bg_color(Color(1, 1, 0))
        /// style_box.set_border_width_all(2)
        /// # We assume here that the `theme` property has been assigned a custom Theme beforehand.
        /// theme.set_stylebox("panel", "TooltipPanel", style_box)
        /// theme.set_color("font_color", "TooltipLabel", Color(0, 1, 1))
        /// </code></para>
        /// </summary>
        public string HintTooltip
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetTooltip();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTooltip(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses the left arrow on the keyboard or left on a gamepad by default. You can change the key by editing the <c>ui_left</c> input action. The node must be a <see cref="Godot.Control"/>. If this property is not set, Godot will give focus to the closest <see cref="Godot.Control"/> to the left of this one.</para>
        /// </summary>
        public NodePath FocusNeighbourLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusNeighbour((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusNeighbour((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses the top arrow on the keyboard or top on a gamepad by default. You can change the key by editing the <c>ui_top</c> input action. The node must be a <see cref="Godot.Control"/>. If this property is not set, Godot will give focus to the closest <see cref="Godot.Control"/> to the bottom of this one.</para>
        /// </summary>
        public NodePath FocusNeighbourTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusNeighbour((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusNeighbour((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses the right arrow on the keyboard or right on a gamepad by default. You can change the key by editing the <c>ui_right</c> input action. The node must be a <see cref="Godot.Control"/>. If this property is not set, Godot will give focus to the closest <see cref="Godot.Control"/> to the bottom of this one.</para>
        /// </summary>
        public NodePath FocusNeighbourRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusNeighbour((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusNeighbour((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses the down arrow on the keyboard or down on a gamepad by default. You can change the key by editing the <c>ui_down</c> input action. The node must be a <see cref="Godot.Control"/>. If this property is not set, Godot will give focus to the closest <see cref="Godot.Control"/> to the bottom of this one.</para>
        /// </summary>
        public NodePath FocusNeighbourBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusNeighbour((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusNeighbour((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses Tab on a keyboard by default. You can change the key by editing the <c>ui_focus_next</c> input action.</para>
        /// <para>If this property is not set, Godot will select a "best guess" based on surrounding nodes in the scene tree.</para>
        /// </summary>
        public NodePath FocusNext
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusNext();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusNext(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells Godot which node it should give keyboard focus to if the user presses Shift+Tab on a keyboard by default. You can change the key by editing the <c>ui_focus_prev</c> input action.</para>
        /// <para>If this property is not set, Godot will select a "best guess" based on surrounding nodes in the scene tree.</para>
        /// </summary>
        public NodePath FocusPrevious
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusPrevious();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusPrevious(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The focus access mode for the control (None, Click or All). Only one Control can be focused at the same time, and it will receive keyboard signals.</para>
        /// </summary>
        public Control.FocusModeEnum FocusMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFocusMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFocusMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Controls whether the control will be able to receive mouse button input events through <see cref="Godot.Control._GuiInput"/> and how these events should be handled. Also controls whether the control can receive the <c>mouse_entered</c>, and <c>mouse_exited</c> signals. See the constants to learn what each does.</para>
        /// </summary>
        public Control.MouseFilterEnum MouseFilter
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMouseFilter();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMouseFilter(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The default cursor shape for this control. Useful for Godot plugins and applications or games that use the system's mouse cursors.</para>
        /// <para>Note: On Linux, shapes may vary depending on the cursor theme of the system.</para>
        /// </summary>
        public Control.CursorShape MouseDefaultCursorShape
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultCursorShape();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultCursorShape(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Enables whether input should propagate when you close the control as modal.</para>
        /// <para>If <c>false</c>, stops event handling at the viewport input event handling. The viewport first hides the modal and after marks the input as handled.</para>
        /// </summary>
        public bool InputPassOnModalCloseClick
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPassOnModalCloseClick();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPassOnModalCloseClick(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells the parent <see cref="Godot.Container"/> nodes how they should resize and place the node on the X axis. Use one of the <see cref="Godot.Control.SizeFlags"/> constants to change the flags. See the constants to learn what each does.</para>
        /// </summary>
        public int SizeFlagsHorizontal
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHSizeFlags();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHSizeFlags(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Tells the parent <see cref="Godot.Container"/> nodes how they should resize and place the node on the Y axis. Use one of the <see cref="Godot.Control.SizeFlags"/> constants to change the flags. See the constants to learn what each does.</para>
        /// </summary>
        public int SizeFlagsVertical
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVSizeFlags();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVSizeFlags(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If the node and at least one of its neighbours uses the <see cref="Godot.Control.SizeFlags.Expand"/> size flag, the parent <see cref="Godot.Container"/> will let it take more or less space depending on this property. If this node has a stretch ratio of 2 and its neighbour a ratio of 1, this node will take two thirds of the available space.</para>
        /// </summary>
        public float SizeFlagsStretchRatio
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStretchRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStretchRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Changing this property replaces the current <see cref="Godot.Theme"/> resource this node and all its <see cref="Godot.Control"/> children use.</para>
        /// </summary>
        public Theme Theme
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTheme();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTheme(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The name of a theme type variation used by this <see cref="Godot.Control"/> to look up its own theme items. When empty, the class name of the node is used (e.g. <c>Button</c> for the <see cref="Godot.Button"/> control), as well as the class names of all parent classes (in order of inheritance).</para>
        /// <para>When set, this property gives the highest priority to the type of the specified name. This type can in turn extend another type, forming a dependency chain. See <see cref="Godot.Theme.SetTypeVariation"/>. If the theme item cannot be found using this type or its base types, lookup falls back on the class names.</para>
        /// <para>Note: To look up <see cref="Godot.Control"/>'s own items use various <c>get_*</c> methods without specifying <c>theme_type</c>.</para>
        /// <para>Note: Theme items are looked for in the tree order, from branch to root, where each <see cref="Godot.Control"/> node is checked for its <see cref="Godot.Control.Theme"/> property. The earliest match against any type/class name is returned. The project-level Theme and the default Theme are checked last.</para>
        /// </summary>
        public string ThemeTypeVariation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetThemeTypeVariation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetThemeTypeVariation(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Control";

        public Control() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Control_Ctor(this);
        }

        internal Control(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Virtual method to be implemented by the user. Returns whether <see cref="Godot.Control._GuiInput"/> should not be called for children controls outside this control's rectangle. Input will be clipped to the Rect of this <see cref="Godot.Control"/>. Similar to <see cref="Godot.Control.RectClipContent"/>, but doesn't affect visibility.</para>
        /// <para>If not overridden, defaults to <c>false</c>.</para>
        /// </summary>
        [GodotMethod("_clips_input")]
        public virtual bool _ClipsInput()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Virtual method to be implemented by the user. Returns the minimum size for this control. Alternative to <see cref="Godot.Control.RectMinSize"/> for controlling minimum size via code. The actual minimum size will be the max value of these two (in each axis separately).</para>
        /// <para>If not overridden, defaults to <c>Vector2.ZERO</c>.</para>
        /// <para>Note: This method will not be called when the script is attached to a <see cref="Godot.Control"/> node that already overrides its minimum size (e.g. <see cref="Godot.Label"/>, <see cref="Godot.Button"/>, <see cref="Godot.PanelContainer"/> etc.). It can only be used with most basic GUI nodes, like <see cref="Godot.Control"/>, <see cref="Godot.Container"/>, <see cref="Godot.Panel"/> etc.</para>
        /// </summary>
        [GodotMethod("_get_minimum_size")]
        public virtual Vector2 _GetMinimumSize()
        {
            return default(Vector2);
        }

        /// <summary>
        /// <para>Virtual method to be implemented by the user. Use this method to process and accept inputs on UI elements. See <see cref="Godot.Control.AcceptEvent"/>.</para>
        /// <para>Example: clicking a control.</para>
        /// <para><code>
        /// func _gui_input(event):
        ///     if event is InputEventMouseButton:
        ///         if event.button_index == BUTTON_LEFT and event.pressed:
        ///             print("I've been clicked D:")
        /// </code></para>
        /// <para>The event won't trigger if:</para>
        /// <para>* clicking outside the control (see <see cref="Godot.Control.HasPoint"/>);</para>
        /// <para>* control has <see cref="Godot.Control.MouseFilter"/> set to <see cref="Godot.Control.MouseFilterEnum.Ignore"/>;</para>
        /// <para>* control is obstructed by another <see cref="Godot.Control"/> on top of it, which doesn't have <see cref="Godot.Control.MouseFilter"/> set to <see cref="Godot.Control.MouseFilterEnum.Ignore"/>;</para>
        /// <para>* control's parent has <see cref="Godot.Control.MouseFilter"/> set to <see cref="Godot.Control.MouseFilterEnum.Stop"/> or has accepted the event;</para>
        /// <para>* it happens outside the parent's rectangle and the parent has either <see cref="Godot.Control.RectClipContent"/> or <see cref="Godot.Control._ClipsInput"/> enabled.</para>
        /// <para>Note: Event position is relative to the control origin.</para>
        /// </summary>
        [GodotMethod("_gui_input")]
        public virtual void _GuiInput(InputEvent @event)
        {
            return;
        }

        /// <summary>
        /// <para>Virtual method to be implemented by the user. Returns a <see cref="Godot.Control"/> node that should be used as a tooltip instead of the default one. The <c>for_text</c> includes the contents of the <see cref="Godot.Control.HintTooltip"/> property.</para>
        /// <para>The returned node must be of type <see cref="Godot.Control"/> or Control-derived. It can have child nodes of any type. It is freed when the tooltip disappears, so make sure you always provide a new instance (if you want to use a pre-existing node from your scene tree, you can duplicate it and pass the duplicated instance). When <c>null</c> or a non-Control node is returned, the default tooltip will be used instead.</para>
        /// <para>The returned node will be added as child to a <see cref="Godot.PopupPanel"/>, so you should only provide the contents of that panel. That <see cref="Godot.PopupPanel"/> can be themed using <see cref="Godot.Theme.SetStylebox"/> for the type <c>"TooltipPanel"</c> (see <see cref="Godot.Control.HintTooltip"/> for an example).</para>
        /// <para>Note: The tooltip is shrunk to minimal size. If you want to ensure it's fully visible, you might want to set its <see cref="Godot.Control.RectMinSize"/> to some non-zero value.</para>
        /// <para>Example of usage with a custom-constructed node:</para>
        /// <para><code>
        /// func _make_custom_tooltip(for_text):
        ///     var label = Label.new()
        ///     label.text = for_text
        ///     return label
        /// </code></para>
        /// <para>Example of usage with a custom scene instance:</para>
        /// <para><code>
        /// func _make_custom_tooltip(for_text):
        ///     var tooltip = preload("res://SomeTooltipScene.tscn").instance()
        ///     tooltip.get_node("Label").text = for_text
        ///     return tooltip
        /// </code></para>
        /// </summary>
        [GodotMethod("_make_custom_tooltip")]
        public virtual Control _MakeCustomTooltip(string forText)
        {
            return default(Control);
        }

        /// <summary>
        /// <para>Godot calls this method to test if <c>data</c> from a control's <see cref="Godot.Control.GetDragData"/> can be dropped at <c>position</c>. <c>position</c> is local to this control.</para>
        /// <para>This method should only be used to test the data. Process the data in <see cref="Godot.Control.DropData"/>.</para>
        /// <para><code>
        /// func can_drop_data(position, data):
        ///     # Check position if it is relevant to you
        ///     # Otherwise, just check data
        ///     return typeof(data) == TYPE_DICTIONARY and data.has("expected")
        /// </code></para>
        /// </summary>
        [GodotMethod("can_drop_data")]
        public virtual bool CanDropData(Vector2 position, object data)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Godot calls this method to pass you the <c>data</c> from a control's <see cref="Godot.Control.GetDragData"/> result. Godot first calls <see cref="Godot.Control.CanDropData"/> to test if <c>data</c> is allowed to drop at <c>position</c> where <c>position</c> is local to this control.</para>
        /// <para><code>
        /// func can_drop_data(position, data):
        ///     return typeof(data) == TYPE_DICTIONARY and data.has("color")
        /// 
        /// func drop_data(position, data):
        ///     color = data["color"]
        /// </code></para>
        /// </summary>
        [GodotMethod("drop_data")]
        public virtual void DropData(Vector2 position, object data)
        {
            return;
        }

        /// <summary>
        /// <para>Godot calls this method to get data that can be dragged and dropped onto controls that expect drop data. Returns <c>null</c> if there is no data to drag. Controls that want to receive drop data should implement <see cref="Godot.Control.CanDropData"/> and <see cref="Godot.Control.DropData"/>. <c>position</c> is local to this control. Drag may be forced with <see cref="Godot.Control.ForceDrag"/>.</para>
        /// <para>A preview that will follow the mouse that should represent the data can be set with <see cref="Godot.Control.SetDragPreview"/>. A good time to set the preview is in this method.</para>
        /// <para><code>
        /// func get_drag_data(position):
        ///     var mydata = make_data()
        ///     set_drag_preview(make_preview(mydata))
        ///     return mydata
        /// </code></para>
        /// </summary>
        [GodotMethod("get_drag_data")]
        public virtual object GetDragData(Vector2 position)
        {
            return default(object);
        }

        /// <summary>
        /// <para>Virtual method to be implemented by the user. Returns whether the given <c>point</c> is inside this control.</para>
        /// <para>If not overridden, default behavior is checking if the point is within control's Rect.</para>
        /// <para>Note: If you want to check if a point is inside the control, you can use <c>get_rect().has_point(point)</c>.</para>
        /// </summary>
        [GodotMethod("has_point")]
        public virtual bool HasPoint(Vector2 point)
        {
            return default(bool);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "accept_event");

        /// <summary>
        /// <para>Marks an input event as handled. Once you accept an input event, it stops propagating, even to nodes listening to <see cref="Godot.Node._UnhandledInput"/> or <see cref="Godot.Node._UnhandledKeyInput"/>.</para>
        /// </summary>
        [GodotMethod("accept_event")]
        public void AcceptEvent()
        {
            NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minimum_size");

        /// <summary>
        /// <para>Returns the minimum size for this control. See <see cref="Godot.Control.RectMinSize"/>.</para>
        /// </summary>
        [GodotMethod("get_minimum_size")]
        public Vector2 GetMinimumSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_1, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_combined_minimum_size");

        /// <summary>
        /// <para>Returns combined minimum size from <see cref="Godot.Control.RectMinSize"/> and <see cref="Godot.Control.GetMinimumSize"/>.</para>
        /// </summary>
        [GodotMethod("get_combined_minimum_size")]
        public Vector2 GetCombinedMinimumSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_2, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchors_preset");

        /// <summary>
        /// <para>Sets the anchors to a <c>preset</c> from <see cref="Godot.Control.LayoutPreset"/> enum. This is the code equivalent to using the Layout menu in the 2D editor.</para>
        /// <para>If <c>keep_margins</c> is <c>true</c>, control's position will also be updated.</para>
        /// </summary>
        [GodotMethod("set_anchors_preset")]
        public void SetAnchorsPreset(Control.LayoutPreset preset, bool keepMargins = false)
        {
            NativeCalls.godot_icall_2_23(method_bind_3, Object.GetPtr(this), (int)preset, keepMargins);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margins_preset");

        /// <summary>
        /// <para>Sets the margins to a <c>preset</c> from <see cref="Godot.Control.LayoutPreset"/> enum. This is the code equivalent to using the Layout menu in the 2D editor.</para>
        /// <para>Use parameter <c>resize_mode</c> with constants from <see cref="Godot.Control.LayoutPresetMode"/> to better determine the resulting size of the <see cref="Godot.Control"/>. Constant size will be ignored if used with presets that change size, e.g. <c>PRESET_LEFT_WIDE</c>.</para>
        /// <para>Use parameter <c>margin</c> to determine the gap between the <see cref="Godot.Control"/> and the edges.</para>
        /// </summary>
        [GodotMethod("set_margins_preset")]
        public void SetMarginsPreset(Control.LayoutPreset preset, Control.LayoutPresetMode resizeMode = (Control.LayoutPresetMode)0, int margin = 0)
        {
            NativeCalls.godot_icall_3_176(method_bind_4, Object.GetPtr(this), (int)preset, (int)resizeMode, margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchors_and_margins_preset");

        /// <summary>
        /// <para>Sets both anchor preset and margin preset. See <see cref="Godot.Control.SetAnchorsPreset"/> and <see cref="Godot.Control.SetMarginsPreset"/>.</para>
        /// </summary>
        [GodotMethod("set_anchors_and_margins_preset")]
        public void SetAnchorsAndMarginsPreset(Control.LayoutPreset preset, Control.LayoutPresetMode resizeMode = (Control.LayoutPresetMode)0, int margin = 0)
        {
            NativeCalls.godot_icall_3_176(method_bind_5, Object.GetPtr(this), (int)preset, (int)resizeMode, margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_anchor");

        [Obsolete("_SetAnchor is deprecated. Use the AnchorBottom property instead.")]
        internal void _SetAnchor(Margin margin, float anchor)
        {
            NativeCalls.godot_icall_2_34(method_bind_6, Object.GetPtr(this), (int)margin, anchor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchor");

        /// <summary>
        /// <para>Sets the anchor identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum to value <c>anchor</c>. A setter method for <see cref="Godot.Control.AnchorBottom"/>, <see cref="Godot.Control.AnchorLeft"/>, <see cref="Godot.Control.AnchorRight"/> and <see cref="Godot.Control.AnchorTop"/>.</para>
        /// <para>If <c>keep_margin</c> is <c>true</c>, margins aren't updated after this operation.</para>
        /// <para>If <c>push_opposite_anchor</c> is <c>true</c> and the opposite anchor overlaps this anchor, the opposite one will have its value overridden. For example, when setting left anchor to 1 and the right anchor has value of 0.5, the right anchor will also get value of 1. If <c>push_opposite_anchor</c> was <c>false</c>, the left anchor would get value 0.5.</para>
        /// </summary>
        [GodotMethod("set_anchor")]
        public void SetAnchor(Margin margin, float anchor, bool keepMargin = false, bool pushOppositeAnchor = true)
        {
            NativeCalls.godot_icall_4_312(method_bind_7, Object.GetPtr(this), (int)margin, anchor, keepMargin, pushOppositeAnchor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_anchor");

        /// <summary>
        /// <para>Returns the anchor identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum. A getter method for <see cref="Godot.Control.AnchorBottom"/>, <see cref="Godot.Control.AnchorLeft"/>, <see cref="Godot.Control.AnchorRight"/> and <see cref="Godot.Control.AnchorTop"/>.</para>
        /// </summary>
        [GodotMethod("get_anchor")]
        [Obsolete("GetAnchor is deprecated. Use the AnchorBottom property instead.")]
        public float GetAnchor(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_8, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_margin");

        /// <summary>
        /// <para>Sets the margin identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum to given <c>offset</c>. A setter method for <see cref="Godot.Control.MarginBottom"/>, <see cref="Godot.Control.MarginLeft"/>, <see cref="Godot.Control.MarginRight"/> and <see cref="Godot.Control.MarginTop"/>.</para>
        /// </summary>
        [GodotMethod("set_margin")]
        [Obsolete("SetMargin is deprecated. Use the MarginBottom property instead.")]
        public void SetMargin(Margin margin, float offset)
        {
            NativeCalls.godot_icall_2_34(method_bind_9, Object.GetPtr(this), (int)margin, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_anchor_and_margin");

        /// <summary>
        /// <para>Works the same as <see cref="Godot.Control.SetAnchor"/>, but instead of <c>keep_margin</c> argument and automatic update of margin, it allows to set the margin offset yourself (see <see cref="Godot.Control.SetMargin"/>).</para>
        /// </summary>
        [GodotMethod("set_anchor_and_margin")]
        public void SetAnchorAndMargin(Margin margin, float anchor, float offset, bool pushOppositeAnchor = false)
        {
            NativeCalls.godot_icall_4_313(method_bind_10, Object.GetPtr(this), (int)margin, anchor, offset, pushOppositeAnchor);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_begin");

        /// <summary>
        /// <para>Sets <see cref="Godot.Control.MarginLeft"/> and <see cref="Godot.Control.MarginTop"/> at the same time. Equivalent of changing <see cref="Godot.Control.RectPosition"/>.</para>
        /// </summary>
        [GodotMethod("set_begin")]
        public void SetBegin(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_11, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_end");

        /// <summary>
        /// <para>Sets <see cref="Godot.Control.MarginRight"/> and <see cref="Godot.Control.MarginBottom"/> at the same time.</para>
        /// </summary>
        [GodotMethod("set_end")]
        public void SetEnd(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_12, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_position");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Control.RectPosition"/> to given <c>position</c>.</para>
        /// <para>If <c>keep_margins</c> is <c>true</c>, control's anchors will be updated instead of margins.</para>
        /// </summary>
        [GodotMethod("set_position")]
        public void SetPosition(Vector2 position, bool keepMargins = false)
        {
            NativeCalls.godot_icall_2_211(method_bind_13, Object.GetPtr(this), ref position, keepMargins);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_position");

        [Obsolete("_SetPosition is deprecated. Use the RectPosition property instead.")]
        internal void _SetPosition(Vector2 margin)
        {
            NativeCalls.godot_icall_1_57(method_bind_14, Object.GetPtr(this), ref margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        /// <summary>
        /// <para>Sets the size (see <see cref="Godot.Control.RectSize"/>).</para>
        /// <para>If <c>keep_margins</c> is <c>true</c>, control's anchors will be updated instead of margins.</para>
        /// </summary>
        [GodotMethod("set_size")]
        public void SetSize(Vector2 size, bool keepMargins = false)
        {
            NativeCalls.godot_icall_2_211(method_bind_15, Object.GetPtr(this), ref size, keepMargins);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_size");

        [Obsolete("_SetSize is deprecated. Use the RectSize property instead.")]
        internal void _SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_16, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_custom_minimum_size");

        [GodotMethod("set_custom_minimum_size")]
        [Obsolete("SetCustomMinimumSize is deprecated. Use the RectMinSize property instead.")]
        public void SetCustomMinimumSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_17, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_global_position");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Control.RectGlobalPosition"/> to given <c>position</c>.</para>
        /// <para>If <c>keep_margins</c> is <c>true</c>, control's anchors will be updated instead of margins.</para>
        /// </summary>
        [GodotMethod("set_global_position")]
        public void SetGlobalPosition(Vector2 position, bool keepMargins = false)
        {
            NativeCalls.godot_icall_2_211(method_bind_18, Object.GetPtr(this), ref position, keepMargins);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_global_position");

        [Obsolete("_SetGlobalPosition is deprecated. Use the RectGlobalPosition property instead.")]
        internal void _SetGlobalPosition(Vector2 position)
        {
            NativeCalls.godot_icall_1_57(method_bind_19, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation");

        /// <summary>
        /// <para>Sets the rotation (in radians).</para>
        /// </summary>
        [GodotMethod("set_rotation")]
        public void SetRotation(float radians)
        {
            NativeCalls.godot_icall_1_15(method_bind_20, Object.GetPtr(this), radians);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_rotation_degrees");

        [GodotMethod("set_rotation_degrees")]
        [Obsolete("SetRotationDegrees is deprecated. Use the RectRotation property instead.")]
        public void SetRotationDegrees(float degrees)
        {
            NativeCalls.godot_icall_1_15(method_bind_21, Object.GetPtr(this), degrees);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scale");

        [GodotMethod("set_scale")]
        [Obsolete("SetScale is deprecated. Use the RectScale property instead.")]
        public void SetScale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_57(method_bind_22, Object.GetPtr(this), ref scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pivot_offset");

        [GodotMethod("set_pivot_offset")]
        [Obsolete("SetPivotOffset is deprecated. Use the RectPivotOffset property instead.")]
        public void SetPivotOffset(Vector2 pivotOffset)
        {
            NativeCalls.godot_icall_1_57(method_bind_23, Object.GetPtr(this), ref pivotOffset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        /// <summary>
        /// <para>Returns the anchor identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum. A getter method for <see cref="Godot.Control.MarginBottom"/>, <see cref="Godot.Control.MarginLeft"/>, <see cref="Godot.Control.MarginRight"/> and <see cref="Godot.Control.MarginTop"/>.</para>
        /// </summary>
        [GodotMethod("get_margin")]
        [Obsolete("GetMargin is deprecated. Use the MarginBottom property instead.")]
        public float GetMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_24, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_begin");

        /// <summary>
        /// <para>Returns <see cref="Godot.Control.MarginLeft"/> and <see cref="Godot.Control.MarginTop"/>. See also <see cref="Godot.Control.RectPosition"/>.</para>
        /// </summary>
        [GodotMethod("get_begin")]
        public Vector2 GetBegin()
        {
            NativeCalls.godot_icall_0_18(method_bind_25, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_end");

        /// <summary>
        /// <para>Returns <see cref="Godot.Control.MarginRight"/> and <see cref="Godot.Control.MarginBottom"/>.</para>
        /// </summary>
        [GodotMethod("get_end")]
        public Vector2 GetEnd()
        {
            NativeCalls.godot_icall_0_18(method_bind_26, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_position");

        [GodotMethod("get_position")]
        [Obsolete("GetPosition is deprecated. Use the RectPosition property instead.")]
        public Vector2 GetPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_27, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        [GodotMethod("get_size")]
        [Obsolete("GetSize is deprecated. Use the RectSize property instead.")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_28, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation");

        /// <summary>
        /// <para>Returns the rotation (in radians).</para>
        /// </summary>
        [GodotMethod("get_rotation")]
        public float GetRotation()
        {
            return NativeCalls.godot_icall_0_14(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rotation_degrees");

        [GodotMethod("get_rotation_degrees")]
        [Obsolete("GetRotationDegrees is deprecated. Use the RectRotation property instead.")]
        public float GetRotationDegrees()
        {
            return NativeCalls.godot_icall_0_14(method_bind_30, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scale");

        [GodotMethod("get_scale")]
        [Obsolete("GetScale is deprecated. Use the RectScale property instead.")]
        public Vector2 GetScale()
        {
            NativeCalls.godot_icall_0_18(method_bind_31, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pivot_offset");

        [GodotMethod("get_pivot_offset")]
        [Obsolete("GetPivotOffset is deprecated. Use the RectPivotOffset property instead.")]
        public Vector2 GetPivotOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_32, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_custom_minimum_size");

        [GodotMethod("get_custom_minimum_size")]
        [Obsolete("GetCustomMinimumSize is deprecated. Use the RectMinSize property instead.")]
        public Vector2 GetCustomMinimumSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_33, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_area_size");

        /// <summary>
        /// <para>Returns the width/height occupied in the parent control.</para>
        /// </summary>
        [GodotMethod("get_parent_area_size")]
        public Vector2 GetParentAreaSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_34, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_position");

        [GodotMethod("get_global_position")]
        [Obsolete("GetGlobalPosition is deprecated. Use the RectGlobalPosition property instead.")]
        public Vector2 GetGlobalPosition()
        {
            NativeCalls.godot_icall_0_18(method_bind_35, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_rect");

        /// <summary>
        /// <para>Returns the position and size of the control relative to the top-left corner of the parent Control. See <see cref="Godot.Control.RectPosition"/> and <see cref="Godot.Control.RectSize"/>.</para>
        /// </summary>
        [GodotMethod("get_rect")]
        public Rect2 GetRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_36, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_global_rect");

        /// <summary>
        /// <para>Returns the position and size of the control relative to the top-left corner of the screen. See <see cref="Godot.Control.RectPosition"/> and <see cref="Godot.Control.RectSize"/>.</para>
        /// </summary>
        [GodotMethod("get_global_rect")]
        public Rect2 GetGlobalRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_37, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "show_modal");

        /// <summary>
        /// <para>Displays a control as modal. Control must be a subwindow. Modal controls capture the input signals until closed or the area outside them is accessed. When a modal control loses focus, or the ESC key is pressed, they automatically hide. Modal controls are used extensively for popup dialogs and menus.</para>
        /// <para>If <c>exclusive</c> is <c>true</c>, other controls will not receive input and clicking outside this control will not close it.</para>
        /// </summary>
        [GodotMethod("show_modal")]
        public void ShowModal(bool exclusive = false)
        {
            NativeCalls.godot_icall_1_16(method_bind_38, Object.GetPtr(this), exclusive);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_focus_mode");

        [GodotMethod("set_focus_mode")]
        [Obsolete("SetFocusMode is deprecated. Use the FocusMode property instead.")]
        public void SetFocusMode(Control.FocusModeEnum mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_39, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focus_mode");

        [GodotMethod("get_focus_mode")]
        [Obsolete("GetFocusMode is deprecated. Use the FocusMode property instead.")]
        public Control.FocusModeEnum GetFocusMode()
        {
            return (Control.FocusModeEnum)NativeCalls.godot_icall_0_207(method_bind_40, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_focus");

        /// <summary>
        /// <para>Returns <c>true</c> if this is the current focused control. See <see cref="Godot.Control.FocusMode"/>.</para>
        /// </summary>
        [GodotMethod("has_focus")]
        public bool HasFocus()
        {
            return NativeCalls.godot_icall_0_7(method_bind_41, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "grab_focus");

        /// <summary>
        /// <para>Steal the focus from another control and become the focused control (see <see cref="Godot.Control.FocusMode"/>).</para>
        /// <para>Note: Using this method together with <see cref="Godot.Object.CallDeferred"/> makes it more reliable, especially when called inside <see cref="Godot.Node._Ready"/>.</para>
        /// </summary>
        [GodotMethod("grab_focus")]
        public void GrabFocus()
        {
            NativeCalls.godot_icall_0_3(method_bind_42, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "release_focus");

        /// <summary>
        /// <para>Give up the focus. No other control will be able to receive keyboard input.</para>
        /// </summary>
        [GodotMethod("release_focus")]
        public void ReleaseFocus()
        {
            NativeCalls.godot_icall_0_3(method_bind_43, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_prev_valid_focus");

        /// <summary>
        /// <para>Finds the previous (above in the tree) <see cref="Godot.Control"/> that can receive the focus.</para>
        /// </summary>
        [GodotMethod("find_prev_valid_focus")]
        public Control FindPrevValidFocus()
        {
            return NativeCalls.godot_icall_0_314(method_bind_44, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "find_next_valid_focus");

        /// <summary>
        /// <para>Finds the next (below in the tree) <see cref="Godot.Control"/> that can receive the focus.</para>
        /// </summary>
        [GodotMethod("find_next_valid_focus")]
        public Control FindNextValidFocus()
        {
            return NativeCalls.godot_icall_0_314(method_bind_45, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focus_owner");

        /// <summary>
        /// <para>Returns the control that has the keyboard focus or <c>null</c> if none.</para>
        /// </summary>
        [GodotMethod("get_focus_owner")]
        public Control GetFocusOwner()
        {
            return NativeCalls.godot_icall_0_314(method_bind_46, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_size_flags");

        [GodotMethod("set_h_size_flags")]
        [Obsolete("SetHSizeFlags is deprecated. Use the SizeFlagsHorizontal property instead.")]
        public void SetHSizeFlags(int flags)
        {
            NativeCalls.godot_icall_1_4(method_bind_47, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_size_flags");

        [GodotMethod("get_h_size_flags")]
        [Obsolete("GetHSizeFlags is deprecated. Use the SizeFlagsHorizontal property instead.")]
        public int GetHSizeFlags()
        {
            return NativeCalls.godot_icall_0_5(method_bind_48, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_49 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_stretch_ratio");

        [GodotMethod("set_stretch_ratio")]
        [Obsolete("SetStretchRatio is deprecated. Use the SizeFlagsStretchRatio property instead.")]
        public void SetStretchRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_49, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_50 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stretch_ratio");

        [GodotMethod("get_stretch_ratio")]
        [Obsolete("GetStretchRatio is deprecated. Use the SizeFlagsStretchRatio property instead.")]
        public float GetStretchRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_50, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_51 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_size_flags");

        [GodotMethod("set_v_size_flags")]
        [Obsolete("SetVSizeFlags is deprecated. Use the SizeFlagsVertical property instead.")]
        public void SetVSizeFlags(int flags)
        {
            NativeCalls.godot_icall_1_4(method_bind_51, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_52 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_size_flags");

        [GodotMethod("get_v_size_flags")]
        [Obsolete("GetVSizeFlags is deprecated. Use the SizeFlagsVertical property instead.")]
        public int GetVSizeFlags()
        {
            return NativeCalls.godot_icall_0_5(method_bind_52, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_53 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_theme");

        [GodotMethod("set_theme")]
        [Obsolete("SetTheme is deprecated. Use the Theme property instead.")]
        public void SetTheme(Theme theme)
        {
            NativeCalls.godot_icall_1_24(method_bind_53, Object.GetPtr(this), Object.GetPtr(theme));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_54 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme");

        [GodotMethod("get_theme")]
        [Obsolete("GetTheme is deprecated. Use the Theme property instead.")]
        public Theme GetTheme()
        {
            return NativeCalls.godot_icall_0_315(method_bind_54, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_55 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_theme_type_variation");

        [GodotMethod("set_theme_type_variation")]
        [Obsolete("SetThemeTypeVariation is deprecated. Use the ThemeTypeVariation property instead.")]
        public void SetThemeTypeVariation(string themeType)
        {
            NativeCalls.godot_icall_1_54(method_bind_55, Object.GetPtr(this), themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_56 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme_type_variation");

        [GodotMethod("get_theme_type_variation")]
        [Obsolete("GetThemeTypeVariation is deprecated. Use the ThemeTypeVariation property instead.")]
        public string GetThemeTypeVariation()
        {
            return NativeCalls.godot_icall_0_6(method_bind_56, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_57 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_icon_override");

        /// <summary>
        /// <para>Creates a local override for a theme icon with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>Note: An override can be removed by assigning it a <c>null</c> value. This behavior is deprecated and will be removed in 4.0, use <see cref="Godot.Control.RemoveIconOverride"/> instead.</para>
        /// <para>See also <see cref="Godot.Control.GetIcon"/>.</para>
        /// </summary>
        [GodotMethod("add_icon_override")]
        public void AddIconOverride(string name, Texture texture)
        {
            NativeCalls.godot_icall_2_114(method_bind_57, Object.GetPtr(this), name, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_58 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_shader_override");

        /// <summary>
        /// <para>Creates a local override for a theme shader with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>Note: An override can be removed by assigning it a <c>null</c> value. This behavior is deprecated and will be removed in 4.0, use <see cref="Godot.Control.RemoveShaderOverride"/> instead.</para>
        /// </summary>
        [GodotMethod("add_shader_override")]
        public void AddShaderOverride(string name, Shader shader)
        {
            NativeCalls.godot_icall_2_114(method_bind_58, Object.GetPtr(this), name, Object.GetPtr(shader));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_59 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_stylebox_override");

        /// <summary>
        /// <para>Creates a local override for a theme <see cref="Godot.StyleBox"/> with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>Note: An override can be removed by assigning it a <c>null</c> value. This behavior is deprecated and will be removed in 4.0, use <see cref="Godot.Control.RemoveStyleboxOverride"/> instead.</para>
        /// <para>See also <see cref="Godot.Control.GetStylebox"/>.</para>
        /// <para>Example of modifying a property in a StyleBox by duplicating it:</para>
        /// <para><code>
        /// # The snippet below assumes the child node MyButton has a StyleBoxFlat assigned.
        /// # Resources are shared across instances, so we need to duplicate it
        /// # to avoid modifying the appearance of all other buttons.
        /// var new_stylebox_normal = $MyButton.get_stylebox("normal").duplicate()
        /// new_stylebox_normal.border_width_top = 3
        /// new_stylebox_normal.border_color = Color(0, 1, 0.5)
        /// $MyButton.add_stylebox_override("normal", new_stylebox_normal)
        /// # Remove the stylebox override.
        /// $MyButton.add_stylebox_override("normal", null)
        /// </code></para>
        /// </summary>
        [GodotMethod("add_stylebox_override")]
        public void AddStyleboxOverride(string name, StyleBox stylebox)
        {
            NativeCalls.godot_icall_2_114(method_bind_59, Object.GetPtr(this), name, Object.GetPtr(stylebox));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_60 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_font_override");

        /// <summary>
        /// <para>Creates a local override for a theme <see cref="Godot.Font"/> with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>Note: An override can be removed by assigning it a <c>null</c> value. This behavior is deprecated and will be removed in 4.0, use <see cref="Godot.Control.RemoveFontOverride"/> instead.</para>
        /// <para>See also <see cref="Godot.Control.GetFont"/>.</para>
        /// </summary>
        [GodotMethod("add_font_override")]
        public void AddFontOverride(string name, Font font)
        {
            NativeCalls.godot_icall_2_114(method_bind_60, Object.GetPtr(this), name, Object.GetPtr(font));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_61 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_color_override");

        /// <summary>
        /// <para>Creates a local override for a theme <see cref="Godot.Color"/> with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>See also <see cref="Godot.Control.GetColor"/>, <see cref="Godot.Control.RemoveColorOverride"/>.</para>
        /// <para>Example of overriding a label's color and resetting it later:</para>
        /// <para><code>
        /// # Given the child Label node "MyLabel", override its font color with a custom value.
        /// $MyLabel.add_color_override("font_color", Color(1, 0.5, 0))
        /// # Reset the font color of the child label.
        /// $MyLabel.add_color_override("font_color", get_color("font_color", "Label"))
        /// </code></para>
        /// </summary>
        [GodotMethod("add_color_override")]
        public void AddColorOverride(string name, Color color)
        {
            NativeCalls.godot_icall_2_316(method_bind_61, Object.GetPtr(this), name, ref color);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_62 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_constant_override");

        /// <summary>
        /// <para>Creates a local override for a theme constant with the specified <c>name</c>. Local overrides always take precedence when fetching theme items for the control.</para>
        /// <para>See also <see cref="Godot.Control.GetConstant"/>, <see cref="Godot.Control.RemoveConstantOverride"/>.</para>
        /// </summary>
        [GodotMethod("add_constant_override")]
        public void AddConstantOverride(string name, int constant)
        {
            NativeCalls.godot_icall_2_110(method_bind_62, Object.GetPtr(this), name, constant);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_63 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_icon_override");

        /// <summary>
        /// <para>Removes a theme override for an icon with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_icon_override")]
        public void RemoveIconOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_63, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_64 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_shader_override");

        /// <summary>
        /// <para>Removes a theme override for a shader with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_shader_override")]
        public void RemoveShaderOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_64, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_65 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_stylebox_override");

        /// <summary>
        /// <para>Removes a theme override for a <see cref="Godot.StyleBox"/> with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_stylebox_override")]
        public void RemoveStyleboxOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_65, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_66 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_font_override");

        /// <summary>
        /// <para>Removes a theme override for a <see cref="Godot.Font"/> with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_font_override")]
        public void RemoveFontOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_66, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_67 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_color_override");

        /// <summary>
        /// <para>Removes a theme override for a <see cref="Godot.Color"/> with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_color_override")]
        public void RemoveColorOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_67, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_68 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_constant_override");

        /// <summary>
        /// <para>Removes a theme override for a constant with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("remove_constant_override")]
        public void RemoveConstantOverride(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_68, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_69 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_icon");

        /// <summary>
        /// <para>Returns an icon from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has an icon item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("get_icon")]
        public Texture GetIcon(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_317(method_bind_69, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_70 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stylebox");

        /// <summary>
        /// <para>Returns a <see cref="Godot.StyleBox"/> from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has a stylebox item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("get_stylebox")]
        public StyleBox GetStylebox(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_318(method_bind_70, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_71 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_font");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Font"/> from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has a font item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("get_font")]
        public Font GetFont(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_319(method_bind_71, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_72 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_color");

        /// <summary>
        /// <para>Returns a <see cref="Godot.Color"/> from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has a color item with the specified <c>name</c> and <c>theme_type</c>. If <c>theme_type</c> is omitted the class name of the current control is used as the type, or <see cref="Godot.Control.ThemeTypeVariation"/> if it is defined. If the type is a class name its parent classes are also checked, in order of inheritance.</para>
        /// <para>For the current control its local overrides are considered first (see <see cref="Godot.Control.AddColorOverride"/>), then its assigned <see cref="Godot.Control.Theme"/>. After the current control, each parent control and its assigned <see cref="Godot.Control.Theme"/> are considered; controls without a <see cref="Godot.Control.Theme"/> assigned are skipped. If no matching <see cref="Godot.Theme"/> is found in the tree, a custom project <see cref="Godot.Theme"/> (see ) and the default <see cref="Godot.Theme"/> are used.</para>
        /// <para><code>
        /// func _ready():
        ///     # Get the font color defined for the current Control's class, if it exists.
        ///     modulate = get_color("font_color")
        ///     # Get the font color defined for the Button class.
        ///     modulate = get_color("font_color", "Button")
        /// </code></para>
        /// </summary>
        [GodotMethod("get_color")]
        public Color GetColor(string name, string themeType = "")
        {
            NativeCalls.godot_icall_2_320(method_bind_72, Object.GetPtr(this), name, themeType, out Color argRet); return (Color)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_73 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_constant");

        /// <summary>
        /// <para>Returns a constant from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has a constant item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("get_constant")]
        public int GetConstant(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_321(method_bind_73, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_74 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_icon_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme icon with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddIconOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_icon_override")]
        public bool HasIconOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_74, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_75 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_shader_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme shader with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddShaderOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_shader_override")]
        public bool HasShaderOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_75, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_76 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_stylebox_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme <see cref="Godot.StyleBox"/> with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddStyleboxOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_stylebox_override")]
        public bool HasStyleboxOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_76, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_77 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_font_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme <see cref="Godot.Font"/> with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddFontOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_font_override")]
        public bool HasFontOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_77, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_78 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_color_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme <see cref="Godot.Color"/> with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddColorOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_color_override")]
        public bool HasColorOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_78, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_79 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_constant_override");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a local override for a theme constant with the specified <c>name</c> in this <see cref="Godot.Control"/> node.</para>
        /// <para>See <see cref="Godot.Control.AddConstantOverride"/>.</para>
        /// </summary>
        [GodotMethod("has_constant_override")]
        public bool HasConstantOverride(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_79, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_80 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_icon");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a matching <see cref="Godot.Theme"/> in the tree that has an icon item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("has_icon")]
        public bool HasIcon(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_80, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_81 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_stylebox");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a matching <see cref="Godot.Theme"/> in the tree that has a stylebox item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("has_stylebox")]
        public bool HasStylebox(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_81, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_82 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_font");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a matching <see cref="Godot.Theme"/> in the tree that has a font item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("has_font")]
        public bool HasFont(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_82, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_83 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_color");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a matching <see cref="Godot.Theme"/> in the tree that has a color item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("has_color")]
        public bool HasColor(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_83, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_84 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_constant");

        /// <summary>
        /// <para>Returns <c>true</c> if there is a matching <see cref="Godot.Theme"/> in the tree that has a constant item with the specified <c>name</c> and <c>theme_type</c>.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("has_constant")]
        public bool HasConstant(string name, string themeType = "")
        {
            return NativeCalls.godot_icall_2_116(method_bind_84, Object.GetPtr(this), name, themeType);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_85 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_theme_default_font");

        /// <summary>
        /// <para>Returns the default font from the first matching <see cref="Godot.Theme"/> in the tree if that <see cref="Godot.Theme"/> has a valid <see cref="Godot.Theme.DefaultFont"/> value.</para>
        /// <para>See <see cref="Godot.Control.GetColor"/> for details.</para>
        /// </summary>
        [GodotMethod("get_theme_default_font")]
        public Font GetThemeDefaultFont()
        {
            return NativeCalls.godot_icall_0_322(method_bind_85, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_86 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_control");

        /// <summary>
        /// <para>Returns the parent control node.</para>
        /// </summary>
        [GodotMethod("get_parent_control")]
        public Control GetParentControl()
        {
            return NativeCalls.godot_icall_0_314(method_bind_86, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_87 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_h_grow_direction");

        [GodotMethod("set_h_grow_direction")]
        [Obsolete("SetHGrowDirection is deprecated. Use the GrowHorizontal property instead.")]
        public void SetHGrowDirection(Control.GrowDirection direction)
        {
            NativeCalls.godot_icall_1_4(method_bind_87, Object.GetPtr(this), (int)direction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_88 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_h_grow_direction");

        [GodotMethod("get_h_grow_direction")]
        [Obsolete("GetHGrowDirection is deprecated. Use the GrowHorizontal property instead.")]
        public Control.GrowDirection GetHGrowDirection()
        {
            return (Control.GrowDirection)NativeCalls.godot_icall_0_323(method_bind_88, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_89 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_v_grow_direction");

        [GodotMethod("set_v_grow_direction")]
        [Obsolete("SetVGrowDirection is deprecated. Use the GrowVertical property instead.")]
        public void SetVGrowDirection(Control.GrowDirection direction)
        {
            NativeCalls.godot_icall_1_4(method_bind_89, Object.GetPtr(this), (int)direction);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_90 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_v_grow_direction");

        [GodotMethod("get_v_grow_direction")]
        [Obsolete("GetVGrowDirection is deprecated. Use the GrowVertical property instead.")]
        public Control.GrowDirection GetVGrowDirection()
        {
            return (Control.GrowDirection)NativeCalls.godot_icall_0_323(method_bind_90, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_91 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_tooltip");

        [GodotMethod("set_tooltip")]
        [Obsolete("SetTooltip is deprecated. Use the HintTooltip property instead.")]
        public void SetTooltip(string tooltip)
        {
            NativeCalls.godot_icall_1_54(method_bind_91, Object.GetPtr(this), tooltip);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_92 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_tooltip");

        /// <summary>
        /// <para>Returns the tooltip, which will appear when the cursor is resting over this control. See <see cref="Godot.Control.HintTooltip"/>.</para>
        /// </summary>
        /// <param name="atPosition">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("get_tooltip")]
        public string GetTooltip(Nullable<Vector2> atPosition = null)
        {
            Vector2 atPosition_in = atPosition.HasValue ? atPosition.Value : new Vector2(0, 0);
            return NativeCalls.godot_icall_1_324(method_bind_92, Object.GetPtr(this), ref atPosition_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_93 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_tooltip");

        [Obsolete("_GetTooltip is deprecated. Use the HintTooltip property instead.")]
        internal string _GetTooltip()
        {
            return NativeCalls.godot_icall_0_6(method_bind_93, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_94 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_cursor_shape");

        [GodotMethod("set_default_cursor_shape")]
        [Obsolete("SetDefaultCursorShape is deprecated. Use the MouseDefaultCursorShape property instead.")]
        public void SetDefaultCursorShape(Control.CursorShape shape)
        {
            NativeCalls.godot_icall_1_4(method_bind_94, Object.GetPtr(this), (int)shape);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_95 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_cursor_shape");

        [GodotMethod("get_default_cursor_shape")]
        [Obsolete("GetDefaultCursorShape is deprecated. Use the MouseDefaultCursorShape property instead.")]
        public Control.CursorShape GetDefaultCursorShape()
        {
            return (Control.CursorShape)NativeCalls.godot_icall_0_325(method_bind_95, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_96 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cursor_shape");

        /// <summary>
        /// <para>Returns the mouse cursor shape the control displays on mouse hover. See <see cref="Godot.Control.CursorShape"/>.</para>
        /// </summary>
        /// <param name="position">If the parameter is null, then the default value is new Vector2(0, 0)</param>
        [GodotMethod("get_cursor_shape")]
        public Control.CursorShape GetCursorShape(Nullable<Vector2> position = null)
        {
            Vector2 position_in = position.HasValue ? position.Value : new Vector2(0, 0);
            return (Control.CursorShape)NativeCalls.godot_icall_1_326(method_bind_96, Object.GetPtr(this), ref position_in);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_97 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_focus_neighbour");

        /// <summary>
        /// <para>Sets the anchor identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum to <see cref="Godot.Control"/> at <c>neighbor</c> node path. A setter method for <see cref="Godot.Control.FocusNeighbourBottom"/>, <see cref="Godot.Control.FocusNeighbourLeft"/>, <see cref="Godot.Control.FocusNeighbourRight"/> and <see cref="Godot.Control.FocusNeighbourTop"/>.</para>
        /// </summary>
        [GodotMethod("set_focus_neighbour")]
        [Obsolete("SetFocusNeighbour is deprecated. Use the FocusNeighbourBottom property instead.")]
        public void SetFocusNeighbour(Margin margin, NodePath neighbour)
        {
            NativeCalls.godot_icall_2_63(method_bind_97, Object.GetPtr(this), (int)margin, NodePath.GetPtr(neighbour));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_98 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focus_neighbour");

        /// <summary>
        /// <para>Returns the focus neighbour identified by <c>margin</c> constant from <see cref="Godot.Margin"/> enum. A getter method for <see cref="Godot.Control.FocusNeighbourBottom"/>, <see cref="Godot.Control.FocusNeighbourLeft"/>, <see cref="Godot.Control.FocusNeighbourRight"/> and <see cref="Godot.Control.FocusNeighbourTop"/>.</para>
        /// </summary>
        [GodotMethod("get_focus_neighbour")]
        [Obsolete("GetFocusNeighbour is deprecated. Use the FocusNeighbourBottom property instead.")]
        public NodePath GetFocusNeighbour(Margin margin)
        {
            return new NodePath(NativeCalls.godot_icall_1_62(method_bind_98, Object.GetPtr(this), (int)margin));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_99 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_focus_next");

        [GodotMethod("set_focus_next")]
        [Obsolete("SetFocusNext is deprecated. Use the FocusNext property instead.")]
        public void SetFocusNext(NodePath next)
        {
            NativeCalls.godot_icall_1_129(method_bind_99, Object.GetPtr(this), NodePath.GetPtr(next));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_100 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focus_next");

        [GodotMethod("get_focus_next")]
        [Obsolete("GetFocusNext is deprecated. Use the FocusNext property instead.")]
        public NodePath GetFocusNext()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_100, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_101 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_focus_previous");

        [GodotMethod("set_focus_previous")]
        [Obsolete("SetFocusPrevious is deprecated. Use the FocusPrevious property instead.")]
        public void SetFocusPrevious(NodePath previous)
        {
            NativeCalls.godot_icall_1_129(method_bind_101, Object.GetPtr(this), NodePath.GetPtr(previous));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_102 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_focus_previous");

        [GodotMethod("get_focus_previous")]
        [Obsolete("GetFocusPrevious is deprecated. Use the FocusPrevious property instead.")]
        public NodePath GetFocusPrevious()
        {
            return new NodePath(NativeCalls.godot_icall_0_130(method_bind_102, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_103 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "force_drag");

        /// <summary>
        /// <para>Forces drag and bypasses <see cref="Godot.Control.GetDragData"/> and <see cref="Godot.Control.SetDragPreview"/> by passing <c>data</c> and <c>preview</c>. Drag will start even if the mouse is neither over nor pressed on this control.</para>
        /// <para>The methods <see cref="Godot.Control.CanDropData"/> and <see cref="Godot.Control.DropData"/> must be implemented on controls that want to receive drop data.</para>
        /// </summary>
        [GodotMethod("force_drag")]
        public void ForceDrag(object data, Control preview)
        {
            NativeCalls.godot_icall_2_327(method_bind_103, Object.GetPtr(this), data, Object.GetPtr(preview));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_104 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_mouse_filter");

        [GodotMethod("set_mouse_filter")]
        [Obsolete("SetMouseFilter is deprecated. Use the MouseFilter property instead.")]
        public void SetMouseFilter(Control.MouseFilterEnum filter)
        {
            NativeCalls.godot_icall_1_4(method_bind_104, Object.GetPtr(this), (int)filter);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_105 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_mouse_filter");

        [GodotMethod("get_mouse_filter")]
        [Obsolete("GetMouseFilter is deprecated. Use the MouseFilter property instead.")]
        public Control.MouseFilterEnum GetMouseFilter()
        {
            return (Control.MouseFilterEnum)NativeCalls.godot_icall_0_328(method_bind_105, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_106 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pass_on_modal_close_click");

        [GodotMethod("set_pass_on_modal_close_click")]
        [Obsolete("SetPassOnModalCloseClick is deprecated. Use the InputPassOnModalCloseClick property instead.")]
        public void SetPassOnModalCloseClick(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_106, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_107 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pass_on_modal_close_click");

        [GodotMethod("get_pass_on_modal_close_click")]
        [Obsolete("GetPassOnModalCloseClick is deprecated. Use the InputPassOnModalCloseClick property instead.")]
        public bool GetPassOnModalCloseClick()
        {
            return NativeCalls.godot_icall_0_7(method_bind_107, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_108 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_clip_contents");

        [GodotMethod("set_clip_contents")]
        [Obsolete("SetClipContents is deprecated. Use the RectClipContent property instead.")]
        public void SetClipContents(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_108, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_109 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_clipping_contents");

        [GodotMethod("is_clipping_contents")]
        [Obsolete("IsClippingContents is deprecated. Use the RectClipContent property instead.")]
        public bool IsClippingContents()
        {
            return NativeCalls.godot_icall_0_7(method_bind_109, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_110 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "grab_click_focus");

        /// <summary>
        /// <para>Creates an <see cref="Godot.InputEventMouseButton"/> that attempts to click the control. If the event is received, the control acquires focus.</para>
        /// <para><code>
        /// func _process(delta):
        ///     grab_click_focus() #when clicking another Control node, this node will be clicked instead
        /// </code></para>
        /// </summary>
        [GodotMethod("grab_click_focus")]
        public void GrabClickFocus()
        {
            NativeCalls.godot_icall_0_3(method_bind_110, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_111 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_forwarding");

        /// <summary>
        /// <para>Forwards the handling of this control's drag and drop to <c>target</c> control.</para>
        /// <para>Forwarding can be implemented in the target control similar to the methods <see cref="Godot.Control.GetDragData"/>, <see cref="Godot.Control.CanDropData"/>, and <see cref="Godot.Control.DropData"/> but with two differences:</para>
        /// <para>1. The function name must be suffixed with _fw</para>
        /// <para>2. The function must take an extra argument that is the control doing the forwarding</para>
        /// <para><code>
        /// # ThisControl.gd
        /// extends Control
        /// func _ready():
        ///     set_drag_forwarding(target_control)
        /// 
        /// # TargetControl.gd
        /// extends Control
        /// func can_drop_data_fw(position, data, from_control):
        ///     return true
        /// 
        /// func drop_data_fw(position, data, from_control):
        ///     my_handle_data(data)
        /// 
        /// func get_drag_data_fw(position, from_control):
        ///     set_drag_preview(my_preview)
        ///     return my_data()
        /// </code></para>
        /// </summary>
        [GodotMethod("set_drag_forwarding")]
        public void SetDragForwarding(Control target)
        {
            NativeCalls.godot_icall_1_53(method_bind_111, Object.GetPtr(this), Object.GetPtr(target));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_112 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_drag_preview");

        /// <summary>
        /// <para>Shows the given control at the mouse pointer. A good time to call this method is in <see cref="Godot.Control.GetDragData"/>. The control must not be in the scene tree. You should not free the control, and you should not keep a reference to the control beyond the duration of the drag. It will be deleted automatically after the drag has ended.</para>
        /// <para><code>
        /// export (Color, RGBA) var color = Color(1, 0, 0, 1)
        /// 
        /// func get_drag_data(position):
        ///     # Use a control that is not in the tree
        ///     var cpb = ColorPickerButton.new()
        ///     cpb.color = color
        ///     cpb.rect_size = Vector2(50, 50)
        ///     set_drag_preview(cpb)
        ///     return color
        /// </code></para>
        /// </summary>
        [GodotMethod("set_drag_preview")]
        public void SetDragPreview(Control control)
        {
            NativeCalls.godot_icall_1_53(method_bind_112, Object.GetPtr(this), Object.GetPtr(control));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_113 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_drag_successful");

        /// <summary>
        /// <para>Returns <c>true</c> if a drag operation is successful. Alternative to <see cref="Godot.Viewport.GuiIsDragSuccessful"/>.</para>
        /// <para>Best used with <see cref="Godot.Node.NotificationDragEnd"/>.</para>
        /// </summary>
        [GodotMethod("is_drag_successful")]
        public bool IsDragSuccessful()
        {
            return NativeCalls.godot_icall_0_7(method_bind_113, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_114 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "warp_mouse");

        /// <summary>
        /// <para>Moves the mouse cursor to <c>to_position</c>, relative to <see cref="Godot.Control.RectPosition"/> of this <see cref="Godot.Control"/>.</para>
        /// </summary>
        [GodotMethod("warp_mouse")]
        public void WarpMouse(Vector2 toPosition)
        {
            NativeCalls.godot_icall_1_57(method_bind_114, Object.GetPtr(this), ref toPosition);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_115 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "minimum_size_changed");

        /// <summary>
        /// <para>Invalidates the size cache in this node and in parent nodes up to toplevel. Intended to be used with <see cref="Godot.Control.GetMinimumSize"/> when the return value is changed. Setting <see cref="Godot.Control.RectMinSize"/> directly calls this method automatically.</para>
        /// </summary>
        [GodotMethod("minimum_size_changed")]
        public void MinimumSizeChanged()
        {
            NativeCalls.godot_icall_0_3(method_bind_115, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
