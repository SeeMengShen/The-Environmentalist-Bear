using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform point1;
    public Transform point2;

    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, point1.position.x, point2.position.x), Mathf.Clamp(player.position.y, point1.position.y, point2.position.y), transform.position.z);
    }
}
