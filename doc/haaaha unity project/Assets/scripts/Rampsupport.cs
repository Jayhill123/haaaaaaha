using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampsupport : MonoBehaviour
{
    private float movespeed = 0.1f
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        //transform.Translate(5, 0, 0);     
    }

    // Update is called once per frame
    void Update()
    { 
   //if the player presses up arrow
   // we move the square up.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, movespeed, 0);                                                                       
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -movespeed, 0);
        }
        //Debug.Log("UPDATE METHOD");

    }
}
