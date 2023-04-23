using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Base resource for <see cref="Godot.AnimationTree"/> nodes. In general, it's not used directly, but you can create custom ones with custom blending formulas.</para>
    /// <para>Inherit this when creating nodes mainly for use in <see cref="Godot.AnimationNodeBlendTree"/>, otherwise <see cref="Godot.AnimationRootNode"/> should be used instead.</para>
    /// </summary>
    public partial class AnimationNode : Resource
    {
        public enum FilterAction
        {
            /// <summary>
            /// <para>Do not use filtering.</para>
            /// </summary>
            Ignore = 0,
            /// <summary>
            /// <para>Paths matching the filter will be allowed to pass.</para>
            /// </summary>
            Pass = 1,
            /// <summary>
            /// <para>Paths matching the filter will be discarded.</para>
            /// </summary>
            Stop = 2,
            /// <summary>
            /// <para>Paths matching the filter will be blended (by the blend value).</para>
            /// </summary>
            Blend = 3
        }

        /// <summary>
        /// <para>If <c>true</c>, filtering is enabled.</para>
        /// </summary>
        public bool FilterEnabled
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsFilterEnabled();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFilterEnabled(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Filters
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _GetFilters();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetFilters(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNode";

        public AnimationNode() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNode_Ctor(this);
        }

        internal AnimationNode(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to override the text caption for this node.</para>
        /// </summary>
        [GodotMethod("get_caption")]
        public virtual string GetCaption()
        {
            return default(string);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to return a child node by its <c>name</c>.</para>
        /// </summary>
        [GodotMethod("get_child_by_name")]
        public virtual Object GetChildByName(string name)
        {
            return default(Object);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to return all children nodes in order as a <c>name: node</c> dictionary.</para>
        /// </summary>
        [GodotMethod("get_child_nodes")]
        public virtual Godot.Collections.Dictionary GetChildNodes()
        {
            return default(Godot.Collections.Dictionary);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to return the default value of parameter "<c>name</c>". Parameters are custom local memory used for your nodes, given a resource can be reused in multiple trees.</para>
        /// </summary>
        [GodotMethod("get_parameter_default_value")]
        public virtual object GetParameterDefaultValue(string name)
        {
            return default(object);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to return a list of the properties on this node. Parameters are custom local memory used for your nodes, given a resource can be reused in multiple trees. Format is similar to <see cref="Godot.Object.GetPropertyList"/>.</para>
        /// </summary>
        [GodotMethod("get_parameter_list")]
        public virtual Godot.Collections.Array GetParameterList()
        {
            return default(Godot.Collections.Array);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to return whether the blend tree editor should display filter editing on this node.</para>
        /// </summary>
        [GodotMethod("has_filter")]
        public virtual bool HasFilter()
        {
            return default(bool);
        }

        /// <summary>
        /// <para>When inheriting from <see cref="Godot.AnimationRootNode"/>, implement this virtual method to run some code when this node is processed. The <c>time</c> parameter is a relative delta, unless <c>seek</c> is <c>true</c>, in which case it is absolute.</para>
        /// <para>Here, call the <see cref="Godot.AnimationNode.BlendInput"/>, <see cref="Godot.AnimationNode.BlendNode"/> or <see cref="Godot.AnimationNode.BlendAnimation"/> functions. You can also use <see cref="Godot.AnimationNode.GetParameter"/> and <see cref="Godot.AnimationNode.SetParameter"/> to modify local memory.</para>
        /// <para>This function should return the time left for the current animation to finish (if unsure, pass the value from the main blend being called).</para>
        /// </summary>
        [GodotMethod("process")]
        public virtual void Process(float time, bool seek)
        {
            return;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_count");

        /// <summary>
        /// <para>Amount of inputs in this node, only useful for nodes that go into <see cref="Godot.AnimationNodeBlendTree"/>.</para>
        /// </summary>
        [GodotMethod("get_input_count")]
        public int GetInputCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_0, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_name");

        /// <summary>
        /// <para>Gets the name of an input by index.</para>
        /// </summary>
        [GodotMethod("get_input_name")]
        public string GetInputName(int input)
        {
            return NativeCalls.godot_icall_1_89(method_bind_1, Object.GetPtr(this), input);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_input");

        /// <summary>
        /// <para>Adds an input to the node. This is only useful for nodes created for use in an <see cref="Godot.AnimationNodeBlendTree"/>.</para>
        /// </summary>
        [GodotMethod("add_input")]
        public void AddInput(string name)
        {
            NativeCalls.godot_icall_1_54(method_bind_2, Object.GetPtr(this), name);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_input");

        /// <summary>
        /// <para>Removes an input, call this only when inactive.</para>
        /// </summary>
        [GodotMethod("remove_input")]
        public void RemoveInput(int index)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), index);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_filter_path");

        /// <summary>
        /// <para>Adds or removes a path for the filter.</para>
        /// </summary>
        [GodotMethod("set_filter_path")]
        public void SetFilterPath(NodePath path, bool enable)
        {
            NativeCalls.godot_icall_2_90(method_bind_4, Object.GetPtr(this), NodePath.GetPtr(path), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_path_filtered");

        /// <summary>
        /// <para>Returns whether the given path is filtered.</para>
        /// </summary>
        [GodotMethod("is_path_filtered")]
        public bool IsPathFiltered(NodePath path)
        {
            return NativeCalls.godot_icall_1_91(method_bind_5, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_filter_enabled");

        [GodotMethod("set_filter_enabled")]
        [Obsolete("SetFilterEnabled is deprecated. Use the FilterEnabled property instead.")]
        public void SetFilterEnabled(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_6, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_filter_enabled");

        [GodotMethod("is_filter_enabled")]
        [Obsolete("IsFilterEnabled is deprecated. Use the FilterEnabled property instead.")]
        public bool IsFilterEnabled()
        {
            return NativeCalls.godot_icall_0_7(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_filters");

        [Obsolete("_SetFilters is deprecated. Use the Filters property instead.")]
        internal void _SetFilters(Godot.Collections.Array filters)
        {
            NativeCalls.godot_icall_1_92(method_bind_8, Object.GetPtr(this), filters.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_get_filters");

        [Obsolete("_GetFilters is deprecated. Use the Filters property instead.")]
        internal Godot.Collections.Array _GetFilters()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_9, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend_animation");

        /// <summary>
        /// <para>Blend an animation by <c>blend</c> amount (name must be valid in the linked <see cref="Godot.AnimationPlayer"/>). A <c>time</c> and <c>delta</c> may be passed, as well as whether <c>seek</c> happened.</para>
        /// </summary>
        [GodotMethod("blend_animation")]
        public void BlendAnimation(string animation, float time, float delta, bool seeked, float blend)
        {
            NativeCalls.godot_icall_5_93(method_bind_10, Object.GetPtr(this), animation, time, delta, seeked, blend);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend_node");

        /// <summary>
        /// <para>Blend another animation node (in case this node contains children animation nodes). This function is only useful if you inherit from <see cref="Godot.AnimationRootNode"/> instead, else editors will not display your node for addition.</para>
        /// </summary>
        [GodotMethod("blend_node")]
        public float BlendNode(string name, AnimationNode node, float time, bool seek, float blend, AnimationNode.FilterAction filter = (AnimationNode.FilterAction)0, bool optimize = true)
        {
            return NativeCalls.godot_icall_7_94(method_bind_11, Object.GetPtr(this), name, Object.GetPtr(node), time, seek, blend, (int)filter, optimize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "blend_input");

        /// <summary>
        /// <para>Blend an input. This is only useful for nodes created for an <see cref="Godot.AnimationNodeBlendTree"/>. The <c>time</c> parameter is a relative delta, unless <c>seek</c> is <c>true</c>, in which case it is absolute. A filter mode may be optionally passed (see <see cref="Godot.AnimationNode.FilterAction"/> for options).</para>
        /// </summary>
        [GodotMethod("blend_input")]
        public float BlendInput(int inputIndex, float time, bool seek, float blend, AnimationNode.FilterAction filter = (AnimationNode.FilterAction)0, bool optimize = true)
        {
            return NativeCalls.godot_icall_6_95(method_bind_12, Object.GetPtr(this), inputIndex, time, seek, blend, (int)filter, optimize);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_parameter");

        /// <summary>
        /// <para>Sets a custom parameter. These are used as local memory, because resources can be reused across the tree or scenes.</para>
        /// </summary>
        [GodotMethod("set_parameter")]
        public void SetParameter(string name, object value)
        {
            NativeCalls.godot_icall_2_96(method_bind_13, Object.GetPtr(this), name, value);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_parameter");

        /// <summary>
        /// <para>Gets the value of a parameter. Parameters are custom local memory used for your nodes, given a resource can be reused in multiple trees.</para>
        /// </summary>
        [GodotMethod("get_parameter")]
        public object GetParameter(string name)
        {
            return NativeCalls.godot_icall_1_97(method_bind_14, Object.GetPtr(this), name);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
