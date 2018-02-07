using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    private void OnCollisionEnter2D(Collision2D collision) {
        health--;
        //if our helth gets to zero, destry object
        if (health <= 0) {
            Destroy(gameObject);

        }
}
}
