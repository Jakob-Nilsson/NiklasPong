using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    [SerializeField] private float maxSpeed = 10f;

    private Rigidbody2D rb;
    private Vector2 direction;

    [SerializeField] private float minAngle = 0.2f;
    [SerializeField] private float maxAngle = 0.8f;

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
        Vector2 normal = collision.GetContact(0).normal.normalized;
        Vector2 temp = Vector2.Reflect(direction, normal).normalized;
        Debug.Log("Normal Vector2: " + normal);
        Debug.Log("In-vector" + temp);
        //temp = CorrectXAngle(temp);
        //temp = CorrectYAngle(temp);
        if (temp.x < -maxAngle)
        {
            temp.x = -maxAngle;
        }
        if (temp.x > maxAngle)
        {

            temp.x = maxAngle;
        }
        if (temp.y < -maxAngle)
        {
            temp.y = maxAngle;

        }
        if (temp.y > maxAngle)
        {
            temp.y = maxAngle;
        }

        direction = temp;
            Debug.Log("normalized Vector: " + temp);

        rb.velocity = direction * speed;
        //speed += 1;

            //villkor: om collider == player: ignore collision with collider for 1000ms
        
    }

    Vector2 CorrectXAngle(Vector2 obj)
    {
        if (Mathf.Abs(obj.x) < minAngle) {
            if (obj.x < 0)
            {
                obj.x = -minAngle;
            } else
            {
                obj.x = minAngle;
            } 
        }

        if (Mathf.Abs(obj.x) > maxAngle)
        {
            if (obj.x < 0)
            {
                obj.x = -maxAngle;
            }
            else
            {
                obj.x = maxAngle;
            }
        }
        return obj;
    }

    Vector2 CorrectYAngle(Vector2 obj)
    {
        if (Mathf.Abs(obj.y) < minAngle)
        {
            if (obj.y < 0)
            {
                obj.y = -minAngle;
            }
            else
            {
                obj.y = minAngle;
            }
        }

        if (Mathf.Abs(obj.y) > maxAngle)
        {
            if (obj.y < 0)
            {
                obj.y = -maxAngle;
            }
            else
            {
                obj.y = maxAngle;
            }
        }
        return obj;
    }

    
}