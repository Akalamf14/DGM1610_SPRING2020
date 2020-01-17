using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{

    //There are 3 types of loops - for, foreach, while, and doWhile
    // while loops is used to perform an action while a condition is met
    
    int cupsInTheSink = 4; // ex of while loop

    // Start is called before the first frame update
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
