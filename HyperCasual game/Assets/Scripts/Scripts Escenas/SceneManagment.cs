using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneManagment : MonoBehaviour
{
   [SerializeField] private string _sceneName;
    [SerializeField] private GameObject _loading;


    
   public void ChangeToNewScene()
   {
        _loading.SetActive(true);
        DOVirtual.DelayedCall(1.0f, Restart);
        
   }
   public void Restart()
   {
        PlayerData.PlayerAlive = true;
        PlayerData.CurrencyGold = 0;
        SceneManager.LoadScene(_sceneName);
   }
}
