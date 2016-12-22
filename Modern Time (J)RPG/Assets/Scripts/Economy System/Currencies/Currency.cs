using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency {

    public int id;
    public string name;
    public ExchangeRate exR;
    public float value;



    public Currency()
    {
        id = -1;
    }

    //Getters
    public int getID() { return id; }
    public string getName() { return name; }
    public ExchangeRate getExR() { return exR; }
    public float getValue() { return value; }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setExR(ExchangeRate exR) { this.exR = exR; }
    public void setValue(float value) { this.value = value; }

    //Methods
}
