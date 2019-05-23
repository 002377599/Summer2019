using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public int playerSpeed = 10;
    public bool player1 = true;
    public int jumpPower = 400;
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
            if (Input.GetKey(KeyCode.A))
                myRigidbody.AddForce(Vector3.left*playerSpeed);
            if (Input.GetKey(KeyCode.D))
                myRigidbody.AddForce(Vector3.right * playerSpeed);
            if (Input.GetKey(KeyCode.W))
                myRigidbody.AddForce(Vector3.up*jumpPower);
            if (Input.GetKey(KeyCode.S))
                myRigidbody.AddForce(Vector3.down * playerSpeed);
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                myRigidbody.AddForce(Vector3.left * playerSpeed);
            if (Input.GetKey(KeyCode.RightArrow))
                myRigidbody.AddForce(Vector3.right * playerSpeed);
            if (Input.GetKey(KeyCode.UpArrow))
                myRigidbody.AddForce(Vector3.up*jumpPower);
            if (Input.GetKey(KeyCode.DownArrow))
                myRigidbody.AddForce(Vector3.down * playerSpeed);
                
        }

    }
}
