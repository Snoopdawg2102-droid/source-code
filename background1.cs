using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background1 : MonoBehaviour
{

    public Transform player;
    public Vector3 xAndZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "reset")
        {
            transform.position = player.position + xAndZ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xAndZ.x = 0f;
    }
}
