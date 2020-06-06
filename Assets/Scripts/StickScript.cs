using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            var contactPointNormal = other.GetContact(0).normal;
            bool shouldRevertX = Mathf.Abs(contactPointNormal.x) >= Mathf.Abs(contactPointNormal.y);
            bool shouldRevertY = Mathf.Abs(contactPointNormal.x) <= Mathf.Abs(contactPointNormal.y);
            var ballVelocityMultiplier = new Vector2(shouldRevertX ? -1 : 1, shouldRevertY ? -1 : 1);
            other.rigidbody.velocity *= ballVelocityMultiplier;
            Debug.Log(this + " contact Point Normal = " + contactPointNormal + ", ball velocity multiplier = " + ballVelocityMultiplier);
        }
    }
}
