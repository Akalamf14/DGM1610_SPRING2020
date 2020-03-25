using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    // enums are customizable types
    //defining a type and a subset within that type.
    // enums is the type
    // Days is the title of the enumeration

    enum Days{sun, mon, tues, wed, thurs, fri, sat};
    // defalt sun = 0, mon = 1, tues = 2, etc
    // can change each to personal number
    // sun = 10, mon = 145, etc

    Days currentDay;


    // Start is called before the first frame update
    void Start()
    {
        currentDay = Days.sun;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(currentDay == Days.mon)
        {
            print("go back to bed.");
        }
    }
}
