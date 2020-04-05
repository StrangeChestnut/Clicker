using System;
using UnityEngine;
using UnityEditor;

namespace Objects
{ 
    public class ScoreScriptableObject : ScriptableObject
    {
        private int _value;
        public int Value
        {
            get => _value;

            set
            {
                _value = value;
                Update();
            }
        }
        public event Action<int> UpdateScore;
        
        public void Update()
        {
            UpdateScore?.Invoke(_value);        
        }
        

#if UNITY_EDITOR
    [MenuItem("Assets/Create/Score")]
    public static void CreateMyAsset()
    {
        ScoreScriptableObject asset = CreateInstance<ScoreScriptableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/Score.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
    }
}