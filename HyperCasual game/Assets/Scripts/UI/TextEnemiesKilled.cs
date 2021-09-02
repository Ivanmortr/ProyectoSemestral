using TMPro;
using UnityEngine;

public class TextEnemiesKilled : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textEnemiesKilled;
    private int _enemyKill = 0;


    private void OnEnable()
    {
        Health.OnDeath += IncreaseEnemyKilled;
    }

    private void IncreaseEnemyKilled(int enemyKilled)
    {
        _enemyKill++;
        _textEnemiesKilled.text = _enemyKill.ToString();
    }
}
