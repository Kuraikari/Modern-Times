using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country {

    //Attributs
    public int id;
    public string name;
    public List<City> cities;
    public Currency currency;

    public Country(int id, string name, List<City> cities, Currency currency)
    {
        this.id = id;
        this.name = name;
        this.cities = cities;
        this.currency = currency;
    }

    public Country()
    {
        id = -1;
    }

    int capitalCityINT;

    //Getters
    public int getID() { return id; }
    public string getName() { return name; }
    public List<City> getCityList() { return cities; }
    public Currency getCurrency() { return currency; }

    //Setters
    public void setID(int id) { this.id = id;  }
    public void setName(string name) { this.name = name; }
    public void setCityList(List<City> cities) { this.cities = cities; }
    public void setCurrency(Currency currency) { this.currency = currency; }

    //Methods
    public string[] getCityNames(List<City> cities)
    {
        string[] cityNames = new string[cities.Count];
        for (int x = 0; x < cities.Count; )
        {
            cityNames[x] = cities[x].name;
        }

        return cityNames;
    }

}
