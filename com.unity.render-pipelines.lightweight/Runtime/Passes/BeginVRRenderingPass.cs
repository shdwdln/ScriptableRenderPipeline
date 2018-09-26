using System;

namespace UnityEngine.Experimental.Rendering.LightweightPipeline
{
    /// <summary>
    /// Configure camera and shader keywords for stereo rendering.
    ///
    /// This pass enables VR rendering. You must also configure
    /// the VR rendering in the global VR Graphics settings.
    ///
    /// Pair this pass with the EndVRRenderingPass.  If this
    /// pass is issued without a matching EndVRRenderingPass
    /// it will lead to undefined rendering results. 
    /// </summary>
    public class BeginVRRenderingPass : ScriptableRenderPass
    {
        /// <inheritdoc/>
        public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (renderer == null)
                throw new ArgumentNullException("renderer");
            
            Camera camera = renderingData.cameraData.camera;
            context.StartMultiEye(camera);
        }
    }
}
