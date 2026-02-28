using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100f;
    [SerializeField] private float maxSpeed = 10f;

    private Rigidbody2D rb;
    private Vector2 direction;

    [SerializeField] private float minX = 0.2f;
    [SerializeField] private float maxX = 0.8f;
    [SerializeField] private float minY = 0.2f;
    [SerializeField] private float maxY = 0.8f;
    public float XAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Disable gravity & rotation in Inspector
        direction = GetRandomDirection();
        LaunchBall();
        //rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
       // rb.AddForce (direction * speed);
    }

    void LaunchBall()
    {
        rb.velocity = direction.normalized * speed;
    }
    void FixedUpdate()
    {
        
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
        Vector2 temp = Vector2.Reflect(direction, collision.GetContact(0).normal).normalized;
        CorrectXAngle(temp);
        CorrectYAngle(temp);
        XAngle = temp.x;
        direction = temp.normalized * speed;
        
        //villkor: om collider == player: ignore collision with collider for 1000ms
    }

    void CorrectXAngle(Vector2 obj)
    {
        if (Mathf.Abs(obj.x) < minX) {
            if (obj.x < 0)
            {
                obj.x = -minX;
            } else
            {
                obj.x = minX;
            } 
        }

        if (Mathf.Abs(obj.x) > maxX)
        {
            if (obj.x < 0)
            {
                obj.x = -maxX;
            }
            else
            {
                obj.x = maxX;
            }
        }
    }

    void CorrectYAngle(Vector2 obj)
    {
        if (Mathf.Abs(obj.y) < minX)
        {
            if (obj.y < 0)
            {
                obj.y = -minX;
            }
            else
            {
                obj.y = minX;
            }
        }

        if (Mathf.Abs(obj.y) > maxX)
        {
            if (obj.y < 0)
            {
                obj.y = -maxX;
            }
            else
            {
                obj.y = maxX;
            }
        }
    }

    
}