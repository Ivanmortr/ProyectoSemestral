using System.Collections;
using UnityEngine;

public class BasicGun : MonoBehaviour, Weapon
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnReference;
    [SerializeField] private float _coolDownFire;

    public void Attack()
    {
        StartCoroutine(SpawnBulletWithCd(_coolDownFire));

    }

    private IEnumerator SpawnBulletWithCd(float cd)
    {
        while(PlayerData.PlayerAlive)
        {
            var bullet = Instantiate(_bulletPrefab, _spawnReference.position, _spawnReference.rotation);
            yield return new WaitForSeconds(cd);
        }
    }
}
