using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class bucketMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveinput;
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;

    void Start()
    {
        rb.gravityScale = 0;
    }


    void Update()
    {
        moveinput.x = Input.GetAxisRaw("Horizontal");
       // moveinput.y = Input.GetAxisRaw("Vertical");
        moveinput.Normalize();

        rb.velocity = moveinput * moveSpeed;
        scoreText.text = $"{score}";

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yellowDrop")
        {
            score -= 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "brownDrop")
        {
            score -= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "whiteDrop")
        {
            score += 1;
            Destroy(collision.gameObject);
        }

    }
}
