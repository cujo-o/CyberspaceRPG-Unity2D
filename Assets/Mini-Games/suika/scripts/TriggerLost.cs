using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLost : MonoBehaviour
{
    public float timer = 0f;
    // Start is called before the first frame update
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer==7)
        {
            timer += Time.deltaTime;
            if (timer>suikaManager.instance.timeTillgameOver)
            {
                suikaManager.instance.GameOver();
            }
        }


    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            timer = 0f;
        }

    }
}
