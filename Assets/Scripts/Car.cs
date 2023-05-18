using UnityEngine;
using TMPro;

public class Car : MonoBehaviour
{
    private string brand;
    private float totalValue;
    private float cashValue;
    private Color defaultColor;
    public TMP_Text floatingPrice;

    [SerializeField] Material material;

    public ObjectData carData;

    // sets up the car data and applies it
    public void SetData(ObjectData data)
    {
        carData = data;
        brand = carData.name;
        cashValue = carData.value;
        // sets the car value (not total value) above the car using a 3d text
        floatingPrice.text = ConfigData.currencySymbol+cashValue.ToString();
        defaultColor = Color.grey;
        SetColorToDefault();
    }

    // Gets the cars data
    public ObjectData GetData()
    {
        return carData;
    }
    // Gets the brand name of the car
    public string GetNameBrand()
    {
        return brand;
    }

    // Gets the cars color, or sets it
    public Color Color
    {
        set { material.color = value;
            carData.color = value;
        }
        get { return material.color; }
    }
    // Sets the color Name of the selected color of the car
    public void SetColorName( string name )
    {
        carData.colorName = name;
    }
    // Sets the total cash value of the car, which inclues the color value
    public void SetCashValue(float amount)
    {
        totalValue      = cashValue + amount;
        carData.value   = totalValue;
    }

    /** 
     * Sets the car back to its default color.
     * It also sets the color on the data level
     * */
    public void SetColorToDefault()
    {
        material.color  = defaultColor;
        carData.color   = defaultColor;
        totalValue      = cashValue;
        carData.value   = totalValue;
        carData.colorPrice = 0;
        carData.colorName = "Grey";
    }



}
