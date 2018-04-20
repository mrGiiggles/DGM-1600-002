using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    [Header("Movement")]
    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    private Attack attacking;
    
    
    //public shootDistance;


    // Use this for initialization
    void Start() {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        attacking = GetComponent<Attack>();
       


}

    // Update is called once per frame
    void Update() {

        //vetical and horizontal movement
        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        rigid.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed), ForceMode2D.Force);
        anim.SetFloat("HorizontalMove", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("VerticalMove", Input.GetAxisRaw("Vertical"));
        if (Input.GetButtonDown("Fire1")) {
            anim.SetTrigger("Attack");
           
        }
       
    }
    
}

