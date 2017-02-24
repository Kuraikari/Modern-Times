using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager {

    public List<Enemy> enemies;

    public void createEnemies()
    {
        enemies.Add(new Enemy(0, "ENEMY", 10000, 100));
        enemies.Add(new Enemy(1, "BROTHER", 100, 5));
        enemies.Add(new Enemy(2, "SISTER", 80, 4));
        enemies.Add(new Enemy(3, "ENEMY", 10000, 100));
        enemies.Add(new Enemy(4, "ENEMY", 10000, 100));
        enemies.Add(new Enemy(5, "ENEMY", 10000, 100));
        enemies.Add(new Enemy(6, "ENEMY", 10000, 100));
    }

    public Enemy getEnemyOfList(string name)
    {
        Enemy enemy = enemies.Find(x => x.name.Contains(name));

        return enemy;
    }


}
