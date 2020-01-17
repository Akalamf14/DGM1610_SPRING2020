using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatIsMyName : MonoBehaviour
{
    string firstName = "Akala";
    string middleName = "Marie";
    string lastName = "Freeman";
    string newLastName = "Escobar";

    // Start is called before the first frame update
    void Start()
    {
       
        fullName(firstName, middleName, lastName);
        marriedName(firstName, middleName, newLastName);
        
    }

    void fullName(string firstName, string middleName, string lastName)
    {
        string whatsMyName;
        whatsMyName = firstName + middleName + lastName;
        print(whatsMyName);
    }

    void marriedName(string firstName, string middleName, string newLastName)
    {
        string newFullName;
        newFullName = firstName + middleName + newLastName;
        print(newFullName);
    }

}

