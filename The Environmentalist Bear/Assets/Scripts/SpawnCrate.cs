using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrate : MonoBehaviour
{
    public GameObject crate;
    private Vector2 spawnLocation;
    public bool eventTriggered;
    private static int maxCrate = 3;
    private static float crateCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (crateCount < maxCrate && eventTriggered)
        {
            spawnLocation = new Vector2(transform.position.x, transform.position.y);
            Instantiate(crate, spawnLocation, Quaternion.identity);
            crateCount++;
        }
    }
}
