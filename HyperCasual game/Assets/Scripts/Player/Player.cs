using System;
using UnityEngine;
using DG.Tweening;


public class Player : MonoBehaviour,IDoEffects
{
    
    private Weapon _weapon;
    
    private SpriteRenderer _spriteRenderer;

    
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        _weapon.Attack();

    }

    private void OnEnable()
    {
        BasicBullet.OnDamaged += HandleOnDamagedIncreaseCurrencyGold;
    }

    private void OnDisable()
    {
        BasicBullet.OnDamaged -= HandleOnDamagedIncreaseCurrencyGold;
    }


    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
    private void HandleOnDamagedIncreaseCurrencyGold(int amountToIncrease)
    {
        PlayerData.CurrencyGold += amountToIncrease;
    }

    public void DoEffect()
    {
        var sequence = DOTween.Sequence();
        sequence.Insert(0.0f, _spriteRenderer.DOColor(Color.red, 0.1f));
        sequence.Insert(0.0f, Camera.main.DOShakePosition(0.2f, 0.3f, 1000));
        sequence.Insert(0.1f, _spriteRenderer.DOColor(Color.white, 0.1f));
    }

    private void OnDestroy()
    {
        PlayerData.PlayerAlive = false;
        Debug.Log("Luis"+PlayerData.PlayerAlive);
    }
}


