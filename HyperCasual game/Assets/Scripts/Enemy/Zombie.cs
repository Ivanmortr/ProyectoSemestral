using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Zombie : Enemy, IDamageable
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private int _healthPoints = 2;   
    private Rigidbody _rigidbody;
    
 
    


    private void Start()
    {
        _target = GameObject.Find("Player").transform;
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Perseguir();
    }

    private void OnCollisionEnter(Collision collision)
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
        _rigidbody.MovePosition(transform.position + (nextPoint * _speed * Time.deltaTime));
    }

    public void DoDamage(int damageToDo)
    {
        _healthPoints -= damageToDo;
        if (_healthPoints <= 0)
            Destroy(gameObject);
    }
}
