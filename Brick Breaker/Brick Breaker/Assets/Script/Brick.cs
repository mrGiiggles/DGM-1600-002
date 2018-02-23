using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick : MonoBehaviour {

    public int health;
    public Sprite[] sprites;

    private void Awake() {
        GameManager.brickCount++;
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        health--;
        GetComponent<SpriteRenderer>().sprite = sprites[health];

        //if our helth gets to zero, destroy object
        if (health <= 0) {
            Destroy(gameObject);
            GameManager.brickCount--;
            print(GameManager.brickCount);

            if (GameManager.brickCount == 0) {
                FindObjectOfType<GameManager>().LoadNextLevel();
            }
        }
    }


    }
