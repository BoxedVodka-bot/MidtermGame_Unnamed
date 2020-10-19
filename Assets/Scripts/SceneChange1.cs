using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject dialogue;
    bool doorOpen = false;
    public AudioSource myAudioSource;
     private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") && !other.isTrigger){
            doorOpen = true;
            dialogue.SetActive(true);
            myAudioSource.Play();
        }
    }

    void Update(){
        if (Input.GetKey("space") && doorOpen == true){
                SceneManager.LoadScene(sceneToLoad);
                doorOpen = false;
                myAudioSource.Play();
            }

    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.tag == "Player"){
            dialogue.SetActive(false);
        }
    }

}
