using UnityEngine;
using System.Collections;

public class Element{

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
}

public class Electro
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

}

public class Dark : Element
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

}