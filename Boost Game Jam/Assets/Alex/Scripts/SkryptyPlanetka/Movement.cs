using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 15;
    public Animator animator;
    private Vector2 moveDir;
    public Rigidbody2D rb;
    private bool facingRight;

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

       float horizontal = Input.GetAxis ("Horizontal");
	
			Flip (horizontal);
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

					animator.SetBool("Jump",true); 
 }
            else 
				{
					animator.SetBool("Jump",false); 
				

 }
 if(Input.GetKey("right")||Input.GetKey("left"))
				{
					animator.SetBool("Run",true); 
				}
            if(Input.GetAxisRaw("Horizontal")==0)
				{
					animator.SetBool("Run",false); 
				}

        //Move(); 
       // GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + transform.TransformDirection(moveDir) *speed* Time.deltaTime); 
    }

    void Move() { 
    float x = Input.GetAxisRaw("Horizontal"); 
    float moveBy = x * speed; 
    rb.velocity = new Vector2(moveBy, rb.velocity.y); 
}
private void Flip(float horizontal)
	{
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
		{
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;

			theScale.x *= -1;

			transform.localScale = theScale;

		}
	}
}

