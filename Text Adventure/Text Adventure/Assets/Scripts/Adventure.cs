using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{

    public enum States { cell, window, cellDoor, bed, sleep, call, insult, search, bribeCellDoor, bribeWindow, escape };
    public States currentState;
    public Text textObject;
    public Text titleObject;



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
        else if (currentState == States.window)
        {
            Window();
        }
        else if (currentState == States.cellDoor)
        {
            CellDoor();
        }
        else if (currentState == States.insult)
        {
            Insult();
        }
        else if (currentState == States.search)
        {
            Search();
        }
        else if (currentState == States.bribeCellDoor)
        {
            GuardBribe();
        }
        else if (currentState == States.bribeWindow)
        {
            BribeKid();
        }
        else if(currentState == States.call)
        {
            SnottyKid();
        }
        else if (currentState == States.sleep)
        {
            Sleep();
        }
        else if (currentState == States.escape)
        {
            Escape();
        }
    } 
    private void Cell() {
        titleObject.text = "Bad Beginnings";
        textObject.text = "You are in a Jail cell. It's dirty, disgusting and smells revolting. \n" +
            "You are trying to escape, look all around and find a way. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "Press W for Widnow, G for Gate, B for Bed. \n";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Bed() {
        titleObject.text = "OH! That's nasty";
        textObject.text = "You go the bed. IF you could call it a bed. \n" +
            "The mattress is thin at best and stinks, and there are some odd stains. \n" +
            "Sleep or search the bed at the risk of your own health.\n" +
            "Press W to go to the window, S to search, N to sleep, G to look at the gate.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.N)) { currentState = States.sleep; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.search; }
    }
    private void Window()
    {
        titleObject.text = "That's a lot of people";
        textObject.text = "You look outside through a small window to a busy street.\n" +
            "No one looks at you, they just move on in hordes.\n" +
            "You spy a kid on the street. hopefully, with no respect for Law.\n" +
            "Like you.\n" +
            "If you call to him, maybe he can help. Or maybe not.\n" +
            "Press C to call to him, G for the Gate and B to go the the Bed";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.call; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void CellDoor()
    {
        titleObject.text = "Can i get some Rum please?";
        textObject.text = "You're infront of cell door. \n" +
            "Not much here, to be honest.\n" +
            " You can see the guardsman on patrol. That's about it.\n" +
            "You notice the lock is easily pickable. Only if you had a lock pick.\n" +
            "A Guardsman passes. \n" +
            "Moving on, Press B for the Bed, W for the Window, \n" +
            "and I to insult the passing Guard.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.I)) { currentState = States.insult; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Insult()
    {
        titleObject.text = "Your Mother was a Hamster!";
        textObject.text = "The Guardsman stabs you without hesitation.\n" +
            "You took a calculate risk, but man, \n" +
            "you suck at math. You'r dead.\n" +
            "Press C to go the beginning Cell. \n" +
            "Try not to do that again.";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void Search()
    {
        titleObject.text = "THAT'S really nasty";
        textObject.text = "You riffled through the bed and found . . .\n" +
            "Oh hey, a gold coint!\n" +
            "maybe you can bribe someone!\n" +
            "Maybe the guard or a kid at the window\n" +
            "Pess G for the Cell Door, W for the Window.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.bribeWindow; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.bribeCellDoor; }

    }
    private void GuardBribe()
    {
        titleObject.text = "Guess what i got . . .";
        textObject.text = "You wait for a passing guard and try to bribe him. \n" +
            "he responds by stabbing you with a spear and taking the coin anyway.\n" +
            "Smooth move Ex Lax.\n" +
            "Press C to start againt.";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void BribeKid()
    {
        titleObject.text = "Kid, do me a solid . . .";
        textObject.text = "You call for a kid and one comes over. \n" +
            "You offer them the gold coint for a lock pick.\n" +
            "The kind snatches the coin and says you got a deal.\n" +
            "It took until Nightfall until you got the lock pick.\n" +
            "The lock was trivial at best and you quickly heard a *click*.\n" +
            "Free at last you swung the bear door open and ran . . .\n" +
            "Into a guards sword. You died. Better luck next time mate.\n" +
            "Press C to start over again.";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
    }
    private void SnottyKid()
    {
        titleObject.text = "You get back here or so help me!";
        textObject.text = "You call for the kid to come over.\n" +
            "Surprisingly he actually listened.\n" +
            "You ask for help, a lock pick or \n" +
            "something you can use to pick a lock.\n" +
            "You're told unless you got money, no.\n" +
            "You tell him you don't havae none and he walks off.\n" +
            "That was totally useless.\n" +
            "Press G to check the Cell Door\n" +
            "press B to check the Bed";
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.cellDoor; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Sleep()
    {
        titleObject.text = "Are you strying to get Disease?!";
        textObject.text = "You lie down on the bed, risking your\n" +
            "health for a few winks of sleep. But just \n " +
            "Before you fell asleep, you see words on the cieling.\n" +
            "\"Lift the cell door up to escape, the \n" +
            "hinges are absolute rubbish. Good luck\" \n" +
            "You smile. Looks like you found your way out.\n" +
            "Press E to escape.";
        if (Input.GetKeyDown(KeyCode.E)) { currentState = States.escape; } 
    }
    private void Escape()
    {
        titleObject.text = "Be free little one";
        textObject.text = "You wait until Night has fallen.\n" +
        "You lift the cell door and as the message \n" +
        "said, the hinges are absolute rubbish.\n" +
        "You carefully replace the door and sneak\n" +
        "off into the night. You have escaped.";
    }
}
