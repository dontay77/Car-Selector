using UnityEngine;

[System.Serializable]
public class ObjectData
{
    public string name;
    public Color color;
    public string colorName;
    public float colorPrice;
    public float value;

    // Prints the users choice to the Console
    public void Print()
    {
        string toPrint;
        toPrint = "\nPurchase Document \n\n";
        toPrint += "Name:\t\t\t\t" + name + "\n";
        toPrint += "Color:\t\t\t\t" + colorName + "\n";
        toPrint += "ColorPrice:\t\t\t" + ConfigData.currencySymbol + colorPrice + "\n";
        toPrint += "Car Price:\t\t\t" + ConfigData.currencySymbol + value + "\n";
        toPrint += "\n";
       toPrint += "Total Price:\t\t\t" + ConfigData.currencySymbol + (value + colorPrice) + "\n";
        Debug.Log(toPrint);
    }
}

