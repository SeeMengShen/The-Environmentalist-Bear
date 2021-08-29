using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    private GameController gc;
    public GameObject hint;

    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Hint") && gc.checkHint())
        {
            hint.SetActive(true);
            Debug.Log("Show hint");
        }
    }

    public void done()
    {
        hint.SetActive(false);
    }
}
