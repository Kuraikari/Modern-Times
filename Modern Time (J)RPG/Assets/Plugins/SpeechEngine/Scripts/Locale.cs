using UnityEngine;
using System.Collections;
using System;
/// <summary>
/// Author : Mamadou Cisse
///  
/// class that represent java.util.Locale object
/// </summary>
[Serializable]
public class Locale
{
    public string name;
    public string language;
    public string country;

    public static Locale FRENCH = new Locale("FRENCH", "fr", "FR");
    public static Locale CANADA_FRENCH = new Locale("CANADA_FRENCH", "fr", "CA");
    public static Locale ENGLISH = new Locale("ENGLISH", "en", "US");
    public static Locale SPANISH = new Locale("SPANISH", "es", "ES");
    public static Locale ITALIAN = new Locale("ITALIAN", "it", "IT");
    public static Locale GERMAN = new Locale("GERMAN", "de", "DE");
    public static Locale CHINESE = new Locale("CHINESE", "zh", "CN");
    public static Locale KOREAN = new Locale("KOREAN", "ko", "KR");

    public Locale(string name, string language, string country)
    {
        this.name = name;
        this.language = language;
        this.country = country;
    }

    /// <summary>
    /// return array of Locale available in java.util.Locale 
    /// </summary>
    /// <returns></returns>
    public static Locale[] AvailableLocales()
    {
        return new Locale[]
        {
                Locale.FRENCH, Locale.CANADA_FRENCH, Locale.ENGLISH, Locale.GERMAN,
                Locale.ITALIAN, Locale.KOREAN, Locale.CHINESE
         };
    }

    /// <summary>
    /// return the Locale object whith this name in parameter 
    /// </summary>
    /// <param name="name">the name of the Locale object to find</param>
    /// <returns>a Locale object </returns>
    public static Locale WhithName(string name)
    {
        if (SPANISH.name == name)
            return SPANISH;

        foreach (Locale l in AvailableLocales())
        {
            if (l.name == name)
                return l;
        }

        return null;
    }

    public static bool Contains(Locale locale)
    {
        foreach (Locale l in AvailableLocales())
        {
            if (l.name == locale.name)
                return true;
        }
        return false;
    }

    public override string ToString()
    {
        return name;
    }

}

