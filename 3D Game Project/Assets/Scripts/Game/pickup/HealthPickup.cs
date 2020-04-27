using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{   
    public int healthAmt = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.AddPoints(healthAmt);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        print("You Gained " + healthAmt + " Health!");
    }
}
