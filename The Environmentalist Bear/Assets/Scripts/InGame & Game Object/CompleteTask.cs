using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTask : MonoBehaviour
{
    public GameObject gameController;
    public GameObject[] showAfterComplete;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            gameController.GetComponent<GameController>().updateCurrent();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            foreach(GameObject o in showAfterComplete)
            {
                o.gameObject.SetActive(true);
            }
            gameController.GetComponent<GameController>().checkCompleteMission();
        }
        else if (other.gameObject.CompareTag("Crate"))
        {
            gameController.GetComponent<GameController>().updateCurrent();
            Destroy(this.gameObject);
            foreach (GameObject o in showAfterComplete)
            {
                o.gameObject.SetActive(true);
            }
            gameController.GetComponent<GameController>().checkCompleteMission();
        }
    }
}
