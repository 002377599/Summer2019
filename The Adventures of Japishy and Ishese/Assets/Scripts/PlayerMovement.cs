using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool player1 = false;
    private Rigidbody2D rb2d;
    public float jumpForce;
    public float moveSpeed;

    private KeyCode jumpCode;
    private KeyCode walkCode;
    
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
        if(Input.GetKeyDown(jumpCode))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }
        else if(Input.GetKeyDown(walkCode))
        {
            rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
        }
    }
}
