using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasue : MonoBehaviour
{
    bool ispaused = false;
    public GameObject pauseCanvas;

    // Start is called before the first frame update
    public void pauseGame()
    {
        if(ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
            pauseCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
            pauseCanvas.SetActive(true);
        }
    }
}
