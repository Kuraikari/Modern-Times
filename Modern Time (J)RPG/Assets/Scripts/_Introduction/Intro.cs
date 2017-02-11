using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Intro
{
    public List<string> introTexts = new List<string>();
    public Dictionary<string, List<Interest>> introQA = new Dictionary<string, List<Interest>>();
    public void newTxt(string text) {
        introTexts.Add(text);
    }

    public void newQA(string quest, List<Interest> answer)
    {
        introQA.Add(quest, answer);
    }
}
