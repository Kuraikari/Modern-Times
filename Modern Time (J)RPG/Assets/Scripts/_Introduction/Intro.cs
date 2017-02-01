using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Intro
{
    public List<string> introTexts = new List<string>();
    public Dictionary<string, System.Object> introQA = new Dictionary<string, System.Object>();
    public void newTxt(string text) {
        introTexts.Add(text);
    }

    public void newQA(string quest, System.Object answer)
    {
        introQA.Add(quest, answer);
    }
}
