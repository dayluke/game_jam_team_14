using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        
        Application.Quit();
    }
}
