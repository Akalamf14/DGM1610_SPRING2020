using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private Transform playerTransform;

    public Transform TeleportGoal;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            playerTransform.position = TeleportGoal.position;
        }
    }
}
