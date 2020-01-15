using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //variables are containers
    //Declaration
    int number;
    //Declaration and Initialization
    int cookie = 5; //determine how many cookies are in the "cookie Container"

    int family = 6;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(family * 2); //Debug.Log() just shows numbers in game.
        number = 15;

        family = multiplyByTwo(family);
        Debug.Log(family);
    }

    int multiplyByTwo(int number) //int number is just saying we have some number which we can put any interger in for that
    {
        int result;
        result = number * 5;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
