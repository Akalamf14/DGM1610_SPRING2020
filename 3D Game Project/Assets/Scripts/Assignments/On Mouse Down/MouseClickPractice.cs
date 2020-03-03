/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPractice : MonoBehaviour
{

    // onMouseDown can detect a click on a collider or a GUI text element.

    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
       // Debug.Log("Clicked on the Door!");
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}
*/
