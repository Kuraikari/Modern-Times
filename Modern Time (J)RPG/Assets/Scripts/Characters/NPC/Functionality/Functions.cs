using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions {

    int id;
    string speciality;
    Functions func;

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
    int getID() { return id; }
    string getSpeciality() { return speciality; }
    Functions getFunction() { return func; }

    //Setters
    void setID(int id) { this.id = id; }
    void setSpeciality(string speciality) { this.speciality = speciality; }
    void setFunction(Functions func) { this.func = func; }
}
