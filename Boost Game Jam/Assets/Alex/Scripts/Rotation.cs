using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float zRotation = 90.0f;
 //public float xRotation1 = 0.0f;
 public float RotationSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate ( Vector3.forward * ( RotationSpeed * Time.deltaTime ) );
       //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, zRotation * ( RotationSpeed * Time.deltaTime )); 
    }
}
