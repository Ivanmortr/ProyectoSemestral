using System.Threading.Tasks;
using UnityEngine;
public class Interfaces : MonoBehaviour
{
    [SerializeField] GameObject death;

    public void ToggleDeath()
    {
        death.SetActive(!death.activeSelf);
    }
}
public interface Weapon
{
    void Attack();
}

public interface IDamageable
{
    void DoDamage(int damageToDo);
}

public interface IDoEffects
{
    void DoEffect();
}
