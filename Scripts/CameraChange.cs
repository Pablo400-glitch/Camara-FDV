using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    public CinemachineVirtualCamera camaraSecundaria;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camaraSecundaria.Priority = 11;
        }
    }
}