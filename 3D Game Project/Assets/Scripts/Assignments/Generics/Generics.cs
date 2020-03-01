using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{
    public T GenericMethod<T>(T param)// you can add where T : (class, struct, new(), Monobehaviour, IEnumerable)
   
   {
        return param;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
