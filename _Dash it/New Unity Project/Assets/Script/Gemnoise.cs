using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemnoise : MonoBehaviour {
        public AudioClip hitSound;

        private void OnTriggerEnter2D(Collider2D collision) {

            AudioSource.PlayClipAtPoint(hitSound, new Vector3(0, 0, 0));
        }
    }
