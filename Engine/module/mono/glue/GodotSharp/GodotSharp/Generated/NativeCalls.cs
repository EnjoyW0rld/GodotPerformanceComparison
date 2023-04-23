using System;
using System.Runtime.CompilerServices;

namespace Godot
{
    internal static class NativeCalls
    {

        internal static ulong godot_api_hash = 6418583619542790341;

        internal static uint bindings_version = 13;

        internal static uint cs_glue_version = 1679002386;

        static NativeCalls()
        {
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AESContext_Ctor(AESContext obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRAnchor_Ctor(ARVRAnchor obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRCamera_Ctor(ARVRCamera obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRController_Ctor(ARVRController obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRInterfaceGDNative_Ctor(ARVRInterfaceGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVROrigin_Ctor(ARVROrigin obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRPositionalTracker_Ctor(ARVRPositionalTracker obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ARVRServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AStar_Ctor(AStar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AStar2D_Ctor(AStar2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AcceptDialog_Ctor(AcceptDialog obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimatedSprite_Ctor(AnimatedSprite obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimatedSprite3D_Ctor(AnimatedSprite3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimatedTexture_Ctor(AnimatedTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Animation_Ctor(Animation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNode_Ctor(AnimationNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeAdd2_Ctor(AnimationNodeAdd2 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeAdd3_Ctor(AnimationNodeAdd3 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeAnimation_Ctor(AnimationNodeAnimation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeBlend2_Ctor(AnimationNodeBlend2 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeBlend3_Ctor(AnimationNodeBlend3 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeBlendSpace1D_Ctor(AnimationNodeBlendSpace1D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeBlendSpace2D_Ctor(AnimationNodeBlendSpace2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeBlendTree_Ctor(AnimationNodeBlendTree obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeOneShot_Ctor(AnimationNodeOneShot obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeOutput_Ctor(AnimationNodeOutput obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeStateMachine_Ctor(AnimationNodeStateMachine obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeStateMachinePlayback_Ctor(AnimationNodeStateMachinePlayback obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeStateMachineTransition_Ctor(AnimationNodeStateMachineTransition obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeTimeScale_Ctor(AnimationNodeTimeScale obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeTimeSeek_Ctor(AnimationNodeTimeSeek obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationNodeTransition_Ctor(AnimationNodeTransition obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationPlayer_Ctor(AnimationPlayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationRootNode_Ctor(AnimationRootNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationTree_Ctor(AnimationTree obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AnimationTreePlayer_Ctor(AnimationTreePlayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Area_Ctor(Area obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Area2D_Ctor(Area2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ArrayMesh_Ctor(ArrayMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AspectRatioContainer_Ctor(AspectRatioContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AtlasTexture_Ctor(AtlasTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioBusLayout_Ctor(AudioBusLayout obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectAmplify_Ctor(AudioEffectAmplify obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectBandLimitFilter_Ctor(AudioEffectBandLimitFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectBandPassFilter_Ctor(AudioEffectBandPassFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectCapture_Ctor(AudioEffectCapture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectChorus_Ctor(AudioEffectChorus obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectCompressor_Ctor(AudioEffectCompressor obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectDelay_Ctor(AudioEffectDelay obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectDistortion_Ctor(AudioEffectDistortion obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectEQ_Ctor(AudioEffectEQ obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectEQ10_Ctor(AudioEffectEQ10 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectEQ21_Ctor(AudioEffectEQ21 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectEQ6_Ctor(AudioEffectEQ6 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectFilter_Ctor(AudioEffectFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectHighPassFilter_Ctor(AudioEffectHighPassFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectHighShelfFilter_Ctor(AudioEffectHighShelfFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectLimiter_Ctor(AudioEffectLimiter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectLowPassFilter_Ctor(AudioEffectLowPassFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectLowShelfFilter_Ctor(AudioEffectLowShelfFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectNotchFilter_Ctor(AudioEffectNotchFilter obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectPanner_Ctor(AudioEffectPanner obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectPhaser_Ctor(AudioEffectPhaser obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectPitchShift_Ctor(AudioEffectPitchShift obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectRecord_Ctor(AudioEffectRecord obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectReverb_Ctor(AudioEffectReverb obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectSpectrumAnalyzer_Ctor(AudioEffectSpectrumAnalyzer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioEffectStereoEnhance_Ctor(AudioEffectStereoEnhance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamGenerator_Ctor(AudioStreamGenerator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamMP3_Ctor(AudioStreamMP3 obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamMicrophone_Ctor(AudioStreamMicrophone obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamOGGVorbis_Ctor(AudioStreamOGGVorbis obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamPlayer_Ctor(AudioStreamPlayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamPlayer2D_Ctor(AudioStreamPlayer2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamPlayer3D_Ctor(AudioStreamPlayer3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamRandomPitch_Ctor(AudioStreamRandomPitch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_AudioStreamSample_Ctor(AudioStreamSample obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BackBufferCopy_Ctor(BackBufferCopy obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BakedLightmap_Ctor(BakedLightmap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BakedLightmapData_Ctor(BakedLightmapData obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BitMap_Ctor(BitMap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BitmapFont_Ctor(BitmapFont obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Bone2D_Ctor(Bone2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BoneAttachment_Ctor(BoneAttachment obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_BoxShape_Ctor(BoxShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Button_Ctor(Button obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ButtonGroup_Ctor(ButtonGroup obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CPUParticles_Ctor(CPUParticles obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CPUParticles2D_Ctor(CPUParticles2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGBox_Ctor(CSGBox obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGCombiner_Ctor(CSGCombiner obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGCylinder_Ctor(CSGCylinder obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGMesh_Ctor(CSGMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGPolygon_Ctor(CSGPolygon obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGSphere_Ctor(CSGSphere obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSGTorus_Ctor(CSGTorus obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CSharpScript_Ctor(CSharpScript obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CallbackTweener_Ctor(CallbackTweener obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Camera_Ctor(Camera obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Camera2D_Ctor(Camera2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CameraFeed_Ctor(CameraFeed obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CameraServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CameraTexture_Ctor(CameraTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CanvasItemMaterial_Ctor(CanvasItemMaterial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CanvasLayer_Ctor(CanvasLayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CanvasModulate_Ctor(CanvasModulate obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CapsuleMesh_Ctor(CapsuleMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CapsuleShape_Ctor(CapsuleShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CapsuleShape2D_Ctor(CapsuleShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CenterContainer_Ctor(CenterContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CharFXTransform_Ctor(CharFXTransform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CheckBox_Ctor(CheckBox obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CheckButton_Ctor(CheckButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CircleShape2D_Ctor(CircleShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ClippedCamera_Ctor(ClippedCamera obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CollisionPolygon_Ctor(CollisionPolygon obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CollisionPolygon2D_Ctor(CollisionPolygon2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CollisionShape_Ctor(CollisionShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CollisionShape2D_Ctor(CollisionShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ColorPicker_Ctor(ColorPicker obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ColorPickerButton_Ctor(ColorPickerButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ColorRect_Ctor(ColorRect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConcavePolygonShape_Ctor(ConcavePolygonShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConcavePolygonShape2D_Ctor(ConcavePolygonShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConeTwistJoint_Ctor(ConeTwistJoint obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConfigFile_Ctor(ConfigFile obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConfirmationDialog_Ctor(ConfirmationDialog obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Container_Ctor(Container obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Control_Ctor(Control obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConvexPolygonShape_Ctor(ConvexPolygonShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ConvexPolygonShape2D_Ctor(ConvexPolygonShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Crypto_Ctor(Crypto obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CryptoKey_Ctor(CryptoKey obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CubeMap_Ctor(CubeMap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CubeMesh_Ctor(CubeMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Curve_Ctor(Curve obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Curve2D_Ctor(Curve2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Curve3D_Ctor(Curve3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CurveTexture_Ctor(CurveTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CylinderMesh_Ctor(CylinderMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_CylinderShape_Ctor(CylinderShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_DTLSServer_Ctor(DTLSServer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_DampedSpringJoint2D_Ctor(DampedSpringJoint2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_DirectionalLight_Ctor(DirectionalLight obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_DynamicFont_Ctor(DynamicFont obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_DynamicFontData_Ctor(DynamicFontData obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_EncodedObjectAsID_Ctor(EncodedObjectAsID obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Environment_Ctor(Environment obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Expression_Ctor(Expression obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ExternalTexture_Ctor(ExternalTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_FileDialog_Ctor(FileDialog obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_FuncRef_Ctor(FuncRef obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GDNative_Ctor(GDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GDNativeLibrary_Ctor(GDNativeLibrary obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GDScript_Ctor(GDScript obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GIProbe_Ctor(GIProbe obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GIProbeData_Ctor(GIProbeData obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFAccessor_Ctor(GLTFAccessor obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFAnimation_Ctor(GLTFAnimation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFBufferView_Ctor(GLTFBufferView obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFCamera_Ctor(GLTFCamera obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFDocument_Ctor(GLTFDocument obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFLight_Ctor(GLTFLight obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFNode_Ctor(GLTFNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFSkeleton_Ctor(GLTFSkeleton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFSkin_Ctor(GLTFSkin obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFSpecGloss_Ctor(GLTFSpecGloss obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFState_Ctor(GLTFState obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GLTFTexture_Ctor(GLTFTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Generic6DOFJoint_Ctor(Generic6DOFJoint obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Gradient_Ctor(Gradient obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GradientTexture_Ctor(GradientTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GradientTexture2D_Ctor(GradientTexture2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GraphEdit_Ctor(GraphEdit obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GraphNode_Ctor(GraphNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GridContainer_Ctor(GridContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GridMap_Ctor(GridMap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_GrooveJoint2D_Ctor(GrooveJoint2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HBoxContainer_Ctor(HBoxContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HFlowContainer_Ctor(HFlowContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HMACContext_Ctor(HMACContext obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HScrollBar_Ctor(HScrollBar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HSeparator_Ctor(HSeparator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HSlider_Ctor(HSlider obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HSplitContainer_Ctor(HSplitContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HTTPClient_Ctor(HTTPClient obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HTTPRequest_Ctor(HTTPRequest obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HashingContext_Ctor(HashingContext obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HeightMapShape_Ctor(HeightMapShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_HingeJoint_Ctor(HingeJoint obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_IP_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Image_Ctor(Image obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ImageTexture_Ctor(ImageTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ImmediateGeometry_Ctor(ImmediateGeometry obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Input_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventAction_Ctor(InputEventAction obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventJoypadButton_Ctor(InputEventJoypadButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventJoypadMotion_Ctor(InputEventJoypadMotion obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventKey_Ctor(InputEventKey obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventMIDI_Ctor(InputEventMIDI obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventMagnifyGesture_Ctor(InputEventMagnifyGesture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventMouseButton_Ctor(InputEventMouseButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventMouseMotion_Ctor(InputEventMouseMotion obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventPanGesture_Ctor(InputEventPanGesture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventScreenDrag_Ctor(InputEventScreenDrag obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputEventScreenTouch_Ctor(InputEventScreenTouch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InputMap_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_InterpolatedCamera_Ctor(InterpolatedCamera obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_IntervalTweener_Ctor(IntervalTweener obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ItemList_Ctor(ItemList obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JNISingleton_Ctor(JNISingleton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JSONParseResult_Ctor(JSONParseResult obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JSONRPC_Ctor(JSONRPC obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JavaClass_Ctor(JavaClass obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JavaClassWrapper_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_JavaScript_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_KinematicBody_Ctor(KinematicBody obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_KinematicBody2D_Ctor(KinematicBody2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_KinematicCollision_Ctor(KinematicCollision obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_KinematicCollision2D_Ctor(KinematicCollision2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Label_Ctor(Label obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Label3D_Ctor(Label3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_LargeTexture_Ctor(LargeTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Light2D_Ctor(Light2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_LightOccluder2D_Ctor(LightOccluder2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Line2D_Ctor(Line2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_LineEdit_Ctor(LineEdit obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_LineShape2D_Ctor(LineShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_LinkButton_Ctor(LinkButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Listener_Ctor(Listener obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Listener2D_Ctor(Listener2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MainLoop_Ctor(MainLoop obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MarginContainer_Ctor(MarginContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MenuButton_Ctor(MenuButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MeshDataTool_Ctor(MeshDataTool obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MeshInstance_Ctor(MeshInstance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MeshInstance2D_Ctor(MeshInstance2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MeshLibrary_Ctor(MeshLibrary obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MeshTexture_Ctor(MeshTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MethodTweener_Ctor(MethodTweener obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MobileVRInterface_Ctor(MobileVRInterface obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MultiMesh_Ctor(MultiMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MultiMeshInstance_Ctor(MultiMeshInstance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MultiMeshInstance2D_Ctor(MultiMeshInstance2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MultiplayerAPI_Ctor(MultiplayerAPI obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_MultiplayerPeerGDNative_Ctor(MultiplayerPeerGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NativeScript_Ctor(NativeScript obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Navigation_Ctor(Navigation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Navigation2D_Ctor(Navigation2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Navigation2DServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationAgent_Ctor(NavigationAgent obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationAgent2D_Ctor(NavigationAgent2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationMesh_Ctor(NavigationMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationMeshGenerator_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationMeshInstance_Ctor(NavigationMeshInstance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationObstacle_Ctor(NavigationObstacle obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationObstacle2D_Ctor(NavigationObstacle2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationPolygon_Ctor(NavigationPolygon obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationPolygonInstance_Ctor(NavigationPolygonInstance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NavigationServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NetworkedMultiplayerCustom_Ctor(NetworkedMultiplayerCustom obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NetworkedMultiplayerENet_Ctor(NetworkedMultiplayerENet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NinePatchRect_Ctor(NinePatchRect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Node_Ctor(Node obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Node2D_Ctor(Node2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_NoiseTexture_Ctor(NoiseTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Occluder_Ctor(Occluder obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OccluderPolygon2D_Ctor(OccluderPolygon2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OccluderShapePolygon_Ctor(OccluderShapePolygon obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OccluderShapeSphere_Ctor(OccluderShapeSphere obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OmniLight_Ctor(OmniLight obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OpenSimplexNoise_Ctor(OpenSimplexNoise obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_OptionButton_Ctor(OptionButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PCKPacker_Ctor(PCKPacker obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PHashTranslation_Ctor(PHashTranslation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PackedDataContainer_Ctor(PackedDataContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PackedScene_Ctor(PackedScene obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PackedSceneGLTF_Ctor(PackedSceneGLTF obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PacketPeerDTLS_Ctor(PacketPeerDTLS obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PacketPeerGDNative_Ctor(PacketPeerGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PacketPeerStream_Ctor(PacketPeerStream obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PacketPeerUDP_Ctor(PacketPeerUDP obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Panel_Ctor(Panel obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PanelContainer_Ctor(PanelContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PanoramaSky_Ctor(PanoramaSky obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ParallaxBackground_Ctor(ParallaxBackground obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ParallaxLayer_Ctor(ParallaxLayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Particles_Ctor(Particles obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Particles2D_Ctor(Particles2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ParticlesMaterial_Ctor(ParticlesMaterial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Path_Ctor(Path obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Path2D_Ctor(Path2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PathFollow_Ctor(PathFollow obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PathFollow2D_Ctor(PathFollow2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Performance_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PhysicalBone_Ctor(PhysicalBone obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Physics2DServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Physics2DShapeQueryParameters_Ctor(Physics2DShapeQueryParameters obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Physics2DTestMotionResult_Ctor(Physics2DTestMotionResult obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PhysicsMaterial_Ctor(PhysicsMaterial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PhysicsServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PhysicsShapeQueryParameters_Ctor(PhysicsShapeQueryParameters obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PhysicsTestMotionResult_Ctor(PhysicsTestMotionResult obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PinJoint_Ctor(PinJoint obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PinJoint2D_Ctor(PinJoint2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PlaneMesh_Ctor(PlaneMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PlaneShape_Ctor(PlaneShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PluginScript_Ctor(PluginScript obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PointMesh_Ctor(PointMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Polygon2D_Ctor(Polygon2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PolygonPathFinder_Ctor(PolygonPathFinder obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Popup_Ctor(Popup obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PopupDialog_Ctor(PopupDialog obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PopupMenu_Ctor(PopupMenu obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PopupPanel_Ctor(PopupPanel obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Portal_Ctor(Portal obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Position2D_Ctor(Position2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Position3D_Ctor(Position3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PrismMesh_Ctor(PrismMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ProceduralSky_Ctor(ProceduralSky obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ProgressBar_Ctor(ProgressBar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ProjectSettings_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_PropertyTweener_Ctor(PropertyTweener obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ProximityGroup_Ctor(ProximityGroup obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ProxyTexture_Ctor(ProxyTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_QuadMesh_Ctor(QuadMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_QueenSolver_Ctor(QueenSolver obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RandomNumberGenerator_Ctor(RandomNumberGenerator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RayCast_Ctor(RayCast obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RayCast2D_Ctor(RayCast2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RayShape_Ctor(RayShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RayShape2D_Ctor(RayShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RectangleShape2D_Ctor(RectangleShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Reference_Ctor(Reference obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ReferenceRect_Ctor(ReferenceRect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ReflectionProbe_Ctor(ReflectionProbe obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RegEx_Ctor(RegEx obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RegExMatch_Ctor(RegExMatch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RemoteTransform_Ctor(RemoteTransform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RemoteTransform2D_Ctor(RemoteTransform2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Resource_Ctor(Resource obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ResourceFormatLoader_Ctor(ResourceFormatLoader obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ResourceFormatSaver_Ctor(ResourceFormatSaver obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ResourcePreloader_Ctor(ResourcePreloader obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RichTextEffect_Ctor(RichTextEffect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RichTextLabel_Ctor(RichTextLabel obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RigidBody_Ctor(RigidBody obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RigidBody2D_Ctor(RigidBody2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Room_Ctor(Room obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RoomGroup_Ctor(RoomGroup obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_RoomManager_Ctor(RoomManager obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SceneTree_Ctor(SceneTree obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SceneTreeTween_Ctor(SceneTreeTween obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ScrollContainer_Ctor(ScrollContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SegmentShape2D_Ctor(SegmentShape2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Shader_Ctor(Shader obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ShaderMaterial_Ctor(ShaderMaterial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ShortCut_Ctor(ShortCut obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Skeleton_Ctor(Skeleton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Skeleton2D_Ctor(Skeleton2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SkeletonIK_Ctor(SkeletonIK obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Skin_Ctor(Skin obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SliderJoint_Ctor(SliderJoint obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SoftBody_Ctor(SoftBody obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Spatial_Ctor(Spatial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpatialMaterial_Ctor(SpatialMaterial obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpatialVelocityTracker_Ctor(SpatialVelocityTracker obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SphereMesh_Ctor(SphereMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SphereShape_Ctor(SphereShape obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpinBox_Ctor(SpinBox obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpotLight_Ctor(SpotLight obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpringArm_Ctor(SpringArm obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Sprite_Ctor(Sprite obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Sprite3D_Ctor(Sprite3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SpriteFrames_Ctor(SpriteFrames obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StaticBody_Ctor(StaticBody obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StaticBody2D_Ctor(StaticBody2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StreamPeerBuffer_Ctor(StreamPeerBuffer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StreamPeerGDNative_Ctor(StreamPeerGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StreamPeerSSL_Ctor(StreamPeerSSL obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StreamPeerTCP_Ctor(StreamPeerTCP obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StreamTexture_Ctor(StreamTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StyleBoxEmpty_Ctor(StyleBoxEmpty obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StyleBoxFlat_Ctor(StyleBoxFlat obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StyleBoxLine_Ctor(StyleBoxLine obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_StyleBoxTexture_Ctor(StyleBoxTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_SurfaceTool_Ctor(SurfaceTool obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TCP_Server_Ctor(TCP_Server obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TabContainer_Ctor(TabContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Tabs_Ctor(Tabs obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextEdit_Ctor(TextEdit obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextFile_Ctor(TextFile obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextMesh_Ctor(TextMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Texture3D_Ctor(Texture3D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextureArray_Ctor(TextureArray obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextureButton_Ctor(TextureButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextureProgress_Ctor(TextureProgress obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TextureRect_Ctor(TextureRect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Theme_Ctor(Theme obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TileMap_Ctor(TileMap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TileSet_Ctor(TileSet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Time_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Timer_Ctor(Timer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ToolButton_Ctor(ToolButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TouchScreenButton_Ctor(TouchScreenButton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Translation_Ctor(Translation obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TranslationServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Tree_Ctor(Tree obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_TriangleMesh_Ctor(TriangleMesh obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Tween_Ctor(Tween obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_UDPServer_Ctor(UDPServer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_UPNP_Ctor(UPNP obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_UPNPDevice_Ctor(UPNPDevice obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_UndoRedo_Ctor(UndoRedo obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VBoxContainer_Ctor(VBoxContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VFlowContainer_Ctor(VFlowContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VScrollBar_Ctor(VScrollBar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VSeparator_Ctor(VSeparator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VSlider_Ctor(VSlider obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VSplitContainer_Ctor(VSplitContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VehicleBody_Ctor(VehicleBody obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VehicleWheel_Ctor(VehicleWheel obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VideoPlayer_Ctor(VideoPlayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VideoStreamGDNative_Ctor(VideoStreamGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VideoStreamTheora_Ctor(VideoStreamTheora obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VideoStreamWebm_Ctor(VideoStreamWebm obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Viewport_Ctor(Viewport obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ViewportContainer_Ctor(ViewportContainer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_ViewportTexture_Ctor(ViewportTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisibilityEnabler_Ctor(VisibilityEnabler obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisibilityEnabler2D_Ctor(VisibilityEnabler2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisibilityNotifier_Ctor(VisibilityNotifier obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisibilityNotifier2D_Ctor(VisibilityNotifier2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScript_Ctor(VisualScript obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptBasicTypeConstant_Ctor(VisualScriptBasicTypeConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptBuiltinFunc_Ctor(VisualScriptBuiltinFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptClassConstant_Ctor(VisualScriptClassConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptComment_Ctor(VisualScriptComment obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptComposeArray_Ctor(VisualScriptComposeArray obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptCondition_Ctor(VisualScriptCondition obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptConstant_Ctor(VisualScriptConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptConstructor_Ctor(VisualScriptConstructor obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptCustomNode_Ctor(VisualScriptCustomNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptDeconstruct_Ctor(VisualScriptDeconstruct obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptEmitSignal_Ctor(VisualScriptEmitSignal obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptEngineSingleton_Ctor(VisualScriptEngineSingleton obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptExpression_Ctor(VisualScriptExpression obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptFunction_Ctor(VisualScriptFunction obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptFunctionCall_Ctor(VisualScriptFunctionCall obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptFunctionState_Ctor(VisualScriptFunctionState obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptGlobalConstant_Ctor(VisualScriptGlobalConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptIndexGet_Ctor(VisualScriptIndexGet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptIndexSet_Ctor(VisualScriptIndexSet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptInputAction_Ctor(VisualScriptInputAction obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptIterator_Ctor(VisualScriptIterator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptLocalVar_Ctor(VisualScriptLocalVar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptLocalVarSet_Ctor(VisualScriptLocalVarSet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptMathConstant_Ctor(VisualScriptMathConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptOperator_Ctor(VisualScriptOperator obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptPreload_Ctor(VisualScriptPreload obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptPropertyGet_Ctor(VisualScriptPropertyGet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptPropertySet_Ctor(VisualScriptPropertySet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptResourcePath_Ctor(VisualScriptResourcePath obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptReturn_Ctor(VisualScriptReturn obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSceneNode_Ctor(VisualScriptSceneNode obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSceneTree_Ctor(VisualScriptSceneTree obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSelect_Ctor(VisualScriptSelect obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSelf_Ctor(VisualScriptSelf obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSequence_Ctor(VisualScriptSequence obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSubCall_Ctor(VisualScriptSubCall obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptSwitch_Ctor(VisualScriptSwitch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptTypeCast_Ctor(VisualScriptTypeCast obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptVariableGet_Ctor(VisualScriptVariableGet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptVariableSet_Ctor(VisualScriptVariableSet obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptWhile_Ctor(VisualScriptWhile obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptYield_Ctor(VisualScriptYield obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualScriptYieldSignal_Ctor(VisualScriptYieldSignal obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualServer_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShader_Ctor(VisualShader obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeBooleanConstant_Ctor(VisualShaderNodeBooleanConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeBooleanUniform_Ctor(VisualShaderNodeBooleanUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeColorConstant_Ctor(VisualShaderNodeColorConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeColorFunc_Ctor(VisualShaderNodeColorFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeColorOp_Ctor(VisualShaderNodeColorOp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeColorUniform_Ctor(VisualShaderNodeColorUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeCompare_Ctor(VisualShaderNodeCompare obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeCubeMap_Ctor(VisualShaderNodeCubeMap obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeCubeMapUniform_Ctor(VisualShaderNodeCubeMapUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeCustom_Ctor(VisualShaderNodeCustom obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeDeterminant_Ctor(VisualShaderNodeDeterminant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeDotProduct_Ctor(VisualShaderNodeDotProduct obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeExpression_Ctor(VisualShaderNodeExpression obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeFaceForward_Ctor(VisualShaderNodeFaceForward obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeFresnel_Ctor(VisualShaderNodeFresnel obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeGlobalExpression_Ctor(VisualShaderNodeGlobalExpression obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeGroupBase_Ctor(VisualShaderNodeGroupBase obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeIf_Ctor(VisualShaderNodeIf obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeInput_Ctor(VisualShaderNodeInput obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeIs_Ctor(VisualShaderNodeIs obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeOuterProduct_Ctor(VisualShaderNodeOuterProduct obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarClamp_Ctor(VisualShaderNodeScalarClamp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarConstant_Ctor(VisualShaderNodeScalarConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarDerivativeFunc_Ctor(VisualShaderNodeScalarDerivativeFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarFunc_Ctor(VisualShaderNodeScalarFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarInterp_Ctor(VisualShaderNodeScalarInterp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarOp_Ctor(VisualShaderNodeScalarOp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarSmoothStep_Ctor(VisualShaderNodeScalarSmoothStep obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarSwitch_Ctor(VisualShaderNodeScalarSwitch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeScalarUniform_Ctor(VisualShaderNodeScalarUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeSwitch_Ctor(VisualShaderNodeSwitch obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTexture_Ctor(VisualShaderNodeTexture obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTextureUniform_Ctor(VisualShaderNodeTextureUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTextureUniformTriplanar_Ctor(VisualShaderNodeTextureUniformTriplanar obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformCompose_Ctor(VisualShaderNodeTransformCompose obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformConstant_Ctor(VisualShaderNodeTransformConstant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformDecompose_Ctor(VisualShaderNodeTransformDecompose obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformFunc_Ctor(VisualShaderNodeTransformFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformMult_Ctor(VisualShaderNodeTransformMult obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformUniform_Ctor(VisualShaderNodeTransformUniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeTransformVecMult_Ctor(VisualShaderNodeTransformVecMult obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeUniformRef_Ctor(VisualShaderNodeUniformRef obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVec3Constant_Ctor(VisualShaderNodeVec3Constant obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVec3Uniform_Ctor(VisualShaderNodeVec3Uniform obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorClamp_Ctor(VisualShaderNodeVectorClamp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorCompose_Ctor(VisualShaderNodeVectorCompose obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorDecompose_Ctor(VisualShaderNodeVectorDecompose obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorDerivativeFunc_Ctor(VisualShaderNodeVectorDerivativeFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorDistance_Ctor(VisualShaderNodeVectorDistance obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorFunc_Ctor(VisualShaderNodeVectorFunc obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorInterp_Ctor(VisualShaderNodeVectorInterp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorLen_Ctor(VisualShaderNodeVectorLen obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorOp_Ctor(VisualShaderNodeVectorOp obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorRefract_Ctor(VisualShaderNodeVectorRefract obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorScalarMix_Ctor(VisualShaderNodeVectorScalarMix obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorScalarSmoothStep_Ctor(VisualShaderNodeVectorScalarSmoothStep obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorScalarStep_Ctor(VisualShaderNodeVectorScalarStep obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_VisualShaderNodeVectorSmoothStep_Ctor(VisualShaderNodeVectorSmoothStep obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WeakRef_Ctor(WeakRef obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebRTCDataChannelGDNative_Ctor(WebRTCDataChannelGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebRTCMultiplayer_Ctor(WebRTCMultiplayer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebRTCPeerConnection_Ctor(WebRTCPeerConnection obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebRTCPeerConnectionGDNative_Ctor(WebRTCPeerConnectionGDNative obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebSocketClient_Ctor(WebSocketClient obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebSocketPeer_Ctor(WebSocketPeer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WebSocketServer_Ctor(WebSocketServer obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WindowDialog_Ctor(WindowDialog obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_World_Ctor(World obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_World2D_Ctor(World2D obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_WorldEnvironment_Ctor(WorldEnvironment obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_X509Certificate_Ctor(X509Certificate obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_XMLParser_Ctor(XMLParser obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_YSort_Ctor(YSort obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__ClassDB_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Directory_Ctor(Directory obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__Engine_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_File_Ctor(File obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__Geometry_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__GodotSharp_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__JSON_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__Marshalls_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Mutex_Ctor(Mutex obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__OS_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__ResourceLoader_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall__ResourceSaver_get_singleton();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Semaphore_Ctor(Semaphore obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_Thread_Ctor(Thread obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_0(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_1_1(IntPtr method, IntPtr ptr, byte[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_0_2(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_3(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_4(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_5(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_0_6(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_0_7(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_8(IntPtr method, IntPtr ptr, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_9(IntPtr method, IntPtr ptr, out Plane argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Mesh godot_icall_0_10(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_11(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_12(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_13(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_0_14(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_15(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_16(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_17(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_18(IntPtr method, IntPtr ptr, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_19(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_20(IntPtr method, IntPtr ptr, out Basis argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_21(IntPtr method, IntPtr ptr, bool arg1, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_22(IntPtr method, IntPtr ptr, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_23(IntPtr method, IntPtr ptr, int arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_24(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ARVRInterface godot_icall_1_25(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_0_26(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ARVRInterface godot_icall_1_27(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ARVRPositionalTracker godot_icall_1_28(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ARVRInterface godot_icall_0_29(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ulong godot_icall_0_30(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_31(IntPtr method, IntPtr ptr, int arg1, ref Vector3 arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_32(IntPtr method, IntPtr ptr, int arg1, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_33(IntPtr method, IntPtr ptr, int arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_34(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_35(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_1_36(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_37(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_38(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_39(IntPtr method, IntPtr ptr, ref Vector3 arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_40(IntPtr method, IntPtr ptr, ref Vector3 arg1, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_2_41(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_2_42(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_43(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_44(IntPtr method, IntPtr ptr, int arg1, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_45(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_46(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_47(IntPtr method, IntPtr ptr, ref Vector2 arg1, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_2_48(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Button godot_icall_0_49(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Label godot_icall_0_50(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Button godot_icall_3_51(IntPtr method, IntPtr ptr, string arg1, bool arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Button godot_icall_1_52(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_53(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_54(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SpriteFrames godot_icall_0_55(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_56(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_57(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_58(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_1_59(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_60(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_61(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_62(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_63(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_64(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_65(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_66(IntPtr method, IntPtr ptr, int arg1, float arg2, ref Vector3 arg3, ref Quat arg4, ref Vector3 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_67(IntPtr method, IntPtr ptr, int arg1, float arg2, object arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_68(IntPtr method, IntPtr ptr, int arg1, int arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_69(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_70(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_71(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_72(IntPtr method, IntPtr ptr, int arg1, float arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_73(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_74(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_75(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_3_76(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_77(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_78(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_79(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_80(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, ref Vector2 arg4, ref Vector2 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_81(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_82(IntPtr method, IntPtr ptr, int arg1, int arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_83(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_84(IntPtr method, IntPtr ptr, int arg1, float arg2, IntPtr arg3, float arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_85(IntPtr method, IntPtr ptr, int arg1, int arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_2_86(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_87(IntPtr method, IntPtr ptr, int arg1, float arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_88(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_89(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_90(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_91(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_92(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_93(IntPtr method, IntPtr ptr, string arg1, float arg2, float arg3, bool arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_7_94(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, float arg3, bool arg4, float arg5, int arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_6_95(IntPtr method, IntPtr ptr, int arg1, float arg2, bool arg3, float arg4, int arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_96(IntPtr method, IntPtr ptr, string arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_97(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_98(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnimationRootNode godot_icall_1_99(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_100(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_101(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_102(IntPtr method, IntPtr ptr, int[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_0_103(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_104(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_105(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnimationNode godot_icall_1_106(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_107(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_108(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_109(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_110(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_111(IntPtr method, IntPtr ptr, string arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_112(IntPtr method, IntPtr ptr, string arg1, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_113(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_114(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_115(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_116(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_117(IntPtr method, IntPtr ptr, string arg1, string arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnimationNodeStateMachineTransition godot_icall_1_118(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_0_119(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_120(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_121(IntPtr method, IntPtr ptr, int arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_122(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Animation godot_icall_1_123(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_124(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_125(IntPtr method, IntPtr ptr, string arg1, string arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_126(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_127(IntPtr method, IntPtr ptr, string arg1, float arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_128(IntPtr method, IntPtr ptr, string arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_129(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_0_130(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_131(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_132(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_133(IntPtr method, IntPtr ptr, float arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnimationNode godot_icall_0_134(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_135(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_136(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_137(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_138(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_139(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_140(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_141(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_142(IntPtr method, IntPtr ptr, string arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_143(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_144(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_145(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_146(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_147(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_148(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_149(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_150(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_151(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_152(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, IntPtr arg3, uint arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_153(IntPtr method, IntPtr ptr, int arg1, int arg2, byte[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_1_154(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_155(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_156(IntPtr method, IntPtr ptr, ref Transform arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_157(IntPtr method, IntPtr ptr, ref AABB arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_158(IntPtr method, IntPtr ptr, out AABB argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_159(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_160(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_0_161(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_162(IntPtr method, IntPtr ptr, ref Rect2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_163(IntPtr method, IntPtr ptr, out Rect2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_1_164(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long godot_icall_0_165(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_166(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_167(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_168(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_169(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioStreamSample godot_icall_0_170(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_171(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_172(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_173(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioEffect godot_icall_2_174(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioEffectInstance godot_icall_3_175(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_176(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_177(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_178(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern double godot_icall_0_179(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioBusLayout godot_icall_0_180(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_181(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_182(IntPtr method, IntPtr ptr, Vector2[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_183(IntPtr method, IntPtr ptr, byte[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioStream godot_icall_0_184(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_185(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AudioStreamPlayback godot_icall_0_186(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_187(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_0_188(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_189(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_190(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_191(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_192(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_193(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_194(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern BakedLightmapData godot_icall_0_195(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_196(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_197(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Sky godot_icall_0_198(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_199(IntPtr method, IntPtr ptr, ref Color arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_200(IntPtr method, IntPtr ptr, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_201(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_202(IntPtr method, IntPtr ptr, ref Transform arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_203(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, ref Rect2 arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_1_204(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_205(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_206(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_207(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ShortCut godot_icall_0_208(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ButtonGroup godot_icall_0_209(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_210(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_211(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_212(IntPtr method, IntPtr ptr, ref Rect2 arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_213(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_0_214(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_215(IntPtr method, IntPtr ptr, int arg1, ref Rect2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Image godot_icall_0_216(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_217(IntPtr method, IntPtr ptr, ref Rect2 arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_218(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Rect2 arg3, ref Vector2 arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern BitmapFont godot_icall_0_219(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_220(IntPtr method, IntPtr ptr, ref Transform2D arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_221(IntPtr method, IntPtr ptr, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_222(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_223(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern BaseButton godot_icall_0_224(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_225(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Curve godot_icall_1_226(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Gradient godot_icall_0_227(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_228(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_229(IntPtr method, IntPtr ptr, Vector3[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_0_230(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_231(IntPtr method, IntPtr ptr, Color[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Color[] godot_icall_0_232(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_233(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_234(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_235(IntPtr method, IntPtr ptr, Vector2[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_0_236(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Material godot_icall_0_237(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_238(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_239(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_240(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_241(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_242(IntPtr method, IntPtr ptr, object[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CallbackTweener godot_icall_1_243(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_244(IntPtr method, IntPtr ptr, ref Vector2 arg1, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_245(IntPtr method, IntPtr ptr, ref Vector3 arg1, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_246(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_247(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_248(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_249(IntPtr method, IntPtr ptr, float arg1, ref Vector2 arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_250(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Environment godot_icall_0_251(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_252(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_253(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_0_254(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_255(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_256(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_0_257(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_258(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CameraFeed godot_icall_1_259(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_260(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_261(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Color arg3, float arg4, bool arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_262(IntPtr method, IntPtr ptr, Vector2[] arg1, ref Color arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_263(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_8_264(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, float arg3, float arg4, int arg5, ref Color arg6, float arg7, bool arg8);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_265(IntPtr method, IntPtr ptr, ref Rect2 arg1, ref Color arg2, bool arg3, float arg4, bool arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_266(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, ref Color arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_267(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Color arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_268(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, bool arg3, ref Color arg4, bool arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_269(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Rect2 arg3, ref Color arg4, bool arg5, IntPtr arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_270(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_271(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, Vector2[] arg3, IntPtr arg4, float arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_272(IntPtr method, IntPtr ptr, Vector2[] arg1, Color[] arg2, Vector2[] arg3, IntPtr arg4, IntPtr arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_273(IntPtr method, IntPtr ptr, Vector2[] arg1, ref Color arg2, Vector2[] arg3, IntPtr arg4, IntPtr arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_274(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, ref Color arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_5_275(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, string arg4, ref Color arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_276(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref Transform2D arg4, ref Color arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_277(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_278(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern World2D godot_icall_0_279(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern InputEvent godot_icall_1_280(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_281(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_282(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_283(IntPtr method, IntPtr ptr, ulong arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_284(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_285(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_1_286(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_287(IntPtr method, IntPtr ptr, uint arg1, ref Transform arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_288(IntPtr method, IntPtr ptr, uint arg1, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Object godot_icall_1_289(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_290(IntPtr method, IntPtr ptr, uint arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_291(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_292(IntPtr method, IntPtr ptr, uint arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_293(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape godot_icall_2_294(IntPtr method, IntPtr ptr, uint arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_295(IntPtr method, IntPtr ptr, uint arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_296(IntPtr method, IntPtr ptr, uint arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_297(IntPtr method, IntPtr ptr, uint arg1, ref Transform2D arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_298(IntPtr method, IntPtr ptr, uint arg1, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_299(IntPtr method, IntPtr ptr, uint arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_300(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape2D godot_icall_2_301(IntPtr method, IntPtr ptr, uint arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_302(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape godot_icall_0_303(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape2D godot_icall_0_304(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ColorPicker godot_icall_0_305(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PopupPanel godot_icall_0_306(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_307(IntPtr method, IntPtr ptr, string arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_308(IntPtr method, IntPtr ptr, string arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_1_309(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_310(IntPtr method, IntPtr ptr, string arg1, byte[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_311(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_312(IntPtr method, IntPtr ptr, int arg1, float arg2, bool arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_313(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Control godot_icall_0_314(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Theme godot_icall_0_315(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_316(IntPtr method, IntPtr ptr, string arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_2_317(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern StyleBox godot_icall_2_318(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Font godot_icall_2_319(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_320(IntPtr method, IntPtr ptr, string arg1, string arg2, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_321(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Font godot_icall_0_322(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_323(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_324(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_325(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_326(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_327(IntPtr method, IntPtr ptr, object arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_328(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_1_329(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CryptoKey godot_icall_1_330(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern X509Certificate godot_icall_4_331(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, string arg3, string arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_3_332(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_4_333(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_2_334(IntPtr method, IntPtr ptr, IntPtr arg1, byte[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_3_335(IntPtr method, IntPtr ptr, int arg1, byte[] arg2, byte[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_336(IntPtr method, IntPtr ptr, byte[] arg1, byte[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_337(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_338(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Image godot_icall_1_339(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_340(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_341(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_342(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2, float arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_343(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_344(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_345(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_346(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_347(IntPtr method, IntPtr ptr, int arg1, float arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_348(IntPtr method, IntPtr ptr, float arg1, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_349(IntPtr method, IntPtr ptr, float arg1, bool arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_350(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_2_351(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_352(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_353(IntPtr method, IntPtr ptr, int arg1, float arg2, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_354(IntPtr method, IntPtr ptr, float arg1, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_355(IntPtr method, IntPtr ptr, float arg1, bool arg2, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float[] godot_icall_0_356(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_357(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_2_358(IntPtr method, IntPtr ptr, int arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Curve godot_icall_0_359(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_360(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PacketPeerDTLS godot_icall_1_361(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_362(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_363(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern DynamicFontData godot_icall_0_364(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern DynamicFontData godot_icall_1_365(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_366(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VBoxContainer godot_icall_0_371(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_377(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_389(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_390(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Object godot_icall_0_397(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_0_402(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_406(IntPtr method, IntPtr ptr, string arg1, object arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_407(IntPtr method, IntPtr ptr, string[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Spatial godot_icall_0_412(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_420(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_424(IntPtr method, IntPtr ptr, ref Basis arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_425(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_426(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_427(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_428(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_429(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_430(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_431(IntPtr method, IntPtr ptr, string arg1, string[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_432(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_433(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern LineEdit godot_icall_0_434(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_435(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_436(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, string arg3, ref Color arg4, int arg5, ref Color arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_437(IntPtr method, IntPtr ptr, string arg1, float arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_6_438(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, int arg3, int arg4, ref Color arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_439(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_440(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_441(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, out Rect2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_442(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_443(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern GDNativeLibrary godot_icall_0_444(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_445(IntPtr method, IntPtr ptr, string arg1, string arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ConfigFile godot_icall_0_446(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_447(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_448(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern GIProbeData godot_icall_0_449(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_450(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_451(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_452(IntPtr method, IntPtr ptr, float[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ArrayMesh godot_icall_0_453(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_0_454(IntPtr method, IntPtr ptr, out Quat argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_455(IntPtr method, IntPtr ptr, ref Quat arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Skeleton godot_icall_0_456(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern BoneAttachment godot_icall_1_457(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Skin godot_icall_0_458(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnimationPlayer godot_icall_1_459(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_1_460(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_461(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_462(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_463(IntPtr method, IntPtr ptr, float arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_464(IntPtr method, IntPtr ptr, int arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_465(IntPtr method, IntPtr ptr, int arg1, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_466(IntPtr method, IntPtr ptr, float arg1, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_467(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_468(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_469(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_470(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_4_471(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_472(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_473(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3, int arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern HBoxContainer godot_icall_0_474(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_9_475(IntPtr method, IntPtr ptr, int arg1, bool arg2, int arg3, ref Color arg4, bool arg5, int arg6, ref Color arg7, IntPtr arg8, IntPtr arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_476(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PhysicsMaterial godot_icall_0_477(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MeshLibrary godot_icall_0_478(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_479(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_480(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_481(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_482(IntPtr method, IntPtr ptr, bool arg1, bool arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_483(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_484(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_485(IntPtr method, IntPtr ptr, bool arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_486(IntPtr method, IntPtr ptr, int arg1, byte[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_487(IntPtr method, IntPtr ptr, byte[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_488(IntPtr method, IntPtr ptr, string arg1, int arg2, bool arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern StreamPeer godot_icall_0_489(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_490(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, byte[] arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_491(IntPtr method, IntPtr ptr, int arg1, string arg2, string[] arg3, string arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_492(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_493(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_494(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, int arg4, byte[] arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_495(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, int arg4, string arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_496(IntPtr method, IntPtr ptr, double arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_497(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_498(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_499(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_500(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_501(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_502(IntPtr method, IntPtr ptr, bool arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_503(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_504(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_505(IntPtr method, IntPtr ptr, int arg1, int arg2, bool arg3, int arg4, byte[] arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_506(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_507(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_508(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_509(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Rect2 arg3, ref Vector2 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_510(IntPtr method, IntPtr ptr, ref Rect2 arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Image godot_icall_1_511(IntPtr method, IntPtr ptr, ref Rect2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_512(IntPtr method, IntPtr ptr, ref Vector2 arg1, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_513(IntPtr method, IntPtr ptr, int arg1, int arg2, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_514(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_515(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Color arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_516(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, uint arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_517(IntPtr method, IntPtr ptr, IntPtr arg1, uint arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_518(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_519(IntPtr method, IntPtr ptr, ref Plane arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_520(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_521(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_522(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_523(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3, string arg4, float arg5, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_524(IntPtr method, IntPtr ptr, int arg1, bool arg2, string arg3, string arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_525(IntPtr method, IntPtr ptr, int arg1, float arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_526(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_527(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_528(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_529(IntPtr method, IntPtr ptr, string arg1, bool arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_530(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_531(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern InputEvent godot_icall_2_532(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_533(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_534(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_535(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_536(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_2_537(IntPtr method, IntPtr ptr, bool arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_538(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_539(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_540(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_541(IntPtr method, IntPtr ptr, int arg1, out Rect2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_542(IntPtr method, IntPtr ptr, int arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_543(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_544(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_545(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VScrollBar godot_icall_0_546(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_0_547(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_548(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_549(IntPtr method, IntPtr ptr, object arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_550(IntPtr method, IntPtr ptr, string arg1, object arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_551(IntPtr method, IntPtr ptr, object arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_552(IntPtr method, IntPtr ptr, string arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_553(IntPtr method, IntPtr ptr, int arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern JavaClass godot_icall_1_554(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_555(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern JavaScriptObject godot_icall_1_556(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern JavaScriptObject godot_icall_2_557(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_558(IntPtr method, IntPtr ptr, string arg1, object[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_559(IntPtr method, IntPtr ptr, byte[] arg1, string arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision godot_icall_4_560(IntPtr method, IntPtr ptr, ref Vector3 arg1, bool arg2, bool arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_561(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, bool arg3, int arg4, float arg5, bool arg6, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_562(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, bool arg4, int arg5, float arg6, bool arg7, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_563(IntPtr method, IntPtr ptr, ref Transform arg1, ref Vector3 arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_564(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision godot_icall_1_565(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision godot_icall_0_566(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision2D godot_icall_4_567(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2, bool arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_568(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, bool arg3, int arg4, float arg5, bool arg6, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_569(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, bool arg4, int arg5, float arg6, bool arg7, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_570(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_571(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision2D godot_icall_1_572(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern KinematicCollision2D godot_icall_0_573(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_574(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_575(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_576(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_577(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_578(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_579(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TriangleMesh godot_icall_0_580(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_581(IntPtr method, IntPtr ptr, ref Vector2 arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_582(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_583(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_584(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern OccluderPolygon2D godot_icall_0_585(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_586(IntPtr method, IntPtr ptr, ref Vector2 arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_587(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_588(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_589(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_590(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PopupMenu godot_icall_0_591(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_592(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_593(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Material godot_icall_1_594(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape godot_icall_2_595(IntPtr method, IntPtr ptr, bool arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Mesh godot_icall_1_596(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_597(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_598(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_599(IntPtr method, IntPtr ptr, int arg1, ref Plane arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_600(IntPtr method, IntPtr ptr, int arg1, out Plane argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_601(IntPtr method, IntPtr ptr, int arg1, int[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_602(IntPtr method, IntPtr ptr, int arg1, float[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float[] godot_icall_1_603(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_604(IntPtr method, IntPtr ptr, bool arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_605(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_606(IntPtr method, IntPtr ptr, int arg1, ref Transform arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_607(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Mesh godot_icall_1_608(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_609(IntPtr method, IntPtr ptr, int arg1, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NavigationMesh godot_icall_1_610(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MethodTweener godot_icall_1_611(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MethodTweener godot_icall_1_612(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_613(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_614(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_615(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_616(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_617(IntPtr method, IntPtr ptr, int arg1, ref Transform2D arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_618(IntPtr method, IntPtr ptr, int arg1, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_619(IntPtr method, IntPtr ptr, float[] arg1, float[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MultiMesh godot_icall_0_620(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_621(IntPtr method, IntPtr ptr, byte[] arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NetworkedMultiplayerPeer godot_icall_0_622(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_3_623(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_624(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, bool arg3, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_625(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_3_626(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_627(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_628(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_1_629(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_630(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_1_631(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_5_632(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Vector2 arg3, bool arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_633(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_634(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_635(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_636(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_637(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_638(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_639(IntPtr method, IntPtr ptr, IntPtr arg1, uint arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_1_640(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_641(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform2D arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_642(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_643(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_644(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_645(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_646(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_647(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, string arg3, object arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_648(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_649(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_650(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_651(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NavigationMesh godot_icall_0_652(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_653(IntPtr method, IntPtr ptr, Vector2[] arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_654(IntPtr method, IntPtr ptr, int arg1, Vector2[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NavigationPolygon godot_icall_0_655(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_656(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_657(IntPtr method, IntPtr ptr, IntPtr arg1, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_5_658(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, ref Vector3 arg3, bool arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_659(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, ref Vector3 arg3, bool arg4, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_660(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_661(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_662(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_663(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_664(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_665(IntPtr method, IntPtr ptr, byte[] arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_666(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_667(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_668(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_669(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_670(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_671(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_672(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_1_673(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_3_674(IntPtr method, IntPtr ptr, string arg1, bool arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_1_675(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_676(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_677(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_678(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_679(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_680(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_681(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTree godot_icall_0_682(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTween godot_icall_0_683(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Viewport godot_icall_0_684(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MultiplayerAPI godot_icall_0_685(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_686(IntPtr method, IntPtr ptr, int arg1, string arg2, object[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_687(IntPtr method, IntPtr ptr, int arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_688(IntPtr method, IntPtr ptr, IntPtr arg1, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern OpenSimplexNoise godot_icall_0_689(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_690(IntPtr method, IntPtr ptr, IntPtr arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_691(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Reference godot_icall_0_692(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_693(IntPtr method, IntPtr ptr, string arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_694(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_695(IntPtr method, IntPtr ptr, string arg1, object[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_696(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_697(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3, IntPtr arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_698(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_699(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern OccluderShape godot_icall_0_700(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_701(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_702(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_703(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Image godot_icall_3_704(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_705(IntPtr method, IntPtr ptr, float arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_3_706(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_4_707(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_708(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_709(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_710(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_711(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneState godot_icall_0_712(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_713(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_714(IntPtr method, IntPtr ptr, string arg1, int arg2, float arg3, uint arg4, IntPtr arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Node godot_icall_5_715(IntPtr method, IntPtr ptr, string arg1, uint arg2, float arg3, uint arg4, IntPtr arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_716(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_717(IntPtr method, IntPtr ptr, object arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_718(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, string arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_719(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_720(IntPtr method, IntPtr ptr, int arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_721(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_722(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_723(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CurveTexture godot_icall_0_724(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern GradientTexture godot_icall_0_725(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Curve3D godot_icall_0_726(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Curve2D godot_icall_0_727(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_728(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_729(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_730(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_731(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ulong godot_icall_1_732(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Object godot_icall_1_733(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Physics2DDirectSpaceState godot_icall_0_734(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_6_735(IntPtr method, IntPtr ptr, ref Vector2 arg1, int arg2, IntPtr arg3, uint arg4, bool arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_7_736(IntPtr method, IntPtr ptr, ref Vector2 arg1, ulong arg2, int arg3, IntPtr arg4, uint arg5, bool arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_6_737(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, IntPtr arg3, uint arg4, bool arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_738(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_739(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_740(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_741(IntPtr method, IntPtr ptr, IntPtr arg1, object arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_742(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_1_743(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_744(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_2_745(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Physics2DDirectSpaceState godot_icall_1_746(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_747(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_748(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform2D arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_749(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_750(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform2D arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_751(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_752(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_753(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_754(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_755(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_756(IntPtr method, IntPtr ptr, IntPtr arg1, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_757(IntPtr method, IntPtr ptr, IntPtr arg1, ulong arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ulong godot_icall_1_758(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_759(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_760(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_761(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, bool arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_762(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_763(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_8_764(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform2D arg2, ref Vector2 arg3, bool arg4, float arg5, IntPtr arg6, bool arg7, IntPtr arg8);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Physics2DDirectBodyState godot_icall_1_765(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_766(IntPtr method, IntPtr ptr, ref Vector2 arg1, IntPtr arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_5_767(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, IntPtr arg4, IntPtr arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_4_768(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, IntPtr arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_769(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PhysicsDirectSpaceState godot_icall_0_770(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_6_771(IntPtr method, IntPtr ptr, ref Vector3 arg1, int arg2, IntPtr arg3, uint arg4, bool arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_6_772(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, IntPtr arg3, uint arg4, bool arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_773(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_774(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PhysicsDirectSpaceState godot_icall_1_775(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_776(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_777(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_778(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_779(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_780(IntPtr method, IntPtr ptr, IntPtr arg1, out Transform argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_781(IntPtr method, IntPtr ptr, int arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_782(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_783(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, ref Vector3 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_784(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_7_785(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2, ref Vector3 arg3, bool arg4, IntPtr arg5, bool arg6, IntPtr arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PhysicsDirectBodyState godot_icall_1_786(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_4_787(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector3 arg2, IntPtr arg3, ref Vector3 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_4_788(IntPtr method, IntPtr ptr, IntPtr arg1, ref Transform arg2, IntPtr arg3, ref Transform arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_789(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_790(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_3_791(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_792(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_793(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_794(IntPtr method, IntPtr ptr, IntPtr arg1, float[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_795(IntPtr method, IntPtr ptr, Vector2[] arg1, int[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_2_796(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_797(IntPtr method, IntPtr ptr, ref Vector2 arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_798(IntPtr method, IntPtr ptr, string arg1, int arg2, uint arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_799(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, int arg3, uint arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_800(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_801(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_802(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_803(IntPtr method, IntPtr ptr, string arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_804(IntPtr method, IntPtr ptr, int arg1, uint arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_805(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ShortCut godot_icall_1_806(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_807(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_808(IntPtr method, IntPtr ptr, string arg1, bool arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PropertyTweener godot_icall_1_809(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PropertyTweener godot_icall_0_810(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PropertyTweener godot_icall_1_811(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PropertyTweener godot_icall_1_812(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_813(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_814(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RegExMatch godot_icall_3_815(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_816(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_5_817(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_818(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_819(IntPtr method, IntPtr ptr, object arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_1_820(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_1_821(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_822(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_823(IntPtr method, IntPtr ptr, int arg1, bool arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_824(IntPtr method, IntPtr ptr, string[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_825(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_826(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_827(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_4_828(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2, float arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_829(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_830(IntPtr method, IntPtr ptr, int arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PackedScene godot_icall_1_831(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_1_832(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTimer godot_icall_2_833(IntPtr method, IntPtr ptr, float arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_834(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Vector2 arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_4_835(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, object[] arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_836(IntPtr method, IntPtr ptr, uint arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_837(IntPtr method, IntPtr ptr, uint arg1, string arg2, string arg3, object arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_838(IntPtr method, IntPtr ptr, string arg1, string arg2, object[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PropertyTweener godot_icall_4_839(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, object arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntervalTweener godot_icall_1_840(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CallbackTweener godot_icall_3_841(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MethodTweener godot_icall_6_842(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, object arg4, float arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTween godot_icall_1_843(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTween godot_icall_1_844(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTween godot_icall_1_845(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SceneTreeTween godot_icall_1_846(IntPtr method, IntPtr ptr, float arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_6_847(IntPtr method, IntPtr ptr, object arg1, object arg2, float arg3, float arg4, int arg5, int arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Script godot_icall_0_848(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern HScrollBar godot_icall_0_850(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_851(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_1_852(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shader godot_icall_0_853(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_854(IntPtr method, IntPtr ptr, ref Transform2D arg1, IntPtr arg2, ref Transform2D arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_5_855(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2, IntPtr arg3, ref Transform2D arg4, ref Vector2 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_856(IntPtr method, IntPtr ptr, ref Transform2D arg1, IntPtr arg2, ref Transform2D arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_5_857(IntPtr method, IntPtr ptr, ref Transform2D arg1, ref Vector2 arg2, IntPtr arg3, ref Transform2D arg4, ref Vector2 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_858(IntPtr method, IntPtr ptr, IntPtr arg1, ref Color arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern InputEvent godot_icall_0_859(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SkinReference godot_icall_1_860(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_861(IntPtr method, IntPtr ptr, int arg1, ref Transform arg2, float arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Bone2D godot_icall_1_862(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_863(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_864(IntPtr method, IntPtr ptr, int arg1, bool arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern World godot_icall_0_865(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SpatialGizmo godot_icall_0_866(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_867(IntPtr method, IntPtr ptr, ref Vector3 arg1, float arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_868(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_869(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_870(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_871(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_872(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_873(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_874(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_875(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_876(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_877(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_878(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_879(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_880(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_881(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_882(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_2_883(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_884(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_885(IntPtr method, IntPtr ptr, byte[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_886(IntPtr method, IntPtr ptr, sbyte arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_887(IntPtr method, IntPtr ptr, byte arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_888(IntPtr method, IntPtr ptr, short arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_889(IntPtr method, IntPtr ptr, ushort arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_890(IntPtr method, IntPtr ptr, long arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_891(IntPtr method, IntPtr ptr, object arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern sbyte godot_icall_0_892(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte godot_icall_0_893(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern short godot_icall_0_894(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ushort godot_icall_0_895(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern StreamPeerBuffer godot_icall_0_896(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_897(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_898(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_899(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_900(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Rect2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CanvasItem godot_icall_0_901(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_902(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_903(IntPtr method, IntPtr ptr, float arg1, float arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_904(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_905(IntPtr method, IntPtr ptr, Vector3[] arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, Vector3[] arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_906(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_907(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_908(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Transform arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ArrayMesh godot_icall_2_909(IntPtr method, IntPtr ptr, IntPtr arg1, uint arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_910(IntPtr method, IntPtr ptr, ushort arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern StreamPeerTCP godot_icall_0_911(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Control godot_icall_1_912(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_913(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_914(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Popup godot_icall_0_915(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_916(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_917(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_918(IntPtr method, IntPtr ptr, int arg1, bool arg2, bool arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_919(IntPtr method, IntPtr ptr, int arg1, int arg2, out Rect2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_4_920(IntPtr method, IntPtr ptr, string arg1, uint arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_921(IntPtr method, IntPtr ptr, string arg1, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_922(IntPtr method, IntPtr ptr, string arg1, string arg2, ref Color arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_923(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_924(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Color arg3, bool arg4, IntPtr arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_925(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, bool arg3, ref Color arg4, bool arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_926(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Rect2 arg3, ref Color arg4, bool arg5, IntPtr arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_927(IntPtr method, IntPtr ptr, uint arg1, uint arg2, uint arg3, int arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern BitMap godot_icall_0_928(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_929(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_930(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_931(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_932(IntPtr method, IntPtr ptr, string arg1, string arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_933(IntPtr method, IntPtr ptr, string arg1, string arg2, ref Color arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_934(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, object arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_3_935(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_936(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_937(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3, string arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_938(IntPtr method, IntPtr ptr, int arg1, string arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_2_939(IntPtr method, IntPtr ptr, int arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TileSet godot_icall_0_940(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_941(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_942(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_943(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_944(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, bool arg4, bool arg5, bool arg6, ref Vector2 arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_945(IntPtr method, IntPtr ptr, ref Vector2 arg1, int arg2, bool arg3, bool arg4, bool arg5, ref Vector2 arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_946(IntPtr method, IntPtr ptr, ref Vector2 arg1, bool arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_947(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_948(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_949(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern OccluderPolygon2D godot_icall_2_950(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NavigationPolygon godot_icall_2_951(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_952(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2, uint arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_2_953(IntPtr method, IntPtr ptr, int arg1, ref Vector2 arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_954(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ShaderMaterial godot_icall_1_955(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Shape2D godot_icall_2_956(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_957(IntPtr method, IntPtr ptr, int arg1, int arg2, ref Transform2D arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_958(IntPtr method, IntPtr ptr, int arg1, int arg2, out Transform2D argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_959(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, ref Transform2D arg3, bool arg4, ref Vector2 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_960(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern NavigationPolygon godot_icall_1_961(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern OccluderPolygon2D godot_icall_1_962(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_963(IntPtr method, IntPtr ptr, long arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_964(IntPtr method, IntPtr ptr, long arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_965(IntPtr method, IntPtr ptr, long arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_966(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_967(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long godot_icall_1_968(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long godot_icall_1_969(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_970(IntPtr method, IntPtr ptr, bool arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_971(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_972(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TreeItem godot_icall_2_973(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TreeItem godot_icall_0_974(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TreeItem godot_icall_1_975(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_976(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_977(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Rect2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TreeItem godot_icall_1_978(IntPtr method, IntPtr ptr, ref Vector2 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_979(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_980(IntPtr method, IntPtr ptr, int arg1, double arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern double godot_icall_1_981(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_982(IntPtr method, IntPtr ptr, int arg1, double arg2, double arg3, double arg4, bool arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_983(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_984(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TreeItem godot_icall_1_985(IntPtr method, IntPtr ptr, bool arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_986(IntPtr method, IntPtr ptr, int arg1, ref Color arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_987(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, int arg3, bool arg4, string arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Texture godot_icall_2_988(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_989(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_990(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_991(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_8_992(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, object arg3, object arg4, float arg5, int arg6, int arg7, float arg8);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_8_993(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, object arg4, float arg5, int arg6, int arg7, float arg8);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_11_994(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, string arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_9_995(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, object arg3, IntPtr arg4, IntPtr arg5, float arg6, int arg7, int arg8, float arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_9_996(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, IntPtr arg4, string arg5, float arg6, int arg7, int arg8, float arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_9_997(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, object arg5, float arg6, int arg7, int arg8, float arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_9_998(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3, string arg4, object arg5, float arg6, int arg7, int arg8, float arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PacketPeerUDP godot_icall_0_999(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern UPNPDevice godot_icall_1_1000(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern UPNPDevice godot_icall_0_1001(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1002(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_1003(IntPtr method, IntPtr ptr, int arg1, int arg2, string arg3, string arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1004(IntPtr method, IntPtr ptr, int arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1005(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1006(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1007(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VideoStream godot_icall_0_1008(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1009(IntPtr method, IntPtr ptr, bool arg1, ref Vector2 arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1010(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1011(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1012(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1013(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1014(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ViewportTexture godot_icall_0_1015(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Camera godot_icall_0_1016(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1017(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1018(IntPtr method, IntPtr ptr, string arg1, int arg2, IntPtr arg3, ref Vector2 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VisualScriptNode godot_icall_2_1019(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1020(IntPtr method, IntPtr ptr, string arg1, int arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1021(IntPtr method, IntPtr ptr, string arg1, int arg2, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1022(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_4_1023(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1024(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_5_1025(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1026(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_1027(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1028(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1029(IntPtr method, IntPtr ptr, string arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1030(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1031(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1032(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1033(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1034(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1035(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1036(IntPtr method, IntPtr ptr, int arg1, string arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1037(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VisualScript godot_icall_0_1038(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1039(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1040(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1041(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1042(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1043(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1044(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1045(IntPtr method, IntPtr ptr, bool arg1, double arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1046(IntPtr method, IntPtr ptr, IntPtr arg1, uint arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1047(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, int arg4, int arg5, int arg6, uint arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1048(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_10_1049(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Image godot_icall_2_1050(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1051(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1052(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1053(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1054(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_1055(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1056(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1057(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1058(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1059(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_1060(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_4_1061(IntPtr method, IntPtr ptr, uint arg1, int arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1062(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4, uint arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1063(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1064(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, byte[] arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1065(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_2_1066(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1067(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_2_1068(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1069(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1070(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out AABB argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1071(IntPtr method, IntPtr ptr, IntPtr arg1, ref AABB arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_1_1072(IntPtr method, IntPtr ptr, IntPtr arg1, out AABB argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1073(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1074(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, ref Color arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1075(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, out Color argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1076(IntPtr method, IntPtr ptr, IntPtr arg1, float[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1077(IntPtr method, IntPtr ptr, IntPtr arg1, ref Plane arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1078(IntPtr method, IntPtr ptr, IntPtr arg1, int[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_1_1079(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1080(IntPtr method, IntPtr ptr, IntPtr arg1, byte[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_1_1081(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1082(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1083(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, ref Vector2 arg3, float arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1084(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1085(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1086(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform2D arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1087(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1088(IntPtr method, IntPtr ptr, IntPtr arg1, ref Basis arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1089(IntPtr method, IntPtr ptr, IntPtr arg1, ref Color arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_1090(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, float arg3, float arg4, float arg5, int arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_12_1091(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, int arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, float arg10, bool arg11, bool arg12);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_9_1092(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, float arg3, float arg4, bool arg5, float arg6, float arg7, float arg8, float arg9);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_1093(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, float arg3, float arg4, float arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1094(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, int arg3, float arg4, float arg5, float arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_13_1095(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, ref Color arg10, int arg11, int arg12, float arg13);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1096(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, ref Color arg3, ref Color arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1097(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, float arg3, float arg4, float arg5, bool arg6, float arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1098(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, float arg3, float arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1099(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1100(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref Rect2 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1101(IntPtr method, IntPtr ptr, IntPtr arg1, float arg2, float arg3, float arg4, float arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1102(IntPtr method, IntPtr ptr, ref AABB arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_1103(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1104(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1105(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Vector2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1106(IntPtr method, IntPtr ptr, IntPtr arg1, bool arg2, ref Rect2 arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_1107(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, ref Vector2 arg3, ref Color arg4, float arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_5_1108(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2[] arg2, Color[] arg3, float arg4, bool arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1109(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Color arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1110(IntPtr method, IntPtr ptr, IntPtr arg1, ref Vector2 arg2, float arg3, ref Color arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1111(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, IntPtr arg3, bool arg4, ref Color arg5, bool arg6, IntPtr arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_8_1112(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, IntPtr arg3, ref Rect2 arg4, ref Color arg5, bool arg6, IntPtr arg7, bool arg8);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_11_1113(IntPtr method, IntPtr ptr, IntPtr arg1, ref Rect2 arg2, ref Rect2 arg3, IntPtr arg4, ref Vector2 arg5, ref Vector2 arg6, int arg7, int arg8, bool arg9, ref Color arg10, IntPtr arg11);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1114(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, IntPtr arg5, float arg6, IntPtr arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_7_1115(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2[] arg2, Color[] arg3, Vector2[] arg4, IntPtr arg5, IntPtr arg6, bool arg7);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_12_1116(IntPtr method, IntPtr ptr, IntPtr arg1, int[] arg2, Vector2[] arg3, Color[] arg4, Vector2[] arg5, int[] arg6, float[] arg7, IntPtr arg8, int arg9, IntPtr arg10, bool arg11, bool arg12);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_6_1117(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, ref Transform2D arg3, ref Color arg4, IntPtr arg5, IntPtr arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1118(IntPtr method, IntPtr ptr, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1119(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2[] arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1120(IntPtr method, IntPtr ptr, IntPtr arg1, Vector2[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_1121(IntPtr method, IntPtr ptr, int arg1, int arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1122(IntPtr method, IntPtr ptr, IntPtr arg1, ref Color arg2, bool arg3, bool arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1123(IntPtr method, IntPtr ptr, int arg1, IntPtr arg2, ref Vector2 arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern VisualShaderNode godot_icall_2_1124(IntPtr method, IntPtr ptr, int arg1, int arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_5_1125(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_5_1126(IntPtr method, IntPtr ptr, int arg1, int arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1127(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1128(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1129(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1130(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1131(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1132(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CubeMap godot_icall_0_1133(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1134(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1135(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1136(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1137(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1138(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1139(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1140(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1141(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1142(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1143(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1144(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1145(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1146(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1147(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1148(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1149(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1150(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1151(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1152(IntPtr method, IntPtr ptr, int arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1153(IntPtr method, IntPtr ptr, IntPtr arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1154(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern WebRTCDataChannel godot_icall_2_1155(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1156(IntPtr method, IntPtr ptr, string arg1, int arg2, string arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1157(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_1158(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, string[] arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern X509Certificate godot_icall_0_1159(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern WebSocketPeer godot_icall_1_1160(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1161(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1162(IntPtr method, IntPtr ptr, int arg1, string[] arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CryptoKey godot_icall_0_1163(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1164(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TextureButton godot_icall_0_1165(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1166(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1167(IntPtr method, IntPtr ptr, ulong arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1168(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_2_1169(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1170(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_1171(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_2_1172(IntPtr method, IntPtr ptr, string arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_3_1173(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_3_1174(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_2_1175(IntPtr method, IntPtr ptr, bool arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MainLoop godot_icall_0_1176(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Object godot_icall_1_1177(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1178(IntPtr method, IntPtr ptr, string arg1, int arg2, byte[] arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1179(IntPtr method, IntPtr ptr, string arg1, int arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_1_1180(IntPtr method, IntPtr ptr, long arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_2_1181(IntPtr method, IntPtr ptr, string[] arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ulong godot_icall_1_1182(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_1183(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_4_1184(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_5_1185(IntPtr method, IntPtr ptr, float arg1, float arg2, int arg3, int arg4, int arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_3_1186(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, float arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float godot_icall_4_1187(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_4_1188(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_4_1189(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_4_1190(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, ref Vector3 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1191(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, out Vector2 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_3_1192(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, out Vector3 argRet);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_1_1193(IntPtr method, IntPtr ptr, ref Vector3 arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern object godot_icall_5_1194(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, ref Vector3 arg4, ref Vector3 arg5);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_4_1195(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, ref Vector3 arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_4_1196(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, float arg3, float arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_3_1197(IntPtr method, IntPtr ptr, ref Vector3 arg1, ref Vector3 arg2, IntPtr arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_4_1198(IntPtr method, IntPtr ptr, ref Vector2 arg1, ref Vector2 arg2, ref Vector2 arg3, ref Vector2 arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool godot_icall_2_1199(IntPtr method, IntPtr ptr, ref Vector2 arg1, Vector2[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int[] godot_icall_1_1200(IntPtr method, IntPtr ptr, Vector2[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector2[] godot_icall_1_1201(IntPtr method, IntPtr ptr, Vector2[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Vector3[] godot_icall_2_1202(IntPtr method, IntPtr ptr, Vector3[] arg1, ref Plane arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_2_1203(IntPtr method, IntPtr ptr, Vector2[] arg1, Vector2[] arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_3_1204(IntPtr method, IntPtr ptr, Vector2[] arg1, float arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_4_1205(IntPtr method, IntPtr ptr, Vector2[] arg1, float arg2, int arg3, int arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr godot_icall_1_1206(IntPtr method, IntPtr ptr, Vector2[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_3_1207(IntPtr method, IntPtr ptr, object arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern JSONParseResult godot_icall_1_1208(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_1209(IntPtr method, IntPtr ptr, object arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_1210(IntPtr method, IntPtr ptr, byte[] arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern byte[] godot_icall_1_1211(IntPtr method, IntPtr ptr, string arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void godot_icall_4_1212(IntPtr method, IntPtr ptr, string arg1, string arg2, object arg3, object arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1213(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long godot_icall_1_1214(IntPtr method, IntPtr ptr, int arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1215(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_6_1216(IntPtr method, IntPtr ptr, string arg1, string[] arg2, bool arg3, IntPtr arg4, bool arg5, bool arg6);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern uint godot_icall_1_1217(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_2_1218(IntPtr method, IntPtr ptr, int arg1, bool arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_1219(IntPtr method, IntPtr ptr, string arg1, float arg2, string arg3, string arg4);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string godot_icall_1_1220(IntPtr method, IntPtr ptr, uint arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_0_1221(IntPtr method, IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ResourceInteractiveLoader godot_icall_2_1222(IntPtr method, IntPtr ptr, string arg1, string arg2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern Resource godot_icall_3_1223(IntPtr method, IntPtr ptr, string arg1, string arg2, bool arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_3_1224(IntPtr method, IntPtr ptr, string arg1, IntPtr arg2, int arg3);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] godot_icall_1_1225(IntPtr method, IntPtr ptr, IntPtr arg1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int godot_icall_4_1226(IntPtr method, IntPtr ptr, IntPtr arg1, string arg2, object arg3, int arg4);
    }
}
