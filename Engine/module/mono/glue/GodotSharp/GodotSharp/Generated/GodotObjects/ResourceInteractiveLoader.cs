using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Interactive <see cref="Godot.Resource"/> loader. This object is returned by <see cref="Godot.ResourceLoader"/> when performing an interactive load. It allows loading resources with high granularity, which makes it mainly useful for displaying loading bars or percentages.</para>
    /// </summary>
    public abstract partial class ResourceInteractiveLoader : Reference
    {
        private const string nativeName = "ResourceInteractiveLoader";

        internal ResourceInteractiveLoader() {}

        internal ResourceInteractiveLoader(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_resource");

        /// <summary>
        /// <para>Returns the loaded resource if the load operation completed successfully, <c>null</c> otherwise.</para>
        /// </summary>
        [GodotMethod("get_resource")]
        public Resource GetResource()
        {
            return NativeCalls.godot_icall_0_402(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "poll");

        /// <summary>
        /// <para>Polls the loading operation, i.e. loads a data chunk up to the next stage.</para>
        /// <para>Returns <c>OK</c> if the poll is successful but the load operation has not finished yet (intermediate stage). This means <see cref="Godot.ResourceInteractiveLoader.Poll"/> will have to be called again until the last stage is completed.</para>
        /// <para>Returns <c>ERR_FILE_EOF</c> if the load operation has completed successfully. The loaded resource can be obtained by calling <see cref="Godot.ResourceInteractiveLoader.GetResource"/>.</para>
        /// <para>Returns another <see cref="Godot.Error"/> code if the poll has failed.</para>
        /// </summary>
        [GodotMethod("poll")]
        public Error Poll()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "wait");

        /// <summary>
        /// <para>Polls the loading operation successively until the resource is completely loaded or a <see cref="Godot.ResourceInteractiveLoader.Poll"/> fails.</para>
        /// <para>Returns <c>ERR_FILE_EOF</c> if the load operation has completed successfully. The loaded resource can be obtained by calling <see cref="Godot.ResourceInteractiveLoader.GetResource"/>.</para>
        /// <para>Returns another <see cref="Godot.Error"/> code if a poll has failed, aborting the operation.</para>
        /// </summary>
        [GodotMethod("wait")]
        public Error Wait()
        {
            return (Error)NativeCalls.godot_icall_0_389(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stage");

        /// <summary>
        /// <para>Returns the load stage. The total amount of stages can be queried with <see cref="Godot.ResourceInteractiveLoader.GetStageCount"/>.</para>
        /// </summary>
        [GodotMethod("get_stage")]
        public int GetStage()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_stage_count");

        /// <summary>
        /// <para>Returns the total amount of stages (calls to <see cref="Godot.ResourceInteractiveLoader.Poll"/>) needed to completely load this resource.</para>
        /// </summary>
        [GodotMethod("get_stage_count")]
        public int GetStageCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
