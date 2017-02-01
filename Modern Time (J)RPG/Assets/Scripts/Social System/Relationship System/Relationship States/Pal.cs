using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pal : States
{

    public bool isActive;
    public float bonus;

    public bool checkActive()
    {
        if (getName() == "Pal")
            isActive = true;
        else
            isActive = false;

        return isActive;
    }

    public override void makeBonusMalus()
    {
        if (checkActive() == true)
        {
            bonus = UnityEngine.Random.Range(5, 10);

        }
    }

}
