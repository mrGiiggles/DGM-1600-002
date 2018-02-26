﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public AudioClip hitSound;
    public Vector2 startSpeed;

    private void Start() {
        GetComponent<Rigidbody2D>().AddForce(startSpeed, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayClipAtPoint(hitSound, new Vector3(0, 0, 0));
    }

}
