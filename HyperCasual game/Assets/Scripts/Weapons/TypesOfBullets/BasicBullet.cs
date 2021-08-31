using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BasicBullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Awake()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<IDamageable>();
        enemy?.DoDamage(1);
        Destroy(gameObject);//ESTO TIENE QUE FUNCIONAR CON POOL OBJECT
    }

    private void Start()
    {
        Destroy(gameObject,3f);
    }
}
