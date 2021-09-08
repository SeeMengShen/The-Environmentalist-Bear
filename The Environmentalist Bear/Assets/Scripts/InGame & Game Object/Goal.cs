using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject completeLevel;
    public GameController gc;
    public int levelInt;
    public PauseGame pg;
    public AudioSource src;
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            src.PlayOneShot(sound);
            completeLevel.SetActive(true);
            Time.timeScale = 0f;
            pg.completed = true;
            gc.completeLevelInt(levelInt);
        }
    }
}
