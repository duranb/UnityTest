using UnityEngine;
using System.Collections;

public class Hero : Character {
	// Use this for initialization

	void Update() {
		Attack();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Move(Input.GetAxis("Horizontal"));
		Jump(Input.GetKeyDown("space"));
	}
}
