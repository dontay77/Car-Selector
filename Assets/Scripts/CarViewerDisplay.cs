using System.Collections.Generic;
using UnityEngine;

public class CarViewerDisplay : MonoBehaviour
{
    public List<Car> carList;
    int carIndex = 0;
    public InfoDisplay infoDisplay;
    public ObjectDataReader carDataReader;
    private ObjectData currentCarData;

    // Sets up thw car data for each car in the carList. Data from Json file
    private void Start()
    {
        for (int i = 0; i < carDataReader.GetData().objectData.Length; i++) 
        {
            carList[i].SetData( carDataReader.GetData().objectData[i]);
        }

        currentCarData = carList[carIndex].GetData();
        infoDisplay.UpdateInfo(currentCarData);
    }
    // Goes to next car in the carViewDisplay
    public void GotoNextCar()
    {
        carIndex++;
        if (carIndex == carList.Count)
            carIndex = 0;

        currentCarData = carList[carIndex].GetData();
        infoDisplay.UpdateInfo(currentCarData);
    }

    // Goes to previous car in the carViewDisplay
    public void GotoPreviousCar()
    {
        carIndex--;
        if (carIndex < 0)
            carIndex = carList.Count-1;

        currentCarData = carList[carIndex].GetData();
        infoDisplay.UpdateInfo(currentCarData);
    }
    // Gets the current cars data
    public ObjectData GetCurrentCarData()
    {
        return currentCarData;
    }

    //Gets the current cars location
    public Transform GetCurrentCarPosition()
    {
        return carList[carIndex].transform;
    }

    // Sets the current car color
    public void SetCarColor(Color color)
    {
        carList[carIndex].Color = color;
    }

    // Updates the the name of the selected color on the current car
    public void updateColorName(string name)
    {
        carList[carIndex].SetColorName(name);
    }

    // Sets the car color and data to the default color, which has no color price
    public void SetCarColorToDefault()
    {
        carList[carIndex].SetColorToDefault();
        currentCarData = carList[carIndex].GetData();
        infoDisplay.UpdateInfo(currentCarData);
    }

    // Update the cars color price and the info display
    public void updateValue(float colorPrice)
    {
        currentCarData = carList[carIndex].GetData();
        carList[carIndex].SetCashValue(colorPrice);
        currentCarData.colorPrice = colorPrice;
        infoDisplay.UpdateInfo(currentCarData);
    }

}
