using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampsupport : MonoBehaviour
{
    public float movespeed = 0.1f;
    public string inputAxis;

    private float verticalInput;
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(1, 0);
    }
    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
        
    }
    // use fixed update for physics code, because we need to be
    // careful about how often we call expensive, hardware intensive,
    // physics stuff.
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(0, verticalInput * movespeed); 
    }
}
