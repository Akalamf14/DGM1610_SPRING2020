﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
     public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target); // this is for when we want the camera to look at a specific gameobject 
        // faces whichever game object entered in the inspector
    }
}
