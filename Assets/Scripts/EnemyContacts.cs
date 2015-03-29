using UnityEngine;
using System.Collections;

public class EnemyContacts : MonoBehaviour {

	public int score = 1;

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.collider.tag == "Player") {
			GetComponent<AudioSource>().Play ();
			GetComponent<BoxCollider2D>().enabled = false;
			transform.Find("Animation").gameObject.SetActive(false);
			Score.AddScore(score);
			StartCoroutine("DelayToDestroy");
		}
	}

	IEnumerator DelayToDestroy () {
		yield return new WaitForSeconds (.5f);
		Destroy(gameObject);
	}
}
