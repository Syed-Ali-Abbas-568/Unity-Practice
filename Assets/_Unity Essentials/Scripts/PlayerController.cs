using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Set player's movement speed.
    public float rotationSpeed = 120.0f; // Set player's rotation speed.

    public float jumpForce = 5.0f;
    private bool isGrounded;


    private Rigidbody rb; // Reference to player's Rigidbody.

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
        rb.freezeRotation=true;
    }




    // Update is called once per frame
    void Update()
    {
         CheckIfGrounded();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
        
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);

         
        }

        

        
        
    }

     void CheckIfGrounded()
    {
        // Player is grounded if y velocity is approximately zero
        isGrounded = Mathf.Abs(rb.linearVelocity.y) < 0.01f;
    }

    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}