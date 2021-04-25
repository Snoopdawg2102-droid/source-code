using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "wall")
        {
            FindObjectOfType<gameManager>().Death2();
        }
        if (collisionInfo.collider.tag == "enemy")
        {
            FindObjectOfType<gameManager>().Death1();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            rb.position += moveSpeed;
        }
        if (Input.GetKey("a"))
        {
            rb.position -= moveSpeed;
        }
        if(transform.position.y <= -4700f)
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                FindObjectOfType<gameManager>().Win();
            }
        }
    }
}
