using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void Loadnextscene()
    {
        int Currentsceneindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(Currentsceneindex + 1);
    }
    public void Loadstartscene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quitgame()
    {
        Application.Quit();
    }
}
