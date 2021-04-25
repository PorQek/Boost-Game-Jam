using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public bool onGround=false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
		{
            if(other.tag=="Player")
            {
            onGround=true; 
            Movement.CanRun=true;
            
            }
            
        }
        void OnTriggerExit2D(Collider2D other)
		{
            if(other.tag=="Player")
            {
            onGround=false; 
            Movement.CanRun=false;
            
            }
            
        }
}


