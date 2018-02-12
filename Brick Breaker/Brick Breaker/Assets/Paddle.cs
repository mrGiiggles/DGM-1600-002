using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public float veticalOffset;
	
	// Update is called once per frame
	void Update () {
        //get horizontal position
       float mousePlacement = Input.mousePosition.x / Screen.width * 60 - 30;
        //set vertiakl offset
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);
     
        paddlePosition.x = mousePlacement;
        //set paddle object to saved position
        this.gameObject.transform.position = paddlePosition;
	}
}
