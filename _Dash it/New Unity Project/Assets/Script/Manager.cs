using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    public Text scoreBoard;
    private int score;


    public void IncrementScore(int value) {
        score += value;
        scoreBoard.text = score.ToString();
    }


    public void LoadLevel(string level) {
        SceneManager.LoadScene(level);


    }
}