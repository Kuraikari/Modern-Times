﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* This codesnippet has the purpose to create the logic for the damaging Abillities. 
 * Which are more or less simpler than the later coming support Abillities.*/

[System.Serializable]
public class AttackAbillity : Abillity {

    //attributes
    public int damage;
    public Status status;
    public Scaling scaling;
    


    //constructors
    public AttackAbillity(uint id, string name, int castTime, uint ap, int dmg, Status status, Scaling scaling)
    {
        this.id = id;
        this.name = name;
        this.castTime = castTime;
        this.abillitypoints = ap;
        this.damage = dmg;
        this.status = status;
        this.scaling = scaling;
    }

    public AttackAbillity()
    {
        id = 1;
    }

    //Getters
    public int getDamage() { return damage; }
    public Status getStatus() { return status; }
    public Scaling getScaling() { return scaling; }

    //Setters
    public void setDamage(int dmg) { damage = dmg; }
    public void setStatus(Status stat) { status = stat; }
    public void setScaling(Scaling scaling) { this.scaling = scaling;}

}
