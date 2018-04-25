﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructables : MonoBehaviour {
    public Health healthScript;
    public ParticleSystem deathParticle;

    private void Start() {
        healthScript = GetComponent<Health>();

    }


    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("collided");
        healthScript.health--;
        if (healthScript.health <= 0) {
            //Die
            //DeathParticle
            ParticleSystem particle = Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(particle, particle.main.duration);
            Destroy(gameObject);

        }

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("collided");
        healthScript.health--;
        if (healthScript.health <= 0) {
            //Die
            //DeathParticle
            GetComponent<Containers>().Drop();
            ParticleSystem particle = Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(particle, particle.main.duration);
            Destroy(gameObject);

        }
    }
}
