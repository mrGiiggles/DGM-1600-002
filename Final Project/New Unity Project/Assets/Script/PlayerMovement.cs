﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    public float jump;
    public bool isGrounded;

    // Use this for initialization
    void Start() {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        //check for button pushes
        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        anim.SetFloat("HorizontalMove", Input.GetAxisRaw("Horizontal"));

        if (Input.GetAxisRaw("Horizontal") < -0.1f) {
            //flip sprite renderer
            rend.flipX = true;

        } else {
            //unflip
            rend.flipX = false;
        }
        if (Input.GetButton("Fire1")) {
            anim.SetTrigger("ShootGo");
        }

        if (isGrounded && Input.GetButtonDown("Jump")) {
            rigid.AddForce(new Vector2(0, jump), ForceMode2D.Force);
        }

    }
    /*void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "Ground") {
            isGrounded = false;
        }

    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.transform.tag == "Ground") {
            isGrounded = false;
        }
     }*/
}
    
