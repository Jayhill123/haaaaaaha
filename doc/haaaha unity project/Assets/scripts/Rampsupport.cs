using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampsupport : MonoBehaviour
{
    public float movespeed = 0.1f;

    private float verticalInput;
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(1, 0);
    }
    // use fixed update for physics code, because we need to be
    // careful about how often we call expensive, hardware intensive,
    // physics stuff.
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("vertical");
        rigidbody.velocity = new Vector2(0, verticalInput * movespeed); 
    }
}
