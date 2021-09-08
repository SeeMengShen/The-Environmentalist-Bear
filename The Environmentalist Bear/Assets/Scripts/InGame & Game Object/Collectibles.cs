using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public GameController gameController;
    public GameObject fruitUI;
    public AudioClip sound;
    private AudioSource src;

    void Start()
    {
        src = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            src.PlayOneShot(sound);
            Destroy(this.gameObject);
            gameController.hint = true;
            fruitUI.SetActive(true);
        }
    }
}
