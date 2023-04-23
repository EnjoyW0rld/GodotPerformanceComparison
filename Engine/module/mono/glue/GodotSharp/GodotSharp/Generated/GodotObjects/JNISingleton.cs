using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>The JNISingleton is implemented only in the Android export. It's used to call methods and connect signals from an Android plugin written in Java or Kotlin. Methods and signals can be called and connected to the JNISingleton as if it is a Node. See <a href="https://en.wikipedia.org/wiki/Java_Native_Interface">Java Native Interface - Wikipedia</a> for more information.</para>
    /// </summary>
    public partial class JNISingleton : Object
    {
        private const string nativeName = "JNISingleton";

        public JNISingleton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_JNISingleton_Ctor(this);
        }

        internal JNISingleton(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
