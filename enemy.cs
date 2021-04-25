using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private int resetCount = 0;
    public Vector3 boundry1;
    public Vector3 boundry2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(resetCount >= 2)
        {
            Destroy(gameObject);
        }
        if (player.position.y <= transform.position.y - 10)
        {
            transform.position = player.position - offset;
            //resetCount += 1;
        }
        if(transform.position.x > 6.2)
        {
            transform.position = boundry1;
        }
        if (transform.position.x < -6.2)
        {
            transform.position = boundry2;
        }
        boundry1.y = player.position.y - 200;
        boundry2.y = player.position.y - 200;
    }
}
