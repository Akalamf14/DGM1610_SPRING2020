using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] enemyPrefab;
    public int enemyIndex;

    public int enemiesToSpawn;

    // Start is called before the first frame update
    void Start()
    {
       //InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

       SpawnEnemyWave(); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        int enemyIndex = Random.Range(0, enemyPrefab.Length);

        
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(enemyPrefab[enemyIndex], new Vector3(0,14,0), enemyPrefab[enemyIndex].transform.rotation);

        }
        */

    }

    void SpawnEnemyWave()
    {
        for( int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab[enemyIndex], transform.position, enemyPrefab[enemyIndex].transform.rotation);
        }

    }
}
