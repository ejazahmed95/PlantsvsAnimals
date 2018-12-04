using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Config
	[Range(0f, 5f)] [SerializeField] float walkSpeed = 2f;

	// state
	float currentSpeed = 0f;
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += Vector3.left * currentSpeed * Time.deltaTime;
	}

	public void StartWalking() {
		currentSpeed = walkSpeed;
	}
}
