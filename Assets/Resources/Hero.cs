using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hero : Character {
	// Use this for initialization

	protected override void Update() {
		base.Update();
		List<AttributeModifier> modifiers = _inventory.modifiers;

		_inventory.BurnDownModifiers(Time.deltaTime);

		foreach(AttributeModifier modifier in modifiers) {
			switch(modifier.modifierType) {
				case AttributeModifierTypes.Speed:
					this._speed = this.baseSpeed * modifier.value;
					break;
				case AttributeModifierTypes.Jump:
					this._jumpHeight = this.baseJumpHeight * modifier.value;
					break;
			}
		}

		Attack();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Move(Input.GetAxis("Horizontal"));
		Jump(Input.GetKeyDown("space"));
	}

	void OnCollisionEnter2D(Collision2D collision) {
		this.Pickup(collision.gameObject);
	}
}