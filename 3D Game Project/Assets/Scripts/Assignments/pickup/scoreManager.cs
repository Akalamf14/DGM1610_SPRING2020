using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public static int score;
    // static means we cannot alter the variable, we cant create an instance of this variable


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game Score;" + score);
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        
    }
}
