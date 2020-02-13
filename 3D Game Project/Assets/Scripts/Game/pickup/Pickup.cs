using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int pointsToAdd;
    public string pickuptype;
    

 void OnTriggerEnter(Collider other)
 {
     if(other.gameObject.CompareTag("Player"))
     {
         scoreManager.AddPoints (pointsToAdd);
         Destroy(gameObject);
     }
 }
}
