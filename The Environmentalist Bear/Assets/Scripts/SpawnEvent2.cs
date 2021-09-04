using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnEvent2 : MonoBehaviour
{
    GameObject cs;
    public TextMeshProUGUI mission;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mission.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
