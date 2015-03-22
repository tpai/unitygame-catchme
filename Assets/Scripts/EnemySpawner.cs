using UnityEngine;
using System.Collections;

public class EnemySpawner: MonoBehaviour {
	
	public GameObject prefab;
	
	void Start() {
		InvokeRepeating ("SpawnEnemy", .1f, 1f);
	}
	
	void SpawnEnemy() {
		GameObject obj = (GameObject) Instantiate(prefab);
		obj.name = "Enemy";
		obj.transform.position = new Vector2 (
			Random.Range (-22f, 22f),
			17f
		);
	}
}