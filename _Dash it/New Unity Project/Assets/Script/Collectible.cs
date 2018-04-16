using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    [Range(1, 50)]
    public int value;
    //public Color colorTint;
    public Manager myManager;

    private void Start() {
        myManager = GameObject.Find("GameManager").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        myManager.IncrementScore(value);
        //THIS IS ALSO POSSIBLY THE PROBLEM CHILD
        Destroy(gameObject);
        }


}