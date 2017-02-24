using UnityEngine;
using System.Collections;

public class Enemy : NonPlayerCharacter
{
    public int id;
    public new string name;
    public float givenEXP;
    public new int level;

    public Enemy(int id, string name, float givenEXP, float health, int level)
    {
        this.id = id;
        this.name = name;
        this.givenEXP = givenEXP;
        this.health = health;
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

}
