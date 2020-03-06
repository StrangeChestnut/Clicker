using System;
using UnityEngine;
using  System.Collections;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
	public GameObject Prefab;
	public float Interval;

	public float From;
	public float To;

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

		_timer += Interval;
		var position = transform.position;
		position.x += Random.Range(From, To);
		Instantiate(Prefab, position, Quaternion.identity);
	}
}
