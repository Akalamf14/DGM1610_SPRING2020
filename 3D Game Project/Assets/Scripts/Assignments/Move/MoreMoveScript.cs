using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreMoveScript : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    public GameObject projectilePrefab;

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
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //first item in list is the item being instantiated (whatever object you choose it to be)
            //second item in list is the position of where we want the object to be instantiated
            //third item is the rotation of the item being instantiated        
        
        }
    }


}
