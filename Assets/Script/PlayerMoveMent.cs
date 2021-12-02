using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    public int speed = 5;
    public int jumpForce = 380;
    public float moveX;
    public bool isGround;
    private Animator anim;
    private Rigidbody2D rb;
    private bool mirrered;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")&& isGround==true )
        {
            Jump();
        }
        if(moveX!=0 && isGround)
        {
            anim.SetBool("Run", true);
        }else
        {
            anim.SetBool("Run", false);
        }
        rb.velocity = new Vector2(moveX*speed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump()
    {
        isGround = false;
        rb.AddForce(Vector2.up*jumpForce);
    }    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="PlatForm")
        {
            isGround = true;
            anim.SetBool("Jump", false);

        }
    }
}
