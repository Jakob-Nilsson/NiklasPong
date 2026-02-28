using UnityEngine;

public class SmoothParticleFollowVelocity2D : MonoBehaviour
{
    [Header("References")]
    public Rigidbody2D ballRb;

    [Header("Rotation Settings")]
    [Range(1f, 30f)]
    public float rotationSpeed = 15f;   // Higher = snappier

    void LateUpdate()
    {
        if (ballRb == null)
            return;

        Vector2 velocity = ballRb.velocity;

        // Don't rotate if barely moving
        if (velocity.sqrMagnitude < 0.01f)
            return;

        // Convert velocity direction to angle (Z axis in 2D)
        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;

        // If your particles face the wrong direction, add +180f here
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle +270f);

        // Smoothly rotate toward direction
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}