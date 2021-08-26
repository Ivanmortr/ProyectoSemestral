using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyConfiguration _enemyConfiguration;
    private EnemyFactory _enemyFactory;

    private void Awake()
    {
        _enemyFactory = new EnemyFactory(Instantiate(_enemyConfiguration));
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            _enemyFactory.Create("Zombie");
        }
    }
}
