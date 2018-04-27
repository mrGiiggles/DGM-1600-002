using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour {
    public static Audiomanager instance = null;

    // Use this for initialization
    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {         //if instance is not assigned
            Destroy(this.gameObject);        // then assign instance to this obect
        }                                    //then destroy this object
        DontDestroyOnLoad(this.gameObject);
    }


}
