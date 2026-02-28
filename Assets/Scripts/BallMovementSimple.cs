using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementAlternative : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();

        Vector2 direction = new Vector2(0, -1);
        _rb2d.velocity = direction * speed;
    }




    // Update is called once per frame
    void Update()
    {

    }
}