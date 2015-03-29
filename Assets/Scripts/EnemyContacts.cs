using UnityEngine;
using System.Collections;

public class EnemyContacts : MonoBehaviour {

	public int amt = 1;

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.collider.tag == "Player") {
			Score.AddScore(amt);
			Destroy(gameObject);
		}
	}
}
