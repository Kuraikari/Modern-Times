using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acquaintance : States {

    public bool isActive;
    public float bonus;

    public bool checkActive()
    {
        if (getName() == "Acquaintance")
            isActive = true;
        else
            isActive = false;

        return isActive;
    }

    public override void makeBonusMalus()
    {
        if (checkActive() == true)
        {
            bonus = UnityEngine.Random.Range(1, 5);
            
        }
    }

}
