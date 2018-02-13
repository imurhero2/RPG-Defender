using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefab;

    public Transform spawnPoint;

    public float enemySpawnRate = 0.5f;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

    private int waveIndex = 0;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown <= 0f) {
            StartCoroutine(Spawnwave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	IEnumerator Spawnwave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(enemySpawnRate);
        }
		Debug.Log ("Wave incoming!");
	}

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
