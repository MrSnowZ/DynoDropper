using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour {
    //score = 0
    private void OnCollisionEnter2D(Collision2D other){
            Debug.Log("hit detected");
            Destroy(other.gameObject);
            //get game object by tag (scoreboard)
            //get text
            //set text to score +1
    }
}
