using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public float hotCocoTemp = 85.0f;
    float hotLimitTemp = 70.0f;
    float coldLimitTemp = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if statements are for the code to make a decision based on a situation
        if (Input.GetKeyDown(KeyCode.Space))
        TempuratureTest();

        hotCocoTemp -= Time.deltaTime * 5f;
    }

    void TempuratureTest()
    {
        if (hotCocoTemp > hotLimitTemp) // we wont drink hot coco if its too hot
        {
            print("Hot Coco is too hot.");
        }
        else if (hotCocoTemp < coldLimitTemp) // the coco can also get too cold so else if is used as another possilbe answer
        {
            print("Hot Coco is too cold.");
        }
        else // is used when neither option is correct above, last option.
        {
            print("Hot Coco is just right");
        }

    }
}
