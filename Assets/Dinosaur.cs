using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinosaur : MonoBehaviour {
    public double score = 0;
    private void OnCollisionEnter2D(Collision2D other){
            Debug.Log("hit detected");
            Destroy(other.gameObject);
            score += 0.5;
            //get game object by tag (scoreboard)
            GameObject scoreBoard = GameObject.FindGameObjectWithTag("scoreboard");
            scoreBoard.GetComponent<Text>().text = ""+(int)score;
            //set text to score +1
    }
}
