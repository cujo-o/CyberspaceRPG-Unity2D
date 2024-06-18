using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class competitonMovement : MonoBehaviour
{

    [SerializeField] public GameObject Center;
    [SerializeField] public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MovetoPlayerCeneter();
    }

    void MovetoPlayerCeneter()
    {

        transform.position = Vector2.MoveTowards(this.transform.position, Center.transform.position, speed * Time.deltaTime);
    }
}
