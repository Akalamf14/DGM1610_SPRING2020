using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.1f);
    }
    // Detect collision with another object
    void OnCollisionEnter(Collision other)
    {
        //without colliders the objects would just pass through
        // collide box


    }
        // other can be used in both instances because they are both contained to their respective function
        // trigger is essentially a collider that can be used as a trigger
        //OnTriggerStay and OnTriggerExit also exist
    void OnTriggerEnter(Collider other)
    {

    }



}
