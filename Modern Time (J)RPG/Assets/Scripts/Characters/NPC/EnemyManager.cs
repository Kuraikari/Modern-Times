using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************************
 * Author: Zian "Kuraikari" Wermelinger                                 *
 * Project: Modern Times (J)RPG                                         *
 *                                                                      *
 * This is the EnemyManager class. This class manages the enemies. E.g. *
 * Creating the lists for them. Still needs some improvements though.   *
 ************************************************************************/
public class EnemyManager {

    public List<Enemy> enemies;
    public NPCManager npc;


    public void convertNPCToEnemy()
    {
        npc.characters.ForEach( x =>  enemies.Add(new Enemy(x.m_id, x.name, x.experience, x.level)));
    }

    public void createNewEnemy(string name, float exp, int lvl)
    {
        enemies.Add(new Enemy(enemies.Count + 1, name, exp, lvl));
    }

    public Enemy getEnemyOfList(string name)
    {
        Enemy enemy = enemies.Find(x => x.name.Contains(name));
        return enemy;
    }


}
