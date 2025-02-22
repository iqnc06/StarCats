using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField]
	public GameObject FleasPrefab;

	[SerializeField]
	public float swarmerInterval = 3.5f;

	void Start()
	{
		StartCoroutine(spawnEnemy(swarmerInterval, FleasPrefab));
	}

	private IEnumerator spawnEnemy(float interval, GameObject enemy)
	{
		yield return new WaitForSeconds(interval);
		//GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0, Quaternion.identity));
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0f);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
		StartCoroutine(spawnEnemy(interval, enemy));
    
	}
}


