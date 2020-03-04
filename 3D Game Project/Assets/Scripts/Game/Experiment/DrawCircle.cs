using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour
{

    //Matrix that tranforms from camera to space world space
    // use this to calculate where in the world a specific camera space point is.
    
    public float distance = -1.0f;

    void OnDrawGizmosSelected()
    {
        Matrix4x4 m = Camera.main.cameraToWorldMatrix;
        Vector3 p = m.MultiplyPoint(new Vector3(0,0, distance));
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(p, 0.2f);
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
