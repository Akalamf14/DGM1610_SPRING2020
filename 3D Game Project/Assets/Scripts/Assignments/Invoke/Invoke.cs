using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    //the Invoke functions enable you to schedule a function call after some specified time delay
    // This allows us to build a useful method-call system, that is time sensitive

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2); // the invoke function takes 2 parameters
        //1. a string containing the name of the method we wish to call
        //2. an amount of time to delay in seconds

        //Invoke only works with methods with no parameters and have void in front
    }

    void SpawnObject() // this method or function is only meant to instantiate the GameObject at the location 0,2,0
    {
        Instantiate(target, new Vector3(0,2,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
