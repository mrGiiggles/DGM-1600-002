using System.Collections;
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
    public float shootDistance;
    private bool lookLeft;

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
            lookLeft = true;

        } else {
            //unflip
            rend.flipX = false;
        }
        if (Input.GetButton("Fire1")) {
            anim.SetTrigger("ShootGo");

            Shoot();
        }

        /*if (Input.GetButtonDown("Jump")) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 2.0f, 8);
            if (hit.collider != null) {
                if (hit.collider.tag == "Ground") {
                    isGrounded = true;
                    Debug.Log("Found Ground");
                } else {
                    isGrounded = false;
                    Debug.Log("no ground");
                }
            }
            if (isGrounded) { 
            rigid.AddForce(new Vector2(0, jump), ForceMode2D.Force);
            }
        }
     }

    bool isGrounded() {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.5f;

        Debug.DrawRay(position, direction, Color.green, 0.25f);
        RaycastHit2D hit = Physics2D.Raycast(poistion, direction, distance, groundlayer);
            if (hit.collider != null) {
            return true;
        }
        return false;
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

  
    void Shoot() {
        Vector2 position = transform.position;
        Vector2 direction;
        if (lookLeft) {
            direction = Vector2.left;
        } else {
            direction = Vector2.right;
        }
        //figure out direction
        Debug.DrawRay(position, direction, Color.green, 0.25f);
        RaycastHit2D = Physics2D.Raycast(position, direction, shootDistance);
        if (hit.collider != null) {
            //deal damage
        }
    }
}
    
