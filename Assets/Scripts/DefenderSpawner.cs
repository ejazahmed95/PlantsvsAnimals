using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	// config
	Defender defenderPrefab;

	private void OnMouseDown() {
		if (!defenderPrefab) return;
		SpawnDefender(GetMousePosition());
	}

	private Vector2 GetMousePosition() {
		Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
		Vector2 gridPos = SnapToGrid(worldPos);
		return gridPos;
	}

	private Vector2 SnapToGrid(Vector2 worldPos) {
		float newX = Mathf.RoundToInt(worldPos.x);
		float newY = Mathf.RoundToInt(worldPos.y);
		return new Vector2(newX, newY);
	}

	private void SpawnDefender(Vector2 roundedPos) {
		Defender defender = Instantiate(defenderPrefab, roundedPos, Quaternion.identity) as Defender;
	}

	public void SetDefender(Defender defender) {
		defenderPrefab = defender;
	}
}
