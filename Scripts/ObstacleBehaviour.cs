using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float radius = 1;

    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < radius)
        {
            //Debug.Log("radius true");
            current++;

            if (current >= waypoints.Length)
            {
                //Debug.Log("wp");

                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }
}
