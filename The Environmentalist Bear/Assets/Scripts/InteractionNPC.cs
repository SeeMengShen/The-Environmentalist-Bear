using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionNPC : MonoBehaviour
{
    public GameObject interactNPC;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (interactNPC != null)
        {
            if (interactNPC.CompareTag("NPC"))
            {
                if (Input.GetButtonDown("Interact") && !(interactNPC.GetComponent<NPCDialogue>().talking))
                {
                    interactNPC.GetComponent<NPCDialogue>().talk();
                }
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            interactNPC = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            interactNPC = null;
        }
    }
}
