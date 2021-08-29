using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    float xWidthC = 100f;
    float yHeightC = 100f;

    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, -xWidthC, xWidthC), Mathf.Clamp(player.position.y, -yHeightC, yHeightC), transform.position.z);
    }
}
