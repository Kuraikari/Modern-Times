using UnityEngine;
using System.Collections;

/* This codesnippet has the purpose to create the logic for the damaging Abillities. 
 * Which are more or less simpler than the later coming support Abillities.*/

public class AttackAbillity : Abillity {

    //attributes
    public int damage;
    public Status status;
    public Scaling scaling;
    


    //constructors
    public AttackAbillity(uint id, string name, float castTime, uint ap, int dmg, Status status)
    {
        this.id = id;
        this.name = name;
        this.castTime = castTime;
        this.abillitypoints = ap;
        this.damage = dmg;
        this.status = status;
    }

    public AttackAbillity()
    {
        id = 1;
    }

    //Getters
    public int getDamage() { return damage; }
    public Status getStatus() { return status; }

    //Setters
    public void setDamage(int dmg) { damage = dmg; }
    public void setStatus(Status stat) { status = stat; }

}
