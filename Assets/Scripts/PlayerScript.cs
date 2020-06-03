using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public ReviewScript reviewLogic;
    
    private const float VerticalBoundary = 0.85f;
    private const float AppliedVelocity = 3.0f;
    
    private Vector3 _currentVelocity = Vector3.zero;
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            _currentVelocity = context.ReadValue<Vector2>() * AppliedVelocity;
        }
        else
        {
            _currentVelocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            reviewLogic.NextItem();
        }
    }

    private void Update()
    {
        float currentY = transform.position.y;
        if ((currentY > -VerticalBoundary && _currentVelocity.y < 0) 
            || (currentY < VerticalBoundary && _currentVelocity.y > 0))
        {
            transform.position += _currentVelocity * Time.deltaTime;
        }
    }
}