using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    public int ammoAmt;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           // ammoManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
    }
}
