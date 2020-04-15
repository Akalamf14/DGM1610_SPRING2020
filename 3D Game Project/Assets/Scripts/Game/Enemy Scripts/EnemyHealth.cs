using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    public int points = 10;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
       // spawnPoint = gameObject.Find("SpawnPoint").transform;
       
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        
        if(currentHealth <= 0)
        {
            //keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");
            // add points to score for killing enemy
            //ScoreManager.AddPoints(points);
            //move enemy to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //reset enemy health
            currentHealth = maxHealth;

            scoreManager.AddPoints(points);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
