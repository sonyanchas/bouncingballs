using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb; // Declare a rigidbody variable
        rb = GetComponent<Rigidbody2D>(); //Get a reference to our rigid body
        rb.velocity = new Vector2(Random.Range(-200f,200f), Random.Range(-200f,200f)); // set velocity
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
