using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>InputEventMIDI allows receiving input events from MIDI devices such as a piano. MIDI stands for Musical Instrument Digital Interface.</para>
    /// <para>MIDI signals can be sent over a 5-pin MIDI connector or over USB, if your device supports both be sure to check the settings in the device to see which output it's using.</para>
    /// <para>To receive input events from MIDI devices, you need to call <see cref="Godot.OS.OpenMidiInputs"/>. You can check which devices are detected using <see cref="Godot.OS.GetConnectedMidiInputs"/>.</para>
    /// <para>Note that Godot does not currently support MIDI output, so there is no way to emit MIDI signals from Godot. Only MIDI input works.</para>
    /// </summary>
    public partial class InputEventMIDI : InputEvent
    {
        /// <summary>
        /// <para>The MIDI channel of this input event. There are 16 channels, so this value ranges from 0 to 15. MIDI channel 9 is reserved for the use with percussion instruments, the rest of the channels are for non-percussion instruments.</para>
        /// </summary>
        public int Channel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetChannel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetChannel(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Returns a value indicating the type of message for this MIDI signal. This is a member of the <see cref="Godot.MidiMessageList"/> enum.</para>
        /// <para>For MIDI messages between 0x80 and 0xEF, only the left half of the bits are returned as this value, as the other part is the channel (ex: 0x94 becomes 0x9). For MIDI messages from 0xF0 to 0xFF, the value is returned as-is.</para>
        /// <para>Notes will return <c>MIDI_MESSAGE_NOTE_ON</c> when activated, but they might not always return <c>MIDI_MESSAGE_NOTE_OFF</c> when deactivated, therefore your code should treat the input as stopped if some period of time has passed.</para>
        /// <para>For more information, see the MIDI message status byte list chart linked above.</para>
        /// </summary>
        public int Message
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMessage();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMessage(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The pitch index number of this MIDI signal. This value ranges from 0 to 127. On a piano, middle C is 60, and A440 is 69, see the "MIDI note" column of the piano key frequency chart on Wikipedia for more information.</para>
        /// </summary>
        public int Pitch
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPitch();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPitch(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The velocity of the MIDI signal. This value ranges from 0 to 127. For a piano, this corresponds to how quickly the key was pressed, and is rarely above about 110 in practice.</para>
        /// </summary>
        public int Velocity
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVelocity();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVelocity(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The instrument of this input event. This value ranges from 0 to 127. Refer to the instrument list on the General MIDI wikipedia article to see a list of instruments, except that this value is 0-index, so subtract one from every number on that chart. A standard piano will have an instrument number of 0.</para>
        /// </summary>
        public int Instrument
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetInstrument();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetInstrument(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The pressure of the MIDI signal. This value ranges from 0 to 127. For many devices, this value is always zero.</para>
        /// </summary>
        public int Pressure
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPressure();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPressure(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If the message is <c>MIDI_MESSAGE_CONTROL_CHANGE</c>, this indicates the controller number, otherwise this is zero. Controllers include devices such as pedals and levers.</para>
        /// </summary>
        public int ControllerNumber
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetControllerNumber();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetControllerNumber(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If the message is <c>MIDI_MESSAGE_CONTROL_CHANGE</c>, this indicates the controller value, otherwise this is zero. Controllers include devices such as pedals and levers.</para>
        /// </summary>
        public int ControllerValue
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetControllerValue();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetControllerValue(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "InputEventMIDI";

        public InputEventMIDI() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMIDI_Ctor(this);
        }

        internal InputEventMIDI(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_channel");

        [GodotMethod("set_channel")]
        [Obsolete("SetChannel is deprecated. Use the Channel property instead.")]
        public void SetChannel(int channel)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), channel);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_channel");

        [GodotMethod("get_channel")]
        [Obsolete("GetChannel is deprecated. Use the Channel property instead.")]
        public int GetChannel()
        {
            return NativeCalls.godot_icall_0_5(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_message");

        [GodotMethod("set_message")]
        [Obsolete("SetMessage is deprecated. Use the Message property instead.")]
        public void SetMessage(int message)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), message);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_message");

        [GodotMethod("get_message")]
        [Obsolete("GetMessage is deprecated. Use the Message property instead.")]
        public int GetMessage()
        {
            return NativeCalls.godot_icall_0_5(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pitch");

        [GodotMethod("set_pitch")]
        [Obsolete("SetPitch is deprecated. Use the Pitch property instead.")]
        public void SetPitch(int pitch)
        {
            NativeCalls.godot_icall_1_4(method_bind_4, Object.GetPtr(this), pitch);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pitch");

        [GodotMethod("get_pitch")]
        [Obsolete("GetPitch is deprecated. Use the Pitch property instead.")]
        public int GetPitch()
        {
            return NativeCalls.godot_icall_0_5(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_velocity");

        [GodotMethod("set_velocity")]
        [Obsolete("SetVelocity is deprecated. Use the Velocity property instead.")]
        public void SetVelocity(int velocity)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), velocity);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_velocity");

        [GodotMethod("get_velocity")]
        [Obsolete("GetVelocity is deprecated. Use the Velocity property instead.")]
        public int GetVelocity()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_instrument");

        [GodotMethod("set_instrument")]
        [Obsolete("SetInstrument is deprecated. Use the Instrument property instead.")]
        public void SetInstrument(int instrument)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), instrument);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_instrument");

        [GodotMethod("get_instrument")]
        [Obsolete("GetInstrument is deprecated. Use the Instrument property instead.")]
        public int GetInstrument()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pressure");

        [GodotMethod("set_pressure")]
        [Obsolete("SetPressure is deprecated. Use the Pressure property instead.")]
        public void SetPressure(int pressure)
        {
            NativeCalls.godot_icall_1_4(method_bind_10, Object.GetPtr(this), pressure);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pressure");

        [GodotMethod("get_pressure")]
        [Obsolete("GetPressure is deprecated. Use the Pressure property instead.")]
        public int GetPressure()
        {
            return NativeCalls.godot_icall_0_5(method_bind_11, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_controller_number");

        [GodotMethod("set_controller_number")]
        [Obsolete("SetControllerNumber is deprecated. Use the ControllerNumber property instead.")]
        public void SetControllerNumber(int controllerNumber)
        {
            NativeCalls.godot_icall_1_4(method_bind_12, Object.GetPtr(this), controllerNumber);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller_number");

        [GodotMethod("get_controller_number")]
        [Obsolete("GetControllerNumber is deprecated. Use the ControllerNumber property instead.")]
        public int GetControllerNumber()
        {
            return NativeCalls.godot_icall_0_5(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_controller_value");

        [GodotMethod("set_controller_value")]
        [Obsolete("SetControllerValue is deprecated. Use the ControllerValue property instead.")]
        public void SetControllerValue(int controllerValue)
        {
            NativeCalls.godot_icall_1_4(method_bind_14, Object.GetPtr(this), controllerValue);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_controller_value");

        [GodotMethod("get_controller_value")]
        [Obsolete("GetControllerValue is deprecated. Use the ControllerValue property instead.")]
        public int GetControllerValue()
        {
            return NativeCalls.godot_icall_0_5(method_bind_15, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
