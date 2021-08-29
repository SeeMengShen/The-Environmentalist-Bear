using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnEvent : MonoBehaviour
{
    GameObject cs;
    public TextMeshProUGUI mission;

    void Start()
    {
        cs = gameObject.transform.parent.gameObject;    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cs.GetComponent<SpawnCrate>().eventTriggered = true;
            mission.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
