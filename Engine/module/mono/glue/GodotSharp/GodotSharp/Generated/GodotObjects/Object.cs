using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Every class which is not a built-in type inherits from this class.</para>
    /// <para>You can construct Objects from scripting languages, using <c>Object.new()</c> in GDScript, <c>new Object</c> in C#, or the "Construct Object" node in VisualScript.</para>
    /// <para>Objects do not manage memory. If a class inherits from Object, you will have to delete instances of it manually. To do so, call the <see cref="Godot.Object.Free"/> method from your script or delete the instance from C++.</para>
    /// <para>Some classes that extend Object add memory management. This is the case of <see cref="Godot.Reference"/>, which counts references and deletes itself automatically when no longer referenced. <see cref="Godot.Node"/>, another fundamental type, deletes all its children when freed from memory.</para>
    /// <para>Objects export properties, which are mainly useful for storage and editing, but not really so much in programming. Properties are exported in <see cref="Godot.Object._GetPropertyList"/> and handled in <see cref="Godot.Object._Get"/> and <see cref="Godot.Object._Set"/>. However, scripting languages and C++ have simpler means to export them.</para>
    /// <para>Property membership can be tested directly in GDScript using <c>in</c>:</para>
    /// <para><code>
    /// var n = Node2D.new()
    /// print("position" in n) # Prints "True".
    /// print("other_property" in n) # Prints "False".
    /// </code></para>
    /// <para>The <c>in</c> operator will evaluate to <c>true</c> as long as the key exists, even if the value is <c>null</c>.</para>
    /// <para>Objects also receive notifications. Notifications are a simple way to notify the object about different events, so they can all be handled together. See <see cref="Godot.Object._Notification"/>.</para>
    /// <para>Note: Unlike references to a <see cref="Godot.Reference"/>, references to an Object stored in a variable can become invalid without warning. Therefore, it's recommended to use <see cref="Godot.Reference"/> for data classes instead of <see cref="Godot.Object"/>.</para>
    /// <para>Note: Due to a bug, you can't create a "plain" Object using <c>Object.new()</c>. Instead, use <c>ClassDB.instance("Object")</c>. This bug only applies to Object itself, not any of its descendents like <see cref="Godot.Reference"/>.</para>
    /// </summary>
    public partial class Object    {
        /// <summary>
        /// <para>Called right when the object is initialized. Not available in script.</para>
        /// </summary>
        public const int NotificationPostinitialize = 0;
        /// <summary>
        /// <para>Called before the object is about to be deleted.</para>
        /// </summary>
        public const int NotificationPredelete = 1;

        public enum ConnectFlags
        {
            /// <summary>
            /// <para>Connects a signal in deferred mode. This way, signal emissions are stored in a queue, then set on idle time.</para>
            /// </summary>
            Deferred = 1,
            /// <summary>
            /// <para>Persisting connections are saved when the object is serialized to file.</para>
            /// </summary>
            Persist = 2,
            /// <summary>
            /// <para>One-shot connections disconnect themselves after emission.</para>
            /// </summary>
            Oneshot = 4,
            /// <summary>
            /// <para>Connect a signal as reference-counted. This means that a given signal can be connected several times to the same target, and will only be fully disconnected once no references are left.</para>
            /// </summary>
            ReferenceCounted = 8
        }

        /// <summary>
        /// <para>Virtual method which can be overridden to customize the return value of <see cref="Godot.Object.Get"/>.</para>
        /// <para>Returns the given property. Returns <c>null</c> if the <c>property</c> does not exist.</para>
        /// </summary>
        [GodotMethod("_get")]
        public virtual object _Get(string property)
        {
            return default(object);
        }

        /// <summary>
        /// <para>Virtual method which can be overridden to customize the return value of <see cref="Godot.Object.GetPropertyList"/>.</para>
        /// <para>Returns the object's property list as an <see cref="Godot.Collections.Array"/> of dictionaries.</para>
        /// <para>Each property's <see cref="Godot.Collections.Dictionary"/> must contain at least <c>name: String</c> and <c>type: int</c> (see <see cref="Godot.Variant.Type"/>) entries. Optionally, it can also include <c>hint: int</c> (see <see cref="Godot.PropertyHint"/>), <c>hint_string: String</c>, and <c>usage: int</c> (see <see cref="Godot.PropertyUsageFlags"/>).</para>
        /// </summary>
        [GodotMethod("_get_property_list")]
        public virtual Godot.Collections.Array _GetPropertyList()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>Called whenever the object receives a notification, which is identified in <c>what</c> by a constant. The base <see cref="Godot.Object"/> has two constants <see cref="Godot.Object.NotificationPostinitialize"/> and <see cref="Godot.Object.NotificationPredelete"/>, but subclasses such as <see cref="Godot.Node"/> define a lot more notifications which are also received by this method.</para>
        /// </summary>
        [GodotMethod("_notification")]
        public virtual void _Notification(int what)
        {
            return;
        }

        /// <summary>
        /// <para>Virtual method which can be overridden to customize the return value of <see cref="Godot.Object.Set"/>.</para>
        /// <para>Sets a property. Returns <c>true</c> if the <c>property</c> exists.</para>
        /// </summary>
        [GodotMethod("_set")]
        public virtual bool _Set(string property, object value)
        {
            return default(bool);
        }

        /// <summary>
        /// <para>Deletes the object from memory immediately. For <see cref="Godot.Node"/>s, you may want to use <see cref="Godot.Node.QueueFree"/> to queue the node for safe deletion at the end of the current frame.</para>
        /// <para>Important: If you have a variable pointing to an object, it will not be assigned to <c>null</c> once the object is freed. Instead, it will point to a previously freed instance and you should validate it with <c>@GDScript.is_instance_valid</c> before attempting to call its methods or access its properties.</para>
        /// </summary>
        [GodotMethod("free")]
        public void Free()
        {
            Call("free");
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_class");

        /// <summary>
        /// <para>Returns the object's class as a <see cref="string"/>. See also <see cref="Godot.Object.IsClass"/>.</para>
        /// <para>Note: <see cref="Godot.Object.GetClass"/> does not take <c>class_name</c> declarations into account. If the object has a <c>class_name</c> defined, the base class name will be returned instead.</para>
        /// </summary>
        [GodotMethod("get_class")]
        public string GetClass()
        {
            return NativeCalls.godot_icall_0_6(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_class");

        /// <summary>
        /// <para>Returns <c>true</c> if the object inherits from the given <c>class</c>. See also <see cref="Godot.Object.GetClass"/>.</para>
        /// <para>Note: <see cref="Godot.Object.IsClass"/> does not take <c>class_name</c> declarations into account. If the object has a <c>class_name</c> defined, <see cref="Godot.Object.IsClass"/> will return <c>false</c> for that name.</para>
        /// </summary>
        [GodotMethod("is_class")]
        public bool IsClass(string @class)
        {
            return NativeCalls.godot_icall_1_108(method_bind_1, Object.GetPtr(this), @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set");

        /// <summary>
        /// <para>Assigns a new value to the given property. If the <c>property</c> does not exist or the given value's type doesn't match, nothing will happen.</para>
        /// <para>Note: In C#, the property name must be specified as snake_case if it is defined by a built-in Godot node. This doesn't apply to user-defined properties where you should use the same convention as in the C# source (typically PascalCase).</para>
        /// </summary>
        [GodotMethod("set")]
        public void Set(string property, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_2, Object.GetPtr(this), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get");

        /// <summary>
        /// <para>Returns the <c>Variant</c> value of the given <c>property</c>. If the <c>property</c> doesn't exist, this will return <c>null</c>.</para>
        /// <para>Note: In C#, the property name must be specified as snake_case if it is defined by a built-in Godot node. This doesn't apply to user-defined properties where you should use the same convention as in the C# source (typically PascalCase).</para>
        /// </summary>
        [GodotMethod("get")]
        public object Get(string property)
        {
            return NativeCalls.godot_icall_1_97(method_bind_3, Object.GetPtr(this), property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_indexed");

        /// <summary>
        /// <para>Assigns a new value to the property identified by the <see cref="Godot.NodePath"/>. The node path should be relative to the current object and can use the colon character (<c>:</c>) to access nested properties. Example:</para>
        /// <para><code>
        /// set_indexed("position", Vector2(42, 0))
        /// set_indexed("position:y", -10)
        /// print(position) # (42, -10)
        /// </code></para>
        /// </summary>
        [GodotMethod("set_indexed")]
        public void SetIndexed(NodePath property, object value)
        {
            NativeCalls.godot_icall_2_690(method_bind_4, Object.GetPtr(this), NodePath.GetPtr(property), value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_indexed");

        /// <summary>
        /// <para>Gets the object's property indexed by the given <see cref="Godot.NodePath"/>. The node path should be relative to the current object and can use the colon character (<c>:</c>) to access nested properties. Examples: <c>"position:x"</c> or <c>"material:next_pass:blend_mode"</c>.</para>
        /// <para>Note: Even though the method takes <see cref="Godot.NodePath"/> argument, it doesn't support actual paths to <see cref="Godot.Node"/>s in the scene tree, only colon-separated sub-property paths. For the purpose of nodes, use <see cref="Godot.Node.GetNodeAndResource"/> instead.</para>
        /// </summary>
        [GodotMethod("get_indexed")]
        public object GetIndexed(NodePath property)
        {
            return NativeCalls.godot_icall_1_691(method_bind_5, Object.GetPtr(this), NodePath.GetPtr(property));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_property_list");

        /// <summary>
        /// <para>Returns the object's property list as an <see cref="Godot.Collections.Array"/> of dictionaries.</para>
        /// <para>Each property's <see cref="Godot.Collections.Dictionary"/> contain at least <c>name: String</c> and <c>type: int</c> (see <see cref="Godot.Variant.Type"/>) entries. Optionally, it can also include <c>hint: int</c> (see <see cref="Godot.PropertyHint"/>), <c>hint_string: String</c>, and <c>usage: int</c> (see <see cref="Godot.PropertyUsageFlags"/>).</para>
        /// </summary>
        [GodotMethod("get_property_list")]
        public Godot.Collections.Array GetPropertyList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_6, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_method_list");

        /// <summary>
        /// <para>Returns the object's methods and their signatures as an <see cref="Godot.Collections.Array"/>.</para>
        /// </summary>
        [GodotMethod("get_method_list")]
        public Godot.Collections.Array GetMethodList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_7, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "notification");

        /// <summary>
        /// <para>Send a given notification to the object, which will also trigger a call to the <see cref="Godot.Object._Notification"/> method of all classes that the object inherits from.</para>
        /// <para>If <c>reversed</c> is <c>true</c>, <see cref="Godot.Object._Notification"/> is called first on the object's own class, and then up to its successive parent classes. If <c>reversed</c> is <c>false</c>, <see cref="Godot.Object._Notification"/> is called first on the highest ancestor (<see cref="Godot.Object"/> itself), and then down to its successive inheriting classes.</para>
        /// </summary>
        [GodotMethod("notification")]
        public void Notification(int what, bool reversed = false)
        {
            NativeCalls.godot_icall_2_23(method_bind_8, Object.GetPtr(this), what, reversed);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instance_id");

        /// <summary>
        /// <para>Returns the object's unique instance ID.</para>
        /// <para>This ID can be saved in <see cref="Godot.EncodedObjectAsID"/>, and can be used to retrieve the object instance with <c>@GDScript.instance_from_id</c>.</para>
        /// </summary>
        [GodotMethod("get_instance_id")]
        public ulong GetInstanceId()
        {
            return NativeCalls.godot_icall_0_30(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_script");

        /// <summary>
        /// <para>Assigns a script to the object. Each object can have a single script assigned to it, which are used to extend its functionality.</para>
        /// <para>If the object already had a script, the previous script instance will be freed and its variables and state will be lost. The new script's  method will be called.</para>
        /// </summary>
        [GodotMethod("set_script")]
        public void SetScript(Reference script)
        {
            NativeCalls.godot_icall_1_24(method_bind_10, Object.GetPtr(this), Object.GetPtr(script));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_script");

        /// <summary>
        /// <para>Returns the object's <see cref="Godot.Script"/> instance, or <c>null</c> if none is assigned.</para>
        /// </summary>
        [GodotMethod("get_script")]
        public Reference GetScript()
        {
            return NativeCalls.godot_icall_0_692(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_meta");

        /// <summary>
        /// <para>Adds, changes or removes a given entry in the object's metadata. Metadata are serialized and can take any <c>Variant</c> value.</para>
        /// <para>To remove a given entry from the object's metadata, use <see cref="Godot.Object.RemoveMeta"/>. Metadata is also removed if its value is set to <c>null</c>. This means you can also use <c>set_meta("name", null)</c> to remove metadata for <c>"name"</c>.</para>
        /// </summary>
        [GodotMethod("set_meta")]
        public void SetMeta(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_12, Object.GetPtr(this), name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_meta");

        /// <summary>
        /// <para>Removes a given entry from the object's metadata. See also <see cref="Godot.Object.SetMeta"/>.</para>
        /// </summary>
        [GodotMethod("remove_meta")]
        public void RemoveMeta(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_13, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_meta");

        /// <summary>
        /// <para>Returns the object's metadata entry for the given <c>name</c>.</para>
        /// <para>Throws error if the entry does not exist, unless <c>default</c> is not <c>null</c> (in which case the default value will be returned).</para>
        /// </summary>
        [GodotMethod("get_meta")]
        public object GetMeta(string name, object @default = null)
        {
            return NativeCalls.godot_icall_2_693(method_bind_14, Object.GetPtr(this), name, @default);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_meta");

        /// <summary>
        /// <para>Returns <c>true</c> if a metadata entry is found with the given <c>name</c>.</para>
        /// </summary>
        [GodotMethod("has_meta")]
        public bool HasMeta(string name)
        {
            return NativeCalls.godot_icall_1_108(method_bind_15, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_meta_list");

        /// <summary>
        /// <para>Returns the object's metadata as a <see cref="string"/>.</para>
        /// </summary>
        [GodotMethod("get_meta_list")]
        public string[] GetMetaList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_user_signal");

        /// <summary>
        /// <para>Adds a user-defined <c>signal</c>. Arguments are optional, but can be added as an <see cref="Godot.Collections.Array"/> of dictionaries, each containing <c>name: String</c> and <c>type: int</c> (see <see cref="Godot.Variant.Type"/>) entries.</para>
        /// </summary>
        /// <param name="arguments">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("add_user_signal")]
        public void AddUserSignal(string signal, Godot.Collections.Array arguments = null)
        {
            Godot.Collections.Array arguments_in = arguments != null ? arguments : new Godot.Collections.Array { };
            NativeCalls.godot_icall_2_694(method_bind_17, Object.GetPtr(this), signal, arguments_in.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_user_signal");

        /// <summary>
        /// <para>Returns <c>true</c> if the given user-defined <c>signal</c> exists. Only signals added using <see cref="Godot.Object.AddUserSignal"/> are taken into account.</para>
        /// </summary>
        [GodotMethod("has_user_signal")]
        public bool HasUserSignal(string signal)
        {
            return NativeCalls.godot_icall_1_108(method_bind_18, Object.GetPtr(this), signal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "emit_signal");

        /// <summary>
        /// <para>Emits the given <c>signal</c>. The signal must exist, so it should be a built-in signal of this class or one of its parent classes, or a user-defined signal. This method supports a variable number of arguments, so parameters are passed as a comma separated list. Example:</para>
        /// <para><code>
        /// emit_signal("hit", weapon_type, damage)
        /// emit_signal("game_over")
        /// </code></para>
        /// </summary>
        [GodotMethod("emit_signal")]
        public void EmitSignal(string signal, params object[] @args)
        {
            NativeCalls.godot_icall_2_695(method_bind_19, Object.GetPtr(this), signal, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call");

        /// <summary>
        /// <para>Calls the <c>method</c> on the object and returns the result. This method supports a variable number of arguments, so parameters are passed as a comma separated list. Example:</para>
        /// <para><code>
        /// call("set", "position", Vector2(42.0, 0.0))
        /// </code></para>
        /// <para>Note: In C#, the method name must be specified as snake_case if it is defined by a built-in Godot node. This doesn't apply to user-defined methods where you should use the same convention as in the C# source (typically PascalCase).</para>
        /// </summary>
        [GodotMethod("call")]
        public object Call(string method, params object[] @args)
        {
            return NativeCalls.godot_icall_2_558(method_bind_20, Object.GetPtr(this), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "call_deferred");

        /// <summary>
        /// <para>Calls the <c>method</c> on the object during idle time. This method supports a variable number of arguments, so parameters are passed as a comma separated list. Example:</para>
        /// <para><code>
        /// call_deferred("set", "position", Vector2(42.0, 0.0))
        /// </code></para>
        /// <para>Note: In C#, the method name must be specified as snake_case if it is defined by a built-in Godot node. This doesn't apply to user-defined methods where you should use the same convention as in the C# source (typically PascalCase).</para>
        /// </summary>
        [GodotMethod("call_deferred")]
        public void CallDeferred(string method, params object[] @args)
        {
            NativeCalls.godot_icall_2_695(method_bind_21, Object.GetPtr(this), method, @args);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_deferred");

        /// <summary>
        /// <para>Assigns a new value to the given property, after the current frame's physics step. This is equivalent to calling <see cref="Godot.Object.Set"/> via <see cref="Godot.Object.CallDeferred"/>, i.e. <c>call_deferred("set", property, value)</c>.</para>
        /// <para>Note: In C#, the property name must be specified as snake_case if it is defined by a built-in Godot node. This doesn't apply to user-defined properties where you should use the same convention as in the C# source (typically PascalCase).</para>
        /// </summary>
        [GodotMethod("set_deferred")]
        public void SetDeferred(string property, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_22, Object.GetPtr(this), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "callv");

        /// <summary>
        /// <para>Calls the <c>method</c> on the object and returns the result. Contrarily to <see cref="Godot.Object.Call"/>, this method does not support a variable number of arguments but expects all parameters to be via a single <see cref="Godot.Collections.Array"/>.</para>
        /// <para><code>
        /// callv("set", [ "position", Vector2(42.0, 0.0) ])
        /// </code></para>
        /// </summary>
        [GodotMethod("callv")]
        public object Callv(string method, Godot.Collections.Array argArray)
        {
            return NativeCalls.godot_icall_2_696(method_bind_23, Object.GetPtr(this), method, argArray.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_method");

        /// <summary>
        /// <para>Returns <c>true</c> if the object contains the given <c>method</c>.</para>
        /// </summary>
        [GodotMethod("has_method")]
        public bool HasMethod(string method)
        {
            return NativeCalls.godot_icall_1_108(method_bind_24, Object.GetPtr(this), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "has_signal");

        /// <summary>
        /// <para>Returns <c>true</c> if the given <c>signal</c> exists.</para>
        /// </summary>
        [GodotMethod("has_signal")]
        public bool HasSignal(string signal)
        {
            return NativeCalls.godot_icall_1_108(method_bind_25, Object.GetPtr(this), signal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_signal_list");

        /// <summary>
        /// <para>Returns the list of signals as an <see cref="Godot.Collections.Array"/> of dictionaries.</para>
        /// </summary>
        [GodotMethod("get_signal_list")]
        public Godot.Collections.Array GetSignalList()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_26, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_signal_connection_list");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of connections for the given <c>signal</c>.</para>
        /// </summary>
        [GodotMethod("get_signal_connection_list")]
        public Godot.Collections.Array GetSignalConnectionList(string signal)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_1_534(method_bind_27, Object.GetPtr(this), signal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_incoming_connections");

        /// <summary>
        /// <para>Returns an <see cref="Godot.Collections.Array"/> of dictionaries with information about signals that are connected to the object.</para>
        /// <para>Each <see cref="Godot.Collections.Dictionary"/> contains three String entries:</para>
        /// <para>- <c>source</c> is a reference to the signal emitter.</para>
        /// <para>- <c>signal_name</c> is the name of the connected signal.</para>
        /// <para>- <c>method_name</c> is the name of the method to which the signal is connected.</para>
        /// </summary>
        [GodotMethod("get_incoming_connections")]
        public Godot.Collections.Array GetIncomingConnections()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_28, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "connect");

        /// <summary>
        /// <para>Connects a <c>signal</c> to a <c>method</c> on a <c>target</c> object. Pass optional <c>binds</c> to the call as an <see cref="Godot.Collections.Array"/> of parameters. These parameters will be passed to the method after any parameter used in the call to <see cref="Godot.Object.EmitSignal"/>. Use <c>flags</c> to set deferred or one-shot connections. See <see cref="Godot.Object.ConnectFlags"/> constants.</para>
        /// <para>A <c>signal</c> can only be connected once to a <c>method</c>. It will print an error if already connected, unless the signal was connected with <see cref="Godot.Object.ConnectFlags.ReferenceCounted"/>. To avoid this, first, use <see cref="Godot.Object.IsConnected"/> to check for existing connections.</para>
        /// <para>If the <c>target</c> is destroyed in the game's lifecycle, the connection will be lost.</para>
        /// <para>Examples:</para>
        /// <para><code>
        /// connect("pressed", self, "_on_Button_pressed") # BaseButton signal
        /// connect("text_entered", self, "_on_LineEdit_text_entered") # LineEdit signal
        /// connect("hit", self, "_on_Player_hit", [ weapon_type, damage ]) # User-defined signal
        /// </code></para>
        /// <para>An example of the relationship between <c>binds</c> passed to <see cref="Godot.Object.Connect"/> and parameters used when calling <see cref="Godot.Object.EmitSignal"/>:</para>
        /// <para><code>
        /// connect("hit", self, "_on_Player_hit", [ weapon_type, damage ]) # weapon_type and damage are passed last
        /// emit_signal("hit", "Dark lord", 5) # "Dark lord" and 5 are passed first
        /// func _on_Player_hit(hit_by, level, weapon_type, damage):
        ///     print("Hit by %s (lvl %d) with weapon %s for %d damage" % [hit_by, level, weapon_type, damage])
        /// </code></para>
        /// </summary>
        /// <param name="binds">If the parameter is null, then the default value is new Godot.Collections.Array { }</param>
        [GodotMethod("connect")]
        public Error Connect(string signal, Object target, string method, Godot.Collections.Array binds = null, uint flags = (uint)0)
        {
            Godot.Collections.Array binds_in = binds != null ? binds : new Godot.Collections.Array { };
            return (Error)NativeCalls.godot_icall_5_697(method_bind_29, Object.GetPtr(this), signal, Object.GetPtr(target), method, binds_in.GetPtr(), flags);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "disconnect");

        /// <summary>
        /// <para>Disconnects a <c>signal</c> from a <c>method</c> on the given <c>target</c>.</para>
        /// <para>If you try to disconnect a connection that does not exist, the method will print an error. Use <see cref="Godot.Object.IsConnected"/> to ensure that the connection exists.</para>
        /// </summary>
        [GodotMethod("disconnect")]
        public void Disconnect(string signal, Object target, string method)
        {
            NativeCalls.godot_icall_3_698(method_bind_30, Object.GetPtr(this), signal, Object.GetPtr(target), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_connected");

        /// <summary>
        /// <para>Returns <c>true</c> if a connection exists for a given <c>signal</c>, <c>target</c>, and <c>method</c>.</para>
        /// </summary>
        [GodotMethod("is_connected")]
        public bool IsConnected(string signal, Object target, string method)
        {
            return NativeCalls.godot_icall_3_699(method_bind_31, Object.GetPtr(this), signal, Object.GetPtr(target), method);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_block_signals");

        /// <summary>
        /// <para>If set to <c>true</c>, signal emission is blocked.</para>
        /// </summary>
        [GodotMethod("set_block_signals")]
        public void SetBlockSignals(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_32, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_blocking_signals");

        /// <summary>
        /// <para>Returns <c>true</c> if signal emission blocking is enabled.</para>
        /// </summary>
        [GodotMethod("is_blocking_signals")]
        public bool IsBlockingSignals()
        {
            return NativeCalls.godot_icall_0_7(method_bind_33, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "property_list_changed_notify");

        /// <summary>
        /// <para>Notify the editor that the property list has changed, so that editor plugins can take the new values into account. Does nothing on export builds.</para>
        /// </summary>
        [GodotMethod("property_list_changed_notify")]
        public void PropertyListChangedNotify()
        {
            NativeCalls.godot_icall_0_3(method_bind_34, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_message_translation");

        /// <summary>
        /// <para>Defines whether the object can translate strings (with calls to <see cref="Godot.Object.Tr"/>). Enabled by default.</para>
        /// </summary>
        [GodotMethod("set_message_translation")]
        public void SetMessageTranslation(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_35, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_translate_messages");

        /// <summary>
        /// <para>Returns <c>true</c> if the object can translate strings. See <see cref="Godot.Object.SetMessageTranslation"/> and <see cref="Godot.Object.Tr"/>.</para>
        /// </summary>
        [GodotMethod("can_translate_messages")]
        public bool CanTranslateMessages()
        {
            return NativeCalls.godot_icall_0_7(method_bind_36, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "tr");

        /// <summary>
        /// <para>Translates a message using translation catalogs configured in the Project Settings.</para>
        /// <para>Only works if message translation is enabled (which it is by default), otherwise it returns the <c>message</c> unchanged. See <see cref="Godot.Object.SetMessageTranslation"/>.</para>
        /// </summary>
        [GodotMethod("tr")]
        public string Tr(string message)
        {
            return NativeCalls.godot_icall_1_124(method_bind_37, Object.GetPtr(this), message);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_queued_for_deletion");

        /// <summary>
        /// <para>Returns <c>true</c> if the <see cref="Godot.Node.QueueFree"/> method was called for the object.</para>
        /// </summary>
        [GodotMethod("is_queued_for_deletion")]
        public bool IsQueuedForDeletion()
        {
            return NativeCalls.godot_icall_0_7(method_bind_38, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
