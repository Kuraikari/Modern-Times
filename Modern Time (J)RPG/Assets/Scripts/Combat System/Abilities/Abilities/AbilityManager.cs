using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour {

    public List<AttackAbillity> attackAbility;
    public List<SupportAbillity> supportAbility;
    public List<GlobalAbillity> globalAbility;

    public Character chara;

    public float outputDMG;

	// Use this for initialization
	void Start () {
		
	}

    public void createAbilities()
    {
        //Category
        attackAbility.Add(new AttackAbillity(0, "ATTACK", 0, 10, 50, new Status(), new Scaling()));
        
        //Create Attackabilities
        attackAbility.Add(new AttackAbillity(1, "HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(2, "PUNCH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(3, "SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(4, "KICK", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(5, "SLAM", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(6, "HEADBUTT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(7, "BODYSLAM", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(8, "TACKLE", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(9, "DOUBLE HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(10, "KNUCKLE", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(11, "SWORD SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(12, "SWORD HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(13, "SWORD CUT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(14, "STAFF HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(15, "SHORTSWORD CUT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(16, "SHORTSWORD SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(17, "BACKHAND KNOCKUP", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(18, "ROUNDHOUSE KICK", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(19, "STOMP", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(20, "FORCE PUNCH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(21, "POWER SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(22, "TRIPLE KICK", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(23, "MACH HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));
        attackAbility.Add(new AttackAbillity(24, "JUMP KICK", 0, 10, 50, new Status(), new PhysicalPower(0.5f)));

        //Category
        supportAbility.Add(new SupportAbillity(50, "SUPPORT", 0, 10, new AbilityFunctions(), new Status()));

        //Create SupportAbilties
        supportAbility.Add(new SupportAbillity(51, "SHIELD", 0, 10, new AbilityFunctions(), new Status()));
        supportAbility.Add(new SupportAbillity(52, "HEAL", 0, 10, new AbilityFunctions(), new Status()));
        supportAbility.Add(new SupportAbillity(53, "COUNTER", 0, 10, new AbilityFunctions(), new Status()));
        supportAbility.Add(new SupportAbillity(54, "REVERSE", 0, 10, new AbilityFunctions(), new Status()));
        supportAbility.Add(new SupportAbillity(55, "ADAPTIVE SHIELD", 0, 10, new AbilityFunctions(), new Status()));
        supportAbility.Add(new SupportAbillity(56, "SILENCE", 0, 10, new AbilityFunctions(), new Status()));

        //Category
        globalAbility.Add(new GlobalAbillity(70, "GLOBAL", 0, 10, new AbilityFunctions(), new Status()));

        //Create GlobalAbilities
        globalAbility.Add(new GlobalAbillity(71, "QUICK ESCAPE", 0, 10, new AbilityFunctions(), new Status()));
        globalAbility.Add(new GlobalAbillity(72, "HIT & CHANGE", 0, 10, new AbilityFunctions(), new Status()));
        globalAbility.Add(new GlobalAbillity(73, "CLEANSE", 0, 10, new AbilityFunctions(), new Status()));

    }

    public void doAttack(int indexOfAbility)
    {
        int ioA = indexOfAbility;
        for (int x = 1; x < 50; x++)
        {
            if (attackAbility[x].id == ioA)
            {
                Scaling attackScaling = attackAbility[x].scaling;
                if (attackScaling.isMagicalOrPhysical() == true)
                    outputDMG = attackAbility[x].damage + (chara.magicalPower *  attackScaling.returnMagical().mp);
                else
                    outputDMG = attackAbility[x].damage + (chara.physicalPower * attackScaling.returnPhysical().pp);

                break;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
