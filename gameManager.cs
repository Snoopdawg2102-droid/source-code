using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Transform player;
    public GameObject tutorial;
    private float distance;
    public Text score;
    public Text message;
    public GameObject death;
    public GameObject Victory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Limitless()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Win()
    {
        Victory.SetActive(true);
    }

    public void Death1()
    {
        death.SetActive(true);
        message.text = "Try and avoid the blocks";
    }
    public void Death2()
    {
        death.SetActive(true);
        message.text = "Try and stay away from the walls!";
    }

    public void Tutorial()
    {
        tutorial.SetActive(true);
    }
    public void TutorialOff()
    {
        tutorial.SetActive(false);
    }
    public void Play()
    {
        if(SceneManager.GetActiveScene().buildIndex < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        distance = -player.position.y + 5.31f;

        score.text = "Speed: " + distance;

        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
