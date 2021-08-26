using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class BasicBullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Awake()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.right * _speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.GetComponent<IDamageable>();
        enemy?.DoDamage(1);
        
    }
}
