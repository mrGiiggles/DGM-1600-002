using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Containers : MonoBehaviour {

    public GameObject[] items;

    public void Drop() {
        for (int i = 0; i < items.Length; i++) {
            GameObject item = Instantiate(items[i], gameObject.transform.position, Quaternion.identity);
            //it has rigid body
            if (!item.GetComponent<Rigidbody2D>()) {
                item.AddComponent<Rigidbody2D>();
            }
            //item collider isn't a trigger

            if (!item.GetComponent<Collider2D>()) {
                item.AddComponent<CapsuleCollider2D>();
            } else {
                item.GetComponent<Collider2D>().isTrigger = false;
            }
            //LimboChanger(item);
        }

    }
    /* IEnumerator LimboChanger(GameObject item) {
        
        yield return new WaitForSeconds(2);
        item.layer = LayerMask.NameToLayer("Item");
    }*/
}

