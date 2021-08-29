using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool paused;
    public bool completed;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && !(completed))
        {
            if (paused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
    }

    public void mute()
    {

    }

    public void quit(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
