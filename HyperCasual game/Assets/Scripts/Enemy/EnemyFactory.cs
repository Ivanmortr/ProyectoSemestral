using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory 
{
    private readonly EnemyConfiguration _enemyConfiguration;

    public EnemyFactory(EnemyConfiguration enemyConfiguration)
    {
        _enemyConfiguration = enemyConfiguration;
    }


    public Enemy Create(string id)
    {
        var enemy = _enemyConfiguration.GetEnemyPrefabById(id);
        return Object.Instantiate(enemy);
    }

    public Enemy Create(string id,Transform parent)
    {
        var enemy = _enemyConfiguration.GetEnemyPrefabById(id);
        return Object.Instantiate(enemy, parent);
    }
}
