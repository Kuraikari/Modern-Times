using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {

    public string speaker;
    public Intro ir;
    public Text textField;
    public SocialManager sm = new SocialManager();

    private List<Interest> interests = new List<Interest>();
    private List<string> keyList;
    private int counter = 0;
    private int counter2 = 0;

    public void createIntro()
    {
        //Create Intro Text
        ir.newTxt("Hello, there");
        ir.newTxt("Welcome to the world of Modern Times!");
        ir.newTxt("My name is Jirou Youyaka, I'm currently the mayor of a small town and I'm here to introduce you to this world.");
        ir.newTxt("We were watching you for a long time, Hyuuga. But due to a software problem with our database we lost some data.");
        ir.newTxt("It would be nice if you could answer our questions to provide us with the missing data. We would appreciate your help.");
    }

    public void createQA()
    {
        sm.createInterests();
        interests.InsertRange(0, sm.interests);

        //Create Intro Questions
        ir.newQA("What is your favorite food?", interests.FindAll(x => x.category.Contains("FOOD")));
        ir.newQA("What is your favorite drink?", interests.FindAll(x => x.category.Contains("DRINKS")));
        ir.newQA("What is your favorite sport?", interests.FindAll(x => x.category.Contains("SPORTS")));
        ir.newQA("What is your favorite martial art?", interests.FindAll(x => x.category.Contains("MARTIAL ARTS")));
        ir.newQA("What is your favorite artcraft?", interests.FindAll(x => x.category.Contains("ARTCRAFT")));
        ir.newQA("What is your favorite movie genre?", interests.FindAll(x => x.category.Contains("MOVIE")));
        ir.newQA("What is your favorite anime?", interests.FindAll(x => x.category.Contains("ANIME")));
        ir.newQA("What is your favorite manga?", interests.FindAll(x => x.category.Contains("MANGA")));
        ir.newQA("What is your favorite book?", interests.FindAll(x => x.category.Contains("BOOKS")));
        ir.newQA("What is your favorite game?", interests.FindAll(x => x.category.Contains("GAMES")));
    }


	// Use this for initialization
	void Start () {
        keyList = new List<string>(ir.introQA.Keys);
        createIntro();
        createQA();
	}

    public List<Dropdown.OptionData> createOptionList()
    {
        List<Dropdown.OptionData> opdata = new List<Dropdown.OptionData>();
        foreach (var i in ir.introQA)
        {
            opdata.Add(new Dropdown.OptionData(i.Key));
        }

        return opdata;
    }
	
	// Update is called once per frame
	void Update () {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject.Find("OutputText").GetComponentInChildren<Text>().text = ir.introTexts[counter];
                counter++;

                if (counter >= ir.introTexts.Count)
                    counter = -100;   
               
                GameObject.Find("Dropdown").GetComponent<Dropdown>().options = createOptionList();
            }
        }
    }

