using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    public float jumpHeight;
    public bool isGrounded;
    private Rigidbody gameCharacter;

    public GameObject projectilePrefab;

    Vector3 startPos;
    

    // Start is called before the first frame update
    void Start()
    {
        gameCharacter = GetComponent<Rigidbody>();

        startPos = this.transform.position;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Optional
    /* void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
            Debug.Log("Colliding with floor");
        }
    }
    */

        // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gameCharacter.AddForce(new Vector3(0,20,0), ForceMode.Impulse);
            isGrounded = false;

            //optional - make character jump
            //gameCharacter.AddForce(Vector3.up * jumpheight * 1000 * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            gameCharacter.transform.position = startPos;
        }

      
    }
}
