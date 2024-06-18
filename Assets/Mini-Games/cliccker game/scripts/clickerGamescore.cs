using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickerGamescore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("customer"))
        {
            Debug.Log("this part works");
            Destroy(collision.gameObject);
            //can add points system later
        }
    }
   
}
