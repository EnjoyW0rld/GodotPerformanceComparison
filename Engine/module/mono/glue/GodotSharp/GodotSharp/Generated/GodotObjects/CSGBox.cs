using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This node allows you to create a box for use with the CSG system.</para>
    /// <para>Note: CSG nodes are intended to be used for level prototyping. Creating CSG nodes has a significant CPU cost compared to creating a <see cref="Godot.MeshInstance"/> with a <see cref="Godot.PrimitiveMesh"/>. Moving a CSG node within another CSG node also has a significant CPU cost, so it should be avoided during gameplay.</para>
    /// </summary>
    public partial class CSGBox : CSGPrimitive
    {
        /// <summary>
        /// <para>Width of the box measured from the center of the box.</para>
        /// </summary>
        public float Width
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetWidth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetWidth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Height of the box measured from the center of the box.</para>
        /// </summary>
        public float Height
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetHeight();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetHeight(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Depth of the box measured from the center of the box.</para>
        /// </summary>
        public float Depth
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDepth();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDepth(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The material used to render the box.</para>
        /// </summary>
        public Material Material
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterial(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CSGBox";

        public CSGBox() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSGBox_Ctor(this);
        }

        internal CSGBox(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_width");

        [GodotMethod("set_width")]
        [Obsolete("SetWidth is deprecated. Use the Width property instead.")]
        public void SetWidth(float width)
        {
            NativeCalls.godot_icall_1_15(method_bind_0, Object.GetPtr(this), width);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        [GodotMethod("get_width")]
        [Obsolete("GetWidth is deprecated. Use the Width property instead.")]
        public float GetWidth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_height");

        [GodotMethod("set_height")]
        [Obsolete("SetHeight is deprecated. Use the Height property instead.")]
        public void SetHeight(float height)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), height);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        [GodotMethod("get_height")]
        [Obsolete("GetHeight is deprecated. Use the Height property instead.")]
        public float GetHeight()
        {
            return NativeCalls.godot_icall_0_14(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_depth");

        [GodotMethod("set_depth")]
        [Obsolete("SetDepth is deprecated. Use the Depth property instead.")]
        public void SetDepth(float depth)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), depth);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_depth");

        [GodotMethod("get_depth")]
        [Obsolete("GetDepth is deprecated. Use the Depth property instead.")]
        public float GetDepth()
        {
            return NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_material");

        [GodotMethod("set_material")]
        [Obsolete("SetMaterial is deprecated. Use the Material property instead.")]
        public void SetMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_6, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_material");

        [GodotMethod("get_material")]
        [Obsolete("GetMaterial is deprecated. Use the Material property instead.")]
        public Material GetMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
