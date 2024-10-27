using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera vcam_1;
    public CinemachineVirtualCamera vcam_2;

    void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            vcam_1.Priority = 20;
            vcam_2.Priority = 10;
        }

        if (Input.GetKey(KeyCode.E))
        {
            vcam_2.Priority = 20;
            vcam_1.Priority = 10;
        }
    }
}
