﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExchangeRate {

    public int id;
    public string name;
    public float value;

    public ExchangeRate()
    {
        id = -1;
    }

    //Getters
    public int getID() { return id; }
    public string getName() { return name; }
    public float getValue() { return value; }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setName(string name) { this.name = name; }
    public void setValue(float value) { this.value = value; }

    //Methods
    public float compareCurrency(Currency c1, Currency c2)
    {
        
        return value;
    }
}
