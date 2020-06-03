using UnityEngine;

public class VerticalEdge : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.rigidbody.velocity *= new Vector2(1, -1);
    }
}
