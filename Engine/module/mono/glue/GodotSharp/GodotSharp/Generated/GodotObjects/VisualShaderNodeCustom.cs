using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>By inheriting this class you can create a custom <see cref="Godot.VisualShader"/> script addon which will be automatically added to the Visual Shader Editor. The <see cref="Godot.VisualShaderNode"/>'s behavior is defined by overriding the provided virtual methods.</para>
    /// <para>In order for the node to be registered as an editor addon, you must use the <c>tool</c> keyword and provide a <c>class_name</c> for your custom script. For example:</para>
    /// <para><code>
    /// tool
    /// extends VisualShaderNodeCustom
    /// class_name VisualShaderNodeNoise
    /// </code></para>
    /// </summary>
    public partial class VisualShaderNodeCustom : VisualShaderNode
    {
        public bool Initialized
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return _IsInitialized();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _SetInitialized(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "VisualShaderNodeCustom";

        public VisualShaderNodeCustom() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualShaderNodeCustom_Ctor(this);
        }

        internal VisualShaderNodeCustom(bool memoryOwn) : base(memoryOwn) {}

        /// <summary>
        /// <para>Override this method to define the category of the associated custom node in the Visual Shader Editor's members dialog. The path may look like <c>"MyGame/MyFunctions/Noise"</c>.</para>
        /// <para>Defining this method is optional. If not overridden, the node will be filed under the "Custom" category.</para>
        /// </summary>
        [GodotMethod("_get_category")]
        public virtual string _GetCategory()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the actual shader code of the associated custom node. The shader code should be returned as a string, which can have multiple lines (the <c>"""</c> multiline string construct can be used for convenience).</para>
        /// <para>The <c>input_vars</c> and <c>output_vars</c> arrays contain the string names of the various input and output variables, as defined by <c>_get_input_*</c> and <c>_get_output_*</c> virtual methods in this class.</para>
        /// <para>The output ports can be assigned values in the shader code. For example, <c>return output_vars[0] + " = " + input_vars[0] + ";"</c>.</para>
        /// <para>You can customize the generated code based on the shader <c>mode</c> (see <see cref="Godot.Shader.Mode"/>) and/or <c>type</c> (see <see cref="Godot.VisualShader.Type"/>).</para>
        /// <para>Defining this method is required.</para>
        /// </summary>
        [GodotMethod("_get_code")]
        public virtual string _GetCode(Godot.Collections.Array inputVars, Godot.Collections.Array outputVars, int mode, int type)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the description of the associated custom node in the Visual Shader Editor's members dialog.</para>
        /// <para>Defining this method is optional.</para>
        /// </summary>
        [GodotMethod("_get_description")]
        public virtual string _GetDescription()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to add shader code on top of the global shader, to define your own standard library of reusable methods, varyings, constants, uniforms, etc. The shader code should be returned as a string, which can have multiple lines (the <c>"""</c> multiline string construct can be used for convenience).</para>
        /// <para>Be careful with this functionality as it can cause name conflicts with other custom nodes, so be sure to give the defined entities unique names.</para>
        /// <para>You can customize the generated code based on the shader <c>mode</c> (see <see cref="Godot.Shader.Mode"/>).</para>
        /// <para>Defining this method is optional.</para>
        /// </summary>
        [GodotMethod("_get_global_code")]
        public virtual string _GetGlobalCode(int mode)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the amount of input ports of the associated custom node.</para>
        /// <para>Defining this method is required. If not overridden, the node has no input ports.</para>
        /// </summary>
        [GodotMethod("_get_input_port_count")]
        public virtual int _GetInputPortCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define the names of input ports of the associated custom node. The names are used both for the input slots in the editor and as identifiers in the shader code, and are passed in the <c>input_vars</c> array in <see cref="Godot.VisualShaderNodeCustom._GetCode"/>.</para>
        /// <para>Defining this method is optional, but recommended. If not overridden, input ports are named as <c>"in" + str(port)</c>.</para>
        /// </summary>
        [GodotMethod("_get_input_port_name")]
        public virtual string _GetInputPortName(int port)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the returned type of each input port of the associated custom node (see <see cref="Godot.VisualShaderNode.PortType"/> for possible types).</para>
        /// <para>Defining this method is optional, but recommended. If not overridden, input ports will return the <see cref="Godot.VisualShaderNode.PortType.Scalar"/> type.</para>
        /// </summary>
        [GodotMethod("_get_input_port_type")]
        public virtual int _GetInputPortType(int port)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define the name of the associated custom node in the Visual Shader Editor's members dialog and graph.</para>
        /// <para>Defining this method is optional, but recommended. If not overridden, the node will be named as "Unnamed".</para>
        /// </summary>
        [GodotMethod("_get_name")]
        public virtual string _GetName()
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the amount of output ports of the associated custom node.</para>
        /// <para>Defining this method is required. If not overridden, the node has no output ports.</para>
        /// </summary>
        [GodotMethod("_get_output_port_count")]
        public virtual int _GetOutputPortCount()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define the names of output ports of the associated custom node. The names are used both for the output slots in the editor and as identifiers in the shader code, and are passed in the <c>output_vars</c> array in <see cref="Godot.VisualShaderNodeCustom._GetCode"/>.</para>
        /// <para>Defining this method is optional, but recommended. If not overridden, output ports are named as <c>"out" + str(port)</c>.</para>
        /// </summary>
        [GodotMethod("_get_output_port_name")]
        public virtual string _GetOutputPortName(int port)
        {
            return default(string);
        }

        /// <summary>
        /// <para>Override this method to define the returned type of each output port of the associated custom node (see <see cref="Godot.VisualShaderNode.PortType"/> for possible types).</para>
        /// <para>Defining this method is optional, but recommended. If not overridden, output ports will return the <see cref="Godot.VisualShaderNode.PortType.Scalar"/> type.</para>
        /// </summary>
        [GodotMethod("_get_output_port_type")]
        public virtual int _GetOutputPortType(int port)
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define the return icon of the associated custom node in the Visual Shader Editor's members dialog.</para>
        /// <para>Defining this method is optional. If not overridden, no return icon is shown.</para>
        /// </summary>
        [GodotMethod("_get_return_icon_type")]
        public virtual int _GetReturnIconType()
        {
            return default(int);
        }

        /// <summary>
        /// <para>Override this method to define the subcategory of the associated custom node in the Visual Shader Editor's members dialog.</para>
        /// <para>Defining this method is optional. If not overridden, the node will be filed under the root of the main category (see <see cref="Godot.VisualShaderNodeCustom._GetCategory"/>).</para>
        /// </summary>
        [GodotMethod("_get_subcategory")]
        public virtual string _GetSubcategory()
        {
            return default(string);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_set_initialized");

        [Obsolete("_SetInitialized is deprecated. Use the Initialized property instead.")]
        internal void _SetInitialized(bool enabled)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), enabled);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_is_initialized");

        [Obsolete("_IsInitialized is deprecated. Use the Initialized property instead.")]
        internal bool _IsInitialized()
        {
            return NativeCalls.godot_icall_0_7(method_bind_1, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
