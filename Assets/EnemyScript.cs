using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D ball;
    
    private const float VerticalBoundary = 0.85f;

    void Update()
    {
        var theTransform = transform;
        var currentPosition = theTransform.position;
        theTransform.position = new Vector3(
            currentPosition.x, 
            Clamp(ball.transform.position.y, -VerticalBoundary, VerticalBoundary), 
            currentPosition.z
        );
    }

    private static float Clamp(float value, float min, float max)
    {
        return value < min ? min : value > max ? max : value;
    }
}
