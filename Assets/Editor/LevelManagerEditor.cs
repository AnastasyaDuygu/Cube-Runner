#if  UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace adk
{
    [CustomEditor(typeof(LevelManager))]
    public class LevelManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            LevelManager myScript = (LevelManager)target;
            if (GUILayout.Button("Load Next level"))
            {
                myScript.LoadNextLevel();
            }
        }
    }
}
#endif
