using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Simple state machine for cases which don't require a more advanced <see cref="Godot.AnimationNodeStateMachine"/>. Animations can be connected to the inputs and transition times can be specified.</para>
    /// </summary>
    public partial class AnimationNodeTransition : AnimationNode
    {
        /// <summary>
        /// <para>The number of available input ports for this node.</para>
        /// </summary>
        public int InputCount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetEnabledInputs();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEnabledInputs(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Cross-fading time (in seconds) between each animation connected to the inputs.</para>
        /// </summary>
        public float XfadeTime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCrossFadeTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCrossFadeTime(value);
            }
#pragma warning restore CS0618
        }

        public string Input0__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(0, value);
            }
#pragma warning restore CS0618
        }

        public bool Input0__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(0, value);
            }
#pragma warning restore CS0618
        }

        public string Input1__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(1, value);
            }
#pragma warning restore CS0618
        }

        public bool Input1__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(1, value);
            }
#pragma warning restore CS0618
        }

        public string Input2__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(2, value);
            }
#pragma warning restore CS0618
        }

        public bool Input2__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(2, value);
            }
#pragma warning restore CS0618
        }

        public string Input3__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(3, value);
            }
#pragma warning restore CS0618
        }

        public bool Input3__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(3, value);
            }
#pragma warning restore CS0618
        }

        public string Input4__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(4, value);
            }
#pragma warning restore CS0618
        }

        public bool Input4__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(4, value);
            }
#pragma warning restore CS0618
        }

        public string Input5__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(5, value);
            }
#pragma warning restore CS0618
        }

        public bool Input5__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(5, value);
            }
#pragma warning restore CS0618
        }

        public string Input6__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(6, value);
            }
#pragma warning restore CS0618
        }

        public bool Input6__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(6, value);
            }
#pragma warning restore CS0618
        }

        public string Input7__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(7, value);
            }
#pragma warning restore CS0618
        }

        public bool Input7__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(7, value);
            }
#pragma warning restore CS0618
        }

        public string Input8__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(8, value);
            }
#pragma warning restore CS0618
        }

        public bool Input8__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(8, value);
            }
#pragma warning restore CS0618
        }

        public string Input9__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(9, value);
            }
#pragma warning restore CS0618
        }

        public bool Input9__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(9, value);
            }
#pragma warning restore CS0618
        }

        public string Input10__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(10, value);
            }
#pragma warning restore CS0618
        }

        public bool Input10__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(10, value);
            }
#pragma warning restore CS0618
        }

        public string Input11__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(11, value);
            }
#pragma warning restore CS0618
        }

        public bool Input11__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(11, value);
            }
#pragma warning restore CS0618
        }

        public string Input12__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(12, value);
            }
#pragma warning restore CS0618
        }

        public bool Input12__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(12, value);
            }
#pragma warning restore CS0618
        }

        public string Input13__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(13, value);
            }
#pragma warning restore CS0618
        }

        public bool Input13__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(13, value);
            }
#pragma warning restore CS0618
        }

        public string Input14__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(14, value);
            }
#pragma warning restore CS0618
        }

        public bool Input14__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(14, value);
            }
#pragma warning restore CS0618
        }

        public string Input15__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(15, value);
            }
#pragma warning restore CS0618
        }

        public bool Input15__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(15, value);
            }
#pragma warning restore CS0618
        }

        public string Input16__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(16, value);
            }
#pragma warning restore CS0618
        }

        public bool Input16__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(16, value);
            }
#pragma warning restore CS0618
        }

        public string Input17__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(17, value);
            }
#pragma warning restore CS0618
        }

        public bool Input17__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(17, value);
            }
#pragma warning restore CS0618
        }

        public string Input18__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(18, value);
            }
#pragma warning restore CS0618
        }

        public bool Input18__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(18, value);
            }
#pragma warning restore CS0618
        }

        public string Input19__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(19, value);
            }
#pragma warning restore CS0618
        }

        public bool Input19__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(19, value);
            }
#pragma warning restore CS0618
        }

        public string Input20__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(20, value);
            }
#pragma warning restore CS0618
        }

        public bool Input20__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(20, value);
            }
#pragma warning restore CS0618
        }

        public string Input21__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(21, value);
            }
