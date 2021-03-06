﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public static int brickCount;

    // Use this for initialization
    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {         //if instance is not assigned
            Destroy(this.gameObject);        // then assign instance to this obect
        }                                    //then destroy this object
        DontDestroyOnLoad(this.gameObject);
    }


    public void LoadLevel(string level) {
        brickCount = 0;
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel() {
        brickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }   

    public void SoDone() {
        print("Quit Game");
        Application.Quit();
    }
   

}