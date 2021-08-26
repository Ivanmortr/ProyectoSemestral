
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JoystickPlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private Rigidbody _rigidbody2D;

    private void FixedUpdate()
    {
        MovementPlayerWithJoystick();
    }

    private void MovementPlayerWithJoystick()
    {
        var direction = Vector3.forward * _joystick.Vertical + Vector3.right * _joystick.Horizontal;
        _rigidbody2D.velocity = new Vector3(direction.x * _speed, direction.y * _speed, direction.z * _speed);
    }
}
