using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefab;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown <= 0f) {
			Spawnwave ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	void Spawnwave(){
		Debug.Log ("Wave incoming!");
	}
}
