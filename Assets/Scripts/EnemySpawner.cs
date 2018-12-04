using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	// config
	[SerializeField] float minDelayToSpawn = 1f;
	[SerializeField] float maxDelayToSpawn = 5f;
	[SerializeField] Enemy enemyPrefab;

	// state
	bool spawn = true;

	// Use this for initialization
	IEnumerator Start () {
		while(spawn) {
			yield return new WaitForSeconds(UnityEngine.Random.Range(minDelayToSpawn, maxDelayToSpawn));
			SpawnEnemy();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnEnemy() {
		Instantiate(enemyPrefab, transform.position, transform.rotation);
	}
}
