using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullObject : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj != null)
        {
            if (Input.GetButtonDown("Interact"))
            {
                obj.GetComponent<FixedJoint2D>().enabled = true;
                obj.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            }
            else if (Input.GetButtonUp("Interact"))
            {
                obj.GetComponent<FixedJoint2D>().connectedBody = null;
                obj.GetComponent<FixedJoint2D>().enabled = false;
                obj = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Object"))
        {
            obj = other.gameObject;
        }
    }
}
