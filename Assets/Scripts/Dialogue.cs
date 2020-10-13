﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            next = true;
            dialogue.SetActive(true);
        }
    }

    void Update(){
        if (Input.GetKeyDown("1") && next == true){
                dialogue.SetActive(false);
                dialogue2.SetActive(true);
                next = false;
                next2 = true;
                //yield return new WaitUntil(() => Input.GetKeyDown("space"));
        }else{

        }
        if (Input.GetKeyDown("2") && next2 == true){
                dialogue2.SetActive(false);
                dialogue3.SetActive(true);
                next2 = false;
                next3 = true;
                //yield return new WaitUntil(() => Input.GetKeyDown("space"));
        }
        if (Input.GetKeyDown("3") && next3 == true){
                dialogue3.SetActive(false);
                dialogue4.SetActive(true);
                next3 = false;
                next4 = true;
                //yield return new WaitUntil(() => Input.GetKeyDown("space"));
        }
        if (Input.GetKeyDown("4") && next4 == true){
                dialogue4.SetActive(false);
                dialogue5.SetActive(true);
                next4 = false;
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
        }
    }
}
