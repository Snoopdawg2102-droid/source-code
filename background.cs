using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "reset")
        {
            transform.position = player.position - offset;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}