using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTask : MonoBehaviour
{
    public GameObject gameController;
    public GameObject afterDestroy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            gameController.GetComponent<GameController>().updateCurrent();
            Destroy(this.gameObject);
            afterDestroy.gameObject.SetActive(true);
            gameController.GetComponent<GameController>().checkCompleteMission();
        }
    }
}
