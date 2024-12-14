using TMPro;

public class HealthTextView : HealthValueView
{
    private TextMeshProUGUI _healthText;

    protected override void Awake()
    {
        base.Awake();
        _healthText = GetComponent<TextMeshProUGUI>();
        _healthText.text = $"{MaxHealthValue}/{HealthValue}";
    }

    protected override void SetCurrentHealthValue(float healthValue)
    {
        base.SetCurrentHealthValue(healthValue);
        _healthText.text = $"{MaxHealthValue}/{HealthValue}";
    }
}
