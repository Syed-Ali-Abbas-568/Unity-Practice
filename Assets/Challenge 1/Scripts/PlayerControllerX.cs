using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed=30.0f;
    public float rotationSpeed=10.0f;
    public float verticalInput;

    // Start is called before the first frame update

    private Rigidbody rb;
    private ForceMode force;

    void Start()
    {

        rb=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        //transform.Translate(Vector3.forward *Time.deltaTime* speed);

         rb.AddForce(transform.forward *speed, ForceMode.Acceleration);
rb.AddTorque(verticalInput *Vector3.right*rotationSpeed);
       
        // tilt the plane up/down based on up/down arrow keys
       // transform.Rotate(Vector3.right , rotationSpeed * Time.deltaTime *verticalInput) ;
    }
}
