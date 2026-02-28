using UnityEngine;

public class FaceVelocity2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRb;

    private void LateUpdate()
    {
        if (ballRb == null)
            return;

        Vector2 velocity = ballRb.velocity;

        // Avoid jitter if somehow velocity is near zero
        if (velocity.sqrMagnitude < 0.0001f)
            return;

        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle +270f);
    }
}