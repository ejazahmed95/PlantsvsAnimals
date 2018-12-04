using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour {

	// config
	[SerializeField] int initialStars = 100;

	// reference
	Text starText;

	// state
	int currentStars;

	// Use this for initialization
	void Start () {
		currentStars = initialStars;
		starText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		starText.text = currentStars.ToString();
	}

	public void AddStars(int amount) {
		currentStars += amount;
	}

	public void SpendStars(int amount) {
		if(currentStars >= amount) {
			currentStars -= amount;
		}
	}
}
