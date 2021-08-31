using UnityEngine;

public class MyInstaller : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private BasicGun _basicGun;

    public Transform GetPlayerTransform => _player;

    private void Awake()
    {
        var player = _player.gameObject.GetComponent<Player>();
        var weapon = GetWeapon(GetPlayerTransform);
        player.SetWeapon(weapon);
    }

    private Weapon GetWeapon(Transform parent)
    {
        return Instantiate(_basicGun, parent);
    }
}
