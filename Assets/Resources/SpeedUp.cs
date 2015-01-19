using UnityEngine;
using System.Collections;

public class SpeedUp : MonoBehaviour {
	private Item _item;

	private Rigidbody2D _speedup_body;



	// Use this for initialization
	void Start () {
		_speedup_body = this.GetComponent<Rigidbody2D>();

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
