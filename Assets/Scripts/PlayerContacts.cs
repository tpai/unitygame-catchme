using UnityEngine;
using System.Collections;

public class PlayerContacts : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.collider.tag == "Enemy") {
			Destroy (coll.collider.gameObject);
		}
	}
}
