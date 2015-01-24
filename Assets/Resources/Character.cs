using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public float maxHealth;
	public float baseSpeed = 10;
	public float baseJumpHeight = 5;

	protected CharacterInventory _inventory = new CharacterInventory(1);

	protected Rigidbody2D _body;

	protected float _currentHealth;

	protected float _speed;
	protected float _jumpHeight;

	// Use this for initialization
	void Start () {
		_body = this.GetComponent<Rigidbody2D>();

		_currentHealth = maxHealth;

		_speed = baseSpeed;
		_jumpHeight = baseJumpHeight;
	}

	protected virtual void Update() {
		_speed = baseSpeed;
		_jumpHeight = baseJumpHeight;
	}

	public void Move(float move) {
		Vector2 newVelocity = new Vector2(move * _speed, _body.velocity.y);

		if(newVelocity.x != 0) {
			int direction = (newVelocity.x < 0) ? -1 : 1;

			Vector3 scale = transform.localScale;
		    scale.x = Mathf.Abs(scale.x) * direction;
		    transform.localScale = scale;
		}
		
	    _body.velocity = newVelocity;
	}

	public void Jump(bool jump) {
		if(jump) {
			_body.AddForce(Vector2.up * _jumpHeight, ForceMode2D.Impulse);
		}
	}

	public void Attack() {

	}

	public void Pickup(GameObject itemGameObject) {
		Item item = itemGameObject.GetComponent<Item>();
		if(item != null) {
			if(_inventory.Add(item)) {
				Destroy(itemGameObject);
			}
		}
	}

	public void Hurt(float damage) {
		_currentHealth -= damage;
	}
}
