using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Intro
{
    public List<string> introTexts = new List<string>();
    public Dictionary<string, string> introQA = new Dictionary<string, string>();
    public void newTxt(string text) {
        introTexts.Add(text);
    }

    public void newQA(string quest, string answer)
    {
        introQA.Add(quest, answer);
    }
}
