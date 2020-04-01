using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int PointsToAdd;
    //public string pickuptype;
    

 void OnTriggerEnter(Collider other)
 {
     if(other.gameObject.CompareTag("Player"))
     {
        scoreManager.AddPoints(PointsToAdd);
        Destroy(gameObject);
     }
 }

 // compareTag is good to add for various players or various enemy that all have the same tag
 //compareTag looks for the tag given to each player or object
 // find is good for individual player or specific objects - looks for the name of your character or game object
 // with find make sure spelling is exactly the same with the same capitalization as well

}
