using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentRaycast : MonoBehaviour
{
    void Update()
    {
        //always move forward (along x axis)
        //transform.Translate(2f*Time.deltaTime, 0f, 0f); //move 2m a second
        
        //ratcast in front of us and randomly turn left or right if there is a wall
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myRayDist = 0.8f;
        Debug.DrawRay(myRay.origin, myRay.direction*myRayDist, Color.yellow);

        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myRayDist);

        if(myRayHit.collider == null){
            transform.Translate(2f*Time.deltaTime, 0f, 0f);
        }else if(myRayHit.collider.CompareTag("Player")){
            transform.Translate(0f, 0f, 0f);
        }

        //did the Raycast hit something
        if (myRayHit.collider != null){
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
