using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    // the class that you are inheriting from is called the parent
    // the class that is inheriting is called the child
    // the child will inherit everything from its parent class
    // funtions and variables in the child class can be used as if it was the parent class

    // there are 3 access modifiers used -- Public, Private, and Protected
    // variables that are public exist AND are available in the child class
    //variables that are private ONLY exist and are not available in the child class
    // protected is a hybrid between public and private
    // protected will exist and be available in the parent and child class, but will not be accesible outside of the parent or child classes.



    public string color;

    public Fruit()
    {
        color = "Orange";
        Debug.Log("1st Fruuit Contructor Called");
    }

    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + "Fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }


}
