using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BasicBullet : MonoBehaviour
{
    public delegate void _OnDamaged(int amount);
    public static event _OnDamaged OnDamaged;

    [SerializeField] private float _speed = 10f;
    [SerializeField] private int _amountToCurrency = 1;

    private void Awake()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        var effect = other.GetComponent<IDoEffects>();
        OnDamaged?.Invoke(_amountToCurrency);
        effect?.DoEffect();
        Destroy(gameObject);//ESTO TIENE QUE FUNCIONAR CON POOL OBJECT
    }

    private void Start()
    {
        Destroy(gameObject,3f);
    }
}
