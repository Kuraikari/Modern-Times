using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PhysicalPower : Scaling {

    public float pp;

    public PhysicalPower(float pp)
    {
        this.pp = pp;
    }

    public PhysicalPower()
    {
        this.pp = 0;
    }

    //getters
    public float getPP() { return pp; }

    //setters
    public void setPP(float pp) { this.pp = pp; }

}
