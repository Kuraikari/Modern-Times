using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : Character {

    TechnicalFunctions tech;

    public Player()
    {

    }

 
    public void setPlayerName()
    {
        GameObject whatIsYourName = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "What is your name?", 16, Color.black);
        setName(Input.inputString);
        whatIsYourName.SetActive(false);
        GameObject areYouSure = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "What is your name?", 16, Color.black);
        bool yesButton, noButton;
        yesButton = GUI.Button(new Rect(100, 100, 100, 50), "Yes!");
        noButton = GUI.Button(new Rect(100, 100, 100, 50), "No!");
    }

}
