using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    [Header("Movement")]
    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    [Space(5), Header("Damage")]
    public float swingDistance;
    public float minDistance;
    public float swingDamage;
    public Color shootColor;
    private LineRenderer lineRenderer;
    //public shootDistance;


    // Use this for initialization
    void Start() {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        lineRenderer = GetComponent<LineRenderer>();


}

    // Update is called once per frame
    void Update() {

        //vetical and horizontal movement
        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        rigid.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed), ForceMode2D.Force);
        anim.SetFloat("HorizontalMove", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("VerticalMove", Input.GetAxisRaw("Vertical"));

        if (Input.GetButton("Fire1")) {
            anim.SetTrigger("Play_Attack_Left");

        }
    }
    /*void Shoot() {
        Vector2 position = transform.position;
        Vector2 direction;
        if (lookleft) {
            direction = Vector2.left;
            position += new Vector2(-0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(-0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(-10.5f, 0, 0));

        } else {
            direction = Vector2.right;
            position += new Vector2(0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(10.5f, 0, 0));
        }
        Debug.DrawRay(position, Vector2.left, Color.red, 0.25f);
        lineRenderer.enabled = true;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, shootDistance);
        if (hit.collider !+ null) {
            Debug.Log(hit.collider.name);
            if (hit. collider.GetComponent<Health>()) {
                hit.collider.GetComponent<Health>().IncrementHealth(-2);
            }
        }
        StartCoroutine(LaserOff());
    }
    IEnumerator LaserOff() {

    }*/
}

