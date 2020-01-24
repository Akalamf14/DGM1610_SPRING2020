using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPractice : MonoBehaviour
{
    public bool isGrounded;
    Rigidbody gameCharacter;

    // Start is called before the first frame update
    void Start()
    {
        gameCharacter = GetComponent<Rigidbody>();        
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gameCharacter.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
            isGrounded = false;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameCharacter.AddForce(new Vector3(5,0,0) , ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameCharacter.AddForce(new Vector3(-5,0,0) , ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameCharacter.AddForce(new Vector3(0,0,5), ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameCharacter.AddForce(new Vector3(0,0,-5), ForceMode.Impulse);
        }
    }
}
