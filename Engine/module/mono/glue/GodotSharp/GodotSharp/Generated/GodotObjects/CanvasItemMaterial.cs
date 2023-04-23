using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para><see cref="Godot.CanvasItemMaterial"/>s provide a means of modifying the textures associated with a CanvasItem. They specialize in describing blend and lighting behaviors for textures. Use a <see cref="Godot.ShaderMaterial"/> to more fully customize a material's interactions with a <see cref="Godot.CanvasItem"/>.</para>
    /// </summary>
    public partial class CanvasItemMaterial : Material
    {
        public enum LightModeEnum
        {
            /// <summary>
            /// <para>Render the material using both light and non-light sensitive material properties.</para>
            /// </summary>
            Normal = 0,
            /// <summary>
            /// <para>Render the material as if there were no light.</para>
            /// </summary>
            Unshaded = 1,
            /// <summary>
            /// <para>Render the material as if there were only light.</para>
            /// </summary>
            LightOnly = 2
        }

        public enum BlendModeEnum
        {
            /// <summary>
            /// <para>Mix blending mode. Colors are assumed to be independent of the alpha (opacity) value.</para>
            /// </summary>
            Mix = 0,
            /// <summary>
            /// <para>Additive blending mode.</para>
            /// </summary>
            Add = 1,
            /// <summary>
            /// <para>Subtractive blending mode.</para>
            /// </summary>
            Sub = 2,
            /// <summary>
            /// <para>Multiplicative blending mode.</para>
            /// </summary>
            Mul = 3,
            /// <summary>
            /// <para>Mix blending mode. Colors are assumed to be premultiplied by the alpha (opacity) value.</para>
            /// </summary>
            PremultAlpha = 4
        }

        /// <summary>
        /// <para>The manner in which a material's rendering is applied to underlying textures.</para>
        /// </summary>
        public CanvasItemMaterial.BlendModeEnum BlendMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The manner in which material reacts to lighting.</para>
        /// </summary>
        public CanvasItemMaterial.LightModeEnum LightMode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLightMode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLightMode(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, enable spritesheet-based animation features when assigned to <see cref="Godot.Particles2D"/> and <see cref="Godot.CPUParticles2D"/> nodes. The <see cref="Godot.ParticlesMaterial.AnimSpeed"/> or <see cref="Godot.CPUParticles2D.AnimSpeed"/> should also be set to a positive value for the animation to play.</para>
        /// <para>This property (and other <c>particles_anim_*</c> properties that depend on it) has no effect on other types of nodes.</para>
        /// </summary>
        public bool ParticlesAnimation
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimation();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimation(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of columns in the spritesheet assigned as <see cref="Godot.Texture"/> for a <see cref="Godot.Particles2D"/> or <see cref="Godot.CPUParticles2D"/>.</para>
        /// <para>Note: This property is only used and visible in the editor if <see cref="Godot.CanvasItemMaterial.ParticlesAnimation"/> is <c>true</c>.</para>
        /// </summary>
        public int ParticlesAnimHFrames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimHFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimHFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of rows in the spritesheet assigned as <see cref="Godot.Texture"/> for a <see cref="Godot.Particles2D"/> or <see cref="Godot.CPUParticles2D"/>.</para>
        /// <para>Note: This property is only used and visible in the editor if <see cref="Godot.CanvasItemMaterial.ParticlesAnimation"/> is <c>true</c>.</para>
        /// </summary>
        public int ParticlesAnimVFrames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimVFrames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimVFrames(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, the particles animation will loop.</para>
        /// <para>Note: This property is only used and visible in the editor if <see cref="Godot.CanvasItemMaterial.ParticlesAnimation"/> is <c>true</c>.</para>
        /// </summary>
        public bool ParticlesAnimLoop
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetParticlesAnimLoop();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetParticlesAnimLoop(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "CanvasItemMaterial";

        public CanvasItemMaterial() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CanvasItemMaterial_Ctor(this);
        }

        internal CanvasItemMaterial(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_mode");

        [GodotMethod("set_blend_mode")]
        [Obsolete("SetBlendMode is deprecated. Use the BlendMode property instead.")]
        public void SetBlendMode(CanvasItemMaterial.BlendModeEnum blendMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_0, Object.GetPtr(this), (int)blendMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_mode");

        [GodotMethod("get_blend_mode")]
        [Obsolete("GetBlendMode is deprecated. Use the BlendMode property instead.")]
        public CanvasItemMaterial.BlendModeEnum GetBlendMode()
        {
            return (CanvasItemMaterial.BlendModeEnum)NativeCalls.godot_icall_0_281(method_bind_1, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_light_mode");

        [GodotMethod("set_light_mode")]
        [Obsolete("SetLightMode is deprecated. Use the LightMode property instead.")]
        public void SetLightMode(CanvasItemMaterial.LightModeEnum lightMode)
        {
            NativeCalls.godot_icall_1_4(method_bind_2, Object.GetPtr(this), (int)lightMode);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_light_mode");

        [GodotMethod("get_light_mode")]
        [Obsolete("GetLightMode is deprecated. Use the LightMode property instead.")]
        public CanvasItemMaterial.LightModeEnum GetLightMode()
        {
            return (CanvasItemMaterial.LightModeEnum)NativeCalls.godot_icall_0_282(method_bind_3, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_animation");

        [GodotMethod("set_particles_animation")]
        [Obsolete("SetParticlesAnimation is deprecated. Use the ParticlesAnimation property instead.")]
        public void SetParticlesAnimation(bool particlesAnim)
        {
            NativeCalls.godot_icall_1_16(method_bind_4, Object.GetPtr(this), particlesAnim);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_animation");

        [GodotMethod("get_particles_animation")]
        [Obsolete("GetParticlesAnimation is deprecated. Use the ParticlesAnimation property instead.")]
        public bool GetParticlesAnimation()
        {
            return NativeCalls.godot_icall_0_7(method_bind_5, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_h_frames");

        [GodotMethod("set_particles_anim_h_frames")]
        [Obsolete("SetParticlesAnimHFrames is deprecated. Use the ParticlesAnimHFrames property instead.")]
        public void SetParticlesAnimHFrames(int frames)
        {
            NativeCalls.godot_icall_1_4(method_bind_6, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_h_frames");

        [GodotMethod("get_particles_anim_h_frames")]
        [Obsolete("GetParticlesAnimHFrames is deprecated. Use the ParticlesAnimHFrames property instead.")]
        public int GetParticlesAnimHFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_7, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_v_frames");

        [GodotMethod("set_particles_anim_v_frames")]
        [Obsolete("SetParticlesAnimVFrames is deprecated. Use the ParticlesAnimVFrames property instead.")]
        public void SetParticlesAnimVFrames(int frames)
        {
            NativeCalls.godot_icall_1_4(method_bind_8, Object.GetPtr(this), frames);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_v_frames");

        [GodotMethod("get_particles_anim_v_frames")]
        [Obsolete("GetParticlesAnimVFrames is deprecated. Use the ParticlesAnimVFrames property instead.")]
        public int GetParticlesAnimVFrames()
        {
            return NativeCalls.godot_icall_0_5(method_bind_9, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_particles_anim_loop");

        [GodotMethod("set_particles_anim_loop")]
        [Obsolete("SetParticlesAnimLoop is deprecated. Use the ParticlesAnimLoop property instead.")]
        public void SetParticlesAnimLoop(bool loop)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), loop);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_particles_anim_loop");

        [GodotMethod("get_particles_anim_loop")]
        [Obsolete("GetParticlesAnimLoop is deprecated. Use the ParticlesAnimLoop property instead.")]
        public bool GetParticlesAnimLoop()
        {
            return NativeCalls.godot_icall_0_7(method_bind_11, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
