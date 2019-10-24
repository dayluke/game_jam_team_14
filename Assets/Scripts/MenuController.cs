using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject PausePanel;
    private bool IsPaused = false;
   

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1;
    }
    
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {

            if(IsPaused == true)
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1;
            }
            if(IsPaused == false)
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
            }

            IsPaused = !IsPaused;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
