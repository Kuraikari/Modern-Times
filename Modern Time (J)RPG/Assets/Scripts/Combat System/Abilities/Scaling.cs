using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling {

    private int m_id;
    private Scaling m_type;
 

	public Scaling(int id, Scaling type)
    {
        this.m_id = id;
        this.m_type = type;
    }

    public Scaling()
    {
        m_id = 1;
    }

    //Getters
    public int getID() { return m_id; }
    public Scaling getType() { return m_type; }

    //Setters
    public void setID(int id) { this.m_id = id; }
    public void setType(Scaling type) { this.m_type = type; }

    //Is it Magical or Physical?
    public bool isMagicalOrPhysical()
    {
        if (m_type is MagicalPower)
            return true;
        else
            return false;
    }

    //Returns
    public PhysicalPower returnPhysical()
    {
        if (m_type is MagicalPower)
            return null;
        else
            return new PhysicalPower();
    }

    public MagicalPower returnMagical()
    {
        if (m_type is MagicalPower)
            return new MagicalPower();
        else
            return null;
    }
}
