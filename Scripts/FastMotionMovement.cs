using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastMotionMovement : MonoBehaviour
{
    public CinemachineVirtualCamera fastMotionCamera;
    public float fastMotionTimeScale = 2f;

    private float originalTimeScale;

    void Start()
    {
        originalTimeScale = Time.timeScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateFastMotion();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RestoreNormalTime();
        }
    }

    void ActivateFastMotion()
    {
        Time.timeScale = fastMotionTimeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        fastMotionCamera.Priority = 15;
    }

    void RestoreNormalTime()
    {
        Time.timeScale = originalTimeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        fastMotionCamera.Priority = 5;
    }
}
