using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEdge : MonoBehaviour
{
    public ReviewScript reviewScript;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            reviewScript.Restart();
        }
    }
}
