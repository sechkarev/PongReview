using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private const float Velocity = 2.0f;

    public void Launch()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Velocity, Velocity);
    }

    public void Reset()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        transform.position = Vector3.zero;
    }
}
