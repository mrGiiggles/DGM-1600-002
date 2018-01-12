using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

   public int max;
   public int min;
   public int guess;





    // Use this for initialization
    private void Start () {
     


        print("Welcome to Number Guesser");
        print("Pick a number between " + min +  " and " + max);

        //is the value GUESS
        print("is the number 54?");
        //instructions - Push these buttons
        print("UP Arrow for higher, DOWN Arrow for lower, ENTER if correct");
	}
	
	// Update is called once per frame
	public void Update () {
        
	}
}
