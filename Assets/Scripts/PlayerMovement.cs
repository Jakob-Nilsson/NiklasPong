using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2D;
    [SerializeField]
    private Vector2 kontroll;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private KeyCode left;
    [SerializeField]
    private KeyCode right;
    [SerializeField] private float width;
    private float direction;
    private KeyCode input;
    private Collider2D selfCollider;

    private void Start()
    {
        selfCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
       
        
        if (Input.GetKey(left))
        {
            direction = -1f;
        }
        else if (Input.GetKey(right))
        {
            direction = 1f;
        } else
        {
            direction = 0f;
        }
          
        
    } 
    void FixedUpdate()
    {
        _rb2D.velocity = new Vector2(direction * speed, _rb2D.velocity.y);
    }


    //Scale difficulty by reducing scale.x on player paddle
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            width *= 0.9f;
            //transform.localScale.Set(width,transform.localScale.y, transform.localScale.z);
            
            transform.localScale = new Vector2(width, 0.35f);
           // Physics2D.IgnoreCollision(selfCollider, collision.collider);
        }
    }
 */
}


