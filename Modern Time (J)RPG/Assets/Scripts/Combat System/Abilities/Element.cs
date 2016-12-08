using UnityEngine;
using System.Collections;

public class Element{

    private int id;
    private string element;
    private static string[] types = { "Fire", "Water", "Nature", "Air", "Electro", "Dark", "Holy", "Metal", "Ice" };

    public Element(int id, string element)
    {
        this.id = id;
        this.element = element;
    }
    //***************
    //FIRE
    //***************
    //Fire > Metal
    //Fire > Ice 
    //Fire = Air
    //Fire = Electro
    //Fire = Dark
    //Fire = Holy
    //Fire < Water
    //Fire < Nature
    //***************
    //Water
    //***************
    //Water > Nature
    //Water > Fire
    //Water = Metal
    //Water = Dark
    //Water = Holy
    //Water = Air
    //Water < Ice
    //Water < Electro
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //


}
