using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentDialogue2 : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject dialogue2;
    public GameObject dialogue3;
    bool next = false;
    bool next2 = false;
    public AudioSource myAudioSource;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            next = true;
            dialogue.SetActive(true);
            myAudioSource.Play();
        }
    }

    void Update(){
        if (Input.GetKeyDown("4") && next == true){
                dialogue.SetActive(false);
                dialogue2.SetActive(true);
                next = false;
                next2 = true;
                myAudioSource.Play();
               
        }
        if (Input.GetKeyDown("3") && next2 == true){
                dialogue2.SetActive(false);
                dialogue3.SetActive(true);
                next2 = false;
                myAudioSource.Play();
                
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Player"){
            dialogue.SetActive(false);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);
            next = false;
            next2 = false;
     
        }
    }
}
