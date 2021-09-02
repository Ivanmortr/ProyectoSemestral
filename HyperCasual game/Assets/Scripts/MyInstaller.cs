using UnityEngine;

public class MyInstaller : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _playerGun;
    [SerializeField] private BasicGun _basicGun;

    public Transform GetPlayerTransform => _player;

    private void Awake()
    {
        var player = _player.gameObject.GetComponent<Player>();
        var weapon = GetWeapon(_playerGun);
        player.SetWeapon(weapon);
    }

    private Weapon GetWeapon(Transform parent)
    {
        return Instantiate(_basicGun, parent);
    }
}
