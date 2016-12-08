using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalPower : Scaling {

    float pp;

    public PhysicalPower(float pp)
    {
        this.pp = pp;
    }

    //getters
    public float getPP() { return pp; }

    //setters
    public void setPP(float pp) { this.pp = pp; }

}
