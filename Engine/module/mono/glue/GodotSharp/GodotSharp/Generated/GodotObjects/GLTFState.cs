using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>Note: This class is only compiled in editor builds. Run-time glTF loading and saving is not available in exported projects. References to <see cref="Godot.GLTFState"/> within a script will cause an error in an exported project.</para>
    /// </summary>
    public partial class GLTFState : Resource
    {
        public Godot.Collections.Dictionary Json
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetJson();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetJson(value);
            }
#pragma warning restore CS0618
        }

        public int MajorVersion
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMajorVersion();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMajorVersion(value);
            }
#pragma warning restore CS0618
        }

        public int MinorVersion
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinorVersion();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinorVersion(value);
            }
#pragma warning restore CS0618
        }

        public byte[] GlbData
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetGlbData();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetGlbData(value);
            }
#pragma warning restore CS0618
        }

        public bool UseNamedSkinBinds
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUseNamedSkinBinds();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUseNamedSkinBinds(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Nodes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetNodes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetNodes(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Buffers
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBuffers();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBuffers(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array BufferViews
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBufferViews();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBufferViews(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Accessors
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAccessors();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAccessors(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Meshes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMeshes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMeshes(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Materials
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaterials();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaterials(value);
            }
#pragma warning restore CS0618
        }

        public string SceneName
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSceneName();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSceneName(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array RootNodes
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetRootNodes();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetRootNodes(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Textures
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetTextures();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetTextures(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Images
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetImages();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetImages(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Skins
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkins();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkins(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Cameras
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetCameras();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetCameras(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Lights
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetLights();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetLights(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array UniqueNames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUniqueNames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUniqueNames(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array UniqueAnimationNames
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetUniqueAnimationNames();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetUniqueAnimationNames(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Skeletons
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkeletons();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkeletons(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Dictionary SkeletonToNode
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSkeletonToNode();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSkeletonToNode(value);
            }
#pragma warning restore CS0618
        }

        public Godot.Collections.Array Animations
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetAnimations();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetAnimations(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "GLTFState";

        public GLTFState() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GLTFState_Ctor(this);
        }

        internal GLTFState(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_json");

        [GodotMethod("get_json")]
        [Obsolete("GetJson is deprecated. Use the Json property instead.")]
        public Godot.Collections.Dictionary GetJson()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_0, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_json");

        [GodotMethod("set_json")]
        [Obsolete("SetJson is deprecated. Use the Json property instead.")]
        public void SetJson(Godot.Collections.Dictionary json)
        {
            NativeCalls.godot_icall_1_213(method_bind_1, Object.GetPtr(this), json.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_major_version");

        [GodotMethod("get_major_version")]
        [Obsolete("GetMajorVersion is deprecated. Use the MajorVersion property instead.")]
        public int GetMajorVersion()
        {
            return NativeCalls.godot_icall_0_5(method_bind_2, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_major_version");

        [GodotMethod("set_major_version")]
        [Obsolete("SetMajorVersion is deprecated. Use the MajorVersion property instead.")]
        public void SetMajorVersion(int majorVersion)
        {
            NativeCalls.godot_icall_1_4(method_bind_3, Object.GetPtr(this), majorVersion);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_minor_version");

        [GodotMethod("get_minor_version")]
        [Obsolete("GetMinorVersion is deprecated. Use the MinorVersion property instead.")]
        public int GetMinorVersion()
        {
            return NativeCalls.godot_icall_0_5(method_bind_4, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_minor_version");

        [GodotMethod("set_minor_version")]
        [Obsolete("SetMinorVersion is deprecated. Use the MinorVersion property instead.")]
        public void SetMinorVersion(int minorVersion)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), minorVersion);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_glb_data");

        [GodotMethod("get_glb_data")]
        [Obsolete("GetGlbData is deprecated. Use the GlbData property instead.")]
        public byte[] GetGlbData()
        {
            return NativeCalls.godot_icall_0_2(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_glb_data");

        [GodotMethod("set_glb_data")]
        [Obsolete("SetGlbData is deprecated. Use the GlbData property instead.")]
        public void SetGlbData(byte[] glbData)
        {
            NativeCalls.godot_icall_1_183(method_bind_7, Object.GetPtr(this), glbData);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_use_named_skin_binds");

        [GodotMethod("get_use_named_skin_binds")]
        [Obsolete("GetUseNamedSkinBinds is deprecated. Use the UseNamedSkinBinds property instead.")]
        public bool GetUseNamedSkinBinds()
        {
            return NativeCalls.godot_icall_0_7(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_use_named_skin_binds");

        [GodotMethod("set_use_named_skin_binds")]
        [Obsolete("SetUseNamedSkinBinds is deprecated. Use the UseNamedSkinBinds property instead.")]
        public void SetUseNamedSkinBinds(bool useNamedSkinBinds)
        {
            NativeCalls.godot_icall_1_16(method_bind_9, Object.GetPtr(this), useNamedSkinBinds);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_nodes");

        [GodotMethod("get_nodes")]
        [Obsolete("GetNodes is deprecated. Use the Nodes property instead.")]
        public Godot.Collections.Array GetNodes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_10, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_nodes");

        [GodotMethod("set_nodes")]
        [Obsolete("SetNodes is deprecated. Use the Nodes property instead.")]
        public void SetNodes(Godot.Collections.Array nodes)
        {
            NativeCalls.godot_icall_1_92(method_bind_11, Object.GetPtr(this), nodes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffers");

        [GodotMethod("get_buffers")]
        [Obsolete("GetBuffers is deprecated. Use the Buffers property instead.")]
        public Godot.Collections.Array GetBuffers()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_12, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffers");

        [GodotMethod("set_buffers")]
        [Obsolete("SetBuffers is deprecated. Use the Buffers property instead.")]
        public void SetBuffers(Godot.Collections.Array buffers)
        {
            NativeCalls.godot_icall_1_92(method_bind_13, Object.GetPtr(this), buffers.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_buffer_views");

        [GodotMethod("get_buffer_views")]
        [Obsolete("GetBufferViews is deprecated. Use the BufferViews property instead.")]
        public Godot.Collections.Array GetBufferViews()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_14, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_buffer_views");

        [GodotMethod("set_buffer_views")]
        [Obsolete("SetBufferViews is deprecated. Use the BufferViews property instead.")]
        public void SetBufferViews(Godot.Collections.Array bufferViews)
        {
            NativeCalls.godot_icall_1_92(method_bind_15, Object.GetPtr(this), bufferViews.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_16 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_accessors");

        [GodotMethod("get_accessors")]
        [Obsolete("GetAccessors is deprecated. Use the Accessors property instead.")]
        public Godot.Collections.Array GetAccessors()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_16, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_17 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_accessors");

        [GodotMethod("set_accessors")]
        [Obsolete("SetAccessors is deprecated. Use the Accessors property instead.")]
        public void SetAccessors(Godot.Collections.Array accessors)
        {
            NativeCalls.godot_icall_1_92(method_bind_17, Object.GetPtr(this), accessors.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_18 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_meshes");

        [GodotMethod("get_meshes")]
        [Obsolete("GetMeshes is deprecated. Use the Meshes property instead.")]
        public Godot.Collections.Array GetMeshes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_18, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_19 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_meshes");

        [GodotMethod("set_meshes")]
        [Obsolete("SetMeshes is deprecated. Use the Meshes property instead.")]
        public void SetMeshes(Godot.Collections.Array meshes)
        {
            NativeCalls.godot_icall_1_92(method_bind_19, Object.GetPtr(this), meshes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_20 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_players_count");

        [GodotMethod("get_animation_players_count")]
        public int GetAnimationPlayersCount(int idx)
        {
            return NativeCalls.godot_icall_1_11(method_bind_20, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_21 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animation_player");

        [GodotMethod("get_animation_player")]
        public AnimationPlayer GetAnimationPlayer(int idx)
        {
            return NativeCalls.godot_icall_1_459(method_bind_21, Object.GetPtr(this), idx);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_22 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_materials");

        [GodotMethod("get_materials")]
        [Obsolete("GetMaterials is deprecated. Use the Materials property instead.")]
        public Godot.Collections.Array GetMaterials()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_22, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_23 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_materials");

        [GodotMethod("set_materials")]
        [Obsolete("SetMaterials is deprecated. Use the Materials property instead.")]
        public void SetMaterials(Godot.Collections.Array materials)
        {
            NativeCalls.godot_icall_1_92(method_bind_23, Object.GetPtr(this), materials.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_24 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scene_name");

        [GodotMethod("get_scene_name")]
        [Obsolete("GetSceneName is deprecated. Use the SceneName property instead.")]
        public string GetSceneName()
        {
            return NativeCalls.godot_icall_0_6(method_bind_24, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_25 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_scene_name");

        [GodotMethod("set_scene_name")]
        [Obsolete("SetSceneName is deprecated. Use the SceneName property instead.")]
        public void SetSceneName(string sceneName)
        {
            NativeCalls.godot_icall_1_54(method_bind_25, Object.GetPtr(this), sceneName);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_26 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_root_nodes");

        [GodotMethod("get_root_nodes")]
        [Obsolete("GetRootNodes is deprecated. Use the RootNodes property instead.")]
        public Godot.Collections.Array GetRootNodes()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_26, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_27 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_root_nodes");

        [GodotMethod("set_root_nodes")]
        [Obsolete("SetRootNodes is deprecated. Use the RootNodes property instead.")]
        public void SetRootNodes(Godot.Collections.Array rootNodes)
        {
            NativeCalls.godot_icall_1_92(method_bind_27, Object.GetPtr(this), rootNodes.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_28 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_textures");

        [GodotMethod("get_textures")]
        [Obsolete("GetTextures is deprecated. Use the Textures property instead.")]
        public Godot.Collections.Array GetTextures()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_28, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_29 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_textures");

        [GodotMethod("set_textures")]
        [Obsolete("SetTextures is deprecated. Use the Textures property instead.")]
        public void SetTextures(Godot.Collections.Array textures)
        {
            NativeCalls.godot_icall_1_92(method_bind_29, Object.GetPtr(this), textures.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_30 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_images");

        [GodotMethod("get_images")]
        [Obsolete("GetImages is deprecated. Use the Images property instead.")]
        public Godot.Collections.Array GetImages()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_30, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_31 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_images");

        [GodotMethod("set_images")]
        [Obsolete("SetImages is deprecated. Use the Images property instead.")]
        public void SetImages(Godot.Collections.Array images)
        {
            NativeCalls.godot_icall_1_92(method_bind_31, Object.GetPtr(this), images.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_32 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skins");

        [GodotMethod("get_skins")]
        [Obsolete("GetSkins is deprecated. Use the Skins property instead.")]
        public Godot.Collections.Array GetSkins()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_32, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_33 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skins");

        [GodotMethod("set_skins")]
        [Obsolete("SetSkins is deprecated. Use the Skins property instead.")]
        public void SetSkins(Godot.Collections.Array skins)
        {
            NativeCalls.godot_icall_1_92(method_bind_33, Object.GetPtr(this), skins.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_34 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_cameras");

        [GodotMethod("get_cameras")]
        [Obsolete("GetCameras is deprecated. Use the Cameras property instead.")]
        public Godot.Collections.Array GetCameras()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_34, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_35 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_cameras");

        [GodotMethod("set_cameras")]
        [Obsolete("SetCameras is deprecated. Use the Cameras property instead.")]
        public void SetCameras(Godot.Collections.Array cameras)
        {
            NativeCalls.godot_icall_1_92(method_bind_35, Object.GetPtr(this), cameras.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_36 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_lights");

        [GodotMethod("get_lights")]
        [Obsolete("GetLights is deprecated. Use the Lights property instead.")]
        public Godot.Collections.Array GetLights()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_36, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_37 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_lights");

        [GodotMethod("set_lights")]
        [Obsolete("SetLights is deprecated. Use the Lights property instead.")]
        public void SetLights(Godot.Collections.Array lights)
        {
            NativeCalls.godot_icall_1_92(method_bind_37, Object.GetPtr(this), lights.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_38 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unique_names");

        [GodotMethod("get_unique_names")]
        [Obsolete("GetUniqueNames is deprecated. Use the UniqueNames property instead.")]
        public Godot.Collections.Array GetUniqueNames()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_38, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_39 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unique_names");

        [GodotMethod("set_unique_names")]
        [Obsolete("SetUniqueNames is deprecated. Use the UniqueNames property instead.")]
        public void SetUniqueNames(Godot.Collections.Array uniqueNames)
        {
            NativeCalls.godot_icall_1_92(method_bind_39, Object.GetPtr(this), uniqueNames.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_40 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_unique_animation_names");

        [GodotMethod("get_unique_animation_names")]
        [Obsolete("GetUniqueAnimationNames is deprecated. Use the UniqueAnimationNames property instead.")]
        public Godot.Collections.Array GetUniqueAnimationNames()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_40, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_41 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_unique_animation_names");

        [GodotMethod("set_unique_animation_names")]
        [Obsolete("SetUniqueAnimationNames is deprecated. Use the UniqueAnimationNames property instead.")]
        public void SetUniqueAnimationNames(Godot.Collections.Array uniqueAnimationNames)
        {
            NativeCalls.godot_icall_1_92(method_bind_41, Object.GetPtr(this), uniqueAnimationNames.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_42 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeletons");

        [GodotMethod("get_skeletons")]
        [Obsolete("GetSkeletons is deprecated. Use the Skeletons property instead.")]
        public Godot.Collections.Array GetSkeletons()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_42, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_43 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skeletons");

        [GodotMethod("set_skeletons")]
        [Obsolete("SetSkeletons is deprecated. Use the Skeletons property instead.")]
        public void SetSkeletons(Godot.Collections.Array skeletons)
        {
            NativeCalls.godot_icall_1_92(method_bind_43, Object.GetPtr(this), skeletons.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_44 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_skeleton_to_node");

        [GodotMethod("get_skeleton_to_node")]
        [Obsolete("GetSkeletonToNode is deprecated. Use the SkeletonToNode property instead.")]
        public Godot.Collections.Dictionary GetSkeletonToNode()
        {
            return new Godot.Collections.Dictionary(NativeCalls.godot_icall_0_214(method_bind_44, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_45 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_skeleton_to_node");

        [GodotMethod("set_skeleton_to_node")]
        [Obsolete("SetSkeletonToNode is deprecated. Use the SkeletonToNode property instead.")]
        public void SetSkeletonToNode(Godot.Collections.Dictionary skeletonToNode)
        {
            NativeCalls.godot_icall_1_213(method_bind_45, Object.GetPtr(this), skeletonToNode.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_46 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_animations");

        [GodotMethod("get_animations")]
        [Obsolete("GetAnimations is deprecated. Use the Animations property instead.")]
        public Godot.Collections.Array GetAnimations()
        {
            return new Godot.Collections.Array(NativeCalls.godot_icall_0_26(method_bind_46, Object.GetPtr(this)));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_47 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_animations");

        [GodotMethod("set_animations")]
        [Obsolete("SetAnimations is deprecated. Use the Animations property instead.")]
        public void SetAnimations(Godot.Collections.Array animations)
        {
            NativeCalls.godot_icall_1_92(method_bind_47, Object.GetPtr(this), animations.GetPtr());
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_48 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_scene_node");

        [GodotMethod("get_scene_node")]
        public Node GetSceneNode(int idx)
        {
            return NativeCalls.godot_icall_1_460(method_bind_48, Object.GetPtr(this), idx);
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
