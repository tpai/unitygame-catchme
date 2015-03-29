using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public static bool timesup = false;
	public float startTime = 30f;

	void Start () {
		timesup = false;
	}

	void Update () {

		if (startTime > 0) {
			startTime -= Time.deltaTime;
		} else {
			timesup = true;
			startTime = 0;
		}
		GetComponent<Text> ().text = "Time\n" + startTime.ToString ("f0");
	}
}