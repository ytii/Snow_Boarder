using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torque = 1f; // Apply torque to char
    //[SerializeField] float boostT = 20f; // apply speed
    Rigidbody2D rb2d; // allows for "rb2d" to be used throughout the script rather than only in start/update

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // What is rb2d?
    }

    void Update()
    {
        // back
        if(Input.GetKey(KeyCode.A)) // Is the player pressing the "D" key
        {
            rb2d.AddTorque(torque); // if they are, add a torque initially of 1, see ln 7
        }
        // fwd
        else if(Input.GetKey(KeyCode.D)) // Is the player pressing the "A" key
        {
            rb2d.AddTorque(-torque); // if they are, add a torque initially of 1, see ln 7
        }
    }
}
