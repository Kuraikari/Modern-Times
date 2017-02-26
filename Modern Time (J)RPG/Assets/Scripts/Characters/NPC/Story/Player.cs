using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the Player class. Here is everything related to the player's *
 * logic. Some things still need to changed though...                   *
 ************************************************************************/

[System.Serializable]
public class Player : Character {

    TechnicalFunctions tech;
    AbilityManager am = new AbilityManager();

    public Transformation transform;
    public bool isTransformed;
    public List<Abillity> abilities = new List<Abillity>();

    public Player()
    {
        name = "Hyuuga Nyagashiki";
        health = 200;
        experience = 0;
        level = 1;
        magicalPower = 0;
        physicalPower = 0;
    }

    public void setAbilities()
    {
        
        abilities.Add(am.attackAbility.Find(x => x.name.Contains("HIT")));
        abilities.Add(am.attackAbility.Find(x => x.name.Contains("PUNCH")));
        abilities.Add(am.attackAbility.Find(x => x.name.Contains("KICK")));
        abilities.Add(am.attackAbility.Find(x => x.name.Contains("TACKLE")));
    }

    public void learnNewAbility(string abName)
    {
        if (abilities.Count == 4)
        {
            Console.Out.WriteLine("You already have the maximum count of abilities!");
            Console.Out.WriteLine("For learning the new skill, you need to forget one.");
            Console.Out.WriteLine("Do you want to forget an old Ability to learn this one?");
        }
        else
        {
            abilities.Add(am.attackAbility.Find(x => x.name.Contains(abName)));
        }
    }


    public void setPlayerName()
    {
        //GameObject whatIsYourName = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "What is your name?", 16, Color.black);
        //setName(Input.inputString);
        //whatIsYourName.SetActive(false);
        //GameObject areYouSure = tech.CreateText(GameObject.Find("Canvas").transform, 50, 50, "Are you sure?", 16, Color.black);

        //GameObject yes = tech.CreateButton(GameObject.Find("Canvas").transform, 35, 80, 30, 30, new Button.ButtonClickedEvent());
        
        //GameObject no = tech.CreateButton(GameObject.Find("Canvas").transform, 70, 80, 30, 30, new Button.ButtonClickedEvent());
    }

}
