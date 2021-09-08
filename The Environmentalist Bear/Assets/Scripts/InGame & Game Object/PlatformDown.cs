using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float intervalTime;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 0f;
        }

        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && timer <= 0)
        {
            effector.rotationalOffset = 180f;
            timer = intervalTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
