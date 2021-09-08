using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stucked : MonoBehaviour
{
    public GameObject stucked;
    public PauseGame pg;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            stucked.SetActive(true);
            Time.timeScale = 0f;
            pg.completed = true;
        }
    }
}
