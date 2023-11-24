using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    private HingeJoint hinge;
    public KeyCode input;
    // public float springPower;
    private float targetPressed;
    private float targetReleased;
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
        // MovePaddle();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if(Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
            Debug.Log("key pressed");
        }else{
            jointSpring.targetPosition = targetReleased;
        }
        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {}
}
