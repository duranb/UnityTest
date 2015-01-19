using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {
	private Item _item;

	private Rigidbody2D _powerup_body;

	// Use this for initialization
	void Start () {
		_powerup_body = this.GetComponent<Rigidbody2D>();

		_item = new Item(ItemTypes.PowerUp, "speed");
	}
	
	void Update() {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		//if(collision.Collision2D.collider) {
			Debug.Log(collision);
		//}
	}
}
