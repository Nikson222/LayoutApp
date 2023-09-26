using UnityEngine;
using UnityEngine.UI;

public class ColoredButton : ActionButton
{
    const float MAX_VALUE_RGB = 1f;
    const float MIN_VALUE_RGB = 0.0f;


    private void Start()
    {
        AddListenerOnClick(SetRandomColor);

        SetRandomColor();
    }

    private void SetRandomColor()
    {
        _button.image.color = GenerateColor();
    }

    private Color GenerateColor()
    {
        float a = Random.Range(MIN_VALUE_RGB, MAX_VALUE_RGB);
        float b = Random.Range(MIN_VALUE_RGB, MAX_VALUE_RGB);
        float c = Random.Range(MIN_VALUE_RGB, MAX_VALUE_RGB);

        return new Color(a, b, c);
    }
}
