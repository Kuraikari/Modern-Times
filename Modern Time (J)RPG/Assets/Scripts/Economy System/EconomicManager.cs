using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomicManager : MonoBehaviour {

    List<Country> countries;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void createCountries()
    {
        //Countries
        countries.Add(new Country(0, "COUNTRY", new List<City>(), new Currency() ));

        countries.Add(new Country(1, "JAPAN", createCitiesJapan(), new Currency(0, "YEN", new List<ExchangeRate>(), 100)));
        countries.Add(new Country(2, "USA", createCitiesUSA(), new Currency(0, "DOLLAR", new List<ExchangeRate>(), 1)));
        countries.Add(new Country(3, "FRANCE", createCitiesFrance(), new Currency(0, "EURO", new List<ExchangeRate>(), 1)));
        countries.Add(new Country(4, "ENGLAND", createCitiesEngland(), new Currency(0, "POUNDS", new List<ExchangeRate>(), 1)));
        countries.Add(new Country(5, "SWITZERLAND", createCitiesSwitzerland(), new Currency(0, "CHF", new List<ExchangeRate>(), 1)));
    }

    public void createExchageRates()
    {

    }

    public List<City> createCitiesJapan()
    {
        List<City> cities = new List<City>();
        cities.Add(new City(0, "TOKYO", true));
        cities.Add(new City(1, "OUSAKA", false));
        cities.Add(new City(2, "KYOTO", false));
        cities.Add(new City(3, "SAPPORO", false));
        cities.Add(new City(4, "OKINAWA", false));

        return cities;
    }

    public List<City> createCitiesUSA()
    {
        List<City> cities = new List<City>();
        cities.Add(new City(0, "WASHINGTON D.C.", true));
        cities.Add(new City(1, "LAS VEGAS", false));
        cities.Add(new City(2, "NEW YORK", false));
        cities.Add(new City(3, "CALIFORNIA", false));
        cities.Add(new City(4, "HOLLYWOOD", false));

        return cities;
    }

    public List<City> createCitiesFrance()
    {
        List<City> cities = new List<City>();
        cities.Add(new City(0, "PARIS", true));
        cities.Add(new City(1, "LYON", false));
        cities.Add(new City(2, "MARSEILLE", false));

        return cities;
    }

    public List<City> createCitiesEngland()
    {
        List<City> cities = new List<City>();
        cities.Add(new City(0, "LONDON", true));
        cities.Add(new City(1, "CAMBRIDGE", false));

        return cities;
    }

    public List<City> createCitiesSwitzerland()
    {
        List<City> cities = new List<City>();
        cities.Add(new City(0, "BERN", true));
        cities.Add(new City(1, "ZURICH", false));
        cities.Add(new City(2, "GENEVA", false));

        return cities;
    }

}
