using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool player1 = false;
    private Rigidbody2D rb2d;
    
    public float moveSpeed;
    private KeyCode walkCode;

    public float jumpForce;
    private KeyCode jumpCode;
    public float jumpWaitTime = 1.0f;
    private float nextJumpTime;
    private bool grounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if(player1)
        {
            jumpCode = KeyCode.W;
            walkCode = KeyCode.D;
        }
        else
        {
            jumpCode = KeyCode.UpArrow;
            walkCode = KeyCode.RightArrow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpCode) && grounded && Time.time >= nextJumpTime)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            nextJumpTime = Time.time + jumpWaitTime;
        }
        else if(Input.GetKeyDown(walkCode))
        {
            rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            grounded = false;
        }
    }
}
