using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Rigidbody2D otherObjectRigidbody = other.rigidbody;
        if (otherObjectRigidbody != null)
        {
            otherObjectRigidbody.velocity *= new Vector2(-1, 1);
        }
    }
}
