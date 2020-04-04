using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : ScriptableObject
{
    [SerializeField] private int _count;
    [SerializeField] private bool _resetOnNewGame = true;
    public int Count => _count;

    public event Action<int> UpdateScore;
    public event Action GameOver;

    public void StartGame()
    {
        if (_resetOnNewGame)
        {
            _count = 0;
        }
        UpdateScore?.Invoke(_count);
    }
    
    public void StopGame()
    {
        GameOver?.Invoke();
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
        GameController asset = CreateInstance<GameController>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/Score.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
