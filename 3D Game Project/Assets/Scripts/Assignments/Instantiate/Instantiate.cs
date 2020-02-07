using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    //instantiate is a function used to create clones of gameObjects.
    //cloing prefab
    //prefab is a preconfigured object which is saved in the projects assests

    // EXAMPLE - firing projectiles
        //each of the projectiles would need to be instantiated into the game world so it could be fired
        // this way we don't have to create a hundred different projectiles, we only need to make one
        // this way we can clone the one object as many times as we need


    public Rigidbody projectile;  

    public Transform barrelEnd; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the most simple Instantiate function takes usually only 1 parameter, the object that we wish to clone
        if(Input.GetButtonDown("Fire1")) // we are using Fire1 to TRIGGER an instantiate function
        {
            Instantiate(projectile);
        } //this function has the object instantiated at it's defalt position which is 0. 

        if(Input.GetButtonDown("Fire1")) // this version requires 3 parameters
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.up * 350f);
        }
   
    }

}
