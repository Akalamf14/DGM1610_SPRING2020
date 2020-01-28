using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2Move : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Obstacle 1")
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.name == "Obstacle 2")
        {
            Destroy(other.gameObject);
        }

    }
}
