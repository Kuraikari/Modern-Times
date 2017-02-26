using UnityEngine;
using System.Collections;

/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the super Class for every freakin' Character, even the       *
 * player get's involved with this one... Have fun encrypting this      *
 ************************************************************************/

[System.Serializable]
public class Character {

    //Attributes
    public int m_id;
    public string name;
    public Character type;

    //Character Attributes...
    public float health;
    public float experience;
    public float neededEXPForLVLUp;
    public int level;
    public float magicalPower;
    public float physicalPower;

    //Constructors
    public Character(string name, Character type, float health, float exp, int lvl, float mp, float pp)
    {
        newID();
        this.name = name;
        this.type = type;
        this.health = health;
        this.experience = exp;
        this.level = lvl;
        this.magicalPower = mp;
        this.physicalPower = pp;
    }

    public Character(string name, Character type, float exp, int lvl, float mp, float pp)
    {
        newID();
        this.name = name;
        this.type = type;
        this.experience = exp;
        this.level = lvl;
        this.magicalPower = mp;
        this.physicalPower = pp;
        this.health = healthScaling();
    }

    public Character(string name, Character type)
    {
        newID();
        this.name = name;
        this.type = type;
    }

    public Character()
    {
        m_id = -1;
    }

    public float healthScaling()
    {
        float healthscaled = health + (level * (health / 10f));
        return healthscaled;
    }

    public void levelScaling()
    {
        neededEXPForLVLUp *= (Mathf.Sqrt(level) / 1.2f);
    }

    public void checkLVLUp()
    {
        if (experience == neededEXPForLVLUp)
        {
            level++;
        }
    }

    //Dynamic ID (^-^)/ 
    public int newID()
    {
        if (m_id < 0)
            m_id = 0;
        else
            m_id++;

        return m_id;
    }
    
    //Getters 
    public string getName() { return name; }
    public Character getType() { return type; }
    public float getHealth() { return health; }
    public float getExperience() { return experience; }
    public int getLevel() { return level; }
    public float getMagicalPower() { return magicalPower; }
    public float getPhysicalPower() { return physicalPower; }

    //Setters
    public void setName(string name) { this.name = name; }
    public void setType(Character type) { this.type =  type; }
    public void setHealth(float health) { this.health = health; }
    public void setExperience(float experience) { this.experience = experience; }
    public void setLevel(int level) { this.level = level; }
    public void setMagicalPower(float magicalPower) { this.magicalPower = magicalPower; }
    public void setPhysicalPower(float physicalPower) { this.physicalPower = physicalPower; }
}
