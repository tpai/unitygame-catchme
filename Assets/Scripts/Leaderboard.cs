using UnityEngine;
using System.Collections;

public class Leaderboard : MonoBehaviour {

	int nowScore;

	void Start () {
		nowScore = PlayerPrefs.GetInt ("NowScore");
		Debug.Log (nowScore);
	}

	void Update () {
	
	}
}
