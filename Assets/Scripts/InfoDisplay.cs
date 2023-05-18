
using UnityEngine;using TMPro;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour
{
    public TMP_Text carBrandText;
    public Image carColorImage;
    public TMP_Text carValueText;
    public TMP_Text colorPrice;
    public string currency = ConfigData.currencySymbol;


    // updaates the cars details to the InfoDisplay
    public void UpdateInfo(ObjectData data )
    {
        carBrandText.text = data.name;
        carColorImage.color = data.color;
        colorPrice.text = currency + data.colorPrice.ToString();
        carValueText.text = currency + data.value;
    }
}
