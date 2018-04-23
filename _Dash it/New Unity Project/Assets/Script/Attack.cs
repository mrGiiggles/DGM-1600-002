using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public float swingDistance;
    public float minDistance;
    public float shootDamage;
    public Color shootColor;
    private LineRenderer lineRenderer;
    private Animator anim;
    private bool lookLeft;

      // Use this for initialization
      void Start () {
          lineRenderer = GetComponent<LineRenderer>();
          anim = GetComponent<Animator>();
      }

      void Swing() {
          Vector2 position = transform.position;
          Vector2 direction;
          if (lookLeft) {
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
          RaycastHit2D hit = Physics2D.Raycast(position, direction, swingDistance);
          if (hit.collider != null) {
              Debug.Log(hit.collider.name);
              if (hit. collider.GetComponent<Health>()) {
                  hit.collider.GetComponent<Health>().IncrementHealth(-2);
              }
          }
         //StartCoroutine(LaserOff());
      }
      

      
       

}
