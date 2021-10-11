using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasue : MonoBehaviour
{
    bool ispaused = false;
    // Start is called before the first frame update
    public void pauseGame()
    {
        if(ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
        }
    }
}
