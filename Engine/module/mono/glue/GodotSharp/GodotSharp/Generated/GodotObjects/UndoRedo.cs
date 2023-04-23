using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Helper to manage undo/redo operations in the editor or custom tools. It works by registering methods and property changes inside "actions".</para>
    /// <para>Common behavior is to create an action, then add do/undo calls to functions or property changes, then committing the action.</para>
    /// <para>Here's an example on how to add an action to the Godot editor's own <see cref="Godot.UndoRedo"/>, from a plugin:</para>
    /// <para><code>
    /// var undo_redo = get_undo_redo() # Method of EditorPlugin.
    /// 
    /// func do_something():
    ///     pass # Put your code here.
    /// 
    /// func undo_something():
    ///     pass # Put here the code that reverts what's done by "do_something()".
    /// 
    /// func _on_MyButton_pressed():
    ///     var node = get_node("MyNode2D")
    ///     undo_redo.create_action("Move the node")
    ///     undo_redo.add_do_method(self, "do_something")
    ///     undo_redo.add_undo_method(self, "undo_something")
    ///     undo_redo.add_do_property(node, "position", Vector2(100,100))
    ///     undo_redo.add_undo_property(node, "position", node.position)
    ///     undo_redo.commit_action()
    /// </code></para>
    /// <para><see cref="Godot.UndoRedo.CreateAction"/>, <see cref="Godot.UndoRedo.AddDoMethod"/>, <see cref="Godot.UndoRedo.AddUndoMethod"/>, <see cref="Godot.UndoRedo.AddDoProperty"/>, <see cref="Godot.UndoRedo.AddUndoProperty"/>, and <see cref="Godot.UndoRedo.CommitAction"/> should be called one after the other, like in the example. Not doing so could lead to crashes.</para>
    /// <para>If you don't need to register a method, you can leave <see cref="Godot.UndoRedo.AddDoMethod"/> and <see cref="Godot.UndoRedo.AddUndoMethod"/> out; the same goes for properties. You can also register more than one method/property.</para>
    /// </summary>
    public partial class UndoRedo : Object
    {
        public enum MergeMode
        {
            /// <summary>
            /// <para>Makes "do"/"undo" operations stay in separate actions.</para>
            /// </summary>
            Disable = 0,
            /// <summary>
            /// <para>Makes so that the action's "do" operation is from the first action created and the "undo" operation is from the last subsequent action with the same name.</para>
            /// </summary>
            Ends = 1,
            /// <summary>
            /// <para>Makes subsequent actions with the same name be merged into one.</para>
            /// </summary>
            All = 2
        }

        private const string nativeName = "UndoRedo";

        public UndoRedo() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_UndoRedo_Ctor(this);
        }

        internal UndoRedo(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "create_action");

        /// <summary>
        /// <para>Create a new action. After this is called, do all your calls to <see cref="Godot.UndoRedo.AddDoMethod"/>, <see cref="Godot.UndoRedo.AddUndoMethod"/>, <see cref="Godot.UndoRedo.AddDoProperty"/>, and <see cref="Godot.UndoRedo.AddUndoProperty"/>, then commit the action with <see cref="Godot.UndoRedo.CommitAction"/>.</para>
        /// <para>The way actions are merged is dictated by the <c>merge_mode</c> argument. See <see cref="Godot.UndoRedo.MergeMode"/> for details.</para>
        /// </summary>
        [GodotMethod("create_action")]
        public void CreateAction(string name, UndoRedo.MergeMode mergeMode = (UndoRedo.MergeMode)0)
        {
            NativeCalls.godot_icall_2_110(method_bind_0, Object.GetPtr(this), name, (int)mergeMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "commit_action");

        /// <summary>
        /// <para>Commit the action. All "do" methods/properties are called/set when this function is called.</para>
        /// </summary>
        [GodotMethod("commit_action")]
        public void CommitAction()
        {
            NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_commiting_action");

        /// <summary>
        /// <para>Returns <c>true</c> if the <see cref="Godot.UndoRedo"/> is currently committing the action, i.e. running its "do" method or property change (see <see cref="Godot.UndoRedo.CommitAction"/>).</para>
        /// </summary>
        [GodotMethod("is_commiting_action")]
        public bool IsCommitingAction()
        {
            return NativeCalls.godot_icall_0_7(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_do_method");

        /// <summary>
        /// <para>Register a method that will be called when the action is committed.</para>
        /// </summary>
        [GodotMethod("add_do_method")]
        public void AddDoMethod(Object @object, string method, params object[] @args)
        {
            NativeCalls.godot_icall_3_1006(method_bind_3, Object.GetPtr(this), Object.GetPtr(@object), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_undo_method");

        /// <summary>
        /// <para>Register a method that will be called when the action is undone.</para>
        /// </summary>
        [GodotMethod("add_undo_method")]
        public void AddUndoMethod(Object @object, string method, params object[] @args)
        {
            NativeCalls.godot_icall_3_1006(method_bind_4, Object.GetPtr(this), Object.GetPtr(@object), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_do_property");

        /// <summary>
        /// <para>Register a property value change for "do".</para>
        /// </summary>
        [GodotMethod("add_do_property")]
        public void AddDoProperty(Object @object, string property, object value)
        {
            NativeCalls.godot_icall_3_1007(method_bind_5, Object.GetPtr(this), Object.GetPtr(@object), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_undo_property");

        /// <summary>
        /// <para>Register a property value change for "undo".</para>
        /// </summary>
        [GodotMethod("add_undo_property")]
        public void AddUndoProperty(Object @object, string property, object value)
        {
            NativeCalls.godot_icall_3_1007(method_bind_6, Object.GetPtr(this), Object.GetPtr(@object), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_do_reference");

        /// <summary>
        /// <para>Register a reference for "do" that will be erased if the "do" history is lost. This is useful mostly for new nodes created for the "do" call. Do not use for resources.</para>
        /// </summary>
        [GodotMethod("add_do_reference")]
        public void AddDoReference(Object @object)
        {
            NativeCalls.godot_icall_1_53(method_bind_7, Object.GetPtr(this), Object.GetPtr(@object));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_undo_reference");

        /// <summary>
        /// <para>Register a reference for "undo" that will be erased if the "undo" history is lost. This is useful mostly for nodes removed with the "do" call (not the "undo" call!).</para>
        /// </summary>
        [GodotMethod("add_undo_reference")]
        public void AddUndoReference(Object @object)
        {
            NativeCalls.godot_icall_1_53(method_bind_8, Object.GetPtr(this), Object.GetPtr(@object));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "clear_history");

        /// <summary>
        /// <para>Clear the undo/redo history and associated references.</para>
        /// <para>Passing <c>false</c> to <c>increase_version</c> will prevent the version number to be increased from this.</para>
        /// </summary>
        [GodotMethod("clear_history")]
        public void ClearHistory(bool increaseVersion = true)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), increaseVersion);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_current_action_name");

        /// <summary>
        /// <para>Gets the name of the current action.</para>
        /// </summary>
        [GodotMethod("get_current_action_name")]
        public string GetCurrentActionName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_undo");

        /// <summary>
        /// <para>Returns <c>true</c> if an "undo" action is available.</para>
        /// </summary>
        [GodotMethod("has_undo")]
        public bool HasUndo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_redo");

        /// <summary>
        /// <para>Returns <c>true</c> if a "redo" action is available.</para>
        /// </summary>
        [GodotMethod("has_redo")]
        public bool HasRedo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_version");

        /// <summary>
        /// <para>Gets the version. Every time a new action is committed, the <see cref="Godot.UndoRedo"/>'s version number is increased automatically.</para>
        /// <para>This is useful mostly to check if something changed from a saved version.</para>
        /// </summary>
        [GodotMethod("get_version")]
        public ulong GetVersion()
        {
            return NativeCalls.godot_icall_0_30(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "redo");

        /// <summary>
        /// <para>Redo the last action.</para>
        /// </summary>
        [GodotMethod("redo")]
        public bool Redo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "undo");

        /// <summary>
        /// <para>Undo the last action.</para>
        /// </summary>
        [GodotMethod("undo")]
        public bool Undo()
        {
            return NativeCalls.godot_icall_0_7(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
