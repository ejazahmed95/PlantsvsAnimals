﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {

	[SerializeField] int timeToWait = 3;
	int currentSceneIndex;

	// Use this for initialization
	void Start () {
		currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		if (currentSceneIndex == 0) {
			StartCoroutine(WaitForTime());
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitForTime() {
		yield return new WaitForSeconds(timeToWait);
		LoadNextScene();
	}

	public void LoadNextScene() {
		SceneManager.LoadScene(currentSceneIndex + 1);
	}
}
