using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomoutController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider ball;
    public CameraController cameraController;
    public float length;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            cameraController.GoBackToDefault();
        }
    }
}
