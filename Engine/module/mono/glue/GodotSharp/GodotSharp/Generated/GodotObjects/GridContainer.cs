using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>GridContainer will arrange its Control-derived children in a grid like structure, the grid columns are specified using the <see cref="Godot.GridContainer.Columns"/> property and the number of rows will be equal to the number of children in the container divided by the number of columns. For example, if the container has 5 children, and 2 columns, there will be 3 rows in the container.</para>
    /// <para>Notice that grid layout will preserve the columns and rows for every size of the container, and that empty columns will be expanded automatically.</para>
    /// <para>Note: GridContainer only works with child nodes inheriting from Control. It won't rearrange child nodes inheriting from Node2D.</para>
    /// </summary>
    public partial class GridContainer : Container
    {
        /// <summary>
        /// <para>The number of columns in the <see cref="Godot.GridContainer"/>. If modified, <see cref="Godot.GridContainer"/> reorders its Control-derived children to accommodate the new layout.</para>
        /// </summary>
        public int Columns
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetColumns();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetColumns(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GridContainer";

        public GridContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GridContainer_Ctor(this);
        }

        internal GridContainer(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_columns");

        [GodotMethod("set_columns")]
        [Obsolete("SetColumns is deprecated. Use the Columns property instead.")]
        public void SetColumns(int columns)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), columns);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_columns");

        [GodotMethod("get_columns")]
        [Obsolete("GetColumns is deprecated. Use the Columns property instead.")]
        public int GetColumns()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
