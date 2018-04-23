using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    private static Manager instance = null;
    public Text scoreBoard;
    private int score;
    //private ouch;

    void Awake() {
        if (instance == null) {
            instance = this.gameObject.GetComponent<Manager>();
        } else if (instance != this) {         //if instance is not assigned
            Destroy(this.gameObject);        // then assign instance to this obect
        }                                    //then destroy this object
        DontDestroyOnLoad(this.gameObject);
    }


    public void IncrementScore(int value) {
        score += value;
        scoreBoard.text = score.ToString();
    }//THTIS IS THE PROBLEM CHILD


    public void LoadLevel(string level) {
        SceneManager.LoadScene(level);


    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Done with the game");
    }
}