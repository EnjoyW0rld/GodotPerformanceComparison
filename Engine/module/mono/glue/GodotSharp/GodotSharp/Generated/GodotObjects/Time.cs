using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The Time singleton allows converting time between various formats and also getting time information from the system.</para>
    /// <para>This class conforms with as many of the ISO 8601 standards as possible. All dates follow the Proleptic Gregorian calendar. As such, the day before <c>1582-10-15</c> is <c>1582-10-14</c>, not <c>1582-10-04</c>. The year before 1 AD (aka 1 BC) is number <c>0</c>, with the year before that (2 BC) being <c>-1</c>, etc.</para>
    /// <para>Conversion methods assume "the same timezone", and do not handle timezone conversions or DST automatically. Leap seconds are also not handled, they must be done manually if desired. Suffixes such as "Z" are not handled, you need to strip them away manually.</para>
    /// <para>When getting time information from the system, the time can either be in the local timezone or UTC depending on the <c>utc</c> parameter. However, the <see cref="Godot.Time.GetUnixTimeFromSystem"/> method always returns the time in UTC.</para>
    /// <para>Important: The <c>_from_system</c> methods use the system clock that the user can manually set. Never use this method for precise time calculation since its results are subject to automatic adjustments by the user or the operating system. Always use <see cref="Godot.Time.GetTicksUsec"/> or <see cref="Godot.Time.GetTicksMsec"/> for precise time calculation instead, since they are guaranteed to be monotonic (i.e. never decrease).</para>
    /// </summary>
    public static partial class Time
    {
        public enum Month
        {
            /// <summary>
            /// <para>The month of January, represented numerically as <c>01</c>.</para>
            /// </summary>
            January = 1,
            /// <summary>
            /// <para>The month of February, represented numerically as <c>02</c>.</para>
            /// </summary>
            February = 2,
            /// <summary>
            /// <para>The month of March, represented numerically as <c>03</c>.</para>
            /// </summary>
            March = 3,
            /// <summary>
            /// <para>The month of April, represented numerically as <c>04</c>.</para>
            /// </summary>
            April = 4,
            /// <summary>
            /// <para>The month of May, represented numerically as <c>05</c>.</para>
            /// </summary>
            May = 5,
            /// <summary>
            /// <para>The month of June, represented numerically as <c>06</c>.</para>
            /// </summary>
            June = 6,
            /// <summary>
            /// <para>The month of July, represented numerically as <c>07</c>.</para>
            /// </summary>
            July = 7,
            /// <summary>
            /// <para>The month of August, represented numerically as <c>08</c>.</para>
            /// </summary>
            August = 8,
            /// <summary>
            /// <para>The month of September, represented numerically as <c>09</c>.</para>
            /// </summary>
            September = 9,
            /// <summary>
            /// <para>The month of October, represented numerically as <c>10</c>.</para>
            /// </summary>
            October = 10,
            /// <summary>
            /// <para>The month of November, represented numerically as <c>11</c>.</para>
            /// </summary>
            November = 11,
            /// <summary>
            /// <para>The month of December, represented numerically as <c>12</c>.</para>
            /// </summary>
            December = 12
        }

        public enum Weekday
        {
            /// <summary>
            /// <para>The day of the week Sunday, represented numerically as <c>0</c>.</para>
            /// </summary>
            Sunday = 0,
            /// <summary>
            /// <para>The day of the week Monday, represented numerically as <c>1</c>.</para>
            /// </summary>
            Monday = 1,
            /// <summary>
            /// <para>The day of the week Tuesday, represented numerically as <c>2</c>.</para>
            /// </summary>
            Tuesday = 2,
            /// <summary>
            /// <para>The day of the week Wednesday, represented numerically as <c>3</c>.</para>
            /// </summary>
            Wednesday = 3,
            /// <summary>
            /// <para>The day of the week Thursday, represented numerically as <c>4</c>.</para>
            /// </summary>
            Thursday = 4,
            /// <summary>
            /// <para>The day of the week Friday, represented numerically as <c>5</c>.</para>
            /// </summary>
            Friday = 5,
            /// <summary>
            /// <para>The day of the week Saturday, represented numerically as <c>6</c>.</para>
            /// </summary>
            Saturday = 6
        }

        private static Godot.Object singleton;

        public static Godot.Object Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = Engine.GetSingleton(typeof(Time).Name);
                return singleton;
            }
        }

        private const string nativeName = "Time";
        internal static IntPtr ptr = NativeCalls.godot_icall_Time_get_singleton();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_dict_from_unix_time");

        /// <summary>
        /// <para>Converts the given Unix timestamp to a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, and <c>weekday</c>.</para>
        /// <para>The returned Dictionary's values will be the same as the <see cref="Godot.Time.GetDatetimeDictFromSystem"/> if the Unix timestamp is the current time, with the exception of Daylight Savings Time as it cannot be determined from the epoch.</para>
        /// </summary>
        [GodotMethod("get_datetime_dict_from_unix_time")]
        public static Godot.Collections.Dictionary GetDatetimeDictFromUnixTime(long unixTimeVal)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_963(method_bind_0, ptr, unixTimeVal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_date_dict_from_unix_time");

        /// <summary>
        /// <para>Converts the given Unix timestamp to a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, and <c>weekday</c>.</para>
        /// </summary>
        [GodotMethod("get_date_dict_from_unix_time")]
        public static Godot.Collections.Dictionary GetDateDictFromUnixTime(long unixTimeVal)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_963(method_bind_1, ptr, unixTimeVal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_dict_from_unix_time");

        /// <summary>
        /// <para>Converts the given time to a dictionary of keys: <c>hour</c>, <c>minute</c>, and <c>second</c>.</para>
        /// </summary>
        [GodotMethod("get_time_dict_from_unix_time")]
        public static Godot.Collections.Dictionary GetTimeDictFromUnixTime(long unixTimeVal)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_963(method_bind_2, ptr, unixTimeVal));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_string_from_unix_time");

        /// <summary>
        /// <para>Converts the given Unix timestamp to an ISO 8601 date and time string (YYYY-MM-DDTHH:MM:SS).</para>
        /// <para>If <c>use_space</c> is true, use a space instead of the letter T in the middle.</para>
        /// </summary>
        [GodotMethod("get_datetime_string_from_unix_time")]
        public static string GetDatetimeStringFromUnixTime(long unixTimeVal, bool useSpace = false)
        {
            return NativeCalls.godot_icall_2_964(method_bind_3, ptr, unixTimeVal, useSpace);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_date_string_from_unix_time");

        /// <summary>
        /// <para>Converts the given Unix timestamp to an ISO 8601 date string (YYYY-MM-DD).</para>
        /// </summary>
        [GodotMethod("get_date_string_from_unix_time")]
        public static string GetDateStringFromUnixTime(long unixTimeVal)
        {
            return NativeCalls.godot_icall_1_965(method_bind_4, ptr, unixTimeVal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_string_from_unix_time");

        /// <summary>
        /// <para>Converts the given Unix timestamp to an ISO 8601 time string (HH:MM:SS).</para>
        /// </summary>
        [GodotMethod("get_time_string_from_unix_time")]
        public static string GetTimeStringFromUnixTime(long unixTimeVal)
        {
            return NativeCalls.godot_icall_1_965(method_bind_5, ptr, unixTimeVal);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_dict_from_datetime_string");

        /// <summary>
        /// <para>Converts the given ISO 8601 date and time string (YYYY-MM-DDTHH:MM:SS) to a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>weekday</c>, <c>hour</c>, <c>minute</c>, and <c>second</c>.</para>
        /// <para>If <c>weekday</c> is false, then the <c>weekday</c> entry is excluded (the calculation is relatively expensive).</para>
        /// <para>Note: Any decimal fraction in the time string will be ignored silently.</para>
        /// </summary>
        [GodotMethod("get_datetime_dict_from_datetime_string")]
        public static Godot.Collections.Dictionary GetDatetimeDictFromDatetimeString(string datetime, bool weekday)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_2_966(method_bind_6, ptr, datetime, weekday));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_string_from_datetime_dict");

        /// <summary>
        /// <para>Converts the given dictionary of keys to an ISO 8601 date and time string (YYYY-MM-DDTHH:MM:SS).</para>
        /// <para>The given dictionary can be populated with the following keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>hour</c>, <c>minute</c>, and <c>second</c>. Any other entries (including <c>dst</c>) are ignored.</para>
        /// <para>If the dictionary is empty, <c>0</c> is returned. If some keys are omitted, they default to the equivalent values for the Unix epoch timestamp 0 (1970-01-01 at 00:00:00).</para>
        /// <para>If <c>use_space</c> is true, use a space instead of the letter T in the middle.</para>
        /// </summary>
        [GodotMethod("get_datetime_string_from_datetime_dict")]
        public static string GetDatetimeStringFromDatetimeDict(Godot.Collections.Dictionary datetime, bool useSpace)
        {
            return NativeCalls.godot_icall_2_967(method_bind_7, ptr, datetime.GetPtr(), useSpace);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unix_time_from_datetime_dict");

        /// <summary>
        /// <para>Converts a dictionary of time values to a Unix timestamp.</para>
        /// <para>The given dictionary can be populated with the following keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>hour</c>, <c>minute</c>, and <c>second</c>. Any other entries (including <c>dst</c>) are ignored.</para>
        /// <para>If the dictionary is empty, <c>0</c> is returned. If some keys are omitted, they default to the equivalent values for the Unix epoch timestamp 0 (1970-01-01 at 00:00:00).</para>
        /// <para>You can pass the output from <see cref="Godot.Time.GetDatetimeDictFromUnixTime"/> directly into this function and get the same as what was put in.</para>
        /// <para>Note: Unix timestamps are often in UTC. This method does not do any timezone conversion, so the timestamp will be in the same timezone as the given datetime dictionary.</para>
        /// </summary>
        [GodotMethod("get_unix_time_from_datetime_dict")]
        public static long GetUnixTimeFromDatetimeDict(Godot.Collections.Dictionary datetime)
        {
            return NativeCalls.godot_icall_1_968(method_bind_8, ptr, datetime.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unix_time_from_datetime_string");

        /// <summary>
        /// <para>Converts the given ISO 8601 date and/or time string to a Unix timestamp. The string can contain a date only, a time only, or both.</para>
        /// <para>Note: Unix timestamps are often in UTC. This method does not do any timezone conversion, so the timestamp will be in the same timezone as the given datetime string.</para>
        /// <para>Note: Any decimal fraction in the time string will be ignored silently.</para>
        /// </summary>
        [GodotMethod("get_unix_time_from_datetime_string")]
        public static long GetUnixTimeFromDatetimeString(string datetime)
        {
            return NativeCalls.godot_icall_1_969(method_bind_9, ptr, datetime);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_offset_string_from_offset_minutes");

        /// <summary>
        /// <para>Converts the given timezone offset in minutes to a timezone offset string. For example, -480 returns "-08:00", 345 returns "+05:45", and 0 returns "+00:00".</para>
        /// </summary>
        [GodotMethod("get_offset_string_from_offset_minutes")]
        public static string GetOffsetStringFromOffsetMinutes(long offsetMinutes)
        {
            return NativeCalls.godot_icall_1_965(method_bind_10, ptr, offsetMinutes);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_dict_from_system");

        /// <summary>
        /// <para>Returns the current date as a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>weekday</c>, <c>hour</c>, <c>minute</c>, and <c>second</c>.</para>
        /// </summary>
        [GodotMethod("get_datetime_dict_from_system")]
        public static Godot.Collections.Dictionary GetDatetimeDictFromSystem(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_11, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_date_dict_from_system");

        /// <summary>
        /// <para>Returns the current date as a dictionary of keys: <c>year</c>, <c>month</c>, <c>day</c>, <c>weekday</c>, and <c>dst</c> (Daylight Savings Time).</para>
        /// <para>The returned values are in the system's local time when <c>utc</c> is false, otherwise they are in UTC.</para>
        /// </summary>
        [GodotMethod("get_date_dict_from_system")]
        public static Godot.Collections.Dictionary GetDateDictFromSystem(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_12, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_dict_from_system");

        /// <summary>
        /// <para>Returns the current time as a dictionary of keys: <c>hour</c>, <c>minute</c>, and <c>second</c>.</para>
        /// <para>The returned values are in the system's local time when <c>utc</c> is false, otherwise they are in UTC.</para>
        /// </summary>
        [GodotMethod("get_time_dict_from_system")]
        public static Godot.Collections.Dictionary GetTimeDictFromSystem(bool utc = false)
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_1_536(method_bind_13, ptr, utc));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_datetime_string_from_system");

        /// <summary>
        /// <para>Returns the current date and time as an ISO 8601 date and time string (YYYY-MM-DDTHH:MM:SS).</para>
        /// <para>The returned values are in the system's local time when <c>utc</c> is false, otherwise they are in UTC.</para>
        /// <para>If <c>use_space</c> is true, use a space instead of the letter T in the middle.</para>
        /// </summary>
        [GodotMethod("get_datetime_string_from_system")]
        public static string GetDatetimeStringFromSystem(bool utc = false, bool useSpace = false)
        {
            return NativeCalls.godot_icall_2_970(method_bind_14, ptr, utc, useSpace);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_date_string_from_system");

        /// <summary>
        /// <para>Returns the current date as an ISO 8601 date string (YYYY-MM-DD).</para>
        /// <para>The returned values are in the system's local time when <c>utc</c> is false, otherwise they are in UTC.</para>
        /// </summary>
        [GodotMethod("get_date_string_from_system")]
        public static string GetDateStringFromSystem(bool utc = false)
        {
            return NativeCalls.godot_icall_1_338(method_bind_15, ptr, utc);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_string_from_system");

        /// <summary>
        /// <para>Returns the current time as an ISO 8601 time string (HH:MM:SS).</para>
        /// <para>The returned values are in the system's local time when <c>utc</c> is false, otherwise they are in UTC.</para>
        /// </summary>
        [GodotMethod("get_time_string_from_system")]
        public static string GetTimeStringFromSystem(bool utc = false)
        {
            return NativeCalls.godot_icall_1_338(method_bind_16, ptr, utc);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_time_zone_from_system");

        /// <summary>
        /// <para>Returns the current time zone as a dictionary of keys: <c>bias</c> and <c>name</c>. The <c>bias</c> value is the offset from UTC in minutes, since not all time zones are multiples of an hour from UTC.</para>
        /// </summary>
        [GodotMethod("get_time_zone_from_system")]
        public static Godot.Collections.Dictionary GetTimeZoneFromSystem()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_17, ptr));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unix_time_from_system");

        /// <summary>
        /// <para>Returns the current Unix timestamp in seconds based on the system time in UTC. This method is implemented by the operating system and always returns the time in UTC.</para>
        /// <para>Note: Unlike other methods that use integer timestamps, this method returns the timestamp as a <see cref="float"/> for sub-second precision.</para>
        /// </summary>
        [GodotMethod("get_unix_time_from_system")]
        public static double GetUnixTimeFromSystem()
        {
            return NativeCalls.godot_icall_0_179(method_bind_18, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks_msec");

        /// <summary>
        /// <para>Returns the amount of time passed in milliseconds since the engine started.</para>
        /// <para>Will always be positive or 0 and uses a 64-bit value (it will wrap after roughly 500 million years).</para>
        /// </summary>
        [GodotMethod("get_ticks_msec")]
        public static ulong GetTicksMsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_19, ptr);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_ticks_usec");

        /// <summary>
        /// <para>Returns the amount of time passed in microseconds since the engine started.</para>
        /// <para>Will always be positive or 0 and uses a 64-bit value (it will wrap after roughly half a million years).</para>
        /// </summary>
        [GodotMethod("get_ticks_usec")]
        public static ulong GetTicksUsec()
        {
            return NativeCalls.godot_icall_0_30(method_bind_20, ptr);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
