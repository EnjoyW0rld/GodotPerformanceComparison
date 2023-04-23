using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>StyleBox is <see cref="Godot.Resource"/> that provides an abstract base class for drawing stylized boxes for the UI. StyleBoxes are used for drawing the styles of buttons, line edit backgrounds, tree backgrounds, etc. and also for testing a transparency mask for pointer signals. If mask test fails on a StyleBox assigned as mask to a control, clicks and motion signals will go through it to the one below.</para>
    /// <para>Note: For children of <see cref="Godot.Control"/> that have Theme Properties, the <c>focus</c> <see cref="Godot.StyleBox"/> is displayed over the <c>normal</c>, <c>hover</c> or <c>pressed</c> <see cref="Godot.StyleBox"/>. This makes the <c>focus</c> <see cref="Godot.StyleBox"/> more reusable across different nodes.</para>
    /// </summary>
    public abstract partial class StyleBox : Resource
    {
        /// <summary>
        /// <para>The left margin for the contents of this style box.Increasing this value reduces the space available to the contents from the left.</para>
        /// <para>Refer to <see cref="Godot.StyleBox.ContentMarginBottom"/> for extra considerations.</para>
        /// </summary>
        public float ContentMarginLeft
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultMargin((Margin)0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultMargin((Margin)0, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The right margin for the contents of this style box. Increasing this value reduces the space available to the contents from the right.</para>
        /// <para>Refer to <see cref="Godot.StyleBox.ContentMarginBottom"/> for extra considerations.</para>
        /// </summary>
        public float ContentMarginRight
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultMargin((Margin)2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultMargin((Margin)2, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The top margin for the contents of this style box. Increasing this value reduces the space available to the contents from the top.</para>
        /// <para>Refer to <see cref="Godot.StyleBox.ContentMarginBottom"/> for extra considerations.</para>
        /// </summary>
        public float ContentMarginTop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultMargin((Margin)1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultMargin((Margin)1, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The bottom margin for the contents of this style box. Increasing this value reduces the space available to the contents from the bottom.</para>
        /// <para>If this value is negative, it is ignored and a child-specific margin is used instead. For example for <see cref="Godot.StyleBoxFlat"/> the border thickness (if any) is used instead.</para>
        /// <para>It is up to the code using this style box to decide what these contents are: for example, a <see cref="Godot.Button"/> respects this content margin for the textual contents of the button.</para>
        /// <para><see cref="Godot.StyleBox.GetMargin"/> should be used to fetch this value as consumer instead of reading these properties directly. This is because it correctly respects negative values and the fallback mentioned above.</para>
        /// </summary>
        public float ContentMarginBottom
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDefaultMargin((Margin)3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDefaultMargin((Margin)3, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "StyleBox";

        internal StyleBox() {}

        internal StyleBox(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "test_mask");

        /// <summary>
        /// <para>Test a position in a rectangle, return whether it passes the mask test.</para>
        /// </summary>
        [GodotMethod("test_mask")]
        public bool TestMask(Vector2 point, Rect2 rect)
        {
            return NativeCalls.godot_icall_2_900(method_bind_0, Object.GetPtr(this), ref point, ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_default_margin");

        /// <summary>
        /// <para>Sets the default value of the specified <see cref="Godot.Margin"/> to given <c>offset</c> in pixels.</para>
        /// </summary>
        [GodotMethod("set_default_margin")]
        [Obsolete("SetDefaultMargin is deprecated. Use the ContentMarginBottom property instead.")]
        public void SetDefaultMargin(Margin margin, float offset)
        {
            NativeCalls.godot_icall_2_34(method_bind_1, Object.GetPtr(this), (int)margin, offset);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_default_margin");

        /// <summary>
        /// <para>Returns the default value of the specified <see cref="Godot.Margin"/>.</para>
        /// </summary>
        [GodotMethod("get_default_margin")]
        [Obsolete("GetDefaultMargin is deprecated. Use the ContentMarginBottom property instead.")]
        public float GetDefaultMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_2, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_margin");

        /// <summary>
        /// <para>Returns the content margin offset for the specified <see cref="Godot.Margin"/>.</para>
        /// <para>Positive values reduce size inwards, unlike <see cref="Godot.Control"/>'s margin values.</para>
        /// </summary>
        [GodotMethod("get_margin")]
        public float GetMargin(Margin margin)
        {
            return NativeCalls.godot_icall_1_12(method_bind_3, Object.GetPtr(this), (int)margin);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minimum_size");

        /// <summary>
        /// <para>Returns the minimum size that this stylebox can be shrunk to.</para>
        /// </summary>
        [GodotMethod("get_minimum_size")]
        public Vector2 GetMinimumSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_4, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_center_size");

        /// <summary>
        /// <para>Returns the size of this <see cref="Godot.StyleBox"/> without the margins.</para>
        /// </summary>
        [GodotMethod("get_center_size")]
        public Vector2 GetCenterSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_5, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset");

        /// <summary>
        /// <para>Returns the "offset" of a stylebox. This helper function returns a value equivalent to <c>Vector2(style.get_margin(MARGIN_LEFT), style.get_margin(MARGIN_TOP))</c>.</para>
        /// </summary>
        [GodotMethod("get_offset")]
        public Vector2 GetOffset()
        {
            NativeCalls.godot_icall_0_18(method_bind_6, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_item_drawn");

        /// <summary>
        /// <para>Returns the <see cref="Godot.CanvasItem"/> that handles its <see cref="Godot.CanvasItem.NotificationDraw"/> or <see cref="Godot.CanvasItem._Draw"/> callback at this moment.</para>
        /// </summary>
        [GodotMethod("get_current_item_drawn")]
        public CanvasItem GetCurrentItemDrawn()
        {
            return NativeCalls.godot_icall_0_901(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "draw");

        /// <summary>
        /// <para>Draws this stylebox using a canvas item identified by the given <see cref="Godot.RID"/>.</para>
        /// <para>The <see cref="Godot.RID"/> value can either be the result of <see cref="Godot.CanvasItem.GetCanvasItem"/> called on an existing <see cref="Godot.CanvasItem"/>-derived node, or directly from creating a canvas item in the <see cref="Godot.VisualServer"/> with <see cref="Godot.VisualServer.CanvasItemCreate"/>.</para>
        /// </summary>
        [GodotMethod("draw")]
        public void Draw(RID canvasItem, Rect2 rect)
        {
            NativeCalls.godot_icall_2_902(method_bind_8, Object.GetPtr(this), RID.GetPtr(canvasItem), ref rect);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
