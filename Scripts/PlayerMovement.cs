using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private bool jumpKeyWasPressed;
    private bool isOnGround;
    public float Forward = 2000f;
    public float Sideways = 2000f;
    public float RotateSpeed = 300f;
    public GameObject score;
    void Update()
    {
        if (rb.position.z > 0)
        {
            score.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
           

            jumpKeyWasPressed = true;
        }
        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (!isOnGround)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {

            rb.AddForce(0, Forward ,0);
            jumpKeyWasPressed = false;

        }
        // Time.deltaTime ne fuggjon FPStol a sebesseg

        if(Input.GetKey("d"))
        {
            rb.AddRelativeForce(Sideways * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);

        }
        
        if(Input.GetKey("a"))
        {
            rb.AddRelativeForce(-Sideways * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);

        }
        if(Input.GetKey("w"))
        {
            rb.AddRelativeForce(0, 0 , Forward * Time.deltaTime);

        }
        if(Input.GetKey("s"))
        {
            rb.AddRelativeForce(0, 0 , -Forward * Time.deltaTime);

        }

        if (Input.GetKey("q"))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey("e"))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);



    }


    private void OnCollisionEnter()
	{
        isOnGround = true;
	}

	private void OnCollisionExit()
	{
        isOnGround = false;
	}

}
