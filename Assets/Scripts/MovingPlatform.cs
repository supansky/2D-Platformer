using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 finishPos = new Vector3(18.0f, 2.238f, 0);
    public float speed = 0.5f;

    private Vector3 startPos;
    private float trackPercent = 0;
    private int direction = 1;

    private void Start()
    {
        startPos = transform.position;
    }
    private void Update()
    {
        trackPercent += direction * speed * Time.deltaTime;
        float x = (finishPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3 (x, y, startPos.z);

        if ((direction == 1 && trackPercent > .9f) || (direction == -1 && trackPercent < .1f))
        {
            direction *= -1;
        }
    }
}
