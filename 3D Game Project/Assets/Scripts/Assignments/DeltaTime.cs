using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    //DeltaTime is a difference between two values
    //Is used to smooth out values and make movement smoother
    // Start is called before the first frame update
    
    public float speed = 8f;
    public float countdown = 3.0f;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
        {
            GetComponent<Light>().enabled = true;
        }
        if(Input.GetKey(KeyCode.RightControl))
        {
            transform.position -= new Vector3(speed* Time.deltaTime, 0.0f, 0.0f);
        }
        //deltaTime gives us the change in values per second instead of per frame
        //each frame can last different amounts of time which makes movement less smooth
    }
}
