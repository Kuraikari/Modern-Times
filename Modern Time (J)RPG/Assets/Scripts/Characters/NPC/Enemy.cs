using UnityEngine;
using System.Collections;


/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the Enemy class. Here is everything related to the enemies'  *
 * logic. Some things still need to changed though...                   *
 ************************************************************************/
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
        this.level = level;
        this.baseHealth = healthScaling();
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
