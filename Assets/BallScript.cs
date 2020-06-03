using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private const float Velocity = 0.5f;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-Velocity, Velocity);
    }
}
