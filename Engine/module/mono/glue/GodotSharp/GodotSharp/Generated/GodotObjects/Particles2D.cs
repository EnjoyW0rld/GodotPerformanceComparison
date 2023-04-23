using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>2D particle node used to create a variety of particle systems and effects. <see cref="Godot.Particles2D"/> features an emitter that generates some number of particles at a given rate.</para>
    /// <para>Use the <c>process_material</c> property to add a <see cref="Godot.ParticlesMaterial"/> to configure particle appearance and behavior. Alternatively, you can add a <see cref="Godot.ShaderMaterial"/> which will be applied to all particles.</para>
    /// <para>Note: <see cref="Godot.Particles2D"/> only work when using the GLES3 renderer. If using the GLES2 renderer, use <see cref="Godot.CPUParticles2D"/> instead. You can convert <see cref="Godot.Particles2D"/> to <see cref="Godot.CPUParticles2D"/> by selecting the node, clicking the Particles menu at the top of the 2D editor viewport then choosing Convert to CPUParticles2D.</para>
    /// <para>Note: On macOS, <see cref="Godot.Particles2D"/> rendering is much slower than <see cref="Godot.CPUParticles2D"/> due to transform feedback being implemented on the CPU instead of the GPU. Consider using <see cref="Godot.CPUParticles2D"/> instead when targeting macOS.</para>
    /// <para>Note: After working on a Particles node, remember to update its <see cref="Godot.Particles2D.VisibilityRect"/> by selecting it, clicking the Particles menu at the top of the 2D editor viewport then choose Generate Visibility Rect. Otherwise, particles may suddenly disappear depending on the camera position and angle.</para>
    /// <para>Note: Unlike <see cref="Godot.CPUParticles2D"/>, <see cref="Godot.Particles2D"/> currently ignore the texture region defined in <see cref="Godot.AtlasTexture"/>s.</para>
    /// </summary>
    public partial class Particles2D : Node2D
    {
        public enum DrawOrderEnum
        {
            /// <summary>
            /// <para>Particles are drawn in the order emitted.</para>
            /// </summary>
            Index = 0,
            /// <summary>
            /// <para>Particles are drawn in order of remaining lifetime.</para>
            /// </summary>
            Lifetime = 1
        }

        /// <summary>
        /// <para>If <c>true</c>, particles are being emitted.</para>
        /// </summary>
        public bool Emitting
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return IsEmitting();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetEmitting(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The number of particles emitted in one emission cycle (corresponding to the <see cref="Godot.Particles2D.Lifetime"/>).</para>
        /// <para>Note: Changing <see cref="Godot.Particles2D.Amount"/> will reset the particle emission, therefore removing all particles that were already emitted before changing <see cref="Godot.Particles2D.Amount"/>.</para>
        /// </summary>
        public int Amount
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAmount();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAmount(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The amount of time each particle will exist (in seconds).</para>
        /// </summary>
        public float Lifetime
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLifetime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLifetime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, only one emission cycle occurs. If set <c>true</c> during a cycle, emission will stop at the cycle's end.</para>
        /// </summary>
        public bool OneShot
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetOneShot();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetOneShot(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle system starts as if it had already run for this many seconds.</para>
        /// </summary>
        public float Preprocess
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetPreProcessTime();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetPreProcessTime(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle system's running speed scaling ratio. A value of <c>0</c> can be used to pause the particles.</para>
        /// </summary>
        public float SpeedScale
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSpeedScale();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSpeedScale(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>How rapidly particles in an emission cycle are emitted. If greater than <c>0</c>, there will be a gap in emissions before the next cycle begins.</para>
        /// </summary>
        public float Explosiveness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetExplosivenessRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetExplosivenessRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Emission lifetime randomness ratio.</para>
        /// </summary>
        public float Randomness
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRandomnessRatio();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRandomnessRatio(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The particle system's frame rate is fixed to a value. For instance, changing the value to 2 will make the particles render at 2 frames per second. Note this does not slow down the simulation of the particle system itself.</para>
        /// </summary>
        public int FixedFps
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFixedFps();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFixedFps(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, results in fractional delta calculation which has a smoother particles display effect.</para>
        /// </summary>
        public bool FractDelta
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetFractionalDelta();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetFractionalDelta(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The <see cref="Godot.Rect2"/> that determines the node's region which needs to be visible on screen for the particle system to be active.</para>
        /// <para>Grow the rect if particles suddenly appear/disappear when the node enters/exits the screen. The <see cref="Godot.Rect2"/> can be grown via code or with the Particles → Generate Visibility Rect editor tool.</para>
        /// </summary>
        public Rect2 VisibilityRect
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetVisibilityRect();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetVisibilityRect(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>If <c>true</c>, particles use the parent node's coordinate space. If <c>false</c>, they use global coordinates.</para>
        /// </summary>
        public bool LocalCoords
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseLocalCoordinates();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseLocalCoordinates(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle draw order. Uses <see cref="Godot.Particles2D.DrawOrderEnum"/> values.</para>
        /// </summary>
        public Particles2D.DrawOrderEnum DrawOrder
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetDrawOrder();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetDrawOrder(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para><see cref="Godot.Material"/> for processing particles. Can be a <see cref="Godot.ParticlesMaterial"/> or a <see cref="Godot.ShaderMaterial"/>.</para>
        /// </summary>
        public Material ProcessMaterial
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetProcessMaterial();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetProcessMaterial(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Particle texture. If <c>null</c>, particles will be squares.</para>
        /// </summary>
        public Texture Texture
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTexture();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTexture(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Normal map to be used for the <see cref="Godot.Particles2D.Texture"/> property.</para>
        /// <para>Note: Godot expects the normal map to use X+, Y-, and Z+ coordinates. See <a href="http://wiki.polycount.com/wiki/Normal_Map_Technical_Details#Common_Swizzle_Coordinates">this page</a> for a comparison of normal map coordinates expected by popular engines.</para>
        /// </summary>
        public Texture NormalMap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNormalMap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNormalMap(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "Particles2D";

        public Particles2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Particles2D_Ctor(this);
        }

        internal Particles2D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_emitting");

        [GodotMethod("set_emitting")]
        [Obsolete("SetEmitting is deprecated. Use the Emitting property instead.")]
        public void SetEmitting(bool emitting)
        {
            NativeCalls.godot_icall_1_16(method_bind_0, Object.GetPtr(this), emitting);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_amount");

        [GodotMethod("set_amount")]
        [Obsolete("SetAmount is deprecated. Use the Amount property instead.")]
        public void SetAmount(int amount)
        {
            NativeCalls.godot_icall_1_4(method_bind_1, Object.GetPtr(this), amount);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lifetime");

        [GodotMethod("set_lifetime")]
        [Obsolete("SetLifetime is deprecated. Use the Lifetime property instead.")]
        public void SetLifetime(float secs)
        {
            NativeCalls.godot_icall_1_15(method_bind_2, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_one_shot");

        [GodotMethod("set_one_shot")]
        [Obsolete("SetOneShot is deprecated. Use the OneShot property instead.")]
        public void SetOneShot(bool secs)
        {
            NativeCalls.godot_icall_1_16(method_bind_3, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_pre_process_time");

        [GodotMethod("set_pre_process_time")]
        [Obsolete("SetPreProcessTime is deprecated. Use the Preprocess property instead.")]
        public void SetPreProcessTime(float secs)
        {
            NativeCalls.godot_icall_1_15(method_bind_4, Object.GetPtr(this), secs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_explosiveness_ratio");

        [GodotMethod("set_explosiveness_ratio")]
        [Obsolete("SetExplosivenessRatio is deprecated. Use the Explosiveness property instead.")]
        public void SetExplosivenessRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_5, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_randomness_ratio");

        [GodotMethod("set_randomness_ratio")]
        [Obsolete("SetRandomnessRatio is deprecated. Use the Randomness property instead.")]
        public void SetRandomnessRatio(float ratio)
        {
            NativeCalls.godot_icall_1_15(method_bind_6, Object.GetPtr(this), ratio);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_visibility_rect");

        [GodotMethod("set_visibility_rect")]
        [Obsolete("SetVisibilityRect is deprecated. Use the VisibilityRect property instead.")]
        public void SetVisibilityRect(Rect2 visibilityRect)
        {
            NativeCalls.godot_icall_1_162(method_bind_7, Object.GetPtr(this), ref visibilityRect);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_local_coordinates");

        [GodotMethod("set_use_local_coordinates")]
        [Obsolete("SetUseLocalCoordinates is deprecated. Use the LocalCoords property instead.")]
        public void SetUseLocalCoordinates(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_8, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fixed_fps");

        [GodotMethod("set_fixed_fps")]
        [Obsolete("SetFixedFps is deprecated. Use the FixedFps property instead.")]
        public void SetFixedFps(int fps)
        {
            NativeCalls.godot_icall_1_4(method_bind_9, Object.GetPtr(this), fps);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_fractional_delta");

        [GodotMethod("set_fractional_delta")]
        [Obsolete("SetFractionalDelta is deprecated. Use the FractDelta property instead.")]
        public void SetFractionalDelta(bool enable)
        {
            NativeCalls.godot_icall_1_16(method_bind_10, Object.GetPtr(this), enable);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_process_material");

        [GodotMethod("set_process_material")]
        [Obsolete("SetProcessMaterial is deprecated. Use the ProcessMaterial property instead.")]
        public void SetProcessMaterial(Material material)
        {
            NativeCalls.godot_icall_1_24(method_bind_11, Object.GetPtr(this), Object.GetPtr(material));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_speed_scale");

        [GodotMethod("set_speed_scale")]
        [Obsolete("SetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public void SetSpeedScale(float scale)
        {
            NativeCalls.godot_icall_1_15(method_bind_12, Object.GetPtr(this), scale);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "is_emitting");

        [GodotMethod("is_emitting")]
        [Obsolete("IsEmitting is deprecated. Use the Emitting property instead.")]
        public bool IsEmitting()
        {
            return NativeCalls.godot_icall_0_7(method_bind_13, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_amount");

        [GodotMethod("get_amount")]
        [Obsolete("GetAmount is deprecated. Use the Amount property instead.")]
        public int GetAmount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lifetime");

        [GodotMethod("get_lifetime")]
        [Obsolete("GetLifetime is deprecated. Use the Lifetime property instead.")]
        public float GetLifetime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_15, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_one_shot");

        [GodotMethod("get_one_shot")]
        [Obsolete("GetOneShot is deprecated. Use the OneShot property instead.")]
        public bool GetOneShot()
        {
            return NativeCalls.godot_icall_0_7(method_bind_16, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_pre_process_time");

        [GodotMethod("get_pre_process_time")]
        [Obsolete("GetPreProcessTime is deprecated. Use the Preprocess property instead.")]
        public float GetPreProcessTime()
        {
            return NativeCalls.godot_icall_0_14(method_bind_17, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_explosiveness_ratio");

        [GodotMethod("get_explosiveness_ratio")]
        [Obsolete("GetExplosivenessRatio is deprecated. Use the Explosiveness property instead.")]
        public float GetExplosivenessRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_18, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_randomness_ratio");

        [GodotMethod("get_randomness_ratio")]
        [Obsolete("GetRandomnessRatio is deprecated. Use the Randomness property instead.")]
        public float GetRandomnessRatio()
        {
            return NativeCalls.godot_icall_0_14(method_bind_19, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_visibility_rect");

        [GodotMethod("get_visibility_rect")]
        [Obsolete("GetVisibilityRect is deprecated. Use the VisibilityRect property instead.")]
        public Rect2 GetVisibilityRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_20, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_local_coordinates");

        [GodotMethod("get_use_local_coordinates")]
        [Obsolete("GetUseLocalCoordinates is deprecated. Use the LocalCoords property instead.")]
        public bool GetUseLocalCoordinates()
        {
            return NativeCalls.godot_icall_0_7(method_bind_21, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fixed_fps");

        [GodotMethod("get_fixed_fps")]
        [Obsolete("GetFixedFps is deprecated. Use the FixedFps property instead.")]
        public int GetFixedFps()
        {
            return NativeCalls.godot_icall_0_5(method_bind_22, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_fractional_delta");

        [GodotMethod("get_fractional_delta")]
        [Obsolete("GetFractionalDelta is deprecated. Use the FractDelta property instead.")]
        public bool GetFractionalDelta()
        {
            return NativeCalls.godot_icall_0_7(method_bind_23, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_process_material");

        [GodotMethod("get_process_material")]
        [Obsolete("GetProcessMaterial is deprecated. Use the ProcessMaterial property instead.")]
        public Material GetProcessMaterial()
        {
            return NativeCalls.godot_icall_0_237(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_speed_scale");

        [GodotMethod("get_speed_scale")]
        [Obsolete("GetSpeedScale is deprecated. Use the SpeedScale property instead.")]
        public float GetSpeedScale()
        {
            return NativeCalls.godot_icall_0_14(method_bind_25, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_draw_order");

        [GodotMethod("set_draw_order")]
        [Obsolete("SetDrawOrder is deprecated. Use the DrawOrder property instead.")]
        public void SetDrawOrder(Particles2D.DrawOrderEnum order)
        {
            NativeCalls.godot_icall_1_4(method_bind_26, Object.GetPtr(this), (int)order);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_draw_order");

        [GodotMethod("get_draw_order")]
        [Obsolete("GetDrawOrder is deprecated. Use the DrawOrder property instead.")]
        public Particles2D.DrawOrderEnum GetDrawOrder()
        {
            return (Particles2D.DrawOrderEnum)NativeCalls.godot_icall_0_722(method_bind_27, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_texture");

        [GodotMethod("set_texture")]
        [Obsolete("SetTexture is deprecated. Use the Texture property instead.")]
        public void SetTexture(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_28, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_texture");

        [GodotMethod("get_texture")]
        [Obsolete("GetTexture is deprecated. Use the Texture property instead.")]
        public Texture GetTexture()
        {
            return NativeCalls.godot_icall_0_161(method_bind_29, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_normal_map");

        [GodotMethod("set_normal_map")]
        [Obsolete("SetNormalMap is deprecated. Use the NormalMap property instead.")]
        public void SetNormalMap(Texture texture)
        {
            NativeCalls.godot_icall_1_24(method_bind_30, Object.GetPtr(this), Object.GetPtr(texture));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_normal_map");

        [GodotMethod("get_normal_map")]
        [Obsolete("GetNormalMap is deprecated. Use the NormalMap property instead.")]
        public Texture GetNormalMap()
        {
            return NativeCalls.godot_icall_0_161(method_bind_31, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "capture_rect");

        /// <summary>
        /// <para>Returns a rectangle containing the positions of all existing particles.</para>
        /// </summary>
        [GodotMethod("capture_rect")]
        public Rect2 CaptureRect()
        {
            NativeCalls.godot_icall_0_163(method_bind_32, Object.GetPtr(this), out Rect2 argRet); return (Rect2)argRet;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "restart");

        /// <summary>
        /// <para>Restarts all the existing particles.</para>
        /// </summary>
        [GodotMethod("restart")]
        public void Restart()
        {
            NativeCalls.godot_icall_0_3(method_bind_33, Object.GetPtr(this));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
