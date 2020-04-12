using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SO", menuName = "Scriptable Object / New Object")]

  
public class SO : ScriptableObject // manage data
// Sriptable objects are like containers to hold data
// its not a game object that is used in the scene
{
   
    public new string name;

    
    public string description;

    
    public GameObject model;

    
    public Color color;

    // scriptable objects do not use monobehavior callbacks suck as start() and update()

    //scriptable objects can also contain function and conditionals.

    /*private void PrintOut(string name, string description)
    {
        Debug.Log(name + " " + description);

        if()
    }

    */



}
