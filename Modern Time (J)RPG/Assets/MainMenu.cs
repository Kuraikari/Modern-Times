using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //**************************************
    //For the toolbar
    int toolbarINT = 0;
    string[] toolbarStrings = new string[] { "Team", "Inventory", "Relationships","Profile", "Settings", "Exit" };
    //buttons
    bool menuButton = true;
    //**************************************


    // Use this for initialization
    void Start ()
    {
           
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.P))
            menuButton = !menuButton;
		
	}

    private void OnGUI()
    {
        GUI.backgroundColor = Color.black;
        GUI.contentColor = Color.white;

        
        menuButton = GUI.Toggle(new Rect(630, 30, 30, 30), menuButton ,"...");

        if (menuButton == false)
        {
            
            toolbarINT = GUI.Toolbar(new Rect(25, 25, 550, 30), toolbarINT, toolbarStrings);

            switch (toolbarINT)
            {
                case 0:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                case 1:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                case 2:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                case 3:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                case 4:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                case 5:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
                default:
                    Console.WriteLine(toolbarStrings[toolbarINT]);
                    break;
            }
        }
        
    }
}
