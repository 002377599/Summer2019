using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool player1 = true;
    public int jumpPower = 400;
    private Rigidbody2D myRigidbody;

    private KeyCode rightCode;
    private KeyCode leftCode;
    private KeyCode jumpCode;

    public float jumpWaitTime = 1.0f;
    private float nextJumpTime;
    private bool grounded = true;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        if (player1)
        {
            jumpCode = KeyCode.W;
            rightCode = KeyCode.D;
            leftCode = KeyCode.A;
        }
        else
        {
            jumpCode = KeyCode.UpArrow;
            rightCode = KeyCode.RightArrow;
            leftCode = KeyCode.LeftArrow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(leftCode))
            myRigidbody.AddForce(Vector2.left*playerSpeed);
        if (Input.GetKey(rightCode))
            myRigidbody.AddForce(Vector2.right * playerSpeed);
        if (Input.GetKey(jumpCode) && grounded && Time.time >= nextJumpTime)
        {
            myRigidbody.AddForce(Vector2.up * jumpPower);
            nextJumpTime = Time.time + jumpWaitTime;
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
