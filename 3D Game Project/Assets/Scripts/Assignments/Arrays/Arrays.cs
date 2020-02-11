using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int [5];

    int[] anotherArray = {12, 76, 8, 937, 980};

    public GameObject[] players;
    //array is a collection of variables of a certain type
    // we need to know the length of the array (how many elements will be stored in it)
    //elements are items stored in an array
    // Start is called before the first frame update
    void Start()
    {
        //we can access and initialize elements of the array by using the name of the array
        //followed by the square brackets containing the index 
        // the index of an element is simply an integer, with the first index being zero.
        myIntArray[0] = 12;
        myIntArray[1] = 25;
        myIntArray[2] = 5;
        myIntArray[3] = 153;
        myIntArray[4] = 2;

        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " +i+ "is named " + players[i].name);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
