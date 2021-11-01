using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera MainCamera;
    public float MinFOV = 30;

    private void Update()
    {
        var scrollData = Input.mouseScrollDelta.y;
        if (scrollData > 0 && MainCamera.fieldOfView > MinFOV)
        {
            MainCamera.fieldOfView -= scrollData;
        }
        else if (scrollData < 0 && MainCamera.fieldOfView < 60)
        {
            MainCamera.fieldOfView -= scrollData;
        }
        CheckFieldOfView();

        if (Input.GetMouseButtonDown(1))
        {
            MainCamera.fieldOfView = 60;
        }
    }

    private void CheckFieldOfView()
    {
        if (MainCamera.fieldOfView > 60)
        {
            MainCamera.fieldOfView = 60;
        }
        else if (MainCamera.fieldOfView < MinFOV)
        {
            MainCamera.fieldOfView = MinFOV;
        }
    }
}
