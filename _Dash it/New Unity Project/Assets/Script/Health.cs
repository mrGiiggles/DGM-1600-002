﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int health;
    public ParticleSystem deathParticle;

    public void IncrementHealth(int amount) {
        health += amount;
        if (health <= 0) {
            //Do something
            Die();
        }
    }

    public void Die() {
        Destroy(gameObject);

        if (deathParticle != null) {
            ParticleSystem particle = Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(particle, particle.main.duration);
            Destroy(gameObject, deathParticle.main.duration);
        }
    }
}
