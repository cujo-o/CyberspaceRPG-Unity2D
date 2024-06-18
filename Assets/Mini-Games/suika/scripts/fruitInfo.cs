using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitInfo : MonoBehaviour
{
  public int fruitIndex;
    public int pointsWhenanimated;
    public float fruitMass;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = fruitMass;
    }
}
