using TMPro;
using UnityEngine;

public class TextCurrency : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCurrencyGold;
    private int _goldAmount = 0;
    
    // Start is called before the first frame update
    private void Start()
    {
        _textCurrencyGold.text = _goldAmount.ToString();
    }

    private void OnEnable()
    {
        BasicBullet.OnDamaged += IncreaseCurrencyInText;
    }

    private void OnDisable()
    {
        BasicBullet.OnDamaged -= IncreaseCurrencyInText;
    }

    private void IncreaseCurrencyInText(int currencyGold)
    {
        _goldAmount += currencyGold;
        _textCurrencyGold.text = _goldAmount.ToString();
    }
    
    
}
