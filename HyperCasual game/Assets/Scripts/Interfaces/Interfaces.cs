using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Weapon
{
    void Attack();
}

public interface IDamageable
{
    void DoDamage(int damageToDo);
}