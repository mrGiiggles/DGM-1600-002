using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Powerup : MonoBehaviour {
    public enum Power { Health, Damage };
    public Power powerupType;
    private SpriteRenderer rend;
    public Sprite[] images;

	// Use this for initialization
	void Start () {
        rend = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (powerupType) {
            case Power.Health:
                rend.sprite = images[0];
                break;
            case Power.Damage:
                rend.sprite = images[1];
                break;

        }
		
	}
    private void OnTriggerEnter2D(Collider2D collider) {
        switch (powerupType) {
            case Power.Health:
                collider.GetComponent<Health>().IncrementHealth(5);
                break;
            case Power.Damage:
                rend.sprite = images[1];
                break;

        }
        Destroy(gameObject);
    }

}
