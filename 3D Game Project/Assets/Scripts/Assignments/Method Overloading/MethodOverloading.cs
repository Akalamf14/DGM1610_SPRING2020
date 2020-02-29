using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloading : MonoBehaviour
{
    //overloading is a process where you can give a single method multiple definitions
    // you can use the same method name to do two different things

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
    // Start is called before the first frame update
    void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(1,2);
        myClass.Add("Hello " + "World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
