using UnityEngine;
using TMPro;

public class ColorButton : MonoBehaviour
{
    public TMP_Text label;
    public string colorName;
    public float value;

    // on Start, set the buttons lable to display its value
    private void Start()
    {
        label.text = ConfigData.currencySymbol + value;
    }
}
