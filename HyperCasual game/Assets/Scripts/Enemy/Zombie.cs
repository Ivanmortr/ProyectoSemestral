using System;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;

[RequireComponent(typeof(Rigidbody2D))]
public class Zombie : Enemy, IDoEffects
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 2f;
    private Rigidbody2D _rigidbody2D;
    private IDamageable _myHealth;
    
    
    private void Start()
    {
        _target = GameObject.Find("Player").transform;
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        _myHealth = gameObject.GetComponent<IDamageable>();
    }

    private void FixedUpdate()
    {
        if(PlayerData.PlayerAlive)
        ChaseTarget();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player")) return;
        var healthPlayer = collision.gameObject.GetComponent<IDamageable>();
        var effectPlayer = collision.gameObject.GetComponent<IDoEffects>();
        effectPlayer?.DoEffect();
        healthPlayer?.DoDamage(1);
    }
    public override void ChaseTarget()
    {
        var position = transform.position;
        var nextPoint = _target.position - position;
        nextPoint.Normalize();
        _rigidbody2D.MovePosition(position + (nextPoint * (_speed * Time.deltaTime)));
    }

    public void DoEffect()
    {
        gameObject.transform.DOShakeScale(0.15f, 0.4f, 10, 90, true);
         _myHealth?.DoDamage(1);
    }

   
}
