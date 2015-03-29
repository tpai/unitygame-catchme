using UnityEngine;
using System.Collections;

public class EnemyContacts : MonoBehaviour {

	public int score = 1;

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.collider.tag == "Player") {
			Score.AddScore(score);
			Destroy(gameObject);
		}
	}
}
