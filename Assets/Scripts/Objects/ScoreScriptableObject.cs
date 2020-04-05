using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Objects
{ 
    public class ScoreScriptableObject : ScriptableObject
    {
        [SerializeField] private string _bestPlayer;
        [SerializeField] private int _bestScore;
        
        [SerializeField] private int _currentScore;
        
        public int Value
        {
            get => _currentScore;

            set
            {
                _currentScore = value;
                Update();
            }
        }
        public event Action<int> UpdateScore;

        public void Update()
        {
            UpdateScore?.Invoke(_currentScore);        
        }
        
        public void TrySaveBest(string nickname)
        {
            if (_currentScore > _bestScore)
            {
                _bestScore = _currentScore;
                _bestPlayer = nickname;
            }
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