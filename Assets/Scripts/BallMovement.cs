using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Launch in a random direction
        Vector2 direction = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;

        rb.velocity = direction * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
}
