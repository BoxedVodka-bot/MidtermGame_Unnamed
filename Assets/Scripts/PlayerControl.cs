using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    //PURPOSE: Control player's movements
    float inputHorizontal;
    float inputVertical;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private bool facingRight = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        Movement();
    }
    void Movement(){
        inputHorizontal = Input.GetAxis("Horizontal"); //Gets a value from -1 to 1. -1 if left, 1 if right.
        inputVertical = Input.GetAxis("Vertical");
        /*
         if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Transform>().position += new Vector3 (-0.05f, 0f, 0f);
        }
        
        //If player press RIGHT ARROW, go right
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Transform>().position += new Vector3 (0.05f, 0f, 0f);
        }
        //If player press UP ARRPW, go up
        if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Transform>().position += new Vector3 (0f, 0.05f, 0f);
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Transform>().position += new Vector3 (0f, -0.05f, 0f);      
        }
        */
        
        if(inputHorizontal !=0 ){
            rb.velocity = new Vector2(inputHorizontal*moveSpeed, rb.velocity.y);
        }
        if(inputVertical != 0){
            rb.velocity = new Vector2 (rb.velocity.x, inputVertical*moveSpeed);
        }
        
    }

    void FixedUpdate(){
        //flip character
        if(facingRight == false && inputHorizontal > 0){
            Flip();
        } else if (facingRight == true && inputHorizontal < 0){
            Flip();
        }
    }

     //flip the character when facing different direction
    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
   
}
