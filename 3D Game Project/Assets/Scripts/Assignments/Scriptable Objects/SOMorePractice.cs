using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Another SO", menuName = "Second Scriptable Object / New Candy")]

public class SOMorePractice : ScriptableObject
{
    public string candyType;

    public string candyFlavor;

    public bool rating;

    private void PrintOut(string candyType, string candyFlavor, bool rating)
    {
        if(rating == true)
        {
            Debug.Log(candyFlavor + candyType + "Is really good");
        }
        else
        {
            Debug.Log(candyFlavor + candyType + "Is really bad");
        }
    }

    
    
}
