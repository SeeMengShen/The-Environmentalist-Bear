using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject completeLevel;
    public PauseGame pg;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            completeLevel.SetActive(true);
            Time.timeScale = 0f;
            pg.completed = true;
        }
    }
}
