using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float turnSpeed = 45.0f;
    private float speed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private float xRange = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-xRange){
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if(transform.position.x >25){
            transform.position = new Vector3(25, transform.position.y,transform.position.z);
        }
        // player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up  * turnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
