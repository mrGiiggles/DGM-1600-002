using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int health;
    public ParticleSystem deathParticle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("collided");
        health--;
        if (health <= 0) {
            //Die
            //DeathParticle
            Instantiate(deathParticle,gameObject.transform.position,Quaternion.identity);


            Destroy(gameObject);
        }
    }
}
