using UnityEngine;
using DG.Tweening;
public class Health : MonoBehaviour,IDamageable
{
    public delegate void _OnDeath();
    public static event _OnDeath OnDeath;

    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = 100;

    public int GetHealth => _currentHealth;
    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void DoDamage(int damageToDo)
    {
        _currentHealth -= damageToDo;
        if (_currentHealth > 0) return;
        OnDeath?.Invoke();
        Destroy(gameObject);

    }
    private void OnDestroy()
    {
        DOTween.Kill(transform);
        DOTween.Kill(gameObject);
    }
}
