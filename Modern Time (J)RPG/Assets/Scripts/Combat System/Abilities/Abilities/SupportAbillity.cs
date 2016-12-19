using UnityEngine;
using System.Collections;

public class SupportAbillity : Abillity {

    //attributes
    public AbilityFunctions func;
    public Status status;
    public Scaling scaling;



    //constructors
    public SupportAbillity(uint id, string name, float castTime, uint ap, AbilityFunctions func, Status status)
    {
        this.id = id;
        this.name = name;
        this.castTime = castTime;
        this.abillitypoints = ap;
        this.func = func;
        this.status = status;
    }

    public SupportAbillity()
    {
        id = 1;
    }

    //Getters
    public AbilityFunctions getFunction() { return func; }
    public Status getStatus() { return status; }

    //Setters
    public void setFunction(AbilityFunctions func) { this.func = func; }
    public void setStatus(Status stat) { status = stat; }
}
