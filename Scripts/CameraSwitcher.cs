using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera confinedCamera;
    public CinemachineVirtualCamera unconfinedCamera;
    private CinemachineVirtualCamera activeCamera;
    private bool isConfinedActive = true;

    IEnumerator Start()
    {
        yield return null;

        activeCamera = confinedCamera;
        activeCamera.Priority = 10;
        unconfinedCamera.Priority = 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        if (isConfinedActive)
        {
            confinedCamera.Priority = 5;
            unconfinedCamera.Priority = 10;
            activeCamera = unconfinedCamera;
        }
        else
        {
            confinedCamera.Priority = 10;
            unconfinedCamera.Priority = 5;
            activeCamera = confinedCamera;
        }

        isConfinedActive = !isConfinedActive;
    }
}
