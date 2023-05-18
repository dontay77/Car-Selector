using UnityEngine;

public class UIManager : MonoBehaviour
{
    public InfoDisplay infoDisplay;
    public CarViewerDisplay carViewer;
    public CameraLookAt carCamera;

    // sets the camera to the first car
    private void Start()
    {
        carCamera.InitializePosition(carViewer.GetCurrentCarPosition());
    }

    // Shows the next car
    public void NextCar()
    {
        carViewer.GotoNextCar();
        infoDisplay.UpdateInfo(carViewer.GetCurrentCarData());
        carCamera.setTargetPos(carViewer.GetCurrentCarPosition());
    }

    // Shows previous Car
    public void PreviousCar()
    {
        carViewer.GotoPreviousCar();
        infoDisplay.UpdateInfo(carViewer.GetCurrentCarData());
        carCamera.setTargetPos(carViewer.GetCurrentCarPosition());
    }

    // Prints the users choice to the Console
    public void Print()
    {
        carViewer.GetCurrentCarData().Print();
    }
}
