using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;

    public void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
