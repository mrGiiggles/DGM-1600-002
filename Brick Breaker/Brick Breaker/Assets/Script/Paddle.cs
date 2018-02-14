using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public float veticalOffset;
    public bool autoPlay;
    private GameObject ball;

    private void Start() {
        ball = FindObjectOfType<Ball>().gameObject;
    }

    // Update is called once per frame
    void Update () {
        //get horizontal position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        if (autoPlay) {
            paddlePosition.x = ball.transform.position.x;

        } else {

            float mousePlacement = Input.mousePosition.x / Screen.width * 60 - 30;
            //set vertiakl offset
           

            paddlePosition.x = mousePlacement;

        }

      
        //set paddle object to saved position
        this.gameObject.transform.position = paddlePosition;
	}
}
