using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int max;
    public int min;
    private int guess;
    public int count;



    // Use this for initialization
    private void Start() {



        print("Welcome to Number Guesser");
        print("Pick a number between " + min + " and " + max);

        //is the value GUESS
        NextGuess();
        //instructions - Push these buttons
        print("UP Arrow for higher, DOWN Arrow for lower, ENTER if correct");

        max = max + 1;
    }

    private void NextGuess() {
        //figure out how randomize gues*************************
        count--;
        guess = Random.Range(min, max);
        print("is the number " + guess + " ?");
    }


    // Update is called once per frame
    void Update() {


        //Up Arrow


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        //Down Arrow
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();

        }

        //Enter Key
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Computer win!");

        }
        else if (count == 0)
        {
            print("Human wins this round!");
        }
        //IF count is zero, human wins
    }
    
}

	


