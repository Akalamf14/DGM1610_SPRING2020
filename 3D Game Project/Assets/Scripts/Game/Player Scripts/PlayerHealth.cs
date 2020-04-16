using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public const int maxHealth = 5;
    public Transform spawnPoint;
    public int points = 1;

    public Text hp;
    public Text maxHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnPoint").transform;

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            print("Game Over");

            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;

            currentHealth = maxHealth;
        }
    }
    // Update is called once per frame
    void Update()
    {
        hp.text = currentHealth.ToString();
        maxHP.text = maxHealth.ToString();
    }
}
