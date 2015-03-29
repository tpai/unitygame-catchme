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
		}
		else if(timesup == false) {
			timesup = true;
			startTime = 0;
			StartCoroutine("DelayToResult");
		}

		GetComponent<Text> ().text = "Time\n" + startTime.ToString ("f0");
	}

	IEnumerator DelayToResult () {
		yield return new WaitForSeconds(3.5f);
		PlayerPrefs.SetInt ("NowScore", Score.nowScore);
		Application.LoadLevel ("Result");
	}
}