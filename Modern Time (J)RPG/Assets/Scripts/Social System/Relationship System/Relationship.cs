using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relationship {

    private int m_id;
    public Character personA;
    public Character personB;
    public States state;
    public float value;

    public Relationship(Character personA, Character personB, States state, float value)
    {
        newID();
        this.personA = personA;
        this.personB = personB;
        this.state = state;
        this.value = value; 
    }
    public Relationship(Character personA, Character personB)
    {
        newID();
        this.personA = personA;
        this.personB = personB;
    }
    public Relationship()
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
    public Character getPersonA() { return personA; }
    public Character getPersonB() { return personB; }
    public States getSate() { return state; }
    public float getValue() { return value; } 

    //Setters
    public void getPersonA(Character personA) { this.personA = personA; }
    public void getPersonB(Character personB) { this.personB = personB; }
    public void getSate(States state) { this.state = state; }
    public void getValue(float value) { this.value = value; }
}
