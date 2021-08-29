using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInScreen : MonoBehaviour
{
    public Transform point1;
    public Transform point2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, point1.position.x, point2.position.x), Mathf.Clamp(transform.position.y, point1.position.y, point2.position.y), 0);
    }
}
