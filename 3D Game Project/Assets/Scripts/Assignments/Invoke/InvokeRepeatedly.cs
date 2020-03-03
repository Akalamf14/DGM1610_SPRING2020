/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatedly : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        //1.String with name of method
        //2. delay in seconds before it calls the method
        //3. delay in seconds between each subsequent call of the method

        CancelInvoke("SpawnObject");
        //in order to stop all instances of an Invoke call from this script we can use the cancel invoke method
        //if we only wish to stop a specific Invoke, we can pass in a string containing the name of the method we wish to stop
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
       Instantiate(target, new Vector3(x,2,z), Quaternion.identity);

        //function still instantiates the object, but now with a random location for x and z
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
