using UnityEngine;
using System.Collections;

public class Deadpit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D target) {
		if (target.tag == "Enemy") {
			Destroy (target.gameObject);
		}
	}
}
