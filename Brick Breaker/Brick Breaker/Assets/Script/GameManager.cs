using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    // Use this for initialization
    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {         //if instance is not assigned
            Destroy(this.gameObject);        // then assign instance to this obect
        }                                    //then destroy this object
        DontDestroyOnLoad(this.gameObject);
    }


    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
   

}