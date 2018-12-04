using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	[SerializeField] float cost = 50f;

	public float GetCost() {
		return cost;
	}
}
