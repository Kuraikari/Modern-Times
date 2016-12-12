using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the super Class for all the complicated States               *
 * There are alot so beware of entering this dangerous place, mate!     *
 ************************************************************************/

public class States {

    //Attributes
    private int m_id;
    public string name;
    public States state;

    //Constructors
    public States(string name, States state)
    {
        newID();
        this.name = name;
        this.state = state;
    } 

    public States()
    {
        m_id = -1;
    }

    //Dynamic ID
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
    public States getState() { return state; }

    //Setters
    public void setName(string name) { this.name =  name; }
    public void setState(States state) { this.state =  state; }


}
