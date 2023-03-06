using UnityEngine;
using Cinemachine;

public class CameraScroll : MonoBehaviour
{
    private float CameraZoom;
    public CinemachineVirtualCamera CameraObjCin;
    private float prevsc = 0;
    private float DefaultFieldOfView;
    private float CurrentFieldOfView;

    private void Start()
    {
        DefaultFieldOfView = Camera.main.fieldOfView;
        CurrentFieldOfView = Camera.main.fieldOfView;
    }
    private void Update()
    {
        float ScrollWheelChange = Input.GetAxis("Mouse ScrollWheel");           // This little peece of code is written by JelleWho https://github.com/jellewie
        /*if (ScrollWheelChange != 0){                                            // If the scrollwheel has changed
            float R = ScrollWheelChange * 15;                                   // The radius from current camera
            float PosX = Camera.main.transform.eulerAngles.x + 90;              // Get up and down
            float PosY = -1 * (Camera.main.transform.eulerAngles.y - 90);       // Get left to right
            PosX = PosX / 180 * Mathf.PI;                                       // Convert from degrees to radians
            PosY = PosY / 180 * Mathf.PI;                                       // ^
            float X = R * Mathf.Sin(PosX) * Mathf.Cos(PosY);                    // Calculate new coords
            float Z = R * Mathf.Sin(PosX) * Mathf.Sin(PosY);                    // ^
            float Y = R * Mathf.Cos(PosX);                                      // ^
            float CamX = Camera.main.transform.position.x;                      // Get current camera postition for the offset
            float CamY = Camera.main.transform.position.y;                      // ^
            float CamZ = Camera.main.transform.position.z;                      // ^
            Camera.main.transform.position = new Vector3(CamX + X, CamY + Y, CamZ + Z); // Move the main camera
        }*/
        /*if (ScrollWheelChange != 0)
        {
            CurrentFieldOfView += 0.09f;
            prevsc += CurrentFieldOfView;
            Camera.main.fieldOfView = prevsc;
        }*/
    }
}