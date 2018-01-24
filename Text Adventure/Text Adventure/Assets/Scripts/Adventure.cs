using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour
{

    public enum States { cell, window, gate, bed, sleep };
    public States currentState;




    // Use this for initialization
    void Start()
    {
        currentState = States.cell;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == States.cell)
        {
            Cell();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }
        else if (currentState == States.sleep)
        {
            Sleep();
        }
    }
    private void Cell() {
        print("You are in a Jail cell. It's dirty, disgusting and smells revolting. \n" +
            "You are trying to escape, look all around and find a way. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "Press W for Widnow, G for Gate, B for Bed. \n");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Bed() {
        print("You go the bed. IF you could call it a bed. \n" +
            "The mattress is thin at best and stinks, and there are some odd stains. \n" +
            "Sleep or search the bed at the risk of your own health.\n" +
            "Press W to go to the window, S to search, N to sleep, G to look at the gate.");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.N)) { currentState = States.sleep; }
    }
    private void Sleep()
    {
        print("You take a nap despite the risk of gettind AIDS or something. When you awake there's a message on the cieling.");
    }
}
