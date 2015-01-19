using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int _speed = 10;
	public int _jump_height = 5;

	private Rigidbody2D _body;

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
		_body = this.GetComponent<Rigidbody2D>();
	}

	public void Move(float move) {
		_body.velocity = new Vector2(move * _speed, _body.velocity.y);
	}

	public void Jump(bool jump) {
		if(jump) {
			_body.AddForce(Vector2.up * jump_height, ForceMode2D.Impulse);
		}
	}

	public void Attack() {

	}

	public void Pickup() {

	}
}
