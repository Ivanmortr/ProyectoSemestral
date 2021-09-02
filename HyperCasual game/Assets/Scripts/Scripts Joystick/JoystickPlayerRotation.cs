using System;
using UnityEngine;


public class JoystickPlayerRotation : MonoBehaviour
{
    [SerializeField] private VariableJoystick _joystickRotation;
    [SerializeField] private Sprite _spriteDown;
    [SerializeField] private Sprite _spriteUp;
    [SerializeField] private Sprite _spriteRight;
    [SerializeField] private Sprite _spriteLeft;
    private SpriteRenderer _spriteRenderer;
    private int _horizontal;
    private int _vertical;
    private BasicGun _basicGun;
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
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
              
                _spriteRenderer.sprite = _spriteDown;
                _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, 90f);

            }
            else 
            {
               
                _spriteRenderer.sprite = _spriteRight;
                _basicGun.transform.rotation = Quaternion.Euler(0f, 180f, 0);
            }
            return;
        }

        if (_horizontal >= _vertical) return;
        if (_horizontal == -1)
        {
            
            _spriteRenderer.sprite = _spriteLeft;
            _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else 
        {
          
            _spriteRenderer.sprite = _spriteUp;
            _basicGun.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        }

        return;




    }
}
