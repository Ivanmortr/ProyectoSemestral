using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] private EnemyConfiguration _enemyConfiguration;
    private EnemyFactory _enemyFactory;

    [SerializeField] Transform[] _bossSpawns;
    [SerializeField] private int _bossCoolDownTime;
    private void Awake()
    {
        _enemyFactory = new EnemyFactory(Instantiate(_enemyConfiguration));
    }
    private void Start()
    {
        StartCoroutine(CoolDownBossSpawn(_bossCoolDownTime));
    }

    private IEnumerator CoolDownBossSpawn(int cdBoss)
    {
        while (PlayerData.PlayerAlive)
        {
            var randomNumber = Random.Range(0, _bossSpawns.Length);
            _enemyFactory.Create("Zombie", _bossSpawns[randomNumber].transform);
            yield return new WaitForSeconds(cdBoss);
        }
    }
}
