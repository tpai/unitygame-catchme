using UnityEngine;
using System.Collections;

public class EnemySpawner: MonoBehaviour {
	
	public GameObject[] prefab;

	void Start() {
		InvokeRepeating ("SpawnEnemy", .1f, .5f);
	}

	void Stop () {
		CancelInvoke ("SpawnEnemy");
	}
	
	void SpawnEnemy() {

		if (Timer.timesup == true) {
			Stop ();
		}

		GameObject obj = (GameObject) Instantiate(prefab[Random.Range (0, prefab.Length)]);
		obj.name = "Enemy";
		obj.transform.position = new Vector2 (
			Random.Range (-22f, 22f),
			17f
		);
		int face = Random.Range (0, 2); // 0, 1
		if (face == 0) {
			face = -1;
		}
		else if (face == 1) {
			face = 1;
		}

		obj.transform.localScale = new Vector2 (face, 1);

		Quaternion rot = Quaternion.identity; // (0, 0, 0)
		rot.eulerAngles = new Vector3 (0, 0, Random.Range (-45, 45));
		obj.transform.rotation = rot;
	}
}