using UnityEngine;

public class LeftFlipper : MonoBehaviour
{
    private HingeJoint2D hinge;
    private JointMotor2D motor;
    [SerializeField] private KeyCode key;

    public float speed = 1500f;
    public float torque = 10000f;
    [SerializeField] float angle;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;
        motor.maxMotorTorque = torque;
    }

    void Update()
    {
        if (Input.GetKey(key))
        {
            motor.motorSpeed = speed * angle;   // Rotate toward 45°
        }
        else
        {
            motor.motorSpeed = -speed * angle;  // Rotate back to 0°
        }

        hinge.motor = motor;
    }
}