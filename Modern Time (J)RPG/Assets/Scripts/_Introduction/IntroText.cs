using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {

    public string speaker;
    public Intro ir;
    public Text textField;

    public void createIntro()
    {
        //Create Intro Text
        ir.newTxt("Hello, there");
        ir.newTxt("Welcome to the world of Modern Times!");
        ir.newTxt("My name is Jirou Youyaka, I'm currently the mayor of a small town and I'm here to introduce you to this world.");
        ir.newTxt("We were watching you for a long time, Hyuuga. But due to a software problem with our database we lost some data.");
        ir.newTxt("It would be nice if you could answer our questions to provide us with the missing data. We would appreciate your help.");

        //Create Intro Questions
        ir.newQA("What is your favorite food?", new Interest());
    }


	// Use this for initialization
	void Start () {
        createIntro();
    
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("OutputText").GetComponentInChildren<Text>().text = ir.introTexts[0];

    }
}

