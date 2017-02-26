using UnityEngine;
using System.Collections;

[System.Serializable]
public class NonPlayerCharacter : Character {

    public int id;
    Functions func;
    bool hasFunction;

    public NonPlayerCharacter(int id, string name, bool hasFunction, Functions func)
    {
        this.id = id;
        this.name = name;
        this.hasFunction = hasFunction;
        this.func = func;

    }

    public NonPlayerCharacter(int id, string name, bool hasFunction)
    {
        this.id = id;
        this.name = name;
        this.hasFunction = hasFunction;

    }

    public NonPlayerCharacter(int id, bool hasFunction)
    {
        this.id = id;
        this.hasFunction = hasFunction;

    }

    public NonPlayerCharacter()
    {

    }

    //Getters
    public int getID() { return id; }
    public Functions getFunc() { return func; }
    public bool hasFunctions() { return hasFunction;  }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setFunc(Functions func) { this.func = func; }
    public void setIfFunction(bool hasFunction) { this.hasFunction = hasFunction; }
}
