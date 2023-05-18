using UnityEngine;
using UnityEngine.UI;

public class ColorPickerDisplay : MonoBehaviour
{
    public CarViewerDisplay carViewer;

    /** 
     * Handles the click events for each color button
     * sets the cars color, selected color price and the color name
    */ 
    public void OnClicked(Button button)
    {
        carViewer.SetCarColor(button.GetComponent<Image>().color);
        carViewer.updateValue(button.GetComponent<ColorButton>().value);
        carViewer.updateColorName(button.GetComponent<ColorButton>().colorName);
    }


    // Sets the car color and data to the default color, which has no color price
    public void OnCleared()
    {
        carViewer.SetCarColorToDefault();
    }
}
