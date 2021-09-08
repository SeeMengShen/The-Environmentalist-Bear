using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoint;
    public Animator animator;
    public float moveSpeed = 1f;
    private int wpIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoint[wpIndex].transform.position;
    }

    private void followPath()
    {
        if (wpIndex <= waypoint.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint[wpIndex].transform.position, moveSpeed * Time.deltaTime);
            if (transform.position == waypoint[wpIndex].transform.position)
            {
                wpIndex += 1;
            }
        }

        if (wpIndex == waypoint.Length)
        {
            wpIndex = 0;
        }
    }

    private void checkAnimDirection()
    {
        if (wpIndex == 1)
        {
            animator.SetInteger("direction", 2);
        }
        else
        {
            animator.SetInteger("direction", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkAnimDirection();
        followPath();
    }
}
