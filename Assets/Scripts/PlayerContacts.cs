using UnityEngine;
using System.Collections;

public class PlayerContacts : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) {
//		if (coll.collider.tag == "Enemy") {
//			Score.AddScore(-5);
//			Destroy (coll.collider.gameObject);
//		}
//
//		if (coll.collider.tag == "Friendly") {
//			Score.AddScore(15);
//			Destroy (coll.collider.gameObject);
//		}

		string tag = coll.collider.tag;
		if (
			tag == "Enemy" ||
			tag == "Friendly"
		) {
			switch(tag) {
				case "Enemy": Score.AddScore(-5); break;
				case "Friendly": Score.AddScore(15); break;
			}
			Destroy (coll.collider.gameObject);
		}
	}
}
