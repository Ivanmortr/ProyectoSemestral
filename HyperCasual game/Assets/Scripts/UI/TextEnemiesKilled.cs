using TMPro;
using UnityEngine;


public class TextEnemiesKilled : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textEnemiesKilled;
    private int _enemyKill = 0;
    [SerializeField] private TextMeshProUGUI Hscore;

    public void Start()
    {
        Hscore.text = PlayerPrefs.GetInt("Text-highscore", 0).ToString();
    }


    private void OnEnable()
    {
        Health.OnDeath += IncreaseEnemyKilled;
    }

    private void IncreaseEnemyKilled(int enemyKilled)
    {
        _enemyKill++;
        _textEnemiesKilled.text = _enemyKill.ToString();

        if(_enemyKill> PlayerPrefs.GetInt("Text-highscore", 0))
        {
            PlayerPrefs.SetInt("Text-highscore", _enemyKill);
            Hscore.text = _enemyKill.ToString();
        }

        
    }
}
