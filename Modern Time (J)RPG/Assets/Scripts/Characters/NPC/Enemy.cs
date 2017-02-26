using UnityEngine;
using System.Collections;


/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the Enemy class. Here is everything related to the enemies'  *
 * logic. Some things still need to changed though...                   *
 ************************************************************************/

 [System.Serializable]
public class Enemy : NonPlayerCharacter
{
    public float givenEXP;
    public float baseHealth;

    public AbilityManager am = new AbilityManager(); 

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
