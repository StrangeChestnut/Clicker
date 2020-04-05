using System;
using UnityEngine;
using  System.Collections;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
	[SerializeField] private GameController _game;
	[SerializeField] private GameObject _prefab;
	
	[SerializeField] private float _spawnInterval;

	[SerializeField] private float _fromPosition;
	[SerializeField] private float _toPosition;

	private IEnumerator _spawner;
	
	public void Awake()
	{
		_game.StartEvent += OnStartGame;
		_game.StopEvent += OnStopGame;
	}

	private void OnStartGame()
	{
		_spawner = SpawnCoroutine();
		StartCoroutine(_spawner);
	}
	
	private void OnStopGame()
	{
		StopCoroutine(_spawner);
		_spawner = null;
	}

	private void Spawn()
	{
		var position = transform.position;
		position.x += Random.Range(_fromPosition, _toPosition);
		Instantiate(_prefab, position, Quaternion.identity);
	}

	IEnumerator SpawnCoroutine()
	{
		for (float timer = 0; timer < _game.Duration; timer += _spawnInterval)
		{
			Spawn();
			yield return new WaitForSeconds(_spawnInterval);
		}
	}
}
