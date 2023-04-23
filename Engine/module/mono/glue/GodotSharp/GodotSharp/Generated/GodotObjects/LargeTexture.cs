using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Deprecated (will be removed in Godot 4.0). A <see cref="Godot.Texture"/> capable of storing many smaller textures with offsets.</para>
    /// <para>You can dynamically add pieces (<see cref="Godot.Texture"/>s) to this <see cref="Godot.LargeTexture"/> using different offsets.</para>
    /// </summary>
    public partial class LargeTexture : Texture
    {
        public Godot.Collections.Array _Data
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

        private const string nativeName = "LargeTexture";

        public LargeTexture() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_LargeTexture_Ctor(this);
        }

        internal LargeTexture(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_piece");

        /// <summary>
        /// <para>Adds <c>texture</c> to this <see cref="Godot.LargeTexture"/>, starting on offset <c>ofs</c>.</para>
        /// </summary>
        [GodotMethod("add_piece")]
        public int AddPiece(Vector2 ofs, Texture texture)
        {
            return NativeCalls.godot_icall_2_581(method_bind_0, Object.GetPtr(this), ref ofs, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_piece_offset");

        /// <summary>
        /// <para>Sets the offset of the piece with the index <c>idx</c> to <c>ofs</c>.</para>
        /// </summary>
        [GodotMethod("set_piece_offset")]
        public void SetPieceOffset(int idx, Vector2 ofs)
        {
            NativeCalls.godot_icall_2_45(method_bind_1, Object.GetPtr(this), idx, ref ofs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_piece_texture");

        /// <summary>
        /// <para>Sets the <see cref="Godot.Texture"/> of the piece with index <c>idx</c> to <c>texture</c>.</para>
        /// </summary>
        [GodotMethod("set_piece_texture")]
        public void SetPieceTexture(int idx, Texture texture)
        {
            NativeCalls.godot_icall_2_58(method_bind_2, Object.GetPtr(this), idx, Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_size");

        /// <summary>
        /// <para>Sets the size of this <see cref="Godot.LargeTexture"/>.</para>
        /// </summary>
        [GodotMethod("set_size")]
        public void SetSize(Vector2 size)
        {
            NativeCalls.godot_icall_1_57(method_bind_3, Object.GetPtr(this), ref size);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear");

        /// <summary>
        /// <para>Clears the <see cref="Godot.LargeTexture"/>.</para>
        /// </summary>
        [GodotMethod("clear")]
        public void Clear()
        {
            NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_piece_count");

        /// <summary>
        /// <para>Returns the number of pieces currently in this <see cref="Godot.LargeTexture"/>.</para>
        /// </summary>
        [GodotMethod("get_piece_count")]
        public int GetPieceCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_piece_offset");

        /// <summary>
        /// <para>Returns the offset of the piece with the index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_piece_offset")]
        public Vector2 GetPieceOffset(int idx)
        {
            NativeCalls.godot_icall_1_44(method_bind_6, Object.GetPtr(this), idx, out Vector2 argRet); return (Vector2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_piece_texture");

        /// <summary>
        /// <para>Returns the <see cref="Godot.Texture"/> of the piece with the index <c>idx</c>.</para>
        /// </summary>
        [GodotMethod("get_piece_texture")]
        public Texture GetPieceTexture(int idx)
        {
            return NativeCalls.godot_icall_1_59(method_bind_7, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_data");

        [Obsolete("_SetData is deprecated. Use the _Data property instead.")]
        internal void _SetData(Godot.Collections.Array data)
        {
            NativeCalls.godot_icall_1_92(method_bind_8, Object.GetPtr(this), data.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_data");

        [Obsolete("_GetData is deprecated. Use the _Data property instead.")]
        internal Godot.Collections.Array _GetData()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_9, Object.GetPtr(this)));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
