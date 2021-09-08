using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLand : MonoBehaviour
{
    GameObject player;
    private Collider2D collide;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Object") || collision.collider.CompareTag("Crate"))
        {
            player.GetComponent<PlayerController>().stepOnObject = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Object") || collision.collider.CompareTag("Crate"))
        {
            player.GetComponent<PlayerController>().stepOnObject = false;
        }
    }
}
