using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameController gc;
    public GameObject mainMenu;
    public AudioSource src;
    public AudioClip sound;
    public GameObject[] journalChapters;

    void Start()
    {
        gc.checkLevelProgress();
    }

    void Update()
    {
        gc.checkChangeSkin();
    }

    public void button(GameObject button)
    {
        src.PlayOneShot(sound);
        mainMenu.SetActive(false);
        button.SetActive(true);
    }

    public void changeSkinButton()
    {
        src.PlayOneShot(sound);
        gc.changeSkin();
    }

    public void loadScene(string sceneName)
    {
        src.PlayOneShot(sound);
        SceneManager.LoadScene(sceneName);
    }

    public void backButton(GameObject thisObject)
    {
        src.PlayOneShot(sound);
        mainMenu.SetActive(true);
        thisObject.SetActive(false);
    }

    public void nextPage(int currentPage)
    {
        src.PlayOneShot(sound);
        journalChapters[currentPage - 1].SetActive(false);
        journalChapters[currentPage].SetActive(true);
    }

    public void prevPage(int currentPage)
    {
        src.PlayOneShot(sound);
        journalChapters[currentPage - 1].SetActive(false);
        journalChapters[currentPage - 2].SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
