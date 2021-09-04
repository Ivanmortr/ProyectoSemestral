using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyConfiguration _enemyConfiguration;
    private EnemyFactory _enemyFactory;


    [SerializeField] Transform[] _spawns;
    [SerializeField] private int _coolDownTime;
    private void Awake()
    {
        _enemyFactory = new EnemyFactory(Instantiate(_enemyConfiguration));
    }
    private void Start()
    {
        StartCoroutine(CooldownSpawnZombie(_coolDownTime));
    }

    private IEnumerator CooldownSpawnZombie(int cd)
    {
        while(PlayerData.PlayerAlive)
        {
        var randomNumber = Random.Range(0,_spawns.Length);
        _enemyFactory.Create("Zombie", _spawns[randomNumber].transform);
        yield return new WaitForSeconds(cd);
        }
    }
}
