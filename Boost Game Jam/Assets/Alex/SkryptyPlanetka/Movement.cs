using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 15;
    private Vector2 moveDir;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    /*void Update()
    {
        //moveDir = new Vector2 (Input.GetAxis("Horizontal"),0).normalized;
        

    }*/

    void FixedUpdate()
    {
        if(Input.GetKey("right"))
 {
    rb.AddForce(transform.right * speed);
 }
 if(Input.GetKey("left"))
 {
    rb.AddForce(transform.right * -1 * speed);
 }
 if(Input.GetKey("up"))
 {
    rb.AddForce(transform.up * speed*5);
 }

        //Move(); 
       // GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + transform.TransformDirection(moveDir) *speed* Time.deltaTime); 
    }

    void Move() { 
    float x = Input.GetAxisRaw("Horizontal"); 
    float moveBy = x * speed; 
    rb.velocity = new Vector2(moveBy, rb.velocity.y); 
}
}

