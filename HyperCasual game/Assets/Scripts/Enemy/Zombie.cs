using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Zombie : Enemy, IDamageable
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private int _healthPoints = 2;   
    private Rigidbody2D _rigidbody2D;
    
 
    


    private void Start()
    {
        _target = GameObject.Find("Player").transform;
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Perseguir();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<IDamageable>();
            player?.DoDamage(1);
        }
    }
    public override void Perseguir()
    {
        var nextPoint = _target.position - transform.position;
        nextPoint.Normalize();
        _rigidbody2D.MovePosition(transform.position + (nextPoint * _speed * Time.deltaTime));
    }

    public void DoDamage(int damageToDo)
    {
        _healthPoints -= damageToDo;
        if (_healthPoints <= 0)
            Destroy(gameObject);
    }
}
