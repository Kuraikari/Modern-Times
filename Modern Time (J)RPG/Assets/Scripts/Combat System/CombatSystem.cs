using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CombatSystem : MonoBehaviour {

    public AbilityManager am = new AbilityManager();
    public Player player;
    public Waifu waifu;
    public EnemyManager em;

    [Space(10)]
    [Header("In-Game Stats")]
    public bool turn; // false == enemy / true == player
    public int turnCount; //for events and bonus exp; 1 turn = 1.01x , 10 turn == 1.10x
    public float receivedEXP;
    public bool isEscaping;

    public void retEXP(Enemy enemy)
    {
        receivedEXP = (enemy.calcEXPOut() * 1+(turnCount/100));
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
