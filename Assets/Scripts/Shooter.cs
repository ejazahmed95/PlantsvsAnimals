using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	// config
	[SerializeField] GameObject projectilePrefab;
	[SerializeField] GameObject firePosition;

	public void Fire() {
		GameObject projectile = Instantiate(projectilePrefab, firePosition.transform.position, firePosition.transform.rotation);
	}
}
