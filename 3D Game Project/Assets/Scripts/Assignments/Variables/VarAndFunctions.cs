/*
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
        //used for regular updates as:
        // moving non-physics objects
        //simple timers
        // recieving input
        // intervals are not always consistent - can have different times between calls
    
        Debug.Log("Update time :" + Time.deltaTime);
    
    }


    void FixedUpdate()
    {
        // called every physics step
        // FixedUpdate intervals are consistent - same time between calls
        // used for regular updates such as:
        // adjusting physics (rigidbody) objects

        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    
    }

    
}
*/