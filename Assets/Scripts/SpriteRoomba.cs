using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRoomba : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private Transform target;

    void Start(){
        target = GameObject.FindGameObjectWithTag("Roomba").GetComponent<Transform>();
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
            transform.localScale = new Vector3 (-2, 2, 1);
        }
    }

}
