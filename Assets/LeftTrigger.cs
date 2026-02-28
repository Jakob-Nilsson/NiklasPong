using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    private HingeJoint2D hinge;
    private JointMotor2D motor;

    public float speed = 1500f;
    public float torque = 10000f;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
        motor.maxMotorTorque = torque;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            motor.motorSpeed = speed;   // Rotate toward 45°
        }
        else
        {
            motor.motorSpeed = -speed;  // Rotate back to 0°
        }

        hinge.motor = motor;
    }
}