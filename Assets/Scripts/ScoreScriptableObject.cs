using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScoreScriptableObject : ScriptableObject
{
    [SerializeField] private int _count;
    [SerializeField] private bool _resetOnNewGame = true;
    public int Count => _count;

    public event Action<int> UpdateScore;
    
    private void OnEnable()
    {
        if (_resetOnNewGame)
        {
            _count = 0;
        }
        UpdateScore?.Invoke(_count);
    }

    public void AddValue(int count)
    {
        _count += count;
        UpdateScore?.Invoke(_count);
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
