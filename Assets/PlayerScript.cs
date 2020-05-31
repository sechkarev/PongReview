using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("OnMove has been executed, context = " + context);
        Vector3 velocity = context.ReadValue<Vector2>();
        transform.position += velocity * 0.1f;
    }
}
