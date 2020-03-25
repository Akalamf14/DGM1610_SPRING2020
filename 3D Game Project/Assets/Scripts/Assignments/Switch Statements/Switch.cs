using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //switches are used when there a lot of options
    // mpc shop - with lots of items to buy
    // use types ex: different types of potions you could buy

    public string favHero;

    public int smarts;
    // Start is called before the first frame update
    void Start()
    {
        //switch as an if conditional
        switch(favHero)
        {
            case "Superman":
            print("wrong!");
            break;

            case "Thor":
            print("correct!");
            break;

            case "Batman":
            print("Correct!");
            break;

            default:
            print("ERROR");
            break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(smarts)
        {
            case 1:
            print("You're dumb");
            break;
            
            case 5:
            print("You're smart");
            break;

            default:
            print("derp!");
            break;

        }
    }
}
