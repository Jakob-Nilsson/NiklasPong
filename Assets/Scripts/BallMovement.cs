using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Disable gravity & rotation in Inspector
        direction = GetRandomDirection();
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        rb.AddForce (direction);
    }

    Vector2 GetRandomDirection()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.Range(-0.75f, 0.75f);

        return new Vector2(x, y).normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reflect direction manually
        direction = Vector2.Reflect(direction, collision.contacts[0].normal).normalized;
        //villkor: om collider == player: ignore collision with collider for 1000ms
    }
}