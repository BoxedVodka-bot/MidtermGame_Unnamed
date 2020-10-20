using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentRaycast : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        //always move forward (along x axis)
        //transform.Translate(2f*Time.deltaTime, 0f, 0f); //move 2m a second
        
        //ratcast in front of us and randomly turn left or right if there is a wall
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myRayDist = 1.5f;
        Debug.DrawRay(myRay.origin, myRay.direction*myRayDist, Color.yellow);

        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myRayDist);

        if(myRayHit.collider == null){
            transform.Translate(2f*Time.deltaTime, 0f, 0f);
            anim.SetBool("stopping", false);
        }else if(myRayHit.collider.CompareTag("Player")){
            transform.Translate(0f, 0f, 0f);
            anim.SetBool("stopping", true);
        }

        //did the Raycast hit something
        if (myRayHit.collider != null && myRayHit.collider.CompareTag("Untagged")  || myRayHit.collider.CompareTag("Wall")){
            //randomly turn left or right
            float randomNumber = Random.Range(0, 100);
            if(randomNumber < 50){ // 50% chance to turn left
                transform.Rotate(0, 0, 90f);
            }else{ //50% chance to turn right
                transform.Rotate(0, 0, -90f);
            }
        }
    }

    
}
