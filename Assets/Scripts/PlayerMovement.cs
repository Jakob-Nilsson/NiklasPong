using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2D;
    [SerializeField]
    private Vector2 kontroll = new Vector2(0, 0);
    
    private void FixedUpdate()
    {
        _rb2D.velocity = kontroll;
    }

   
    void Update()
    {
        float sidled = Input.GetAxisRaw("Horizontal");
        kontroll = new Vector2(sidled, 0);

    }


}