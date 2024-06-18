using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tetris"))
        {
            SceneManager.LoadScene("tetris");
        }
        else if (collision.CompareTag("palace"))
        {
            SceneManager.LoadScene("yui palace");
        }
        else if (collision.CompareTag("home"))
        {
            SceneManager.LoadScene("home");
        }
        else if (collision.CompareTag("suika"))
        {
            SceneManager.LoadScene("Suika-Game");
        }
    }
}
