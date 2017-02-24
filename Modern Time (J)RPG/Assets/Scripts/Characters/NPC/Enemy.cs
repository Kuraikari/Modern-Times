using UnityEngine;
using System.Collections;

public class Enemy : NonPlayerCharacter
{
    public int id;
    public new string name;
    public float givenEXP;
    public new int level;
    public float baseHealth;

    public Enemy(int id, string name, float givenEXP, int level)
    {
        this.id = id;
        this.name = name;
        this.givenEXP = givenEXP;
        this.baseHealth = healthScaling();
        this.level = level;
    }

    public Enemy()
    {
        id = -1;
    }

    public float calcEXPOut()
    {
        float expOut;
        expOut = givenEXP * (level * 0.75f) / 2.5f;

        return expOut;
    }

    public float healthScaling()
    {
        float healthscaled = baseHealth + (level * (baseHealth/10));
        return healthscaled;
    }

}
