using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	float Duration;

	//Spawn points
	public Transform[] spawn;
	//spawn timer
	public float spawnTime;
	//the enmy
	public GameObject enemy;


	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void spawner()
	{
		int spawnPointIndex = Random.Range(0, spawn.Length);
		Instantiate(enemy, spawn[spawnPointIndex].position, spawn[spawnPointIndex].rotation);
	}
}
