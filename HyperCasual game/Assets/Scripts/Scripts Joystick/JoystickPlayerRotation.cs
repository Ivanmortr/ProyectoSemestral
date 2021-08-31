using System;
using UnityEngine;


public class JoystickPlayerRotation : MonoBehaviour
{
    [SerializeField] private VariableJoystick _joystickRotation;
    private SpriteRenderer _spriteRenderer;
    private int _horizontal;
    private int _vertical;
    private Transform _playerTransform;
    private BasicGun _basicGun;
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        _playerTransform = GameObject.Find("Player").transform;
        _basicGun = GameObject.Find("Player").GetComponentInChildren<BasicGun>();
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
                _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, 90f);

            }
            else 
            {
                Debug.Log("Viendo derecha");
                _spriteRenderer.flipX = true;
                _basicGun.transform.rotation = Quaternion.Euler(0f, 180f, 0);
            }
            return;
        }
        if(_horizontal<_vertical)
        {

            if (_horizontal == -1)
            {
                Debug.Log("Viendo izquierda");
                _spriteRenderer.flipX = false;
                _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            else 
            {
                Debug.Log("Viendo arriba");
                _spriteRenderer.flipY = true;
                _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
            }

            return;
        }
       
      


    }
}
