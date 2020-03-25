
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{

    // used when you want to compare one variable to a series of constants
    // most common use is to make decisions based on enums

    public int intelligence = 5;

    void Greet()
    {
        switch(intelligence)
        {
            // return is used for functions
            // break is usually used for just switches and loops
            case 5:
                print("Good Day to you kind sir, would you like a cup of tea?");
            break;
            case 4:
                print("Hello and good day");
            break;
            case 3:
                print("hey there dude");
            break;
            case 2:
                print("whazzzup");
            break;
            case 1:
                print("uuuuhhhh...hi");
            break;
            default:
                print("Incorrect intelligence leve.");
            break;

            //the last case has to be different to end the function so we use default
            // this is for any case that hasn't already been covered, it doesn't need a value
            
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

