using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalenderDialog : MonoBehaviour
{
    public GameObject calenderDialog;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            calenderDialog.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Player"){
            calenderDialog.SetActive(false);
        }
    }
}
