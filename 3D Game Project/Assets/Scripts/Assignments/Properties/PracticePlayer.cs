using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticePlayer
{
    //properties act like variables and encapsulate member variables which we can also call fields.
    // this encapsulation gives us a greater amount of control over when and how a field is accessed

    
    private int experience; // experience is the field found in the class PracticePlayer
    //we want a way for code existing outside of the class to access this.

    // 1. specify the access modifier, the type, and the name of the property
    public int Experience
    {
        // good rule of thumb is to name the property the same as the field EXCEPT STARTING WITH A CAPITOL LETTER
    
        // a property can have 2 accessors "get" and "set"
        // these are the funtions that are called when a property is referenced and allocated to, respectively

        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }

        //there are two things that you can do with properties that you can't do with the public access modifier
        // you can make it only read or write
        // accessors (get and set) can be used just like functions meaning you can run other lines of code or put calls to other functions inside them

    }

    public int Level
    {
        // Level is a property that converts experience points into the level of a player automatically
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //this is an example of an auto-implemented property
    public int Health{ get; set; }
}
