using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A 6-sided 3D texture typically used for faking reflections. It can be used to make an object look as if it's reflecting its surroundings. This usually delivers much better performance than other reflection methods.</para>
    /// </summary>
    public partial class CubeMap : Resource
    {
        public enum FlagsEnum
        {
            /// <summary>
            /// <para>Generate mipmaps, to enable smooth zooming out of the texture.</para>
            /// </summary>
            Mipmaps = 1,
            /// <summary>
            /// <para>Repeat (instead of clamp to edge).</para>
            /// </summary>
            Repeat = 2,
            /// <summary>
            /// <para>Turn on magnifying filter, to enable smooth zooming in of the texture.</para>
            /// </summary>
            Filter = 4,
            /// <summary>
            /// <para>Default flags. Generate mipmaps, repeat, and filter are enabled.</para>
            /// </summary>
            Default = 7
        }

        public enum Side
        {
            /// <summary>
            /// <para>Identifier for the left face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Left = 0,
            /// <summary>
            /// <para>Identifier for the right face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Right = 1,
            /// <summary>
            /// <para>Identifier for the bottom face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Bottom = 2,
            /// <summary>
            /// <para>Identifier for the top face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Top = 3,
            /// <summary>
            /// <para>Identifier for the front face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Front = 4,
            /// <summary>
            /// <para>Identifier for the back face of the <see cref="Godot.CubeMap"/>.</para>
            /// </summary>
            Back = 5
        }

        public enum Storage
        {
            /// <summary>
            /// <para>Store the <see cref="Godot.CubeMap"/> without any compression.</para>
            /// </summary>
            Raw = 0,
            /// <summary>
            /// <para>Store the <see cref="Godot.CubeMap"/> with strong compression that reduces image quality.</para>
            /// </summary>
            CompressLossy = 1,
            /// <summary>
            /// <para>Store the <see cref="Godot.CubeMap"/> with moderate compression that doesn't reduce image quality.</para>
            /// </summary>
            CompressLossless = 2
        }

        /// <summary>
        /// <para>The render flags for the <see cref="Godot.CubeMap"/>. See the <see cref="Godot.CubeMap.FlagsEnum"/> constants for details.</para>
        /// </summary>
        public uint Flags
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFlags();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFlags(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.CubeMap"/>'s storage mode. See <see cref="Godot.CubeMap.Storage"/> constants.</para>
        /// </summary>
        public CubeMap.Storage StorageMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetStorage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetStorage(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The lossy storage quality of the <see cref="Godot.CubeMap"/> if the storage mode is set to <see cref="Godot.CubeMap.Storage.CompressLossy"/>.</para>
        /// </summary>
        public float LossyStorageQuality
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLossyStorageQuality();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLossyStorageQuality(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CubeMap";

        public CubeMap() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CubeMap_Ctor(this);
        }

        internal CubeMap(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_width");

        /// <summary>
        /// <para>Returns the <see cref="Godot.CubeMap"/>'s width.</para>
        /// </summary>
        [GodotMethod("get_width")]
        public int GetWidth()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_height");

        /// <summary>
        /// <para>Returns the <see cref="Godot.CubeMap"/>'s height.</para>
        /// </summary>
        [GodotMethod("get_height")]
        public int GetHeight()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_flags");

        [GodotMethod("set_flags")]
        [Obsolete("SetFlags is deprecated. Use the Flags property instead.")]
        public void SetFlags(uint flags)
        {
            NativeCalls.godot_icall_1_187(method_bind_2, Object.GetPtr(this), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_flags");

        [GodotMethod("get_flags")]
        [Obsolete("GetFlags is deprecated. Use the Flags property instead.")]
        public uint GetFlags()
        {
            return NativeCalls.godot_icall_0_188(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_side");

        /// <summary>
        /// <para>Sets an <see cref="Godot.Image"/> for a side of the <see cref="Godot.CubeMap"/> using one of the <see cref="Godot.CubeMap.Side"/> constants.</para>
        /// </summary>
        [GodotMethod("set_side")]
        public void SetSide(CubeMap.Side side, Image image)
        {
            NativeCalls.godot_icall_2_58(method_bind_4, Object.GetPtr(this), (int)side, Object.GetPtr(image));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_side");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Image"/> for a side of the <see cref="Godot.CubeMap"/> using one of the <see cref="Godot.CubeMap.Side"/> constants.</para>
        /// </summary>
        [GodotMethod("get_side")]
        public Image GetSide(CubeMap.Side side)
        {
            return NativeCalls.godot_icall_1_339(method_bind_5, Object.GetPtr(this), (int)side);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_storage");

        [GodotMethod("set_storage")]
        [Obsolete("SetStorage is deprecated. Use the StorageMode property instead.")]
        public void SetStorage(CubeMap.Storage mode)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), (int)mode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_storage");

        [GodotMethod("get_storage")]
        [Obsolete("GetStorage is deprecated. Use the StorageMode property instead.")]
        public CubeMap.Storage GetStorage()
        {
            return (CubeMap.Storage)NativeCalls.godot_icall_0_340(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lossy_storage_quality");

        [GodotMethod("set_lossy_storage_quality")]
        [Obsolete("SetLossyStorageQuality is deprecated. Use the LossyStorageQuality property instead.")]
        public void SetLossyStorageQuality(float quality)
        {
            NativeCalls.godot_icall_1_15(method_bind_8, Object.GetPtr(this), quality);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lossy_storage_quality");

        [GodotMethod("get_lossy_storage_quality")]
        [Obsolete("GetLossyStorageQuality is deprecated. Use the LossyStorageQuality property instead.")]
        public float GetLossyStorageQuality()
        {
            return NativeCalls.godot_icall_0_14(method_bind_9, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
