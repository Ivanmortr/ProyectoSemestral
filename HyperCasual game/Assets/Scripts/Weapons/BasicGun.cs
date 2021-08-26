using UnityEngine;

public class BasicGun : MonoBehaviour, Weapon
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnReference;

    public void Attack()
    {
        var bullet = Instantiate(_bulletPrefab, _spawnReference.position, _spawnReference.rotation);
    }
}
