using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject selectLevel;

    public void startButton()
    {
        selectLevel.SetActive(true);
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
