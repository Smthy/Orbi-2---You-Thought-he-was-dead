using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float xMove;    

    bool isJumping;
    Rigidbody rb;

    void Awake()
    {
        isJumping = true;
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");

        this.transform.Translate(new Vector3((xMove * 12.5f * Time.deltaTime), 0.0f, 0.0f));

        Jump();
        WallJump();
    }


    void Jump()
    {
        if (Input.GetKeyDown("space") && isJumping == true || (Input.GetKeyDown("w") && isJumping == true))
        {
            isJumping = false;
            rb.AddForce(new Vector3(0, 20f, 0), ForceMode.Impulse);            
        }

    }

    void WallJump()
    {
        if (Input.GetKeyDown("space") && isJumping == true || (Input.GetKeyDown("w") && isJumping == true))
        {
            isJumping = false;
            rb.AddForce(new Vector3(0, 20f, 0), ForceMode.Impulse);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }  

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("wallJump"))
        {
            isJumping = true;
        }
    }


}