using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 0f;
	public float upBorder, downBorder, leftBorder, rightBorder;
	float x, y;

	void Start () {
		x = 0;
		y = 0;
	}

	void Update () {
		// catch input key
		if(Input.GetKey(KeyCode.UpArrow)) {
			y += speed;
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			y -= speed;
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {
			x -= speed;
			transform.localScale = new Vector2(-1, 1);
		}
		if(Input.GetKey(KeyCode.RightArrow)) {
			x += speed;
			transform.localScale = new Vector2(1, 1);
		}

		x = Mathf.Clamp (x, leftBorder, rightBorder);
		y = Mathf.Clamp (y, downBorder, upBorder);

		transform.position = new Vector2(x, y);
	}
}
