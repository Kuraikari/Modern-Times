using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling {

    private int m_id;
    private string m_type;

	public Scaling(int id, string type)
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
    public string getType() { return m_type; }

    //Setters
    public void setID(int id) { this.m_id = id; }
    public void setType(string type) { this.m_type = type; }
}
