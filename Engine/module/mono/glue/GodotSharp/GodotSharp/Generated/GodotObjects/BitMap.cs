using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A two-dimensional array of boolean values, can be used to efficiently store a binary matrix (every matrix element takes only one bit) and query the values using natural cartesian coordinates.</para>
    /// </summary>
    public partial class BitMap : Resource
    {
        public Godot.Collections.Dictionary Data
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetData(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "BitMap";

        public BitMap() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BitMap_Ctor(this);
        }

        internal BitMap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create");

        /// <summary>
        /// <para>Creates a bitmap with the specified size, filled with <c>false</c>.</para>
        /// </summary>
        [GodotMethod("create")]
        public void Create(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_0, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_from_image_alpha");

        /// <summary>
        /// <para>Creates a bitmap that matches the given image dimensions, every element of the bitmap is set to <c>false</c> if the alpha value of the image at that position is equal to <c>threshold</c> or less, and <c>true</c> in other case.</para>
        /// </summary>
        [GodotMethod("create_from_image_alpha")]
        public void CreateFromImageAlpha(Image image, float threshold = 0.1f)
        {
            NativeCalls.godot_icall_2_210(method_bind_1, Object.GetPtr(this), Object.GetPtr(image), threshold);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bit");

        /// <summary>
        /// <para>Sets the bitmap's element at the specified position, to the specified value.</para>
        /// </summary>
        [GodotMethod("set_bit")]
        public void SetBit(Vector2 position, bool bit)
        {
            NativeCalls.godot_icall_2_211(method_bind_2, Object.GetPtr(this), ref position, bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_bit");

        /// <summary>
        /// <para>Returns bitmap's value at the specified position.</para>
        /// </summary>
        [GodotMethod("get_bit")]
        public bool GetBit(Vector2 position)
        {
            return NativeCalls.godot_icall_1_181(method_bind_3, Object.GetPtr(this), ref position);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_bit_rect");

        /// <summary>
        /// <para>Sets a rectangular portion of the bitmap to the specified value.</para>
        /// </summary>
        [GodotMethod("set_bit_rect")]
        public void SetBitRect(Rect2 rect, bool bit)
        {
            NativeCalls.godot_icall_2_212(method_bind_4, Object.GetPtr(this), ref rect, bit);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_true_bit_count");

        /// <summary>
        /// <para>Returns the amount of bitmap elements that are set to <c>true</c>.</para>
        /// </summary>
        [GodotMethod("get_true_bit_count")]
        public int GetTrueBitCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_size");

        /// <summary>
        /// <para>Returns bitmap's dimensions.</para>
        /// </summary>
        [GodotMethod("get_size")]
        public Vector2 GetSize()
        {
            NativeCalls.godot_icall_0_18(method_bind_6, Object.GetPtr(this), out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "resize");

        /// <summary>
        /// <para>Resizes the image to <c>new_size</c>.</para>
        /// </summary>
        [GodotMethod("resize")]
        public void Resize(Vector2 newSize)
        {
            NativeCalls.godot_icall_1_57(method_bind_7, Object.GetPtr(this), ref newSize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the Data property instead.")]
        internal void _SetData(Godot.Collections.Dictionary arg0)
        {
            NativeCalls.godot_icall_1_213(method_bind_8, Object.GetPtr(this), arg0.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the Data property instead.")]
        internal Godot.Collections.Dictionary _GetData()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "grow_mask");

        /// <summary>
        /// <para>Applies morphological dilation or erosion to the bitmap. If <c>pixels</c> is positive, dilation is applied to the bitmap. If <c>pixels</c> is negative, erosion is applied to the bitmap. <c>rect</c> defines the area where the morphological operation is applied. Pixels located outside the <c>rect</c> are unaffected by <see cref="Godot.BitMap.GrowMask"/>.</para>
        /// </summary>
        [GodotMethod("grow_mask")]
        public void GrowMask(int pixels, Rect2 rect)
        {
            NativeCalls.godot_icall_2_215(method_bind_10, Object.GetPtr(this), pixels, ref rect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "convert_to_image");

        /// <summary>
        /// <para>Returns an image of the same size as the bitmap and with a <see cref="Godot.Image.Format"/> of type <c>FORMAT_L8</c>. <c>true</c> bits of the bitmap are being converted into white pixels, and <c>false</c> bits into black.</para>
        /// </summary>
        [GodotMethod("convert_to_image")]
        public Image ConvertToImage()
        {
            return NativeCalls.godot_icall_0_216(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "opaque_to_polygons");

        [GodotMethod("opaque_to_polygons")]
        public Godot.Collections.Array OpaqueToPolygons(Rect2 rect, float epsilon = 2f)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_217(method_bind_12, Object.GetPtr(this), ref rect, epsilon));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
