using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayersMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveinput;
    public bool isFacingRight;
    public Animator anim;
    void Start()
    {
        rb.gravityScale = 0;
    }


    void Update()
    {
        moveinput.x = Input.GetAxisRaw("Horizontal");
        moveinput.y = Input.GetAxisRaw("Vertical");
        moveinput.Normalize();

        rb.velocity = moveinput * moveSpeed;

        Flip();

      
        if (moveinput.y>=1)
        {

            anim.SetTrigger("backwalk");
        }
        if (moveinput.y <= -1)
        {
            anim.SetTrigger("frontwalk");
        }
        if (moveinput.x != 0)
        {
            anim.SetTrigger("sidewalk");
        }
        if (moveinput.y==0 && moveinput.x==0)
        {
            anim.SetTrigger("idle");
        }

    }

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void MoveInput(Vector2 newMoveDirection)
    {
        moveinput = newMoveDirection;
    }




    private void Flip()
    {
        if (isFacingRight && moveinput.x < 0f || !isFacingRight && moveinput.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }

}


