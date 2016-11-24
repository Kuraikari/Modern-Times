using UnityEngine;
using System.Collections;

public class Abillity {

    //attributes
    public uint id;
    public string name;
    public float castTime;
    public uint abillitypoints; //Same as PKMs PP
    public Abillity categorie;
    

    //constructors
    public Abillity(uint id, string name, float castTime, uint ap, Abillity cat)
    {
        this.id = id;
        this.name = name;
        this.castTime = castTime;
        this.abillitypoints = ap;
        this.categorie = cat;
    }

    public Abillity()
    {
        id = 0;
    }

    //methods

        //getters
    public uint getID() { return id; }
    public string getName() { return name; }
    public float getCastTime() { return castTime; }
    public uint getAP() { return abillitypoints; }
    public Abillity getAbillity() { return categorie; }


        //setters
    public void setID(uint id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setCastTime(float castTime) { this.castTime = castTime; }
    public void setAP(uint ap) { this.abillitypoints = ap; }
    public void setAbillity(Abillity ab) { this.categorie = ab; }
}
