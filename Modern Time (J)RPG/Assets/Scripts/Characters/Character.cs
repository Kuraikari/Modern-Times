using UnityEngine;
using System.Collections;

/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the super Class for every freakin' Character, even the       *
 * player get's involved with this one... Have fun encrypting this      *
 ************************************************************************/
public class Character {

    //Attributes
    private int m_id;
    public string name;
    public Character type;

    //Constructors
    public Character(string name, Character type)
    {
        newID();
        this.name = name;
        this.type = type;
    }

    public Character()
    {
        m_id = -1;
    }

    //Dynamic ID (^-^)/ 
    public int newID()
    {
        if (m_id < 0)
            m_id = 0;
        else
            m_id++;

        return m_id;
    }
    
    //Getters 
    public string getName() { return name; }
    public Character getType() { return type; }

    //Setters
    public void setName(string name) { this.name = name; }
    public void setType(Character type) { this.type =  type; }
}
