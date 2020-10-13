using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAtSchool : MonoBehaviour
{
public GameObject dialogue;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject dialogue4;
    public GameObject dialogue5;
    bool next = false;
    bool next2 = false;
    bool next3 = false;
    bool next4 = false;

    public static bool isText = false;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            next = true;
            isText = true;
            dialogue.SetActive(true);
        }
    }

    void Update(){
        if (Input.GetKeyDown("1") && isText == true){
                dialogue.SetActive(false);
                dialogue2.SetActive(true);
                dialogue3.SetActive(false);
                dialogue4.SetActive(false);
                dialogue5.SetActive(false);
                next = false;

        }
        else if (Input.GetKeyDown("2") && isText == true){
                dialogue2.SetActive(false);
                dialogue3.SetActive(true);
                dialogue.SetActive(false);
                dialogue4.SetActive(false);
                dialogue5.SetActive(false);
                next = false;
               
        }
        else if (Input.GetKeyDown("3") && isText == true){
                dialogue.SetActive(false);
                dialogue2.SetActive(false);
                dialogue3.SetActive(false);
                dialogue4.SetActive(true);
                dialogue5.SetActive(false);
                next = false;
               
        }
        else if (Input.GetKeyDown("4") && isText == true){
                dialogue.SetActive(false);
                dialogue2.SetActive(false);
                dialogue3.SetActive(false);
                dialogue4.SetActive(false);
                dialogue5.SetActive(true);
                next = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Player"){
            dialogue.SetActive(false);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);
            dialogue4.SetActive(false);
            dialogue5.SetActive(false);
            next = false;
            next2 = false;
            next3 = false;
            next4 = false;
            isText = false;
        }
    }
}
