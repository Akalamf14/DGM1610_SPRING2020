using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //access modifier (public or private) - public show up in unity whereas private does not
    //variables are containers
    //Declaration
    private int number; //whole number that is positive or negative
    public float chocolate; // can have a decimal
    public string lastName; 
    public string firstName = "Akala";
    public double rbi;
    
    public GameObject player; //green - specific to unity and is referring to object in game

    //Declaration and Initialization
    int cookie = 5; //determine how many cookies are in the "cookie Container"

    int family = 6;

    // Start is called before the first frame update
    void Start() //void (type) = doesn't return a value
    {
        Debug.Log(family * 2); //Debug.Log() print informational messages to help debug your application
        number = 15;

        
        Debug.Log("What is my name" +  firstName);

        family = multiplyByTwo(family);
        Debug.Log(family);

        lastName = "Escobar";
        //function Call
        CheckScore();
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

    void CheckScore()
    {
        print("Hello World!");

    }
}

//fixed update - irregular (physics) and/or (animation)
//Late update - end at every cycle
// update is based on CPU