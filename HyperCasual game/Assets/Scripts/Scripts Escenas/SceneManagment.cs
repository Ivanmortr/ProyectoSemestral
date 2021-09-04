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
        DOVirtual.DelayedCall(1.0f, GoNextScene);
        
   }
   public void GoNextScene()
   {
        SceneManager.LoadScene(_sceneName); 
   }
}
