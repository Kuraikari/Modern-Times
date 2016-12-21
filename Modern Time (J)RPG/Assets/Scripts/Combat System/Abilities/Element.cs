using UnityEngine;
using System.Collections;
using System;

public abstract class Element{

    private int id;
    private string element;

    public Element(int id, string element)
    {
        this.id = id;
        this.element = element;
    }

    public Element()
    {
        this.id = -1;
    }

    //Getters
    public int getID() { return id; }
    public string getElement() { return element; }

    //Setters
    public void setID(int id) { this.id = id; }
    public void setElement(string element) { this.element = element; }

    //Methods
    public abstract void thisHitsElement(Element el1);

}

public class Fire : Element
{
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Water : Element
{
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Nature : Element
{
    //***************
    //Nature
    //***************
    //Nature > Electro
    //Nature > Ice
    //Nature > Water
    //Nature = Holy
    //Nature = Metal
    //Nature < Air
    //Nature < Dark
    //Nature < Fire
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Air : Element
{
    //***************
    //Air
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Electro : Element
{
    //***************
    //Electro
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Dark : Element
{
    //***************
    //Dark
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Holy : Element
{
    //***************
    //Air
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Metal : Element
{
    //***************
    //Air
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}

public class Ice : Element
{
    //***************
    //Air
    //***************
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
    public override void thisHitsElement(Element el1)
    {
        throw new NotImplementedException();
    }
}
