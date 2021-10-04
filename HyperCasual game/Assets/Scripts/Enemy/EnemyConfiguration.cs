using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Enemy configuration")]
public class EnemyConfiguration : ScriptableObject
{
    [SerializeField] private Enemy[] _enemies;
    private Dictionary<string, Enemy> _idToEnemy;

    private void Awake()
    {
        _idToEnemy = new Dictionary<string, Enemy>();
        foreach(var enemy in _enemies)
        {
            _idToEnemy.Add(enemy.ID, enemy);
        }
    }

    public Enemy GetEnemyPrefabById(string id)
    {
        if(!_idToEnemy.TryGetValue(id, out var enemy))
        {
            throw new Exception($"Este enemigo con el id {id} no existe en el diccionario");

        }
        return enemy;
    }
}