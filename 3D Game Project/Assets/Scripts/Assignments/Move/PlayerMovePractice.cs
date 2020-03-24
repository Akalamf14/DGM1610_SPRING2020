using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePractice : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //Transform.position = new Vector3(0,0,0);
        // we can make position x, y, or z
        // Transform.rotation
        // Transform.scale
        
        transform.position = startPosition;
        startPosition = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
