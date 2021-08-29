using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEvent : MonoBehaviour
{
    GameObject cs;

    private void Start()
    {
        cs = gameObject.transform.parent.gameObject;    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cs.GetComponent<SpawnCrate>().eventTriggered = true;
            Destroy(this.gameObject);
        }
    }
}
