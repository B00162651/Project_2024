using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 35f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//move spawn car towards mine
         transform.Translate(Vector3.forward * speed * Time.deltaTime);
         if (transform.position.z < -22) 
        {
            Destroy(gameObject);
        }
    }
}
