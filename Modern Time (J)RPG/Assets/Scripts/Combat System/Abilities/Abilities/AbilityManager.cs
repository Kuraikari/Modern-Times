using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour {

    public List<Abillity> abil;

	// Use this for initialization
	void Start () {
		
	}

    public void createAbilities()
    {
        //Category
        abil.Add(new AttackAbillity(0, "ATTACK", 0, 10, 50, new Status()));
        
        //Create Attackabilities
        abil.Add(new AttackAbillity(1, "HIT", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(2, "PUNCH", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(3, "SLASH", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(4, "KICK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(5, "SLAM", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(6, "HEADBUTT", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(7, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(8, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(9, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(10, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(11, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(12, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(13, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(14, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(15, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(16, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(17, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(18, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(19, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(20, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(21, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(22, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(23, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(24, "ATTACK", 0, 10, 50, new Status()));

        //Category
        abil.Add(new SupportAbillity(50, "SUPPORT", 0, 10, new AbilityFunctions(), new Status()));

        //Create SupportAbilties
        abil.Add(new AttackAbillity(51, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(52, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(53, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(54, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(55, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(56, "ATTACK", 0, 10, 50, new Status()));

        //Category
        abil.Add(new GlobalAbillity(70, "GLOBAL", 0, 10, new AbilityFunctions(), new Status()));

        //Create GlobalAbilities
        abil.Add(new AttackAbillity(71, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(72, "ATTACK", 0, 10, 50, new Status()));
        abil.Add(new AttackAbillity(73, "ATTACK", 0, 10, 50, new Status()));

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
