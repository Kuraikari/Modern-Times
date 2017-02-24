using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager {

    public List<Enemy> enemies;

    public void createEnemies()
    {
        enemies.Add(new Enemy());
    }

}
