using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedalController : MonoBehaviour
{

    public KeyCode input;

    private HingeJoint hinge;
    private float targetPressed;
    private float targetRealease;

    // Start is called before the first frame update
   private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRealease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input)){
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRealease;
        }

        hinge.spring = jointSpring;
    }
}
