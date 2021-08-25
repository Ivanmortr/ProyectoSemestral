using System;
using UnityEngine;


public class JoystickPlayerRotation : MonoBehaviour
{
    [SerializeField] private VariableJoystick _joystickRotation;  
    private void FixedUpdate()
    {
        RotateWithJoystick();
    }

    private void RotateWithJoystick()
    {
        var moveVector = (Vector2.up * _joystickRotation.Vertical - Vector2.left * _joystickRotation.Horizontal);
        if(_joystickRotation.Horizontal !=0 || _joystickRotation.Vertical != 0)
        {
           gameObject.transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }
    }
}
