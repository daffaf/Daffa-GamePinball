using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider ball;
    public CameraController cameraController;
    public float length;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            cameraController.FollowTarget(ball.transform,length);
        }
    }
}
