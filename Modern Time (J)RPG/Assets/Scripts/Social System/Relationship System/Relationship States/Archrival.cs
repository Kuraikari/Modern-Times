using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archrival : States {

    public bool isActive;
    public float malus;

    public bool checkActive()
    {
        if (getName() == "Archrival")
            isActive = true;
        else
            isActive = false;

        return isActive;
    }

    public override void makeBonusMalus()
    {
        if (checkActive() == true)
        {
            malus = UnityEngine.Random.Range(-15, -20);

        }
    }

}
