using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTwo : MonoBehaviour
{
    public string animals;

    // Start is called before the first frame update
    void Start()
    {
        switch(animals)
        {
            case "horse":
            print("Mammal");
            break;

            case "beetle":
            print("insect");
            break;

            case "frog":
            print("amphibian");
            break;

            case "cat":
            print("mammal");
            break;

            case "lizard":
            print("reptile");
            break;

            case "canary":
            print("bird");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
