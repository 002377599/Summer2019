using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public int moveX;
    public bool facingRight = true;
    public int playerSpeed = 10;
    public bool player1 = true;
    public int jumpPower = 500;
    private Rigidbody2D myRigidbody;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        
    }

    void Move()
    {

        if (player1)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                jump();
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                jump();
            }

        }

    }

    void jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);

    }
}
