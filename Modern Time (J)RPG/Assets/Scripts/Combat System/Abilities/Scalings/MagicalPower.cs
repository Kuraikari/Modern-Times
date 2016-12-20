using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalPower : Scaling  {

    public float mp;

    public MagicalPower(float mp)
    {
        this.mp = mp;
    }

    //Getters
    public float getMP() { return mp; }

    //Setters
    public void setMP(float mp) { this.mp = mp; }


}
