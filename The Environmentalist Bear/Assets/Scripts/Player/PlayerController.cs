using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;
    public float jumpHeight;
    public bool landed;
    public bool stepOnObject;
    private Rigidbody2D rb;
    GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void FixedUpdate()
    {
        move();
        jump();

        if(rb.velocity.y == 0)
        {
            landed = true;
        }
    }

    void move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        if(landed || stepOnObject)
        {
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        }
        
    }

    void jump()
    {
        if (Input.GetButton("Jump") && (landed || stepOnObject))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            //rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            landed = false;
        }
    }
}
