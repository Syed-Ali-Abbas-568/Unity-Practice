using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    public bool secondPlayer = false;
    

    [SerializeField]private float horsePower=20000;
   private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = secondPlayer ? Input.GetAxis("Horizontal2") : Input.GetAxis("Horizontal");
        forwardInput = secondPlayer ? Input.GetAxis("Vertical2") : Input.GetAxis("Vertical");
       
       
     // transform.position+=transform.forward *speed *Time.deltaTime *forwardInput;
        rb.AddRelativeForce(Vector3.forward * horsePower* forwardInput);
       // transform.Translate();

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
