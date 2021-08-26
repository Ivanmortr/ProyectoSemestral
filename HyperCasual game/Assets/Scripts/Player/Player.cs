using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private int _health = 100;
    private Weapon _weapon;

    public void DoDamage(int damageToDo)
    {
        _health -= damageToDo; 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            _weapon.Attack();
        }
    }

    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
}
