using System.Threading.Tasks;

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
