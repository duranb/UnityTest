using UnityEngine;
using System.Collections;

public interface ICharacter {
	void Move();
	void Jump();
	void Attack();
	void Pickup();
}