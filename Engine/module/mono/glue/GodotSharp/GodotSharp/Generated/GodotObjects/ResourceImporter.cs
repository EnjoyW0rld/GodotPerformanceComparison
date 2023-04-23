using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>This is the base class for the resource importers implemented in core. To implement your own resource importers using editor plugins, see <see cref="Godot.EditorImportPlugin"/>.</para>
    /// </summary>
    public abstract partial class ResourceImporter : Reference
    {
        public enum ImportOrder
        {
            /// <summary>
            /// <para>The default import order.</para>
            /// </summary>
            Default = 0,
            /// <summary>
            /// <para>The import order for scenes, which ensures scenes are imported after all other core resources such as textures. Custom importers should generally have an import order lower than <c>100</c> to avoid issues when importing scenes that rely on custom resources.</para>
            /// </summary>
            Scene = 100
        }

        private const string nativeName = "ResourceImporter";

        internal ResourceImporter() {}

        internal ResourceImporter(bool memoryOwn) : base(memoryOwn) {}
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
