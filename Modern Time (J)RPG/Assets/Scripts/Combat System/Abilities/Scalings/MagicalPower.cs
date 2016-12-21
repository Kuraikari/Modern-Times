using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalPower : Scaling  {

    public float mp;

    public MagicalPower(float mp)
    {
        this.mp = mp;
    }

    public MagicalPower()
    {
        mp = 0;
    }

    //Getters
    public float getMP() { return mp; }

    //Setters
    public void setMP(float mp) { this.mp = mp; }


}
