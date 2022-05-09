using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other){
            Debug.Log("hit detected");
            Destroy(other.gameObject);
    }
}
