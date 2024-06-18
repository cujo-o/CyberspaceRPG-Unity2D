using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collionDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yellowDrop")
        {
  
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "brownDrop")
        {
        
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "whiteDrop")
        {
         
            Destroy(collision.gameObject);
        }

    }
}
