using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour
{
    public Transform block;
    public Vector3 nSeven;
    public Vector3 zero;
    public Vector3 pSeven;

    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if(block.position.x >= -6.2 && block.position.x <= -2.5)
        {
            transform.position = nSeven;
        }
        if (block.position.x >= -2.5 && block.position.x <= 2.5)
        {
            transform.position = zero;
        }
        if (block.position.x >= 2.5 && block.position.x <= 6.2)
        {
            transform.position = pSeven;
        }

        nSeven.y = player.position.y - 2f;
        zero.y = player.position.y - 2f;
        pSeven.y = player.position.y - 2f;
    }
}
