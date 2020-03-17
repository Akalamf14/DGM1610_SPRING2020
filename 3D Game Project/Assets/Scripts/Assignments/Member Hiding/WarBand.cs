using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // here we are calling each script for the types of humanoids
        
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        //each humanoid variable contains a reference to a different
        //class in the inheritance hierarchy, yet each of them calls the humanoid Yell() method.

        human.Yell();
        enemy.Yell();
        orc.Yell();

    }

   // THE QUESTION THEN IS WHY DO I HAVE SEPERATE CALL FUNCTIONS FOR HUMANOID, ENEMY, AND ORC IF THEY ARE
   // ALL GOING TO USE THE SAME HUMANOID FUNCTION??
}
