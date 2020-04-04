using System;
using UnityEngine;
using  System.Collections;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
	[SerializeField] private GameObject _prefab;
	
	[SerializeField] private float _spawnInterval;

	[SerializeField] private float _fromPosition;
	[SerializeField] private float _toPosition;

	private float _timer;
	
	public void StopSpawn()
	{
		enabled = false;
	}

	private void Update()
	{
		_timer -= Time.fixedDeltaTime;

		if (_timer > 0)
			return;

		_timer += _spawnInterval;
		var position = transform.position;
		position.x += Random.Range(_fromPosition, _toPosition);
		Instantiate(_prefab, position, Quaternion.identity);
	}
}
