using System;
using TMPro;
using UnityEngine;

public class TextCurrency : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCurrencyGold;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        _textCurrencyGold.text = PlayerData.CurrencyGold.ToString();
    }

    private void OnEnable()
    {
        BasicBullet.OnDamaged += IncreaseCurrencyInText;
        Health.OnDeath += HandleIncreaseAmountPerDeath;
    }

    private void HandleIncreaseAmountPerDeath(int amountToIncrease)
    {
        PlayerData.CurrencyGold += amountToIncrease;
        _textCurrencyGold.text = PlayerData.CurrencyGold.ToString();
    }

    private void OnDisable()
    {
        BasicBullet.OnDamaged -= IncreaseCurrencyInText;
        Health.OnDeath -= HandleIncreaseAmountPerDeath;
    }

    private void IncreaseCurrencyInText(int currencyGold)
    {
        
        _textCurrencyGold.text = PlayerData.CurrencyGold.ToString();
    }
    
    
}
