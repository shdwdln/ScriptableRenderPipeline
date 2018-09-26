using System;

namespace UnityEngine.Experimental.Rendering.LightweightPipeline
{
    /// <summary>
    /// End VR rendering
    ///
    /// This pass disables VR rendering. Pair this pass with the BeginVRRenderingPass.
    /// If this pass is issued without a matching BeginVRRenderingPass it will lead to
    /// undefined rendering results. 
    /// </summary>
    public class EndVRRenderingPass : ScriptableRenderPass
    {
        /// <inheritdoc/>
        public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (renderer == null)
                throw new ArgumentNullException("renderer");
            
            Camera camera = renderingData.cameraData.camera;
            context.StopMultiEye(camera);
            context.StereoEndRender(camera);
        }
    }
}
