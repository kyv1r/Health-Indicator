using TMPro;

public class HealthTextView : HealthValueView
{
    private TextMeshProUGUI _healthText;

    private void Awake()
    {
        Init();
        _healthText = GetComponent<TextMeshProUGUI>();
        _healthText.text = $"{MaxHealthValue}/{HealthValue}";
    }

    protected override void SetCurrentHealthValue(float healthValue)
    {
        base.SetCurrentHealthValue(healthValue);
        _healthText.text = $"{MaxHealthValue}/{HealthValue}";
    }
}
