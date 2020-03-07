using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int PointsToAdd;
    public string pickuptype;
    

 void OnTriggerEnter(Collider other)
 {
     if(other.gameObject.CompareTag("Player"))
     {
        CharacterScore.AddPoints(PointsToAdd);
        Destroy(gameObject);
     }
 }
}
