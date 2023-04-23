using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Provides access to metadata stored for every available class.</para>
    /// </summary>
    public static partial class ClassDB
    {
        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(ClassDB).Name);
                return singleton;
            }
        }

        private const string nativeName = "_ClassDB";
        internal static IntPtr ptr = NativeCalls.godot_icall__ClassDB_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_class_list");

        /// <summary>
        /// <para>Returns the names of all the classes available.</para>
        /// </summary>
        [GodotMethod("get_class_list")]
        public static string[] GetClassList()
        {
            return NativeCalls.godot_icall_0_119(method_bind_0, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_inheriters_from_class");

        /// <summary>
        /// <para>Returns the names of all the classes that directly or indirectly inherit from <c>class</c>.</para>
        /// </summary>
        [GodotMethod("get_inheriters_from_class")]
        public static string[] GetInheritersFromClass(string @class)
        {
            return NativeCalls.godot_icall_1_309(method_bind_1, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parent_class");

        /// <summary>
        /// <para>Returns the parent class of <c>class</c>.</para>
        /// </summary>
        [GodotMethod("get_parent_class")]
        public static string GetParentClass(string @class)
        {
            return NativeCalls.godot_icall_1_124(method_bind_2, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_exists");

        /// <summary>
        /// <para>Returns whether the specified <c>class</c> is available or not.</para>
        /// </summary>
        [GodotMethod("class_exists")]
        public static bool ClassExists(string @class)
        {
            return NativeCalls.godot_icall_1_108(method_bind_3, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_parent_class");

        /// <summary>
        /// <para>Returns whether <c>inherits</c> is an ancestor of <c>class</c> or not.</para>
        /// </summary>
        [GodotMethod("is_parent_class")]
        public static bool IsParentClass(string @class, string inherits)
        {
            return NativeCalls.godot_icall_2_116(method_bind_4, ptr, @class, inherits);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "can_instance");

        /// <summary>
        /// <para>Returns <c>true</c> if you can instance objects from the specified <c>class</c>, <c>false</c> in other case.</para>
        /// </summary>
        [GodotMethod("can_instance")]
        public static bool CanInstance(string @class)
        {
            return NativeCalls.godot_icall_1_108(method_bind_5, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "instance");

        /// <summary>
        /// <para>Creates an instance of <c>class</c>.</para>
        /// </summary>
        [GodotMethod("instance")]
        public static object Instance(string @class)
        {
            return NativeCalls.godot_icall_1_97(method_bind_6, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_has_signal");

        /// <summary>
        /// <para>Returns whether <c>class</c> or its ancestry has a signal called <c>signal</c> or not.</para>
        /// </summary>
        [GodotMethod("class_has_signal")]
        public static bool ClassHasSignal(string @class, string signal)
        {
            return NativeCalls.godot_icall_2_116(method_bind_7, ptr, @class, signal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_signal");

        /// <summary>
        /// <para>Returns the <c>signal</c> data of <c>class</c> or its ancestry. The returned value is a <see cref="Godot.Collections.Dictionary"/> with the following keys: <c>args</c>, <c>default_args</c>, <c>flags</c>, <c>id</c>, <c>name</c>, <c>return: (class_name, hint, hint_string, name, type, usage)</c>.</para>
        /// </summary>
        [GodotMethod("class_get_signal")]
        public static Godot.Collections.Dictionary ClassGetSignal(string @class, string signal)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_420(method_bind_8, ptr, @class, signal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_signal_list");

        /// <summary>
        /// <para>Returns an array with all the signals of <c>class</c> or its ancestry if <c>no_inheritance</c> is <c>false</c>. Every element of the array is a <see cref="Godot.Collections.Dictionary"/> as described in <see cref="Godot.ClassDB.ClassGetSignal"/>.</para>
        /// </summary>
        [GodotMethod("class_get_signal_list")]
        public static Godot.Collections.Array ClassGetSignalList(string @class, bool noInheritance = false)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1168(method_bind_9, ptr, @class, noInheritance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_property_list");

        /// <summary>
        /// <para>Returns an array with all the properties of <c>class</c> or its ancestry if <c>no_inheritance</c> is <c>false</c>.</para>
        /// </summary>
        [GodotMethod("class_get_property_list")]
        public static Godot.Collections.Array ClassGetPropertyList(string @class, bool noInheritance = false)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1168(method_bind_10, ptr, @class, noInheritance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_property");

        /// <summary>
        /// <para>Returns the value of <c>property</c> of <c>class</c> or its ancestry.</para>
        /// </summary>
        [GodotMethod("class_get_property")]
        public static object ClassGetProperty(Object @object, string property)
        {
            return NativeCalls.godot_icall_2_1169(method_bind_11, ptr, Object.GetPtr(@object), property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_set_property");

        /// <summary>
        /// <para>Sets <c>property</c> value of <c>class</c> to <c>value</c>.</para>
        /// </summary>
        [GodotMethod("class_set_property")]
        public static Error ClassSetProperty(Object @object, string property, object value)
        {
            return (Error)NativeCalls.godot_icall_3_1170(method_bind_12, ptr, Object.GetPtr(@object), property, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_has_method");

        /// <summary>
        /// <para>Returns whether <c>class</c> (or its ancestry if <c>no_inheritance</c> is <c>false</c>) has a method called <c>method</c> or not.</para>
        /// </summary>
        [GodotMethod("class_has_method")]
        public static bool ClassHasMethod(string @class, string method, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_3_1171(method_bind_13, ptr, @class, method, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_method_list");

        /// <summary>
        /// <para>Returns an array with all the methods of <c>class</c> or its ancestry if <c>no_inheritance</c> is <c>false</c>. Every element of the array is a <see cref="Godot.Collections.Dictionary"/> with the following keys: <c>args</c>, <c>default_args</c>, <c>flags</c>, <c>id</c>, <c>name</c>, <c>return: (class_name, hint, hint_string, name, type, usage)</c>.</para>
        /// <para>Note: In exported release builds the debug info is not available, so the returned dictionaries will contain only method names.</para>
        /// </summary>
        [GodotMethod("class_get_method_list")]
        public static Godot.Collections.Array ClassGetMethodList(string @class, bool noInheritance = false)
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_2_1168(method_bind_14, ptr, @class, noInheritance));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_integer_constant_list");

        /// <summary>
        /// <para>Returns an array with the names all the integer constants of <c>class</c> or its ancestry.</para>
        /// </summary>
        [GodotMethod("class_get_integer_constant_list")]
        public static string[] ClassGetIntegerConstantList(string @class, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_2_1172(method_bind_15, ptr, @class, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_has_integer_constant");

        /// <summary>
        /// <para>Returns whether <c>class</c> or its ancestry has an integer constant called <c>name</c> or not.</para>
        /// </summary>
        [GodotMethod("class_has_integer_constant")]
        public static bool ClassHasIntegerConstant(string @class, string name)
        {
            return NativeCalls.godot_icall_2_116(method_bind_16, ptr, @class, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_integer_constant");

        /// <summary>
        /// <para>Returns the value of the integer constant <c>name</c> of <c>class</c> or its ancestry. Always returns 0 when the constant could not be found.</para>
        /// </summary>
        [GodotMethod("class_get_integer_constant")]
        public static int ClassGetIntegerConstant(string @class, string name)
        {
            return NativeCalls.godot_icall_2_321(method_bind_17, ptr, @class, name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_has_enum");

        /// <summary>
        /// <para>Returns whether <c>class</c> or its ancestry has an enum called <c>name</c> or not.</para>
        /// </summary>
        [GodotMethod("class_has_enum")]
        public static bool ClassHasEnum(string @class, string name, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_3_1171(method_bind_18, ptr, @class, name, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_enum_list");

        /// <summary>
        /// <para>Returns an array with all the enums of <c>class</c> or its ancestry.</para>
        /// </summary>
        [GodotMethod("class_get_enum_list")]
        public static string[] ClassGetEnumList(string @class, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_2_1172(method_bind_19, ptr, @class, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_enum_constants");

        /// <summary>
        /// <para>Returns an array with all the keys in <c>enum</c> of <c>class</c> or its ancestry.</para>
        /// </summary>
        [GodotMethod("class_get_enum_constants")]
        public static string[] ClassGetEnumConstants(string @class, string @enum, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_3_1173(method_bind_20, ptr, @class, @enum, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_integer_constant_enum");

        /// <summary>
        /// <para>Returns which enum the integer constant <c>name</c> of <c>class</c> or its ancestry belongs to.</para>
        /// </summary>
        [GodotMethod("class_get_integer_constant_enum")]
        public static string ClassGetIntegerConstantEnum(string @class, string name, bool noInheritance = false)
        {
            return NativeCalls.godot_icall_3_1174(method_bind_21, ptr, @class, name, noInheritance);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "class_get_category");

        /// <summary>
        /// <para>Returns a category associated with the class for use in documentation and the Asset Library. Debug mode required.</para>
        /// </summary>
        [GodotMethod("class_get_category")]
        public static string ClassGetCategory(string @class)
        {
            return NativeCalls.godot_icall_1_124(method_bind_22, ptr, @class);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_class_enabled");

        /// <summary>
        /// <para>Returns whether this <c>class</c> is enabled or not.</para>
        /// </summary>
        [GodotMethod("is_class_enabled")]
        public static bool IsClassEnabled(string @class)
        {
            return NativeCalls.godot_icall_1_108(method_bind_23, ptr, @class);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
