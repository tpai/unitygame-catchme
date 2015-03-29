using UnityEngine;
using System.Collections;

public class Leaderboard : MonoBehaviour {

	int nowScore;
	int[] scoreList;

	void Start () {
		// define
		scoreList = new int[4];
		nowScore = PlayerPrefs.GetInt ("NowScore");

		// top3 insert into array
		for (int i=1; i<=3; i++) {
			int score = PlayerPrefs.GetInt("NO"+i);
			scoreList[i-1] = score;
		}
		// nowscore insert into array
		scoreList [3] = nowScore;

		// sort and reverse
		System.Array.Sort (scoreList);
		System.Array.Reverse (scoreList);

		// write back to playerprefs
		for (int i=1; i<4; i++) {
			PlayerPrefs.SetInt("NO"+i, scoreList[i-1]);
		}

		// print
		for (int i=1; i<4; i++) {
			Debug.Log (PlayerPrefs.GetInt("NO"+i));
		}
	}

	void Update () {
	
	}
}
