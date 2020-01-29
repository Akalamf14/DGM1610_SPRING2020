using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreMoveScript : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); //vertical goes back and forth
        horizontalInput = Input.GetAxis("Horizontal"); //horizontal goes left and right
   
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    }

}
