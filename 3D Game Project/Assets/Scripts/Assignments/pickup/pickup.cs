using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public int pointsToAdd;

 void OnTriggerEnter(Collider other)
 {
     if(other.gameObject.CompareTag("Player"))
     {
         scoreManager.AddPoints (pointsToAdd);
         Destroy(gameObject);
     }
 }
}
