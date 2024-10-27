using Cinemachine;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;

    void Update()
    {
        Zoom();
    }
    
    private void Zoom()
    {
        if (Input.GetKey(KeyCode.W))
        {
            vcam.m_Lens.OrthographicSize = 2.5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vcam.m_Lens.OrthographicSize = 10;
        }
    }
}
