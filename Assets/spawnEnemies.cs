using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class spawnEnemies : MonoBehaviour {

    public GameObject enemy;
    public float spawnInterval;
    float spawnTimer;
    public float minRange;
    public float maxRange;
    public int spawnCount;
    // Use this for initialization
    void Start ()
    {
		
	}
	

    void spawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(enemy);
        float randoRange = Random.Range(minRange, maxRange);
        Vector2 spawnDir = Random.insideUnitSphere;
        Vector3 spawnPos = new Vector3(spawnDir.x,0, spawnDir.y) * randoRange;
        spawnedEnemy.GetComponent<NavMeshAgent>().Warp(transform.position + spawnPos);
        spawnedEnemy.GetComponent<Crawler>().player = gameObject;
    }

	// Update is called once per frame
	void Update ()
    {
		if(spawnTimer <= 0)
        {
            for(int i =0; i < spawnCount; i++)
            {
                spawnEnemy();
            }
            spawnTimer = spawnInterval;
        }
        spawnTimer -= Time.deltaTime;
	}
}
