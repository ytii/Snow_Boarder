using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torque = 1f; // Apply torque to char
    Rigidbody2D rb2d; // allows for "rb2d" to be used throughout the script rather than only in start/update
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostS; // speed up
    [SerializeField] float defaultS = 20f; // return to normal speed
    bool canMove = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // What is rb2d?
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
        RotateControls();
        BoostSpeed();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RotateControls()
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

    void BoostSpeed()
    {
        if(Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostS;
            Debug.Log("Fast");
        }
        else
        {
            surfaceEffector2D.speed = defaultS;
        }
    }
    
}
