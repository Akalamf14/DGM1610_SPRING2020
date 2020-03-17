using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : MonoBehaviour
{
    //Recreating or Redeclaring the members of a parent class in the child class
    // is known as member hiding

    // in order to hide the member () of a base class
    // we must declare it with 

    //Base version of the Yell method

    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}
