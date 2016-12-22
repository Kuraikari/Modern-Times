using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour {

    //Abilities
    public List<AttackAbillity> attackAbility;
    public List<SupportAbillity> supportAbility;
    public List<GlobalAbillity> globalAbility;

    //Statuses
    public List<Status> abilStatus;

    public Character chara;

    public float outputDMG;

	// Use this for initialization
	void Start () {
		
	}

    public void loadAbilities()
    {
        Serializer.Load<List<Status>>("statuses.txt");
        Serializer.Load<List<AttackAbillity>>("attacks.txt");
        Serializer.Load<List<SupportAbillity>>("supports.txt");
        Serializer.Load<List<GlobalAbillity>>("globals.txt");
    }

    public void createEverything()
    {
        createStatuses();
        createAbilities();
    }

    public void createStatuses()
    {
        //Category: Fight over overlapping
        abilStatus.Add(new Status(0, "FIGHT OVERLAPPING", 0));

        //Create Statuses
        abilStatus.Add(new Status(1, "BURN", 0, "COLD WATER"));
        abilStatus.Add(new Status(2, "POISON", 0, "ANTIDOTE"));
        abilStatus.Add(new Status(3, "FROZEN", 0, "WARMTH"));
        abilStatus.Add(new Status(4, "KO", 0, "REVIVE"));

        //Category: In-Fight only
        abilStatus.Add(new Status(10, "IN-FIGHT ONLY", 20));

        //Create Statuses
        abilStatus.Add(new Status(11, "CONFUSED", 5));
        abilStatus.Add(new Status(12, "STUNNED", 3));
        abilStatus.Add(new Status(13, "FLINCHED", 1));
        abilStatus.Add(new Status(14, "FEARED", 2));

        Serializer.Save<List<Status>>("statuses.txt", abilStatus);
    }

    public void createAbilities()
    {
        //Category
        attackAbility.Add(new AttackAbillity(0, "ATTACK", 0, 10, 50, new Status(), new Scaling()));
        
        //Create Attackabilities
        attackAbility.Add(new AttackAbillity(1, "HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Normal Hit
        attackAbility.Add(new AttackAbillity(2, "PUNCH", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //A Punch
        attackAbility.Add(new AttackAbillity(3, "SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Attack with something sharp
        attackAbility.Add(new AttackAbillity(4, "KICK", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Kick
        attackAbility.Add(new AttackAbillity(5, "SLAM", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Slam with the body
        attackAbility.Add(new AttackAbillity(6, "HEADBUTT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Attack with the Head
        attackAbility.Add(new AttackAbillity(7, "BODYSLAM", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Stronger Version of the Slam Attack
        attackAbility.Add(new AttackAbillity(8, "TACKLE", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Weak Attack, ONLY used for untransformed Chars
        attackAbility.Add(new AttackAbillity(9, "DOUBLE HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Hits the enemy 2x
        attackAbility.Add(new AttackAbillity(10, "KNUCKLE", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Hit with the knuckles
        attackAbility.Add(new AttackAbillity(11, "SWORD SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //heavy attack with the Sword (For Go-Ken)
        attackAbility.Add(new AttackAbillity(12, "SWORD HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Normal Attack with the back of the Sowrd (For Go-Ken)
        attackAbility.Add(new AttackAbillity(13, "SWORD CUT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Normal Attack withe Blade of the Sword (For Go-Ken)
        attackAbility.Add(new AttackAbillity(14, "STAFF HIT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Only Physical attack for the Miko
        attackAbility.Add(new AttackAbillity(15, "SHORTSWORD CUT", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Kunoichi Attacks fast multiple Times(between 2 and 5)
        attackAbility.Add(new AttackAbillity(16, "SHORTSWORD SLASH", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //Quick and Heavy Attack with the blade.
        attackAbility.Add(new AttackAbillity(17, "BACKHAND KNOCKUP", 0, 10, 50, new Status(), new PhysicalPower(0.5f))); //An attack with the backhand (Kunoichi) can critically hit
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

        Serializer.Save<List<AttackAbillity>>("attacks.txt", attackAbility);
        Serializer.Save<List<SupportAbillity>>("supports.txt", supportAbility);
        Serializer.Save<List<GlobalAbillity>>("globals.txt", globalAbility);
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
