using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	// config
	[SerializeField] int health = 100;
	[SerializeField] GameObject deathVFX;

	public void DealDamage(int damage) {
		if (health <= 0) return;
		health -= damage;
		if(health <= 0) {
			PlayDeathVFX();
			Destroy(gameObject);
		}
	}

	private void PlayDeathVFX() {
		if (!deathVFX) return;
		GameObject deathVFXObj = Instantiate(deathVFX, transform.position, transform.rotation);
		Destroy(deathVFXObj, 2f);
	}
}
