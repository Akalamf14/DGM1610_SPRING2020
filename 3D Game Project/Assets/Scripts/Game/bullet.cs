using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage = 1;
    public int time = 5;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other) // other is arbitrary - we could substitute it with anything
    {

        // other.gameObject.GetComponent<EnemyHealth>();

        if(other.gameObject.CompareTag("Enemy"))
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<EnemyHealth>();

            if( health != null) // != not equal
            //null means nothing - there's no value (or 0)
            // health != null -- if health is not 0 or below (negative numbers)
            {

             health.TakeDamage(damage);
             Debug.Log("ouch, you hit me!");

            }
        }

       
    }

   
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);

    }
    
}
