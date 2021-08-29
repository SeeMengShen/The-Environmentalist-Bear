using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockWater : MonoBehaviour
{
    public GameObject gameController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            gameController.GetComponent<GameController>().updateCurrent();
            Destroy(this.gameObject);
            gameController.GetComponent<GameController>().checkCompleteMission();
        }
    }
}
