using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	// config
	[SerializeField] float speed = 4f;
	[SerializeField] int damage = 10;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D otherCollider) {
		if (otherCollider.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
			var health = otherCollider.GetComponent<Health>();
			if(health) {
				health.DealDamage(damage);
				Destroy(gameObject);
			}
		}
	}
}
