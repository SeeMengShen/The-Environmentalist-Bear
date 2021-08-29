using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockWater : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            Destroy(this.gameObject);
        }
    }
}
