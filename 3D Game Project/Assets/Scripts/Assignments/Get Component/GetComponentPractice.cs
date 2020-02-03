using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentPractice : MonoBehaviour
{

    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;

    private BoxCollider boxCol;

    void awake()
    {

        // when the script being referenced in the main script is attached to the same object you can directly address the part of script you want
        // example is anotherScript - it is attached to the same gameObject as the main script GetComponentPractice.
        //so we can reference playerScore directly.

        //when you are referencing another script attached to another object you must first reference that object before you can access its script
        //example is the yetAnotherScript. we first reference the otherGameObject before we can access the death count.

      //  anotherScript = GetComonent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        
        boxCol = otherGameObject.GetComponent<BoxCollider>();

        // for GetComponent we use the angle brackets in place of the normal brackets.
        //these brackets are for taking a type as a parameter
        //in this specific script the type is another script

        // GetComponent can also be used to address other components on other game objects that we have reference to
        //such as otherGameObject referenced here in the script
        //GetComponent will return a reference to any component of the type specified on the game object its called upon.
    }
    void start()
    {
        Debug.Log("The player's score is" + anotherScript.playerScore);
        Debug.Log("The player has died" + yetAnotherScript.numberOfPlayerDeaths + "times");

        boxCol.size = new Vector3(3,3,3);
        //we can use this variable boxCol to address any of the parameters on that component on the other game object.

        //GetComponent is most commonly used to access other scripts it can also reference other components that are not exposed by the API  
        //GetComponent should be called as little as possible
   
    }
}
