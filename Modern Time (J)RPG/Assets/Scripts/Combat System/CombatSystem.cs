using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class CombatSystem : MonoBehaviour { 

    public AbilityManager am = new AbilityManager();
    public Player player = new Player();
    public Waifu waifu;
    public EnemyManager em = new EnemyManager();

    //GUI THINGY ( ͡° ͜ʖ ͡°)
    public GameObject enemySide;
    public GameObject allySide;


    [Space(10)]
    [Header("In-Game Stats")]
    public bool turn; // false == enemy / true == player
    public int turnCount; //for events and bonus exp; 1 turn = 1.01x , 10 turn == 1.10x
    public float receivedEXP;
    public bool isEscaping;

    public void retEXP(Enemy enemy)
    {
        receivedEXP = (enemy.calcEXPOut() * 1 + (turnCount / 100));
    }

    public void abilities()
    {
        bool qSkill = GUI.Button(new Rect(525, 20, 50, 20), player.abilities[0].name);
        bool wSkill = GUI.Button(new Rect(575, 40, 50, 20), player.abilities[1].name);
        bool eSkill = GUI.Button(new Rect(525, 40, 50, 20), player.abilities[2].name);
        bool rSkill = GUI.Button(new Rect(575, 20, 50, 20), player.abilities[3].name);
    }

    // Use this for initialization
    void Start () {
        //am.createEverything();
        Serializer.Load<Abillity>("attacks.txt");
        Serializer.Load<Abillity>("globals.txt");
        Serializer.Load<Abillity>("supports.txt");
        Serializer.Load<Abillity>("statuses.txt");
        player.setAbilities();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void escape()
    {
        SceneManager.UnloadSceneAsync("fighting_screen");
    }

    public void OnGUI()
    {
        abilities();
    }

}