using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple1 myApple = new Apple1();

        //The apple version of the methods override the fruit versions.
        // Since the apple versions call the fruit version with the 'base' keyword, both are called

        myApple.SayHello();
        myApple.Chop();

        //since the methods of the fruit class are virtual and the methods of the apple class are override
        //when we upcast an apple into a fruit, the apple version of the methods are used

        Fruit1 myFruit = new Apple1();
        myFruit.SayHello();
        myFruit.Chop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
