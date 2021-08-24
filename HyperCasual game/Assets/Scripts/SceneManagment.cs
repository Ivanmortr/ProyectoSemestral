using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
   [SerializeField] private string _sceneName;

   public void ChangeToNewScene()
   {
        SceneManager.LoadScene(_sceneName);
   }

}
