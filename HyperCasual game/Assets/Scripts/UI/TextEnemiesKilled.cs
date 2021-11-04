using TMPro;
using UnityEngine;
using UnityEngine.Analytics;


public class TextEnemiesKilled : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textEnemiesKilled;
    private int _enemyKill = 0;
    [SerializeField] private TextMeshProUGUI Hscore;
    private bool kills= false;

    public void Start()
    {
        Hscore.text = PlayerPrefs.GetInt("Text-highscore", 0).ToString();
    }


    private void OnEnable()
    {
        Health.OnDeath += IncreaseEnemyKilled;
    }

    public void IncreaseEnemyKilled(int enemyKilled)
    {
        _enemyKill++;
        _textEnemiesKilled.text = _enemyKill.ToString();
        if (_enemyKill==20)
        {
          Analytics.CustomEvent("20Kills");
            
        }

       
        if(_enemyKill> PlayerPrefs.GetInt("Text-highscore", 0))
        {
            PlayerPrefs.SetInt("Text-highscore", _enemyKill);
            Hscore.text = _enemyKill.ToString();
        }

        
    }
}
