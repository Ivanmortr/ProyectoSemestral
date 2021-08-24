using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JoystickPlayerRotation : MonoBehaviour
{
    [SerializeField] private VariableJoystick _joystickRotation;
    private Rigidbody2D _rigidbody2D;


    private void Awake()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        RotateWithJoystick();
    }

    private void RotateWithJoystick()
    {
        _rigidbody2D.MoveRotation(_joystickRotation.Vertical);
    }
}
