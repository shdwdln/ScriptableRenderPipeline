using UnityEditor;

namespace UnityEngine.Experimental.Rendering
{
    [CustomPropertyDrawer(typeof(VRGraphicsConfig))]
    public class VRGraphicsConfigDrawer : PropertyDrawer
    {
        internal class Styles
        {
            public static GUIContent XRSettingsLabel = new GUIContent("VR Config", "Enable VR in Player Settings. Then SetConfig can be used to set this configuration to XRSettings.");
            public static GUIContent useOcclusionMeshLabel = new GUIContent("Use Occlusion Mesh", "Determines whether or not to draw the occlusion mesh (goggles-shaped overlay) when rendering");
            public static GUIContent occlusionScaleLabel = new GUIContent("Occlusion Mesh Scale", "Scales the occlusion mesh");

        }
        // Draw the property inside the given rect
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var drawUseOcclusionMesh = property.FindPropertyRelative("useOcclusionMesh");
            var drawOcclusionMaskScale = property.FindPropertyRelative("occlusionMaskScale");

            EditorGUI.BeginDisabledGroup(!VRGraphicsConfig.tryEnable);
            EditorGUILayout.LabelField(Styles.XRSettingsLabel, EditorStyles.boldLabel);
            EditorGUI.indentLevel++;
            EditorGUILayout.PropertyField(drawUseOcclusionMesh, Styles.useOcclusionMeshLabel);
            EditorGUILayout.PropertyField(drawOcclusionMaskScale, Styles.occlusionScaleLabel);
            EditorGUI.indentLevel--;
            EditorGUILayout.Space();
            EditorGUI.EndDisabledGroup();
        }
    }
}
