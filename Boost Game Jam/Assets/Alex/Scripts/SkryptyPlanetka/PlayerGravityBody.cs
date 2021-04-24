using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityBody : MonoBehaviour {

    public PlanetScript attractorPlanet;
    private Transform playerTransform;

    void Start()
    {
        //GetComponent<Rigidbody2D>().GravityScale = 0;
        //GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }

    void FixedUpdate()
    {
        if (attractorPlanet)
        {
            attractorPlanet.Attract(playerTransform);
        }
    }

        void OnTriggerEnter2D(Collider2D other)
		{
		if (other.tag=="Planet") {

            Debug.Log("skok");
            attractorPlanet = other.GetComponent<PlanetScript>();
            gameObject.transform.parent = attractorPlanet.transform;
            
        }

			
    }
    
}