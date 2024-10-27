using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionMovement : MonoBehaviour
{
    public CinemachineVirtualCamera slowMotionCamera;
    public float slowMotionTimeScale = 0.5f;

    private float originalTimeScale;

    void Start()
    {
        originalTimeScale = Time.timeScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateSlowMotion();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RestoreNormalTime();
        }
    }

    void ActivateSlowMotion()
    {
        Time.timeScale = slowMotionTimeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        slowMotionCamera.Priority = 15;
    }

    void RestoreNormalTime()
    {
        Time.timeScale = originalTimeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        slowMotionCamera.Priority = 5;
    }
}
