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
			tag == "Friendly1" ||
			tag == "Friendly2"
		) {
			switch(tag) {
				case "Enemy": Score.AddScore(-25); break;
				case "Friendly1": Score.AddScore(15); break;
				case "Friendly2": Score.AddScore(30); break;
			}
			Destroy (coll.collider.gameObject);
		}
	}
}
