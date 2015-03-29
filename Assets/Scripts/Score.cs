using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public static int nowScore = 0;

	void Update () {
		GetComponent<Text> ().text = "Score: " + nowScore.ToString ();
	}

	public static void AddScore (int amt) {
		nowScore += amt;
	}
}
