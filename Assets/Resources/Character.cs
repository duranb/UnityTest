using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour, ICharacter {
	public int _speed = 10;
	public int _jump_height = 5;

	private Rigidbody2D _hero_body;

	public int speed {
		get { return _speed; }
		set { _speed = value; }
	}

	public int jump_height {
		get { return _jump_height; }
		set { _jump_height = value; }
	}

	// Use this for initialization
	void Start () {
		_hero_body = this.GetComponent<Rigidbody2D>();
	}
	
	void Update() {
		Attack();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Move();
		Jump();
	}

	public void Move() {
		float move = Input.GetAxis("Horizontal");

		_hero_body.velocity = new Vector2(move * _speed, _hero_body.velocity.y);
	}

	public void Jump() {
		if(Input.GetKeyDown("space")) {
			_hero_body.AddForce(Vector2.up * jump_height, ForceMode2D.Impulse);
		}

	}

	public void Attack() {

	}

	public void Pickup() {

	}
}
