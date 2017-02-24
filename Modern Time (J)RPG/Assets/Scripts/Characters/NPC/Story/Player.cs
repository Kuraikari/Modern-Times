using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : Character {

    TechnicalFunctions tech;

    public Transformation transform;
    bool isTransformed;

    public Player()
    {
        name = "Hyuuga Nyagashiki";
        health = 200;
        experience = 0;
        level = 0;
        magicalPower = 0;
        physicalPower = 0;
    }

 
    public void setPlayerName()
    {
        //GameObject whatIsYourName = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "What is your name?", 16, Color.black);
        //setName(Input.inputString);
        //whatIsYourName.SetActive(false);
        //GameObject areYouSure = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "Are you sure?", 16, Color.black);

        //GameObject yes = tech.CreateButton(GameObject.Find("Canvas").transform, 35, 80, 30, 30, new Button.ButtonClickedEvent());
        
        //GameObject no = tech.CreateButton(GameObject.Find("Canvas").transform, 70, 80, 30, 30, new Button.ButtonClickedEvent());
    }

}
