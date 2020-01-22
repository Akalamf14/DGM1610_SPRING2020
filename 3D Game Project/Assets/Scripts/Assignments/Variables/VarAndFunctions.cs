using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarAndFunctions : MonoBehaviour
{
    int watermelons = 25;
    

    // Start is called before the first frame update
    void Start()
    { 
        watermelons = multiplyByFive(watermelons);
        Debug.Log(watermelons);
    }

    int multiplyByFive(int number)
    {
        int fruit;
        fruit = number * 5;
        return fruit; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
