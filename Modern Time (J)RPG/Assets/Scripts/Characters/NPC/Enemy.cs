using UnityEngine;
using System.Collections;

public class Enemy : NonPlayerCharacter
{
    public int id;
    public new string name;
    public float givenEXP;
    public new int level;

    public Enemy(int id, string name, float givenEXP, float health, float level) :base(id, name ,false)
    {
        
    }

    public float calcEXPOut()
    {
        float expOut;
        expOut = givenEXP * (level * 0.75f) / 2.5f;


        return expOut;
    }

}
