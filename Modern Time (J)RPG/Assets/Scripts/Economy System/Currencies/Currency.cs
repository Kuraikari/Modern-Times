using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency {

    public int id;
    public string name;
    public List<ExchangeRate> exR;
    public float value;

    public Currency(int id, string name, List<ExchangeRate> exR, float value)
    {
        this.id = id;
        this.name = name;
        this.exR = exR;
        this.value = value;
    }

    public Currency()
    {
        id = -1;
    }

    //Getters
    public int getID() { return id; }
    public string getName() { return name; }
    public List<ExchangeRate> getExR() { return exR; }
    public float getValue() { return value; }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setExR(List<ExchangeRate> exR) { this.exR = exR; }
    public void setValue(float value) { this.value = value; }

    //Methods
}
