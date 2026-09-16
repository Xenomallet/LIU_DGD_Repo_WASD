using UnityEngine;
using UnityEngine.InputSystem; 

public class WASD_rb_old : MonoBehaviour
{

    //Declaring variables
    public Rigidbody2D rb;
    public float forceAmount = 1.236f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Graft gameobject rigid body to script
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move square up with W
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceAmount);
        }

        //Move square down with S
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceAmount);
        }

        //Move square left with A
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmount);
        }

        //Move square right with D
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * forceAmount);
        }
    }
}
