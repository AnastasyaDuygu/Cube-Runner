using UnityEditor;
using UnityEngine;

namespace adk
{
    [CustomEditor(typeof(CoinBoxManager))]
    public class CoinScriptEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            CoinBoxManager myScript = (CoinBoxManager)target;
            if (GUILayout.Button("Reset Coin"))
            {
                myScript.ResetCoin();
            }
        }
    }
}

