﻿using System;
using UnityEditor;

[System.Serializable]
public class Interest
{
    int id { get; set; }
    string name { get; set; }
    string category { get; set; }

    public Interest()
    {
        id = -1;
    }

    public Interest(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public Interest(int id, string name, string category)
    {
        this.id = id;
        this.name = name;
        this.category = category;
    }

    //getters
    public int getID() { return id; }
    public string getName() { return name; }
    public string getCategory() { return category; }

    //setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setCategory(string cat) { this.category = cat; }

    //Create
    public Interest newInterest(int id, string name)
    {
        int thisID = id;
        string thisName = name;
        return newInterest(thisID, thisName);
    }
}
