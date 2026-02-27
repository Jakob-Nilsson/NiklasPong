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
    private float direction;
    private KeyCode input;

   

   
    void Update()
    {
        if (!Input.anyKey)
        {   
            direction = 0;

        }
        
        if (Input.GetKey(left))
        {
            direction = -1f;
        }
        if (Input.GetKey(right))
        {
            direction = 1f;
        }
          
        
    } 
    void FixedUpdate()
    {
        _rb2D.velocity = new Vector2(direction * speed, _rb2D.velocity.y);
    }
}


