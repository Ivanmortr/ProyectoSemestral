using System;
using UnityEngine;


public class JoystickPlayerRotation : MonoBehaviour
{
    [SerializeField] private VariableJoystick _joystickRotation;
    private SpriteRenderer _spriteRenderer;
    private int _horizontal;
    private int _vertical;
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        RotateWithJoystick();
    }

    private void RotateWithJoystick()
    {

        _horizontal = Mathf.RoundToInt(_joystickRotation.Horizontal);
        _vertical = Mathf.RoundToInt(_joystickRotation.Vertical);

        if (_horizontal>_vertical)
        {
            
            if(_vertical == -1)
            {
                Debug.Log("Viendo abajo");
                _spriteRenderer.flipY = false;
            }
            else 
            {
                Debug.Log("Viendo derecha");
                _spriteRenderer.flipX = true;
            }
            return;
        }
        if(_horizontal<_vertical)
        {

            if (_horizontal == -1)
            {
                Debug.Log("Viendo izquierda");
                _spriteRenderer.flipX = false;
            }
            else 
            {
                Debug.Log("Viendo arriba");
                _spriteRenderer.flipY = true;
            }

            return;
        }
       
      


    }
}
