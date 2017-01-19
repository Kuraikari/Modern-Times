using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomicManager : MonoBehaviour {

    
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Creations
    public List<Country> createCountries()
    {
        List<Country> countries = new List<Country>();

        //Countries
        countries.Add(new Country(0, "COUNTRY", new List<City>(), new Currency() ));

        countries.Add(new Country(1, "JAPAN", createCitiesJapan(), retCurrencyByIndex(1)));
        countries.Add(new Country(2, "USA", createCitiesUSA(), retCurrencyByIndex(2)));
        countries.Add(new Country(3, "FRANCE", createCitiesFrance(), retCurrencyByIndex(3)));
        countries.Add(new Country(4, "ENGLAND", createCitiesEngland(), retCurrencyByIndex(4)));
        countries.Add(new Country(5, "SWITZERLAND", createCitiesSwitzerland(), retCurrencyByIndex(5)));

        return countries;
    }

    public List<Currency> createCurrencies()
    {
        List<Currency> currencies = new List<Currency>();
        currencies.Add(new Currency(0, "EXCHANGE", 1));

        currencies.Add(new Currency(1, "YEN", 100));
        currencies.Add(new Currency(2, "DOLLAR", 1));
        currencies.Add(new Currency(3, "EURO", 1));
        currencies.Add(new Currency(4, "POUNDS", 1));
        currencies.Add(new Currency(5, "CHF", 1));

        return currencies;
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


    //Returns
    public Currency retCurrencyByIndex(int id)
    {
        List<Currency> curs = createCurrencies();
        Currency cur = curs.Find(x => x.id.Equals(id));
        return cur;
    }

    

}
