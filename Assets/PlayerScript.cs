using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private Vector3 _currentVelocity = Vector3.zero;
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("OnMove has been executed, context = " + context);
        if (context.phase == InputActionPhase.Performed)
        {
            _currentVelocity = context.ReadValue<Vector2>();
        }
        else
        {
            _currentVelocity = Vector3.zero;
        }
    }

    private void Update()
    {
        transform.position += _currentVelocity * 0.003f;
    }
}