using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2D;
    [SerializeField]
    private Vector2 kontroll = new Vector2(0, 0);
    [SerializeField]
    private float speed = 100f;
    

/*    private void FixedUpdate()
    {
        _rb2D.velocity = kontroll;
    }
*/
   
    void Update()
    {
        
        float input = Input.GetAxisRaw("Horizontal");
        kontroll = new Vector2(input, 0);
        transform.Translate(kontroll * speed * Time.deltaTime);

    }


}