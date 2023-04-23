using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Sort all child nodes based on their Y positions. The child node must inherit from <see cref="Godot.CanvasItem"/> for it to be sorted. Nodes that have a higher Y position will be drawn later, so they will appear on top of nodes that have a lower Y position.</para>
    /// <para>Nesting of YSort nodes is possible. Children YSort nodes will be sorted in the same space as the parent YSort, allowing to better organize a scene or divide it in multiple ones, yet keep the unique sorting.</para>
    /// </summary>
    public partial class YSort : Node2D
    {
        /// <summary>
        /// <para>If <c>true</c>, child nodes are sorted, otherwise sorting is disabled.</para>
        /// </summary>
        public bool SortEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsSortEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSortEnabled(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "YSort";

        public YSort() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_YSort_Ctor(this);
        }

        internal YSort(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_sort_enabled");

        [GodotMethod("set_sort_enabled")]
        [Obsolete("SetSortEnabled is deprecated. Use the SortEnabled property instead.")]
        public void SetSortEnabled(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_sort_enabled");

        [GodotMethod("is_sort_enabled")]
        [Obsolete("IsSortEnabled is deprecated. Use the SortEnabled property instead.")]
        public bool IsSortEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