#pragma warning restore CS0618
        }

        public bool Input21__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(21, value);
            }
#pragma warning restore CS0618
        }

        public string Input22__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(22, value);
            }
#pragma warning restore CS0618
        }

        public bool Input22__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(22, value);
            }
#pragma warning restore CS0618
        }

        public string Input23__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(23, value);
            }
#pragma warning restore CS0618
        }

        public bool Input23__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(23, value);
            }
#pragma warning restore CS0618
        }

        public string Input24__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(24, value);
            }
#pragma warning restore CS0618
        }

        public bool Input24__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(24, value);
            }
#pragma warning restore CS0618
        }

        public string Input25__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(25, value);
            }
#pragma warning restore CS0618
        }

        public bool Input25__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(25, value);
            }
#pragma warning restore CS0618
        }

        public string Input26__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(26, value);
            }
#pragma warning restore CS0618
        }

        public bool Input26__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(26, value);
            }
#pragma warning restore CS0618
        }

        public string Input27__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(27, value);
            }
#pragma warning restore CS0618
        }

        public bool Input27__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(27, value);
            }
#pragma warning restore CS0618
        }

        public string Input28__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(28, value);
            }
#pragma warning restore CS0618
        }

        public bool Input28__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(28, value);
            }
#pragma warning restore CS0618
        }

        public string Input29__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(29, value);
            }
#pragma warning restore CS0618
        }

        public bool Input29__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(29, value);
            }
#pragma warning restore CS0618
        }

        public string Input30__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(30, value);
            }
#pragma warning restore CS0618
        }

        public bool Input30__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(30, value);
            }
#pragma warning restore CS0618
        }

        public string Input31__name
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInputCaption(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputCaption(31, value);
            }
#pragma warning restore CS0618
        }

        public bool Input31__autoAdvance
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsInputSetAsAutoAdvance(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInputAsAutoAdvance(31, value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeTransition";

        public AnimationNodeTransition() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeTransition_Ctor(this);
        }

        internal AnimationNodeTransition(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_enabled_inputs");

        [GodotMethod("set_enabled_inputs")]
        [Obsolete("SetEnabledInputs is deprecated. Use the InputCount property instead.")]
        public void SetEnabledInputs(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_enabled_inputs");

        [GodotMethod("get_enabled_inputs")]
        [Obsolete("GetEnabledInputs is deprecated. Use the InputCount property instead.")]
        public int GetEnabledInputs()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_as_auto_advance");

        [GodotMethod("set_input_as_auto_advance")]
        [Obsolete("SetInputAsAutoAdvance is deprecated. Use the Input31__autoAdvance property instead.")]
        public void SetInputAsAutoAdvance(int input, bool enable)
        {
            NativeCalls.godot_icall_2_23(method_bind_2, Object.GetPtr(this), input, enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_input_set_as_auto_advance");

        [GodotMethod("is_input_set_as_auto_advance")]
        [Obsolete("IsInputSetAsAutoAdvance is deprecated. Use the Input31__autoAdvance property instead.")]
        public bool IsInputSetAsAutoAdvance(int input)
        {
            return NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), input);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_input_caption");

        [GodotMethod("set_input_caption")]
        [Obsolete("SetInputCaption is deprecated. Use the Input31__name property instead.")]
        public void SetInputCaption(int input, string caption)
        {
            NativeCalls.godot_icall_2_121(method_bind_4, Object.GetPtr(this), input, caption);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_input_caption");

        [GodotMethod("get_input_caption")]
        [Obsolete("GetInputCaption is deprecated. Use the Input31__name property instead.")]
        public string GetInputCaption(int input)
        {
            return NativeCalls.godot_icall_1_89(method_bind_5, Object.GetPtr(this), input);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cross_fade_time");

        [GodotMethod("set_cross_fade_time")]
        [Obsolete("SetCrossFadeTime is deprecated. Use the XfadeTime property instead.")]
        public void SetCrossFadeTime(float time)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), time);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cross_fade_time");

        [GodotMethod("get_cross_fade_time")]
        [Obsolete("GetCrossFadeTime is deprecated. Use the XfadeTime property instead.")]
        public float GetCrossFadeTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_7, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
