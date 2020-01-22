using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
         /* 
         Semi Colon is used to terminate/End statements
         the dot oporator or Period is used to separate words in our code
         its like an address below Debug would be like a Country and Log the city
         also in the parethesis transform is like the country, position is like the city and x is like the street name
         dot oporator allows us to access elements of a compound item
         compound item contains MANY items
          */

        Debug.Log(transform.position.x); 

        // transform (position, rotation, and scale)
        // position (x, y, z)


        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
