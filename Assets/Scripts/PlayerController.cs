using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    
    
    private float forwardInput;
    private float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      forwardInput = Input.GetAxis("Vertical");
      horizontalInput = Input.GetAxis("Horizontal");
      
      //moves car forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      
      //turns car
      transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
      
    }
}
