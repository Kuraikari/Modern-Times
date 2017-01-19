using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions {

    public int id;
    public string speciality;
    public Functions func;

    public Functions(int id, Functions func)
    {
        this.id = id;
        this.func = func;
    }

    public Functions()
    {
        id = -1;
    }

    //Getters
    public int getID() { return id; }
    public string getSpeciality() { return speciality; }
    public Functions getFunction() { return func; }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setSpeciality(string speciality) { this.speciality = speciality; }
    public void setFunction(Functions func) { this.func = func; }
}
