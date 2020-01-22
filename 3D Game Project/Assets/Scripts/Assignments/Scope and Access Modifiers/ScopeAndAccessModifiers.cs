using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //scope refers to the visibility of variables and functions

    // access modifier is placed before a variable. 
    // determines where a variable or function can be seen.
    // if variable is public that means it can be accessed outside of the class
    // and can be seen and edited in the inspector in Unity

    public int alpha = 5; // when varialbe is given a value here it can be overridden in the inspector
        // public also means you can access variables and functions from other scripts

    private int beta = 0;
    private int gamma = 5;

    // private variables can only be edited within the class
    // variables that aren't given an access modifier are automatically private

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha =29; // when a variable is given a value in a function it cannot be overridden
        // if the game is running and you change the value in the inspector it will override the script but once gameplay is over it'll be reset and not saved


        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    // with the script AnotherClass we can only access the parts that are set as public

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to:" + alpha);
        
    }
}
