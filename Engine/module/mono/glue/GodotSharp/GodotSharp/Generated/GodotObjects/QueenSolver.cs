using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    public partial class QueenSolver : Node
    {
        private const string nativeName = "QueenSolver";

        public QueenSolver() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_QueenSolver_Ctor(this);
        }

        internal QueenSolver(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "SolveNQueens");

        [GodotMethod("SolveNQueens")]
        public void SolveNQueens(int n)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), n);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "SolveNPrint");

        [GodotMethod("SolveNPrint")]
        public void SolveNPrint(int n)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), n);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
