using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSpriteRoomba : MonoBehaviour
{
    public Animator anim;
    private Transform target;

    void Start(){
        target = GameObject.FindGameObjectWithTag("Teacher").GetComponent<Transform>();
    }
    void Update()
    {
     
        transform.position = Vector2.MoveTowards(transform.position, target.position, 2f*Time.deltaTime);
       
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            anim.SetBool("stopping", true);
        }else{
            anim.SetBool("stopping", false);
        }
        
        if(collision.tag == "Wall"){
            transform.localScale = new Vector3 (-3, 3, 1);
        }
        
    }
}
