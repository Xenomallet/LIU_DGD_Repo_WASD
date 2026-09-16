using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb_new : MonoBehaviour
{
    //Declaring variables
    public Rigidbody2D rb;
    public float movespeed;
    private Vector2 movedirection;
    public InputActionReference move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Add ridgidbody to object
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       //Add direction of movement with input manager
       movedirection = move.action.ReadValue<Vector2>(); 
    }

    // FixedUpdate is called once per physics frame
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);
    }
}
