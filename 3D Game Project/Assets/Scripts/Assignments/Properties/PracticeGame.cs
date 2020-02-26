using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PracticePlayer myPlayer = new PracticePlayer();

        // Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
