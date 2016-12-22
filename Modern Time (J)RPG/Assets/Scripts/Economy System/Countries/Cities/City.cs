using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City  {

    //Attributs
    public int id;
    public string name;
    public bool capital;
    


    public City(int id, string name, bool isCapital)
    {
        this.id = id;
        this.name = name;
        capital = this.isCapital(isCapital);
    }

    public City()
    {
        id = -1;
    }


    //Getters
    public int getID() { return id; }
    public string getName() { return name; }


    //Setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }

    //Issers xD
    public bool isCapital(bool yesno) { if (yesno == true) return true; else return false; }
}
