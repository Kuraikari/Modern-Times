using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neutral : States
{

    public bool isActive;
    public float malus;

    public bool checkActive()
    {
        if (getName() == "Neutral")
            isActive = true;
        else
            isActive = false;

        return isActive;
    }

    public override void makeBonusMalus()
    {
        if (checkActive() == true)
        {
            malus = UnityEngine.Random.Range(-1, 1);

        }
    }

}