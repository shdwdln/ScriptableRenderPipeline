namespace UnityEngine.Experimental.Rendering.LightweightPipeline
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Light))]
    public class LightweightRPLightOverrides : MonoBehaviour
    {
        [Tooltip("Controls the distance at which the shadows will be pushed away from the light. Useful for avoiding false self-shadowing artifacts.")]
        [SerializeField] float m_DepthBias = 1.0f;

        [Tooltip("Controls distance at which the shadow casting surfaces will be shrunk along the surface normal. Useful for avoiding false self-shadowing artifacts.")]
        [SerializeField] float m_NormalBias = 1.0f;
        public float depthBias
        {
            get { return m_DepthBias; }
            set { m_DepthBias = value; }
        }

        public float normalBias
        {
            get { return m_NormalBias; }
            set { m_NormalBias = value; }
        }
    }
}
