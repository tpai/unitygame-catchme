using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed = -.5f;
	float y = 0f;

	void Start () {
		// rigidbody2D
		// GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speed);
		y = transform.position.y;
	}
	
	void Update () {
		y += speed;
		transform.position = new Vector2 (transform.position.x, y);
	}
}
