using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLastFunctionPracticeScript : MonoBehaviour
{
    int seats = 40;
    int students = 132;
    int teachers = 4;

    // Start is called before the first frame update
    void Start()
    {
        busesNeeded(seats, students, teachers);
    }

    void busesNeeded(int seats, int students, int teachers)
    {
        int buses;
        buses = (students + teachers) / seats;
        print(buses + "buses needed for the fieldtrip");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
