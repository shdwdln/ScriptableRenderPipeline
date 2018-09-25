using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    public static class VRUtils
    {
        public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera)
        {   // This method expects VRGraphicsConfig.SetConfig() to have been called prior to it.
            // Then, engine code will check if occlusion mesh rendering is enabled, and apply occlusion mesh scale.
#if UNITY_2019_1_OR_NEWER
            if ((!VRGraphicsConfig.enabled) || (!camera.stereoEnabled))
                return;
            UnityEngine.RectInt normalizedCamViewport = new UnityEngine.RectInt(0, 0, camera.pixelWidth, camera.pixelHeight);
            cmd.DrawOcclusionMesh(normalizedCamViewport);
#else
            return;
#endif
        }

        public static void DrawOcclusionMesh(CommandBuffer cmd, Camera camera, bool stereoEnabled) // This variant is for if the calling SRP has additional stereo suppression logic
        {   // This method expects VRGraphicsConfig.SetConfig() to have been called prior to it.
            // Then, engine code will check if occlusion mesh rendering is enabled, and apply occlusion mesh scale.
#if UNITY_2019_1_OR_NEWER
            if ((!VRGraphicsConfig.enabled) || (!camera.stereoEnabled) || (!stereoEnabled))
                return;
            UnityEngine.RectInt normalizedCamViewport = new UnityEngine.RectInt(0, 0, camera.pixelWidth, camera.pixelHeight);
            cmd.DrawOcclusionMesh(normalizedCamViewport);
#else
            return;
#endif
        }

    }
}
