using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    public bool isGrounded;
    Rigidbody gameCharacter;

    public GameObject projectilePrefab;
    

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
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gameCharacter.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
            isGrounded = false;
        }

        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

      
    }
}
